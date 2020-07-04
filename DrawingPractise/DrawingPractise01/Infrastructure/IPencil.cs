using System;
using System.Collections.Generic;
using System.Text;

namespace DrawingPractice01.Infrastructure
{
    public interface IPencil
    {
        /// <summary>
        /// Effectively a "zoom", set to 2 to have drawings be 2x their size, 3 to be 3 times their original size
        /// </summary>
        byte PixedRatio { get; set; }

        void DrawPoint(DrawColour colour, int x, int y);
    }
}
