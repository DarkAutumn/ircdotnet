﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IrcDotNet
{
    /// <summary>
    /// Stores information received from a server about its IRC network.
    /// </summary>
    public struct IrcNetworkInformation
    {
        public int? VisibleUsersCount;
        public int? InvisibleUsersCount;
        public int? ServersCount;
        public int? OperatorsCount;
        public int? UnknownConnectionsCount;
        public int? ChannelsCount;
        public int? ServerClientsCount;
        public int? ServerServersCount;
    }
}