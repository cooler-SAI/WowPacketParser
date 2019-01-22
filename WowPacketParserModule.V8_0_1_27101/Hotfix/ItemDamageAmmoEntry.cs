﻿using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ItemDamageAmmo, HasIndexInData = false)]
    public class ItemDamageAmmoEntry
    {
        public ushort ItemLevel { get; set; }
        [HotfixArray(7)]
        public float[] Quality { get; set; }
    }
}