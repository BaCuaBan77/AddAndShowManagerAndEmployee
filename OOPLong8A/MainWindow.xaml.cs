using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOPLong8A
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<SalesPerson> salespersons = new List<SalesPerson>()

            {
            {new SalesPerson("Stan Still", new DateTime(1976, 03, 23), 123)},
            {new SalesPerson("Joe Bloggs", new DateTime(1989, 11, 27), 156)},
            {new SalesPerson("Luke Warm", new DateTime(1991, 07, 9), 147)},
            {new SalesPerson("Norman Knight", new DateTime(1959, 10, 16), 139)},
            {new SalesPerson("Susan Wynns", new DateTime(1963, 11, 26), 239)},
            {new SalesPerson("Clarence Sales", new DateTime(1977, 05, 01), 149)},
            {new SalesPerson("Lynn Seed", new DateTime(1982, 06, 23), 141)},
            {new SalesPerson("Barry More", new DateTime(1991, 12, 24), 135)},
            {new SalesPerson("Cookie Baker", new DateTime(1969, 04, 12), 155)},
            {new SalesPerson("Dawn Bright", new DateTime(1978, 01, 18), 144)}
            };


        List<Manager> managers = new List<Manager>()

            {
            {new Manager("Rocky Rhoades", new DateTime(1988, 06, 25), 1230)},
            {new Manager("Bud Light", new DateTime(1969, 08, 01), 1450)},
            {new Manager("Dick Durns", new DateTime(1974, 12, 13), 1510)},
            {new Manager("Bob Paisley", new DateTime(1979, 09, 15), 1095)},
            {new Manager("Frank Furter", new DateTime(1958, 09, 14), 1190)},
            {new Manager("Wanda Round", new DateTime(1975, 08, 11), 1220)},
            {new Manager("Sunny Day", new DateTime(1980, 11, 25), 1040)},
            {new Manager("Joy Daley", new DateTime(1992, 02, 28), 1235)},
            {new Manager("Hooker Crooke", new DateTime(1995, 11, 11), 1245)},
            {new Manager("June McBride", new DateTime(1994, 05, 04), 1075)}
            };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DisplayChoice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Display.ItemsSource = null;
            Display.Columns[2].Header = string.Empty;
            if (DisplayChoice.SelectedIndex == 1)
            {
                Display.ItemsSource = salespersons;
                Display.Columns[2].Header = "Sales num";
                ((DataGridTextColumn)Display.Columns[2]).Binding = new Binding("SalesNumber");
            }
            if (DisplayChoice.SelectedIndex == 2)
            {
                Display.ItemsSource = managers;
                Display.Columns[2].Header = "Stock opt";
                ((DataGridTextColumn)Display.Columns[2]).Binding = new Binding("StockOption");
            }
        }

        private void AddNew_Click(object sender, RoutedEventArgs e)
        {
            if (NameInformation.Text.Trim() == "" || DOBInformation.Text.Trim() == "" || (SalesPersonRB.IsChecked == false && ManagerRB.IsChecked == false)
                || (BonusInformation.Text.Trim() == "" && StockInformation.Text.Trim() == ""))
            {
                MessageBox.Show("Not enough info");
            }
            else
            {
                DateTime nextDOB;
                int nextBonus = 0, nextOption = 0;
                string errorMes = "";
                if (!DateTime.TryParse(DOBInformation.Text.Trim(), out nextDOB))
                {
                    errorMes += "Not valid";
                }
                if (SalesPersonRB.IsChecked == true && BonusInformation.Text.Trim() == "" && !Int32.TryParse(BonusInformation.Text.Trim(), out nextBonus))
                {
                    errorMes += "NOT valid";
                }
                if (ManagerRB.IsChecked == true && StockInformation.Text.Trim() == "" && !Int32.TryParse(StockInformation.Text.Trim(), out nextOption))
                {
                    errorMes += "Not VALID";
                }
                if (errorMes != "")
                {
                    MessageBox.Show(errorMes);
                }
                else
                {
                    if (SalesPersonRB.IsChecked == true)
                    {
                        salespersons.Add(new SalesPerson(NameInformation.Text.Trim(), nextDOB, nextBonus));
                        MessageBox.Show("Salesperson added!");
                    }
                    else
                    {
                        managers.Add(new Manager(NameInformation.Text.Trim(), nextDOB, nextOption));
                        MessageBox.Show("Manager added!");
                    }
                    NameInformation.Text = DOBInformation.Text = BonusInformation.Text = StockInformation.Text = string.Empty;
                    if (SalesPersonRB.IsChecked == true)
                        SalesPersonRB.IsChecked = false;
                    if (ManagerRB.IsChecked == true)
                        ManagerRB.IsChecked = false;
                }
            }
        }
    }
}