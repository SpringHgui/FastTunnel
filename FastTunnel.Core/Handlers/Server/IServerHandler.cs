﻿using FastTunnel.Core.Core;
using FastTunnel.Core.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace FastTunnel.Core.Handlers
{
    public interface IServerHandler
    {
        void HandlerMsg(FastTunnelServer server, Socket client, Message<JObject> msg);
    }
}