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

namespace UAA14_I4_PonchautNicolas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MethodesDuProjet func = new MethodesDuProjet();
        public MainWindow()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            txtNombre1.Text = "";
            txtNombre2.Text = "";
            txtResultat.Text = "";

            optAddition.IsChecked = true;
            optSoustraction.IsChecked = false;

            txtNombre1.PreviewTextInput += new TextCompositionEventHandler(VerifText1);
            txtNombre2.PreviewTextInput += new TextCompositionEventHandler(VerifText2);

            btnCalculer.Click += new RoutedEventHandler(Calculer);
            btnReset.Click += new RoutedEventHandler(Reset);
        }

        private void VerifText1(object sender, TextCompositionEventArgs e)
        {
            if (txtNombre1.Text.Length >= 7)
            {
                e.Handled = true;
                return;
            }
            if (e.Text != "0" && e.Text != "1")
            {
                e.Handled = true;
                return;
            }
        }
        private void VerifText2(object sender, TextCompositionEventArgs e)
        {
            if (txtNombre2.Text.Length >= 7)
            {
                e.Handled = true;
                return;
            }
            if (e.Text != "0" && e.Text != "1")
            {
                e.Handled = true;
                return;
            }
        }

        private void Reset(object sender, RoutedEventArgs e)
        {
                Init();
        }
        private void Calculer(object sender, RoutedEventArgs e)
        {
            if (txtNombre1.Text.Length > 0 && txtNombre1.Text.Length <= 7 && txtNombre2.Text.Length > 0 && txtNombre2.Text.Length <= 7)
            {
                ushort[] tabN1 = func.RemplirTableau(txtNombre1.Text);
                ushort[] tabN2 = func.RemplirTableau(txtNombre2.Text);
                if (optAddition.IsChecked == true)
                {
                    func.Additionne(tabN1, tabN2, out ushort[] tabRest, out bool ok);
                    if (ok)
                    {

                        txtResultat.Text = func.Concatene(tabRest);
                    }
                    else
                    {
                        txtResultat.Text = "Concatenation impossible";
                    }
                }
                else 
                {
                    func.Soustrait(tabN1, tabN2, out ushort[] tabRest);

                    txtResultat.Text = func.Concatene(tabRest);
                }
            }
            else
            {
                MessageBox.Show("les nombres sont pas valid");
                e.Handled = true;
            }
        }
    }
}