using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForms
{
    class DrawingController
    {
        private Bitmap _bitmap;
        private Graphics _canvas;

        private PaintEventArgs _controlCanvas;

        private Model _mdl;

        public event Action<PaintEventArgs> EventRedraw;


        public DrawingController(Control canvas)
        {
            _bitmap = new Bitmap(canvas.Width, canvas.Height);
            _canvas = Graphics.FromImage(_bitmap);
            _controlCanvas = new PaintEventArgs(canvas.CreateGraphics(), canvas.ClientRectangle);

            _mdl = new Model();
        }

        public void Move(int dx, int dy)
        {
            foreach (var coords in _mdl.Coords)
            {
                coords[0] += dx;
                coords[1] += dy;
            }

            EventRedraw?.Invoke(_controlCanvas);
        }

        public void MouseClick(bool lmb, int x, int y)
        {
            int delta = Model.DIM / 2;
            if (lmb)
                _mdl.AddBlockAt(x - delta, y - delta);
            else
                _mdl.DeleteBlockAt(x, y);

            EventRedraw?.Invoke(_controlCanvas);
        }

        public void Draw()
        {
            _canvas.Clear(Color.White);

            foreach (var block in _mdl.Coords)
            {
                _canvas.FillRectangle(Brushes.Orange, block[0], block[1], Model.DIM, Model.DIM);
                _canvas.DrawRectangle(Pens.Black, block[0], block[1], Model.DIM, Model.DIM);
            }

            _controlCanvas.Graphics.DrawImage(_bitmap, 0, 0);
        }
    }
}
