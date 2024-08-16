using System.Drawing;
using System.Windows.Forms;

namespace RayTracingInCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var model = LoadUtils.LoadFBX();
            Bitmap bmp = new Bitmap(renderOutputPort.Width, renderOutputPort.Height);
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    var r = i * 255 / renderOutputPort.Height;
                    var g = j * 255 / renderOutputPort.Width;
                    Color pixelColor = Color.FromArgb(255, r, g, 0);
                    bmp.SetPixel(j, i, pixelColor);
                }
            }
            renderOutputPort.Image = bmp;
        }
    }
}
