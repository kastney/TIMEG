﻿using System;
using System.Drawing;
using Nulo.WinForms.Control.WordCloudGenerator.Geometry;

namespace Nulo.WinForms.Control.WordCloudGenerator
{
    public static class LayoutFactory
    {
        public static ILayout CrateLayout(LayoutType layoutType, SizeF size)
        {
            switch (layoutType)
            {
                case LayoutType.Typewriter:
                    return new TypewriterLayout(size);

                case LayoutType.Spiral:
                    return new SpiralLayout(size);
            
                default:
                    throw new ArgumentException(string.Format("No constructor specified to create a layout instance for {0}.", layoutType), "layoutType");
            }
        }
    }
}
