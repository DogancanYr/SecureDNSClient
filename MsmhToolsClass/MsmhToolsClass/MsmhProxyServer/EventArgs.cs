﻿namespace MsmhToolsClass.MsmhProxyServer;

public class DataEventArgs : EventArgs
{
    public DataEventArgs(ProxyClient sc, byte[] buffer)
    {
        Client = sc;
        Buffer = buffer;
    }

    public ProxyClient Client { get; set; }
    public byte[] Buffer { get; set; }
}