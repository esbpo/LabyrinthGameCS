using LabyrinthGameCS;
using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;

public class Player
{
	public string Name { get; set; }
	public int X { get; set; }
	public int Y { get; set; }
	private List<object> inventory = new List<object>() {"Sword", "Axe", "Armour"};
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

	private int InvSize()
	{
		return inventory.Count;
	}

	private void RemoveItem(object sender, RoutedEventArgs e, UIElement[] items)
	{
        foreach (UIElement item in items)
        {
			((MainWindow)Application.Current.MainWindow).InvContents.Children.Remove(item);
        }
    }

	public bool OpenInv()
	{
		Button[] buttons = new Button[InvSize()];
		Label[] labels = new Label[InvSize()];
		int[] Coordinates = [40, 40];
		((MainWindow)Application.Current.MainWindow).InvContents.Children.Clear();
        foreach (var item in inventory)
		{
			Label new_label = new Label() { Content = item.ToString(), Width = 100, Height = 40 };
            new_label.Margin = new Thickness(Coordinates[0]+50, Coordinates[1], 0, 0);
            Button new_button = new Button() { Content = "X", Width = 40, Height = 40 };
			new_button.Click += (object sender, RoutedEventArgs e) => { };
			new_button.Margin = new Thickness(Coordinates[0], Coordinates[1], 0, 0);
            Coordinates[1] += 50;
			buttons.Append(new_button);
			labels.Append(new_label);
			((MainWindow)Application.Current.MainWindow).InvContents.Children.Add(new_label);
            ((MainWindow)Application.Current.MainWindow).InvContents.Children.Add(new_button);
        }
        return true;
	}
}
