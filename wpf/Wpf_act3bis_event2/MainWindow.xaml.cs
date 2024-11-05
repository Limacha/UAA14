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

namespace Wpf_act3bis_event2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpWindow();
        }
        private void SetUpWindow()
        {
            dateArrivee.SelectedDate = null;
            dateSortie.SelectedDate = null;

            dateArrivee.BlackoutDates.Clear();
            dateSortie.BlackoutDates.Clear();

            SetDate(dateArrivee);
            SetDate(dateSortie);

            dateArrivee.DisplayDateStart = DateTime.Now;
            dateArrivee.DisplayDateEnd = DateTime.Now.AddYears(1);

            dateSortie.DisplayDateStart = DateTime.Now;
            dateSortie.DisplayDateEnd = DateTime.Now.AddYears(1);

            dateArrivee.CalendarClosed += new RoutedEventHandler(VerifDateOut);
            dateSortie.CalendarClosed += new RoutedEventHandler(VerifDateIn);

            boutonInit.MouseDown += new MouseButtonEventHandler(resetGame);
        }

        private void resetGame(object sender, MouseButtonEventArgs e)
        {
            SetUpWindow();
        }

        private void SetDate(DatePicker date)
        {
            CalendarDateRange dateRange = new CalendarDateRange(new DateTime(0001, 01, 01), DateTime.Now.AddDays(-1));
            date.BlackoutDates.Add(dateRange);

            dateRange = new CalendarDateRange(new DateTime(DateTime.Now.Year, 01, 31), new DateTime(DateTime.Now.Year, 03, 31));
            date.BlackoutDates.Add(dateRange);
            dateRange = new CalendarDateRange(new DateTime(DateTime.Now.Year, 04, 30), new DateTime(DateTime.Now.Year, 06, 30));
            date.BlackoutDates.Add(dateRange);
            dateRange = new CalendarDateRange(new DateTime(DateTime.Now.Year, 08, 31), new DateTime(DateTime.Now.Year, 11, 30));
            date.BlackoutDates.Add(dateRange);

            dateRange = new CalendarDateRange(new DateTime(DateTime.Now.Year + 1, 01, 31), new DateTime(DateTime.Now.Year + 1, 03, 31));
            date.BlackoutDates.Add(dateRange);
            dateRange = new CalendarDateRange(new DateTime(DateTime.Now.Year + 1, 04, 30), new DateTime(DateTime.Now.Year + 1, 06, 30));
            date.BlackoutDates.Add(dateRange);
            dateRange = new CalendarDateRange(new DateTime(DateTime.Now.Year + 1, 08, 31), new DateTime(DateTime.Now.Year + 1, 11, 30));
            date.BlackoutDates.Add(dateRange);

            dateRange = new CalendarDateRange(DateTime.Now.AddYears(1), new DateTime(9999, 12, 31));
            date.BlackoutDates.Add(dateRange);
        }
        //les date beug encore mais plus envie de me battre
        private void VerifDateOut(object sender, RoutedEventArgs e)
        {
            if (dateArrivee.SelectedDate != null)
            {
                dateSortie.SelectedDate = null;
                CalendarDateRange dateRangeOut;

                switch (dateArrivee.SelectedDate.Value.Date.Month)
                {
                    case 1:
                        dateRangeOut = new CalendarDateRange(new DateTime(dateArrivee.SelectedDate.Value.Date.Year, 02, 01), new DateTime(9999, 12, 31));
                        dateSortie.BlackoutDates.Add(dateRangeOut);
                        dateRangeOut = new CalendarDateRange(DateTime.Now, dateArrivee.SelectedDate.Value.Date);
                        dateSortie.BlackoutDates.Add(dateRangeOut);
                        break;
                    case 4:
                        dateRangeOut = new CalendarDateRange(new DateTime(dateArrivee.SelectedDate.Value.Date.Year, 05, 01), new DateTime(9999, 12, 31));
                        dateSortie.BlackoutDates.Add(dateRangeOut);
                        dateRangeOut = new CalendarDateRange(DateTime.Now, dateArrivee.SelectedDate.Value.Date);
                        dateSortie.BlackoutDates.Add(dateRangeOut);
                        break;
                    case 7:
                        dateRangeOut = new CalendarDateRange(new DateTime(dateArrivee.SelectedDate.Value.Date.Year, 09, 01), new DateTime(9999, 12, 31));
                        dateSortie.BlackoutDates.Add(dateRangeOut);
                        dateRangeOut = new CalendarDateRange(DateTime.Now, dateArrivee.SelectedDate.Value.Date);
                        dateSortie.BlackoutDates.Add(dateRangeOut);
                        break;
                    case 8:
                        dateRangeOut = new CalendarDateRange(new DateTime(dateArrivee.SelectedDate.Value.Date.Year, 09, 01), new DateTime(9999, 12, 31));
                        dateSortie.BlackoutDates.Add(dateRangeOut);
                        dateRangeOut = new CalendarDateRange(DateTime.Now, dateArrivee.SelectedDate.Value.Date);
                        dateSortie.BlackoutDates.Add(dateRangeOut);
                        break;
                    case 12:
                        dateRangeOut = new CalendarDateRange(new DateTime(dateArrivee.SelectedDate.Value.Date.Year + 1, 02, 01), new DateTime(9999, 12, 31));
                        dateSortie.BlackoutDates.Add(dateRangeOut);
                        dateRangeOut = new CalendarDateRange(DateTime.Now, dateArrivee.SelectedDate.Value.Date);
                        dateSortie.BlackoutDates.Add(dateRangeOut);
                        break;
                }
                dateSortie.SelectedDate = dateArrivee.SelectedDate.Value.Date.AddDays(1);
            }
        }
        private void VerifDateIn(object sender, RoutedEventArgs e)
        {
            if (dateSortie.SelectedDate != null)
            {
                dateArrivee.SelectedDate = null;
                CalendarDateRange dateRangeOut;

                switch (dateSortie.SelectedDate.Value.Date.Month)
                {
                    case 1:
                        dateRangeOut = new CalendarDateRange(dateSortie.SelectedDate.Value.Date, new DateTime(9999, 12, 31));
                        dateArrivee.BlackoutDates.Add(dateRangeOut);
                        dateRangeOut = new CalendarDateRange(new DateTime(0001, 01, 01), new DateTime(dateSortie.SelectedDate.Value.Date.Year - 1, 11, 30));
                        dateArrivee.BlackoutDates.Add(dateRangeOut);
                        break;
                    case 4:
                        dateRangeOut = new CalendarDateRange(dateSortie.SelectedDate.Value.Date, new DateTime(9999, 12, 31));
                        dateArrivee.BlackoutDates.Add(dateRangeOut);
                        dateRangeOut = new CalendarDateRange(new DateTime(0001, 01, 01), new DateTime(dateSortie.SelectedDate.Value.Date.Year, 03, 31));
                        dateArrivee.BlackoutDates.Add(dateRangeOut);
                        break;
                    case 7:
                        dateRangeOut = new CalendarDateRange(dateSortie.SelectedDate.Value.Date, new DateTime(9999, 12, 31));
                        dateArrivee.BlackoutDates.Add(dateRangeOut);
                        dateRangeOut = new CalendarDateRange(new DateTime(0001, 01, 01), new DateTime(dateSortie.SelectedDate.Value.Date.Year, 06, 30));
                        dateArrivee.BlackoutDates.Add(dateRangeOut);
                        break;
                    case 8:
                        dateRangeOut = new CalendarDateRange(dateSortie.SelectedDate.Value.Date, new DateTime(9999, 12, 31));
                        dateArrivee.BlackoutDates.Add(dateRangeOut);
                        dateRangeOut = new CalendarDateRange(new DateTime(0001, 01, 01), new DateTime(dateSortie.SelectedDate.Value.Date.Year, 06, 30));
                        dateArrivee.BlackoutDates.Add(dateRangeOut);
                        break;
                    case 12:
                        dateRangeOut = new CalendarDateRange(dateSortie.SelectedDate.Value.Date, new DateTime(9999, 12, 31));
                        dateArrivee.BlackoutDates.Add(dateRangeOut);
                        dateRangeOut = new CalendarDateRange(new DateTime(0001, 01, 01), new DateTime(dateSortie.SelectedDate.Value.Date.Year, 11, 30));
                        dateArrivee.BlackoutDates.Add(dateRangeOut);
                        break;
                }
                dateArrivee.SelectedDate = dateSortie.SelectedDate.Value.Date.AddDays(1);
            }
        }
    }
}