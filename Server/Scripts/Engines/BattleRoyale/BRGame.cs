using Server;
using Server.Commands;
using Server.Mobiles;

using System;
using System.Collections;
using System.Collections.Generic;

namespace Server.BattleRoyale{
    public class GameController : Item {

	public enum BattleState {
	    Idle, //game not running, nobody able to join
	    Joining, //players able to join
	    Parachuting, //if it was pubg you'd be in the herc or parachuting
	    Playing, // game actually started
	    Shrinking //same as playing only the zone is contracting
	}

	private static BattleState _state = BattleState.Idle;
	
	private static Point3D _EscapeLoc = new Point3D(3033, 3406, 20); //serps, see AccountHandler
	public static Point3D EscapeLoc{
	    get { return _EscapeLoc; }
	}

	//TODO randomize this start loc by +/-5 in each x and y directions
	private static Point3D _StartLoc = new Point3D(4420, 1155, 0); //Moonglow, near the maze
	public static Point3D StartLoc{
	    get { return _StartLoc; }
	}
	
	private static List<PlayerMobile> _Players;
	private static List<PlayerMobile> _AlivePlayers;

	public static void Initialize() {
	    //all commands go here, no more splitting it up between several files.
	    // I'm looking at *you*, sith.
	    // --sith

	    CommandSystem.Register("Escape", AccessLevel.Player, new CommandEventHandler(Escape_OnCommand) );
	}

	public static void Escape_OnCommand( CommandEventArgs e){
	    if( e.Mobile.Alive ) {
		e.Mobile.SendMessage("You cannot do this unless dead.");
		return;
	    }
	    else {
		e.Mobile.SendMessage("You will now be moved from the battle royale arena as an observer and removed from the minigame.");
		e.Mobile.MoveToWorld(GameController.EscapeLoc, Map.Felucca);
		GameController.TryUnregisterPlayer( e.Mobile as PlayerMobile );
		return;
	    }
	}

	// it's possible they're abandoned on the island due to a bug or server restart but not registered as a player any more.
	public static void TryUnregisterPlayer( PlayerMobile pm ) {
	    if( _Players.Contains( pm ) ){
		_Players.Remove( pm );
	    }
	}
		
	[Constructable]
	public GameController() : base( 0xED4 ){
	    this.Name = "Battle Royale Control Stone";
	    this.Hue = 2771; //dripstone
	}

	public GameController( Serial serial ) : base( serial ){
	    // if the server goes down the game just ends and everyone can just deal with it
	    // not going to try to wrestle the complexity of having a minigame traverse server
	    // restarts
	    
	    this.Name = "Battle Royale Control Stone";
	    this.Hue = 2771; //dripstone
	}

	public override void OnDoubleClick( Mobile mob ){
	    PlayerMobile from = mob as PlayerMobile;

	    if( from.AccessLevel == AccessLevel.Player ){
		if( _state == BattleState.Joining ){
		    //sign 'em up
		}
		else {
		    from.SendMessage("The game queue is not currently accepting new players; please try again later." );
		    return;
		}
	    }
	    else {
		from.SendMessage("Staff may not join Battle Royale.");
		return;
	    }
	}

	public static void Announce( String s ){
	    World.Broadcast( 0x35, true, s );
	    // later, change this to broadcast via the Town Criers TODO
	}
	
	public static void BeginJoining() {
	    if( _state != BattleState.Joining ){
		_state = BattleState.Joining;
		Announce("Battle Royale is now open for joining!  Game starts in 10 minutes!");
		JoinTimer jt = new JoinTimer( new TimeSpan(0, 10, 0) );  //h:m:s
		jt.Start();
	    }
	}

	public static void EndJoining(){
	    _state = BattleState.Parachuting;
	    // kill everyone, move em to arena, set a res timer that calls BeginPlay()

	    foreach( PlayerMobile pm in _Players ){
		pm.Kill();
		pm.MoveToWorld(_StartLoc, Map.Felucca);
		pm.SendMessage("You will be automatically resurrected in 45 seconds, at which point the battle royale will begin!"); //TODO cliloc this
	    }
	    
	    Announce("BattleRoyale has started!");
	    ResTimer rt = new ResTimer( new TimeSpan(0, 1, 0) );
	    rt.Start();
	}

	public static void BeginPlay(){
	    foreach( PlayerMobile pm in _Players ){
		pm.Resurrect();
		pm.SendMessage("Last one standing in Moonglow wins!");
	    }

	    _state = BattleState.Playing;
	}
    }
}
