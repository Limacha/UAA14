using System.Reflection;
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

namespace wpf_creaObjDyna2
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
            for (int i = 0; i < 4; i++)
            {
                body.ColumnDefinitions.Add(new ColumnDefinition());
                body.RowDefinitions.Add(new RowDefinition());
                for (int j = 0; j < 4; j++)
                {

                    TextBlock block = new TextBlock();
                    block.Text = "?";
                    block.HorizontalAlignment = HorizontalAlignment.Center;
                    block.VerticalAlignment = VerticalAlignment.Center;
                    block.MouseDown += Change;

                    Grid.SetColumn(block, i);
                    Grid.SetRow(block, j);

                    body.Children.Add(block);
                }
            }
        }

        private void Change(object sender, MouseButtonEventArgs e)
        {
            ((TextBlock)sender).Text = "X";
        }
    }
}