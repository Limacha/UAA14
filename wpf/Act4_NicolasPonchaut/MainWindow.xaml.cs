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
using Act4_NicolasPonchaut.Views;

namespace Act4_NicolasPonchaut
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitComponent();
        }

        public void InitComponent()
        {
            btnPage1.Click += new RoutedEventHandler(ChangeToPage1);
            btnPage2.Click += new RoutedEventHandler(ChangeToPage2);
        }

        private void ChangeToPage1(object sender, RoutedEventArgs e)
        {
            MainWindow pagePrincipale = (MainWindow)App.Current.MainWindow;
            pagePrincipale.Contenu.Content = new Page1();
        }

        private void ChangeToPage2(object sender, RoutedEventArgs e)
        {
            MainWindow pagePrincipale = (MainWindow)App.Current.MainWindow;
            pagePrincipale.Contenu.Content = new Page2();
        }
    }
}