using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point mousePosition = Cursor.Position;
            Color color = GetColorAt(mousePosition.X, mousePosition.Y);

            DisplayColorInfo(color);
        }

        private static Color GetColorAt(int x, int y)
        {
            Bitmap screen = new Bitmap(1, 1);
            using (Graphics g = Graphics.FromImage(screen))
            {
                g.CopyFromScreen(x, y, 0, 0, new Size(1, 1));
            }

            return screen.GetPixel(0, 0);
        }

        private void DisplayColorInfo(Color color)
        {
            int red = color.R;
            int green = color.G;
            int blue = color.B;

            TXThex.Text = "HEX: " + ColorToHex(color);
            TXTrgb.Text = $"RGB: {red}, {green}, {blue}";

            TXThex.ForeColor = Color.FromArgb(red,green,blue);
            TXTrgb.ForeColor = Color.FromArgb(red,green,blue);

            pic_Colors.BackColor = color;
        }

        private static string ColorToHex(Color color)
        {
            return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
