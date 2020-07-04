using DrawingPractice01.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrawingPractice01
{
    class PaintBox: IPaintBox
    {
        private readonly IPencil pencil;

        public PaintBox(IPencil pencil)
        {
            this.pencil = pencil;
        }

        public void DrawLine(DrawColour colour, int x, int y)
        {
            throw new NotImplementedException();
        }

        public void DrawRectangle(DrawColour colour, int left, int top, int right, int bottom)
        {
            throw new NotImplementedException();
        }

        public void DrawCircle(DrawColour colour, int centreX, int centreY, int radius)
        {
            throw new NotImplementedException();
        }
    }
}
