﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="INetworkPacket.cs" company="SyndicatedLife">
//   Copyright© 2007 - 2021 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (https://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   INetworkPacket.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.Common.Core.Network.Interfaces {
    using System;

    public interface INetworkPacket {
        byte[] Buffer { get; set; }

        int CurrentPosition { get; set; }

        uint Key { get; set; }

        int MessageSize { get; set; }

        DateTime PacketDate { get; set; }
    }
}