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

namespace CE_UAA14WPF_Dec24_PonchautNicolas
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
        private void Init()
        {
            taille.Visibility = Visibility.Hidden;

            nbreLigne.PreviewTextInput += VerifText;
            nbreColonnes.PreviewTextInput += VerifText;


            rbSolitaire.Click += TailleVisibility;
            rbMarelle.Click += TailleVisibility;
            rbLibre.Click += TailleVisibility;

            btnValider.Click += BtnValiderClick;

            reset.Click += Reset_Click;
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            gridchange.Children.Clear();

            taille.Visibility = Visibility.Hidden;
            nbreLigne.Text = "";
            nbreColonnes.Text = "";

            rbSolitaire.IsChecked = false;
            rbMarelle.IsChecked = false;
            rbLibre.IsChecked = false;

            Error.Text = "Test WPF 6T 2024";
        }

        private void TailleVisibility(object sender, RoutedEventArgs e)
        {
            if (rbLibre.IsChecked == true)
            {
                taille.Visibility = Visibility.Visible;
            }
            else
            {
                taille.Visibility = Visibility.Hidden;
            }
        }

        private void BtnValiderClick(object sender, RoutedEventArgs e)
        {
            if (rbSolitaire.IsChecked == true)
            {
                SetSolitaire();
            }
            else if (rbMarelle.IsChecked == true)
            {
                SetMarelle();
            }
            else if (rbLibre.IsChecked == true)
            {
                SetLibre();
            }
        }

        private void VerifText(object sender, TextCompositionEventArgs e)
        {
            if (!EstEntier(e.Text))
            {
                e.Handled = true;
            }
        }
        private bool EstEntier(string texteUser)
        {
            return int.TryParse(texteUser, out int n);
        }

        private void SetSolitaire()
        {
            Grid grid = new Grid();
            for (int i = 0; i < 9; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
                grid.RowDefinitions.Add(new RowDefinition());
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if ((i >= 3 && i <= 6) || (j >= 3 && j <= 6))
                    {
                        Button button = new Button();
                        button.Background = Brushes.Khaki;
                        button.Click += Button_Click;

                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri(@"img/petitCercleRouge.png", UriKind.Relative);
                        imageBouton.EndInit();

                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        imBouton.Stretch = System.Windows.Media.Stretch.Fill;

                        button.Content = imBouton;
                        Grid.SetColumn(button, j);
                        Grid.SetRow(button, i);
                        grid.Children.Add(button);
                    }

                }
            }

            Grid.SetColumn(grid, 0);
            Grid.SetRow(grid, 1);
            gridchange.Children.Clear();
            gridchange.Children.Add(grid);
        }

        private void SetMarelle()
        {
            Grid grid = new Grid();
            for (int i = 0; i < 7; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
                grid.RowDefinitions.Add(new RowDefinition());
            }

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if ((j == 3 || i == 3 || j == i || j == 6 - i) && !(j == 3 && i == 3))
                    {
                        Button button = new Button();
                        button.Background = Brushes.Khaki;
                        button.Click += Button_Click;

                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri(@"img/petitCercleRouge.png", UriKind.Relative);
                        imageBouton.EndInit();

                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        imBouton.Stretch = System.Windows.Media.Stretch.Fill;

                        button.Content = imBouton;
                        Grid.SetColumn(button, j);
                        Grid.SetRow(button, i);
                        grid.Children.Add(button);
                    }

                }
            }

            Grid.SetColumn(grid, 0);
            Grid.SetRow(grid, 1);
            gridchange.Children.Clear();
            gridchange.Children.Add(grid);
        }
        private void SetLibre()
        {
            if (nbreLigne.Text.Length > 0 && nbreColonnes.Text.Length > 0)
            {
                int.TryParse(nbreLigne.Text, out int nLigne);
                int.TryParse(nbreColonnes.Text, out int nColonne);
                if (nLigne > 0 && nColonne > 0 && nLigne < 13 && nColonne < 13) 
                {
                    Grid grid = new Grid();
                    for (int i = 0; i < nLigne; i++)
                    {
                        grid.RowDefinitions.Add(new RowDefinition());
                    }
                    for (int i = 0; i < nColonne; i++)
                    {
                        grid.ColumnDefinitions.Add(new ColumnDefinition());
                    }

                    for (int i = 0; i < nLigne; i++)
                    {
                        for (int j = 0; j < nColonne; j++)
                        {
                            if (j == 0 || j == nColonne - 1 || i == 0 || i == nLigne -1)
                            {
                                Button button = new Button();
                                button.Background = Brushes.Khaki;
                                button.Foreground = Brushes.Red;
                                button.Click += ChangeBack;

                                TextBlock textBlock = new TextBlock();
                                textBlock.Text = "X";
                                button.Content = textBlock;

                                Grid.SetColumn(button, j);
                                Grid.SetRow(button, i);
                                grid.Children.Add(button);
                            }
                        }
                    }
                    Grid.SetColumn(grid, 0);
                    Grid.SetRow(grid, 1);
                    gridchange.Children.Clear();
                    gridchange.Children.Add(grid);
                }
                else
                {
                    Error.Text = "Veuillez encoder des dimensions valides comprises entre 1 et 12";
                }
            }
            else
            {
                Error.Text = "Veuillez encoder des dimensions valides comprises entre 1 et 12";
            }
        }

        private void ChangeBack(object sender, RoutedEventArgs e)
        {
            var color = ((Button)sender).Background;
            ((Button)sender).Background = ((Button)sender).Foreground;
            ((Button)sender).Foreground = color;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            BitmapImage imageBouton = new BitmapImage();
            imageBouton.BeginInit();
            imageBouton.UriSource = new Uri(@"img/golfBall60.png", UriKind.Relative);
            imageBouton.EndInit();

            Image imBouton = new Image();
            imBouton.Source = imageBouton;
            imBouton.Stretch = System.Windows.Media.Stretch.Fill;

            button.Content = imBouton;
        }
    }
}