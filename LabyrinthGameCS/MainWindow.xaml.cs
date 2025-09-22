using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LabyrinthGameCS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Player player = new Player("TestPlayer");
        public MainWindow()
        {
            InitializeComponent();
        }
    
        void Move(object sender, RoutedEventArgs e)
        {
            string? input = ((Button)sender).Tag.ToString();
            player.Move(input ?? "");
            this.debug.Text = player.X.ToString() + "  " + player.Y.ToString();
        }

        void OpenInv(object sender, RoutedEventArgs e)
        {
            this.debug.Text = player.Name;
        }
    }
}