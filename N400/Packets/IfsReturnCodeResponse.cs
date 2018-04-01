﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N400.Packets
{
    internal class IfsReturnCodeResponse : IfsChainedPacketBase
    {
        public const ushort ID = 0x8001;

        public ushort ReturnCode => Data.ReadUInt16BE(22);

        public IfsReturnCodeResponse(byte[] data)
            : base(data)
        {
        }
    }
}
