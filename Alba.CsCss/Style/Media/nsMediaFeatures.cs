﻿using System.Linq;

namespace Alba.CsCss.Style
{
    internal partial class nsMediaFeatures
    {
        public static nsMediaFeature GetFeature (string aName)
        {
            return features.FirstOrDefault(f => f.mName == aName) ?? EmptyFeature;
        }
    }
}