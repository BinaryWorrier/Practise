using DrawingPractice01.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingPractice01
{
    public partial class CanvasForm : Form
    {
        public CanvasForm()
        {
            InitializeComponent();

            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CanvasForm_Paint);
        }

        private void CanvasForm_Paint(object sender, PaintEventArgs e)
        {
            var page = new Page(e.Graphics);
            page.Draw();
        }
    }

    partial class Page
    {
        private readonly Graphics graphics;

        public Page(Graphics graphics)
        {
            pencil = new Pencil(graphics);
            this.graphics = graphics;
        }

        public void Render()
        {
            Draw();
        }

        int PageWidth => (int)graphics.VisibleClipBounds.Width;

        int PageHeight => (int)graphics.VisibleClipBounds.Height;
    }
}
