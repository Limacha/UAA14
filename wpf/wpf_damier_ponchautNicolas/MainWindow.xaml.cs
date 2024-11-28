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

namespace wpf_damier_ponchautNicolas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            for (int i = 0; i < 10; i++)
            {

                ColumnDefinition columnDefinition = new ColumnDefinition();
                RowDefinition rowDefinition = new RowDefinition();

                body.ColumnDefinitions.Add(columnDefinition);
                body.RowDefinitions.Add(rowDefinition);
            }

            int nCase = 1;
            bool white = true;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button newCase = new Button();
                    newCase.Content = nCase++;
                    newCase.Foreground = Brushes.Red;
                    newCase.FontWeight = FontWeights.Bold;
                    newCase.Click += HideText;

                    newCase.Width = 65;
                    newCase.Height = 65;

                    if (white)
                    {
                        newCase.Background = Brushes.White;
                    }
                    else
                    {
                        newCase.Background = Brushes.Black;
                    }
                    white = !white;

                    Grid.SetColumn(newCase, j);
                    Grid.SetRow(newCase, i);
                    body.Children.Add(newCase);
                }
                white = !white;
            }
        }

        private void HideText(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Content = string.Empty;
        }
    }
}