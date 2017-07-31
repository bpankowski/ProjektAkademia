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
    /// Interaction logic for shopping_list.xaml
    /// </summary>
    public partial class shopping_list : Window
    {
        public shopping_list()
        {
            InitializeComponent();
            combo_fill();
            ing_fill();
            meters();
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

        void ing_fill()
        {

            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);
            try
            {
                // connection to db
                sqliteCon.Open();
                string Query = "select * from ingridients";
                SQLiteCommand newCommand = new SQLiteCommand(Query, sqliteCon);
                SQLiteDataReader dr = newCommand.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr.GetString(0);
                    comboBox1.Items.Add(name);
                    comboBox1_Copy.Items.Add(name);
                    comboBox1_Copy1.Items.Add(name);
                    comboBox1_Copy2.Items.Add(name);
                    comboBox1_Copy3.Items.Add(name);
                    comboBox1_Copy4.Items.Add(name);
                    comboBox1_Copy11.Items.Add(name);
                    comboBox1_Copy12.Items.Add(name);
                    comboBox1_Copy13.Items.Add(name);
                    comboBox1_Copy14.Items.Add(name);
                    comboBox1_Copy15.Items.Add(name);
                    comboBox1_Copy16.Items.Add(name);

                }

                sqliteCon.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        void meters()

        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);
            try
            {
                // connection to db
                sqliteCon.Open();
                string Query = "select * from meters";
                SQLiteCommand newCommand = new SQLiteCommand(Query, sqliteCon);
                SQLiteDataReader dr = newCommand.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr.GetString(0);
                    comboBox1_Copy5.Items.Add(name);
                    comboBox1_Copy6.Items.Add(name);
                    comboBox1_Copy7.Items.Add(name);
                    comboBox1_Copy8.Items.Add(name);
                    comboBox1_Copy9.Items.Add(name);
                    comboBox1_Copy10.Items.Add(name);
                    comboBox1_Copy17.Items.Add(name);
                    comboBox1_Copy18.Items.Add(name);
                    comboBox1_Copy19.Items.Add(name);
                    comboBox1_Copy20.Items.Add(name);
                    comboBox1_Copy21.Items.Add(name);
                    comboBox1_Copy22.Items.Add(name);

                }

                sqliteCon.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }




        }

        private void rec_list(object sender, EventArgs e)
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

                    string sIng = dr.GetString(2);


                    ing_txt.Text = sIng;

                }



                sqliteCon.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
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

        private void add_new_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainProgram main = new MainProgram();
            main.ShowDialog();
        }

        private void all_recipes_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            all_recipes main = new all_recipes();
            main.ShowDialog();
        }
    }
 }


