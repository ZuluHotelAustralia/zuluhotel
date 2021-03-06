using System;
using System.IO;
using System.Net;
using Server.Misc;

namespace Server
{
    public static class AccessRestrictions
    {
        public static void Initialize()
        {
            EventSink.SocketConnect += EventSink_SocketConnect;
        }

        private static void EventSink_SocketConnect(SocketConnectEventArgs e)
        {
            try
            {
                var ip = (e.Connection.RemoteEndPoint as IPEndPoint)?.Address;

                if (Firewall.IsBlocked(ip))
                {
                    Console.WriteLine("Client: {0}: Firewall blocked connection attempt.", ip);
                    e.AllowConnection = false;
                    return;
                }

                if (IPLimiter.SocketBlock && !IPLimiter.Verify(ip))
                {
                    Console.WriteLine("Client: {0}: Past IP limit threshold", ip);

                    using (var op = new StreamWriter("ipLimits.log", true))
                    {
                        op.WriteLine("{0}\tPast IP limit threshold\t{1}", ip, DateTime.UtcNow);
                    }

                    e.AllowConnection = false;
                }
            }
            catch
            {
                e.AllowConnection = false;
            }
        }
    }
}