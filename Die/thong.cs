using KeyAuth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Die
{
    public partial class thong : Form
    {

        public thong()
        {
            InitializeComponent();
        }

        public static bool dragging = false;
        public static Point cursor;
        public static Point dragfrom;

        public void AssSpank(object sender, EventArgs e)
        {
            try
            {
                Form1.ireallywantadildoorabuttplugORbobinmern.check();

                if (!Form1.ireallywantadildoorabuttplugORbobinmern.response.success)
                {
                    this.Hide();
                    MessageBox.Show("Your subscription is no longer active.");
                    //  MessageBox.Show($"Session Error: {Form1.ireallywantadildoorabuttplugORbobinmern.response.message}");
                    Application.Exit();
                }
                else
                {
                    Console.WriteLine("subscription is valid");
                }
            }
            catch (Exception ex)
            {
                //   MessageBox.Show($"Error At: {ex.Message}");
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AssSpank(sender, e);
            Application.Exit();
        }


        private void thong_Load(object sender, EventArgs e)
        {
            AssSpank(sender, e);
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath path = new GraphicsPath();
            int radius = 10;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            this.Region = new Region(path);
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //  AssSpank.Stop();
            //  AssSpank.Dispose();
            //  base.OnFormClosing(e);
        }

        private void thong_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void thong_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(cursor));
                this.Location = Point.Add(dragfrom, new Size(diff));
            }
        }

        private void thong_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            cursor = Cursor.Position;
            dragfrom = this.Location;
        }
    }
}
