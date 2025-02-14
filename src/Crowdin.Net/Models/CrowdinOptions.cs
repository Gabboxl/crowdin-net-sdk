﻿using System;
using JetBrains.Annotations;

namespace Crowdin.Net.Models
{
    [PublicAPI]
    public class CrowdinOptions : ICloneable
    {
        public string DistributionHash { get; set; }
        
        public string FileName { get; set; }
        
        public bool UseCache { get; set; } = true;
        
        public NetworkPolicy NetworkPolicy { get; set; } = NetworkPolicy.ALL;
        
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}