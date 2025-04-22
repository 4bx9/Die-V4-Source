using KeyAuth;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace Die
{
    public partial class Form1 : Form
    {
        public static string ahhhhhdaddyitssosohuge = string.Empty;

        public Form1()
        {
            InitializeComponent();
            ireallywantadildoorabuttplugORbobinmern.init();
        }

        public static api ireallywantadildoorabuttplugORbobinmern = new api(
// NOT LEAKING MY THING
        );


        public static bool dragging = false;
        public static Point dragCursorPoint;
        public static Point dragFormPoint;






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



        private void button1_Click(object sender, EventArgs e)
        {
            string correctkeys;
            string keysthatwork;
            string skipauth;

            try
            {
                ireallywantadildoorabuttplugORbobinmern.login(diebox1.Text, diebox2.Text);

                if (ireallywantadildoorabuttplugORbobinmern.response.success)
                {
                    // ireallywantadildoorabuttplugORbobinmern.license(diebox3.Text);

                    if (ireallywantadildoorabuttplugORbobinmern.response.success)
                    {
                        Form thong = new thong();
                        this.Hide();
                        ahhhhhdaddyitssosohuge = diebox1.Text; // meno
                        MessageBox.Show("Welcome to Die V4.");
                        Program.doyoulikeitsugarplum = diebox2.Text; // ti vis co retarde
                        thong.Show();
                    }
                    else
                    {
                        MessageBox.Show($"Invalid Key: {ireallywantadildoorabuttplugORbobinmern.response.message}");
                    }
                }
                else
                {
                    MessageBox.Show($"Login failed: {ireallywantadildoorabuttplugORbobinmern.response.message}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something Went Wrong: {ex.Message}");
            }
        }

        private void diebox2_TextChanged(object sender, EventArgs e)
        {
            //   if (!diebox2.Text == "                          password")
            //  {
            //    diebox2.Text.pass
            // }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://example.com",
                UseShellExecute = true // why the living fuck does this need to be here
            });
            Application.Exit();
        }

        private void Form1_MouseUp_1(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void diebox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void diebox2_Click(object sender, EventArgs e)
        {
            diebox2.Clear();
        }
    }
}
