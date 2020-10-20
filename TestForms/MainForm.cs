using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForms
{
    public partial class MainForm : Form
    {
        private DrawingController _ctrl;
        public MainForm()
        {
            InitializeComponent();
            _ctrl = new DrawingController(CtrlPnlMain);
            _ctrl.EventRedraw += OnPaint;
            MouseWheel += new MouseEventHandler(CtrlPnlMain_MouseScroll);
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
        }

        private void CtrlPnlMain_MouseScroll(object sender, MouseEventArgs e)
        {

            int dx = CtrlRBXRight.Checked ? 1 : CtrlRBXLeft.Checked ? -1 : 0;
            int dy = CtrlRBYUp.Checked ? -1 : CtrlRBYDown.Checked ? 1 : 0;

            if (e.Delta < 0)
            {
                dx = -dx;
                dy = -dy;
            }

            _ctrl.Move(dx, dy);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            _ctrl?.Draw();
        }

        private void CtrlPnlMain_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    _ctrl.MouseClick(true, e.X, e.Y);
                    break;
                case MouseButtons.Right:
                    _ctrl.MouseClick(false, e.X, e.Y);
                    break;
            }
        }

        private void CtrlBtnMove_Click(object sender, EventArgs e)
        {
            int dist = (int)CtrlNudDist.Value;
            int dx = CtrlRBXRight.Checked ? 1 : CtrlRBXLeft.Checked ? -1 : 0;
            int dy = CtrlRBYUp.Checked ? -1 : CtrlRBYDown.Checked ? 1 : 0;

            for (int i = 0; i < dist; i++)
            {
                _ctrl.Move(dx, dy);
                Thread.Sleep(10);
            }
        }
    }
}
