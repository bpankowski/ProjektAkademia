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

    public partial class MainProgram : Window
    {
        public MainProgram()
        {
            InitializeComponent();
        
        }
        string dbConnectionString = @"Data Source = database.db;Version=3;";


        private void save_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);
            try
            {
                // connection to db
                sqliteCon.Open();
                string Query = "insert into recipe_table (recipe_name, recipe, ingridients) values('"+this.recipe_name.Text+"','"+this.recipe_txt.Text+ "','" + this.ing_txt.Text + "')";
                SQLiteCommand newCommand = new SQLiteCommand(Query, sqliteCon);

                newCommand.ExecuteNonQuery();
               
                MessageBox.Show("Recipe Saved!");
                sqliteCon.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);
            try
            {
                // connection to db
                sqliteCon.Open();
                string Query = "update recipe_table set recipe_name='" + this.recipe_name.Text + "', recipe='" + this.recipe_txt.Text + "', ingridients='"+this.ing_txt.Text+"' where recipe_name='" + this.recipe_name.Text + "' ";
                SQLiteCommand newCommand = new SQLiteCommand(Query, sqliteCon);

                newCommand.ExecuteNonQuery();
              
                MessageBox.Show("Recipe Updated!");
                sqliteCon.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);
            try
            {
                // connection to db
                sqliteCon.Open();
                string Query = "delete from recipe_table where recipe_name='" + this.recipe_name.Text + "'";
                SQLiteCommand newCommand = new SQLiteCommand(Query, sqliteCon);

                newCommand.ExecuteNonQuery();
               
                MessageBox.Show("Recipe Deleted!");
                sqliteCon.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void all_rec_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            all_recipes main = new all_recipes();
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


