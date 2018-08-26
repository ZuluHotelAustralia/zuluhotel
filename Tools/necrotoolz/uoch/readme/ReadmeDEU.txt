1. Januar 2005


Ultima Online Client Hacker (UOCH) 2.1
Entwicklerausgabe

Copyright 2005 Daniel 'Necr0Potenc3' Cavalcanti


[Benutzung]
1 - Starte UOCH.exe
2 - Es finden den Ultima Online-Client in der Registry. Alternativ
kann ein anderer Client mit dem "..."-Button gew�hlt werden.
3 - W�hle die Optionen, die du brauchst.
4 - Dr�cke den "Patch"-Button.
5 - Ein neuer Client des Namens "UOCH_n0p3_Clientxxx.exe" wird im
UO-Ordner erstellt. Hierbei steht "xxx" f�r die Versionsnummer, so
kann man beliebig viele Clients patchen.

[Funktionen]
- Open source
- "Developer's dump": Schreibt einige Werte des Clients, z.B. die
loginkeys, die CRC32-Pr�fsumme, den Zeitstempel des PE-Headers, die Image-Base, den
Entry-Point, die Version, die Offsets der Verschl�sselungsfunktionen,
die Packet-Behandlungsroutinen und die komplette Packet-Tabelle des
Clients im C-Format.

- Everman's way: Sch�tzt dich davor, dass du ausversehen deinen
Charakter l�scht, indem es den Client beim Aktivieren dieser Funktion
zum Absturz bringt.

- Multi clients:  Erlaubt es, mehr als einen Client gleichzeitig zu
benutzen (Neuere Clienten erlauben nur die Benutzung von maximal zwei
Clienten zur selben Zeit).

- Clear nights (Auch bekannt als NightSight und NightHack): Nie wieder
dunkle N�chte w�hrend des Spiels!

- Special names: Hebt die Namensrestriktionen des Clients auf. Somit
werden Namen wie "Lady", "Lord", etc., m�glich.

- Remove encryption: Entfernt die Verschl�sselung des Clients und gibt
Informationen �ber die angewandte Verschl�sselung aus (Login,
Blowfish, Twofish, MD5)

- Remove macro delay: Entfernt die Zeitspanne zwischen "arm"- und
"disarm"-Aufrufen.

- Remove stamina check: Erlaubt es dem Client, durch Leute hindurch zu
wandern, auch wenn die Stamina nicht voll ist.

[Quelltext]
  Der Quelltex wird zusammen mit der Bin�rdatei vervielf�ltigt; du
kannst damit machen, was immer du willst, solange du sagst, dass es
auf diesem Projekt basiert.

  Der Quelltext enth�lt die Datei "CrackTools.C". Diese enth�lt eine
Sammlung von Funktionen, die ich entwickelt habe und die zum Cracken
sinnvoll sind. All diese Funktionen geben die Offsets innerhalb eines
Buffers zur�ck, nicht die virtuelle Adresse.