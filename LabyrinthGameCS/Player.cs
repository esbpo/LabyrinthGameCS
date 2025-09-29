using System;
using System.Windows.Media;

public class Player
{
	public string Name { get; set; }
	public int X { get; set; }
    public int Y { get; set; }
    public Player(string name = "Default", int x = 0, int y = 0)
	{
		this.Name = name;
		this.X = x; this.Y = y;
	}

	public bool Move(string dir)
	{
		switch (dir)
		{
			case "north":
				this.Y += 1;
				break;
			case "south":
				this.Y -= 1;
				break;
			case "east":
				this.X += 1;
				break;
			case "west":
				this.X -= 1;
				break;
			default:
				return false;
		}
		return true;
	}
}
using System;

public class labrinth
{
    public class RectangleForm : Form
    {
        public RectangleForm()
        {
            this.Size = new Size(400, 300);
            this.Paint += new PaintEventHandler(DrawRectangle);
        }

        private void DrawRectangle(object sender, PaintEventArgs e)
        {
            //placement: x=50, y=40, width=200, height=100
            Rectangle rect = new Rectangle(50, 10, 200, 100);

            // Use a brush to fill rectangle
            using (SolidBrush brush = new SolidBrush(Color.#00ffbc))
            {
                e.Graphics.FillRectangle(brush, rect);
            }

            // Optional: draw outline
            using (Pen pen = new Pen(Color.Black, 2))
            {
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        [STAThread]
        public static void Main()
        {
            Application.Run(new RectangleForm());
        }
    }
}

