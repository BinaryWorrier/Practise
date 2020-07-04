using System;
using System.Collections.Generic;
using System.Text;

namespace DrawingPractice01.Infrastructure
{
    public interface IPencil
    {
        void DrawPoint(DrawColour colour, int x, int y);
    }
}
