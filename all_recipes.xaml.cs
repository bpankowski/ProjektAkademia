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
using System.Windows.Shapes;
using System.Data.SQLite;


namespace Akademia
{
    /// <summary>
    /// Interaction logic for all_recipes.xaml
    /// </summary>
    public partial class all_recipes : Window
    {
        public all_recipes()
        {
            InitializeComponent();
           combo_fill();
        }
   

        string dbConnectionString = @"Data Source = database.db;Version=3;";

        void combo_fill()
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);
            try
            {
                // connection to db
                sqliteCon.Open();
                string Query = "select * from recipe_table";
                SQLiteCommand newCommand = new SQLiteCommand(Query, sqliteCon);
                SQLiteDataReader dr = newCommand.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr.GetString(0);
                    comboBox.Items.Add(name);

                }

                sqliteCon.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
               
        private void list_rec(object sender, EventArgs e)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);
            try
            {
                // connection to db
                sqliteCon.Open();
                string Query = "select * from recipe_table where recipe_name='" + comboBox.Text + "'";
                SQLiteCommand newCommand = new SQLiteCommand(Query, sqliteCon);
                SQLiteDataReader dr = newCommand.ExecuteReader();
                while (dr.Read())
                {
                    string sRec = dr.GetString(1);
                    string sIng = dr.GetString(2);

                    recipe_txt.Text = sRec;

                    ing_txt.Text = sIng;

                }



                sqliteCon.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }


        }

        private void add_new_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainProgram main = new MainProgram();
            main.ShowDialog();
        }

        private void shopping_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            shopping_list main = new shopping_list();
            main.ShowDialog();
        }

        private void Custom_Shopping_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            custom_shopping main = new custom_shopping();
            main.ShowDialog();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //printing
            PrintDialog dialog = new PrintDialog();
            if (dialog.ShowDialog() == true)
            {
                dialog.PrintVisual(_PrintCanvas, "My Canvas");
            }
        }
    }
}
