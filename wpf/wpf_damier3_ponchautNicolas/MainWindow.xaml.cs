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

namespace wpf_damier3_ponchautNicolas
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
            for (int i = 0; i < 8; i++)
            {

                ColumnDefinition columnDefinition = new ColumnDefinition();
                RowDefinition rowDefinition = new RowDefinition();

                body.ColumnDefinitions.Add(columnDefinition);
                body.RowDefinitions.Add(rowDefinition);
            }

            bool white = false;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Button newCase = new Button();

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
                    if (i == 0 || i == 1 || i == 6 || i == 7)
                    {
                        BitmapImage imageBouton = new BitmapImage();
                        if (i == 1 || i == 6)
                        {
                            imageBouton.BeginInit();
                            imageBouton.UriSource = new Uri(@"img/p.png", UriKind.Relative);
                            imageBouton.EndInit();
                        }
                        else
                        {
                            switch (j)
                            {
                                case 0:
                                    imageBouton.BeginInit();
                                    imageBouton.UriSource = new Uri(@"img/t.png", UriKind.Relative);
                                    imageBouton.EndInit();
                                    break;
                                case 1:
                                    imageBouton.BeginInit();
                                    imageBouton.UriSource = new Uri(@"img/kn.png", UriKind.Relative);
                                    imageBouton.EndInit();
                                    break;
                                case 2:
                                    imageBouton.BeginInit();
                                    imageBouton.UriSource = new Uri(@"img/b.png", UriKind.Relative);
                                    imageBouton.EndInit();
                                    break;
                                case 3:
                                    imageBouton.BeginInit();
                                    imageBouton.UriSource = new Uri(@"img/k.png", UriKind.Relative);
                                    imageBouton.EndInit();
                                    break;
                                case 4:
                                    imageBouton.BeginInit();
                                    imageBouton.UriSource = new Uri(@"img/q.png", UriKind.Relative);
                                    imageBouton.EndInit();
                                    break;
                                case 5:
                                    imageBouton.BeginInit();
                                    imageBouton.UriSource = new Uri(@"img/b.png", UriKind.Relative);
                                    imageBouton.EndInit();
                                    break;
                                case 6:
                                    imageBouton.BeginInit();
                                    imageBouton.UriSource = new Uri(@"img/kn.png", UriKind.Relative);
                                    imageBouton.EndInit();
                                    break;
                                case 7:
                                    imageBouton.BeginInit();
                                    imageBouton.UriSource = new Uri(@"img/t.png", UriKind.Relative);
                                    imageBouton.EndInit();
                                    break;
                            }
                        }
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        imBouton.Stretch = System.Windows.Media.Stretch.None;
                        newCase.Content = imBouton;
                    }
                    Grid.SetColumn(newCase, j);
                    Grid.SetRow(newCase, i);
                    body.Children.Add(newCase);
                }
                white = !white;
            }
        }
    }
}