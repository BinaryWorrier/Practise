using DrawingPractice01.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrawingPractice01
{
    partial class Page
    {
        private readonly IPencil pencil;
        public void Draw()
        {
            var smile = new Smile();
            smile.Draw(pencil, 5);
        }
    }
}
