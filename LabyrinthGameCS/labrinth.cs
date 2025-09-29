using System;
using System.Drawing;
using System.Windows.Forms;

namespace LabyrinthGameCS
{
    public class RectangleForm : Form
    {
        public RectangleForm()
        {
            this.Text = "Green Rectangle Example";
            this.Size = new Size(400, 300);
            this.Paint += new PaintEventHandler(DrawRectangle);
        }

        private void DrawRectangle(object sender, PaintEventArgs e)
        {
            // Placering: x=50, y=40, width=200, height=100
            Rectangle rect = new Rectangle(50, 40, 200, 100);

            // Grøn fyldfarve (hex: #00ffbc)
            using (SolidBrush brush = new SolidBrush(ColorTranslator.FromHtml("#00ffbc")))
            {
                e.Graphics.FillRectangle(brush, rect);
            }

            // Valgfri: sort kant
            using (Pen pen = new Pen(Color.Black, 2))
            {
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new RectangleForm());
        }
    }
}
