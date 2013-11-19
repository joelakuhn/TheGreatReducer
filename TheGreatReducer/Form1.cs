using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace TheGreatReducer
{
    public partial class Form1 : Form
    {
        private WindowDragEffect dragger;

        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += TimerOnTick;
            timer.Start();
            dragger = new WindowDragEffect(this);
            dragger.AddIgnoredType(pictureBox1.GetType());
            dragger.AddIgnoredType(button1.GetType());
            dragger.AddIgnoredType(scaleFactor_txt.GetType());
            dragger.ApplyDragging(this);
            dragger.DragStart += () => this.Opacity = 0.8;
            dragger.DragEnd += () => this.Opacity = 1.0;
        }

        private void TimerOnTick(object sender, EventArgs eventArgs)
        {
            UpdatePicture();
            timer.Start();
        }

        private Timer timer;

        private Rectangle shotRect;

        private void button1_Click(object sender, EventArgs e)
        {
            var selector = new AreaSelector();
            selector.SizeChanged += SelectorOnSizeChanged;
            selector.Move += SelectorOnSizeChanged;
            selector.Closed += SelectorOnClosed;
            if (shotRect.Height != 0 && shotRect.Width != 0)
            {
                selector.Bounds = shotRect;
                selector.Left = shotRect.Left;
                selector.Top = shotRect.Top;
            }
            else
            {
                selector.StartPosition = FormStartPosition.WindowsDefaultLocation;
            }
            selector.Show();
        }

        private void SelectorOnClosed(object sender, EventArgs eventArgs)
        {
        }

        private void SelectorOnSizeChanged(object sender, EventArgs eventArgs)
        {
            var senderAsSelector = sender as AreaSelector;
            if (senderAsSelector != null)
            {
                shotRect = senderAsSelector.Bounds;
            }
        }

        private void UpdatePicture()
        {
            //if (!pictureBox1.Visible) return;
            if (shotRect.Width > 0 && shotRect.Height > 0)
            {
                var scaleFactor = float.Parse(scaleFactor_txt.Text);
                using (Bitmap bmpScreenCapture = new Bitmap(shotRect.Width,
                                            shotRect.Height))
                {
                    using (Graphics g = Graphics.FromImage(bmpScreenCapture))
                    {
                        g.CopyFromScreen(shotRect.X,
                                         shotRect.Y,
                                         0, 0,
                                         bmpScreenCapture.Size,
                                         CopyPixelOperation.SourceCopy);
                    }
                    var scaled = new Bitmap(bmpScreenCapture,
                        (int) (shotRect.Width/scaleFactor),
                        (int) (shotRect.Height/scaleFactor));
                    pictureBox1.Size = scaled.Size;
                    if (pictureBox1.Image != null)
                        pictureBox1.Image.Dispose();
                    pictureBox1.Image = scaled;
                }
            }
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public void DoMouseClick(uint x, uint y)
        {
            //Call the imported function with the cursor's current position
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, x, y, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void transparent_btn_Down(object sender, MouseEventArgs e)
        {
            //pictureBox1.Visible = false;
        }

        private void transparent_btn_Up(object sender, MouseEventArgs e)
        {
            //pictureBox1.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var eAsMouseArgs = e as MouseEventArgs;
            var x = (uint)(shotRect.X + (int)(eAsMouseArgs.X * float.Parse(scaleFactor_txt.Text)));
            var y = (uint)(shotRect.Y + (int)(eAsMouseArgs.Y * float.Parse(scaleFactor_txt.Text)));
            var oldCursorPos = Cursor.Position;
            Cursor.Position = new Point((int)x, (int)y);
            DoMouseClick(x, y);
            Cursor.Position = oldCursorPos;
        }

        private void transparent_btn_Click(object sender, EventArgs e)
        {
            if (!pictureBox1.Visible)
            {
                UpdatePicture();
            }
            pictureBox1.Visible = !pictureBox1.Visible;
        }

        private void up_btn_Click(object sender, EventArgs e)
        {
            this.Top--;
            Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y - 1);
        }

        private void right_btn_Click(object sender, EventArgs e)
        {
            this.Left++;
            Cursor.Position = new Point(Cursor.Position.X + 1, Cursor.Position.Y);
        }

        private void down_btn_Click(object sender, EventArgs e)
        {
            this.Top++;
            Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y + 1);
        }

        private void left_btn_Click(object sender, EventArgs e)
        {
            this.Left--;
            Cursor.Position = new Point(Cursor.Position.X - 1, Cursor.Position.Y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
