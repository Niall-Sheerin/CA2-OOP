using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace CA2_S00200760
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        ObservableCollection<Employee> FullTime = new ObservableCollection<Employee>();
        ObservableCollection<Employee> PartTime = new ObservableCollection<Employee>();
        
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
            lbxEmployee.ItemsSource = employees;
        }

        private void txtAddEmployee_GotFocus(object sender, RoutedEventArgs e)
        {
            txtFirstName.Clear();
        }

        private void btnAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            //read name from text box
            string firstname = txtFirstName.Text;
            string lastname = txtSurname.Text;
            
            //Add new employee

            Employee employee;

            //Display new Employee
            lbxEmployee.ItemsSource = null;
            lbxEmployee.ItemsSource = employees;

            if(rbFullTime.IsChecked == true)
            {
                employee = new Employee(firstname, lastname, "Full Time");
                FullTime.Add(employee);
                tbxSalary.Text = Convert.ToString(Convert.ToDouble(tbxHoursWorked.Text) * Convert.ToDouble(tbxHourlyRate.Text) * 12);

            }
            else
            {
                employee = new Employee(firstname, lastname, "Part Time");
                PartTime.Add(employee);
                if (tbxHourlyRate.Text.Length > 0 && tbxHoursWorked.Text.Length > 0)
                {
                    tbxMonthlyPay.Text = Convert.ToString(Convert.ToDouble(tbxHoursWorked.Text) * Convert.ToDouble(tbxHourlyRate.Text));

                }

            }

            employees.Add(employee);
            
        }

        private void txtSurname_GotFocus(object sender, RoutedEventArgs e)
        { 
            txtSurname.Clear();
        }

        private void lbxEmployee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Employee selectedemployee = lbxEmployee.SelectedItem as Employee;

            if (selectedemployee != null)
            {
                txtFirstName.Text = selectedemployee.FirstName;
                txtSurname.Text = selectedemployee.LastName;

                rbFullTime.IsChecked = true;
                if (selectedemployee is FullTimeEmployee)
                {

                }
                else
                if (selectedemployee is PartTimeEmployee)
                {

                }
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtFirstName.Clear();
            txtSurname.Clear();
            tbxHoursWorked.Clear();
            tbxHourlyRate.Clear();
            tbxMonthlyPay.Clear();
            tbxSalary.Clear();
            
        }

        private void tbxHoursWorked_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void tbxHourlyRate_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            //read name from text box
            string firstname = txtFirstName.Text;
            string lastname = txtSurname.Text;

            //Add new employee

            Employee employee;

            //Display new Employee
            lbxEmployee.ItemsSource = null;
            lbxEmployee.ItemsSource = employees;

            if (rbFullTime.IsChecked == true)
            {
                employee = new Employee(firstname, lastname, "Full Time");
                FullTime.Add(employee);
                tbxSalary.Text = Convert.ToString(Convert.ToDouble(tbxHoursWorked.Text) * Convert.ToDouble(tbxHourlyRate.Text) * 12);

            }
            else
            {
                employee = new Employee(firstname, lastname, "Part Time");
                PartTime.Add(employee);
                if (tbxHourlyRate.Text.Length > 0 && tbxHoursWorked.Text.Length > 0)
                {
                    tbxMonthlyPay.Text = Convert.ToString(Convert.ToDouble(tbxHoursWorked.Text) * Convert.ToDouble(tbxHourlyRate.Text));

                }

            }

            employees.Add(employee);



        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Employee deletedemployee = lbxEmployee.SelectedItems as Employee;

            if(deletedemployee != null)
            {
                
            }

        }

        private void cbFulltime_Checked(object sender, RoutedEventArgs e)
        {
            if(cbFulltime.IsChecked == true)
            {
                lbxEmployee.ItemsSource = FullTime;
            }
            
            
        }

        private void cbParttime_Checked(object sender, RoutedEventArgs e)
        {
            if (cbParttime.IsChecked == true)
            {
                lbxEmployee.ItemsSource = PartTime;
            }

        }
    }
}
