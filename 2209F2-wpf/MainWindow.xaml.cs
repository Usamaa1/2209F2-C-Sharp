
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
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

namespace _2209F2_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public class Connectivity
        {
            public static SqlConnection connect = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=stdInfo;Integrated Security=True;Connect Timeout=30;");
        }


        void inptGotFocus(TextBox inptName, string inptText)
        {
            if (inptName.Text == inptText)
            {
                inptName.Text = "";
                inptName.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            }
        } 

        void inptLostFocus(TextBox inptName, string inptText)
        {
            if (inptName.Text == "")
            {
                inptName.Text = inptText;
                inptName.Foreground = new SolidColorBrush(Color.FromRgb(127, 140, 141));
            }
        }

        private void stdName_GotFocus(object sender, RoutedEventArgs e)
        {
            inptGotFocus(stdName, "Enter Student Name");
        }

        private void stdName_LostFocus(object sender, RoutedEventArgs e)
        {
            inptLostFocus(stdName, "Enter Student Name");
        }

        private void stdRoll_GotFocus(object sender, RoutedEventArgs e)
        {
            inptGotFocus(stdRoll, "Enter Roll Number");
        }

        private void stdRoll_LostFocus(object sender, RoutedEventArgs e)
        {
            inptLostFocus(stdRoll, "Enter Roll Number");
        }

        private void stdAge_GotFocus(object sender, RoutedEventArgs e)
        {
            inptGotFocus(stdAge, "Enter Age");
        }

        private void stdAge_LostFocus(object sender, RoutedEventArgs e)
        {
            inptLostFocus(stdAge, "Enter Age");

        }

        private void addStd_Click(object sender, RoutedEventArgs e)
        {
           

            try
            {
                Connectivity.connect.Open();
                SqlCommand insertQuery = new SqlCommand("INSERT INTO student VALUES (@stdName,@stdRoll, @stdAge)", Connectivity.connect);

                insertQuery.Parameters.AddWithValue("@stdName", stdName.Text);
                insertQuery.Parameters.AddWithValue("@stdRoll", stdRoll.Text);
                insertQuery.Parameters.AddWithValue("@stdAge", stdAge.Text);

                int row = insertQuery.ExecuteNonQuery();

                if (row > 0)
                {
                    MessageBox.Show("Your Data Inserted Successfully");
                }
                else
                {
                    MessageBox.Show("Data Insertion Failed");
                }
                Connectivity.connect.Close();


        }
            catch(System.InvalidOperationException er)
            {
                MessageBox.Show(er.ToString());
            }




}

        private void viewData_Click(object sender, RoutedEventArgs e)
        {

            dataForm dataForm = new dataForm();

            
            SqlCommand viewQuery = new SqlCommand("SELECT * FROM student", Connectivity.connect);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(viewQuery);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            dataForm.dataGrid.ItemsSource = dataTable.DefaultView;

            dataForm.Show();


        }
    }
}
