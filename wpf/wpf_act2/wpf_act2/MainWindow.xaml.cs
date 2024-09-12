using System;
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
using System.Windows.Threading;

namespace wpf_act2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random nbAlea = new Random();
        TextBlock derniereTBClique;
        bool trouvePaire = false; //si on cherche le second ou pas
        DispatcherTimer timer = new DispatcherTimer();
        int tempsEcoule = 0;
        int nbPairesTrouvees = 0;

        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += new EventHandler(onTimerTick);
            SetUpGame();
        }

        public void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
            "🐈","🐈",
            "🐷","🐷",
            "🐐","🐐",
            "🦊","🦊",
            "🐴","🐴",
            "🦨","🦨",
            "🦉","🦉",
            "🐀","🐀",
            };

            foreach (TextBlock textBlock in grdMain.Children.OfType<TextBlock>())
            {
                if (textBlock.Name != "txtTemps")
                {
                    int index = nbAlea.Next(animalEmoji.Count);
                    string nextEmoji = animalEmoji[index];
                    textBlock.Text = nextEmoji;
                    animalEmoji.RemoveAt(index); // on retire un animal de la liste pour ne pas l’attribuer à nouveau.
                }
            }
            timer.Start();
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlockActif = sender as TextBlock;
            if (!trouvePaire)
            {
                textBlockActif.Visibility = Visibility.Hidden;
                derniereTBClique = textBlockActif;
                trouvePaire = true;
            }
            else if (textBlockActif.Text == derniereTBClique.Text)
            {
                nbPairesTrouvees++;
                textBlockActif.Visibility = Visibility.Hidden;
                trouvePaire = false;
            }
            else
            {
                derniereTBClique.Visibility = Visibility.Visible;
                trouvePaire = false;
            }
        }

        private void onTimerTick(object sender, EventArgs e)
        {
            tempsEcoule++;
            txtTemps.Text = Math.Round(tempsEcoule / 60F) + "m " + tempsEcoule + "s";
            if (nbPairesTrouvees == 8)
            {
                timer.Stop();
                txtTemps.Text = txtTemps.Text + " - Rejouer ?";
            }
        }

        private void onMouseDownReplayListener(object sender, MouseButtonEventArgs e)
        {
            if (nbPairesTrouvees == 8)
            {
                ResetGame();
                SetUpGame();
            }
        }

        private void ResetGame()
        {
            foreach (TextBlock block in grdMain.Children.OfType<TextBlock>())
            {
                if (block.Name == "tempsEcoule")
                {
                    block.Text = "Temps écoulé";
                    continue;
                }

                if (block.Visibility == Visibility.Hidden)
                {
                    block.Visibility = Visibility.Visible;
                }
                block.Text = "?";
            }
            nbPairesTrouvees = 0;
            tempsEcoule = 0;
        }
    }
}