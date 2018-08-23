﻿using WowPacketParser.Misc;

namespace WowPacketParser.Enums.Version.V8_0_1_27101
{
    public static class Opcodes_8_0_1
    {
        public static BiDictionary<Opcode, int> Opcodes(Direction direction)
        {
            switch (direction)
            {
                case Direction.ClientToServer:
                    return ClientOpcodes;
                case Direction.ServerToClient:
                    return ServerOpcodes;
                default:
            return MiscOpcodes;
        }
        }

        private static readonly BiDictionary<Opcode, int> ClientOpcodes = new BiDictionary<Opcode, int>
        {
            {Opcode.CMSG_TOGGLE_WARMODE, 0x32AC}
        };

        private static readonly BiDictionary<Opcode, int> ServerOpcodes = new BiDictionary<Opcode, int>
        {
            {Opcode.SMSG_LIGHTNING_STORM_CHANGE, 0x26D5},
            {Opcode.SMSG_LIGHTNING_STORM_START, 0x26D6},
        };

        private static readonly BiDictionary<Opcode, int> MiscOpcodes = new BiDictionary<Opcode, int>();
    }
}
