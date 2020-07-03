using DrawingPractice01.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrawingPractice01
{
    public interface IPaintBox
    {
        void DrawLine(DrawColour colour, int x, int y);

        void DrawRectangle(DrawColour colour, int left, int top, int right, int bottom);

        void DrawCircle(DrawColour colour, int centreX, int centreY, int radius);
    }
}
