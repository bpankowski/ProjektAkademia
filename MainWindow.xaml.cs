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
using System.Data.SQLite;

namespace Akademia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string dbConnectionString = @"Data Source = database.db;Version=3;";
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);
            try
            {
                // connection to db
                sqliteCon.Open();
                string Query = "select * from login where username = '" + this.txt_username.Text + "' and password = '" + this.passwordBox.Password + "' ";
                SQLiteCommand newCommand = new SQLiteCommand(Query, sqliteCon);

                newCommand.ExecuteNonQuery();
                SQLiteDataReader dr = newCommand.ExecuteReader();

                int count = 0;
                while (dr.Read())
                {
                    count++;
                }
                
                if (count == 1)
                {
                    MessageBox.Show("Login Succes");
                    this.Hide();
                    MainProgram main = new MainProgram();
                    main.ShowDialog();
                    
                }
                if (count > 1)
                {
                    MessageBox.Show("Duplicate");
                }
                if (count < 1)
                {
                    MessageBox.Show("Not correct");
                }
                sqliteCon.Close();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
