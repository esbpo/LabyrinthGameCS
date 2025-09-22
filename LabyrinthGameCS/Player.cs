using System;

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
