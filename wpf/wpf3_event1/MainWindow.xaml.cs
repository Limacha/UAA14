using System.Security.Cryptography.X509Certificates;
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

namespace wpf3_event1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textA.PreviewTextInput += new TextCompositionEventHandler(VerifText);
            textB.PreviewTextInput += new TextCompositionEventHandler(VerifText);
            textC.PreviewTextInput += new TextCompositionEventHandler(VerifText);
            BtnCalculer.MouseEnter += new MouseEventHandler(SurvolBoutonTrue);
            BtnCalculer.MouseLeave += new MouseEventHandler(SurvolBoutonFalse);

        }

        public void VerifText(object sender, TextCompositionEventArgs e)
        {
            if (e.Text != "," && !EstEntier(e.Text))
            {
                e.Handled = true;
            } else if(e.Text == "," && ((TextBox)sender).Text.IndexOf(e.Text) >- 1) {
                e.Handled = true;
            }
        }

        public void SurvolBoutonTrue(object sender, MouseEventArgs e)
        {
            BtnV.Visibility = Visibility.Visible;
        }
        public void SurvolBoutonFalse(object sender, MouseEventArgs e)
        {
            BtnV.Visibility = Visibility.Visible;
        }

        private bool EstEntier(string texteUser)
        {
                return int.TryParse(texteUser, out int n);
        }

        static void ResoudTrinome(double a, double b, double c, out string message)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta < 0)
            {
                message = "Il n'y a pas de solution réelle";

            }
            else if (delta == 0)
            {
                double x1 = -b / (2 * a);
                message = "Il y a une solution " + x1;
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                message = "Il y a deux solutions " + x1 + " et " + x2;
            }
        }
    }
}