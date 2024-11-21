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

namespace wpf_creationDynaObject
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
            ColumnDefinition columnDefinition1 = new ColumnDefinition();
            ColumnDefinition columnDefinition2 = new ColumnDefinition();
            ColumnDefinition columnDefinition3 = new ColumnDefinition();

            RowDefinition rowDefinition1 = new RowDefinition();
            RowDefinition rowDefinition2 = new RowDefinition();
            RowDefinition rowDefinition3 = new RowDefinition();
            
            body.ColumnDefinitions.Add(columnDefinition1);
            body.ColumnDefinitions.Add(columnDefinition2);
            body.ColumnDefinitions.Add(columnDefinition3);

            body.RowDefinitions.Add(rowDefinition1);
            body.RowDefinitions.Add(rowDefinition2);
            body.RowDefinitions.Add(rowDefinition3);

            #region row0
            TextBlock textBlock = new TextBlock();
            textBlock.Text = "TextBlock créé dynamiquement";
            textBlock.Background = Brushes.Yellow;
            textBlock.Foreground = Brushes.Red;

            Grid.SetColumnSpan(textBlock, 3);
            body.Children.Add(textBlock);
            #endregion

            #region row1
            Button button1 = new Button();
            Button button2 = new Button();
            Button button3 = new Button();

            button1.Content = "Button 1";
            button2.Content = "Button 2";
            button3.Content = "Button 3";

            button1.Height = this.Height/6;
            button2.Height = this.Height/6;
            button3.Height = this.Height/6;

            button1.Width = this.Width/6;
            button2.Width= this.Width/6;
            button3.Width = this.Width/6;

            Grid.SetRow(button1, 1);
            Grid.SetColumn(button1, 0);

            Grid.SetRow(button2, 1);
            Grid.SetColumn(button2, 1);

            Grid.SetRow(button3, 1);
            Grid.SetColumn(button3, 2);

            body.Children.Add(button1);
            body.Children.Add(button2);
            body.Children.Add(button3);
            #endregion

            #region row2
            StackPanel stackPanel = new StackPanel();

            Grid.SetColumnSpan(stackPanel, 2);
            Grid.SetColumn(stackPanel, 0);
            Grid.SetRow(stackPanel, 2);

            textBlock = new TextBlock();
            TextBox textBox = new TextBox();

            textBlock.Text = "INFO: ";
            textBlock.Background = Brushes.Yellow;

            textBox.Text = "J'attend vos infos";

            stackPanel.Children.Add(textBlock);
            stackPanel.Children.Add(textBox);

            body.Children.Add(stackPanel);

            ComboBox cboNoms = new ComboBox();

            cboNoms.Height = this.Height/6;
            cboNoms.Width = this.Width/6;

            cboNoms.Items.Add("Jean");
            cboNoms.Items.Add("Jack");

            Grid.SetColumn(cboNoms, 2);
            Grid.SetRow(cboNoms, 2);

            body.Children.Add(cboNoms);
            #endregion
        }
    }
}