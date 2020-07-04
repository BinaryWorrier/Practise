using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DrawingPractice01.Infrastructure
{
    class Pencil : IPencil
    {
        private Graphics graphics;

        public Pencil(Graphics graphics)
        {
            this.graphics = graphics;
        }

        private byte pixelRatio = 1;
        public byte PixedRatio
        {
            get => pixelRatio;
            set
            {
                if (value < 1 || value > 10)
                    throw new ArgumentException("Must be between 1 and 10 inclusive", "PixelRatio");
                pixelRatio = value;
            }
        }

        public void DrawPoint(DrawColour colour, int x, int y)
        {
            graphics.FillRectangle(ColourToBrush(colour), x * PixedRatio, y * PixedRatio, PixedRatio, PixedRatio);
        }

        private Brush ColourToBrush(DrawColour colour)
        {
            switch(colour)
            {
                case DrawColour.Black: return Brushes.Black;
                case DrawColour.Blue: return Brushes.Blue;
                case DrawColour.Brown: return Brushes.Brown;
                case DrawColour.Green: return Brushes.Green;

                case DrawColour.Red: return Brushes.Red;
                case DrawColour.White: return Brushes.White;
                case DrawColour.Yellow: return Brushes.Yellow;
                default:
                    throw new PencilException($"Unknown PencilColour '{colour.ToString()}");
            }
        }
    }
}
