﻿using System;
using kasthack.vksharp.DataTypes.Enums;

namespace kasthack.vksharp.DataTypes.EntityFragments {
    public class LastSeen {
        public DateTimeOffset Time { get; set; }
        public Platform Platform { get; set; }
    }
}