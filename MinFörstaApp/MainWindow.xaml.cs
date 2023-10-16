using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Label = System.Reflection.Emit.Label;

namespace MinFörstaApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int Counter { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            HejText.Text = Counter.ToString();
            HejText.FontSize = 48;

            var newGrid = new Grid();

            for (int i = 0; i < 10; i++)
            {
                var row = new RowDefinition();
                newGrid.RowDefinitions.Add(row);
            }
            for (int i = 0; i < 10; i++)
            {
                var col = new ColumnDefinition();
                newGrid.ColumnDefinitions.Add(col);
            }

            var myButton = new Button();

            newGrid.Children.Add(myButton);

            MittGrid.Children.Add(newGrid);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Counter++;
            HejText.Text = Counter.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Counter--;
            HejText.Text = Counter.ToString();
        }
    }
}
