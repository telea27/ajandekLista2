using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ajandekLista2
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=ajandek; Uid=root; Pwd=''");
            conn.Open();

            this.FormClosed += (sender, args) =>
              {
                  if (conn != null)
                  {
                      conn.Close();
                  }
              };
            AdatBetoltes();
        }

        void AdatBetoltes()
        {
            string sql = @"SELECT id, nev, uzlet FROM ajandek ORDER BY nev";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string nev = reader.GetString("nev");
                    string uzlet;
                    try
                    {
                        uzlet = reader.GetString("uzlet");
                    }
                    catch (SqlNullValueException ex)
                    {
                        uzlet = null;
                    }
                    var ajandek = new Ajandek(id, nev, uzlet);
                    ajandekListBox.Items.Add(ajandek);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxAjandekNev_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHozzaad_Click(object sender, EventArgs e)
        {

            string nev = textBoxAjandekNev.Text;
            string uzlet = textBoxAjandekUzlet.Text;
            string sql = @"INSERT INTO `ajandek`(`nev`, `uzlet`) VALUES ('" + nev + "','" + uzlet + "')";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            comm.ExecuteNonQuery();
            ajandekListBox.Items.Clear();
            AdatBetoltes();

        }

        private void buttonTorol_Click(object sender, EventArgs e)
        {
            if (ajandekListBox.SelectedItem != null)
            {

                string sql = @"DELETE FROM `ajandek` WHERE nev = '" + ajandekListBox.SelectedItem + "'", GetConnection;
                var comm = this.conn.CreateCommand();
                comm.CommandText = sql;
                comm.ExecuteNonQuery();
                ajandekListBox.Items.Remove(ajandekListBox.SelectedItem);

            }
        }
        private void buttonReszletek_Click(object sender, EventArgs e)
        {
            if(ajandekListBox.SelectedItem!=null)
            {
                string sql = @"SELECT id, nev, uzlet FROM `ajandek` WHERE nev = '"+ajandekListBox.SelectedItem+"'", GetConnection;
                var comm = this.conn.CreateCommand();
                comm.CommandText = sql;
                using (var reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id");
                        string nev = reader.GetString("nev");
                        string uzlet;
                        try
                        {
                            uzlet = reader.GetString("uzlet");
                        }
                        catch (SqlNullValueException ex)
                        {
                            uzlet = null;
                        }
                        if(uzlet==null)
                        {
                            MessageBox.Show(id + ":" + nev + " - saját készítésű");
                        }
                        else
                        {
                            MessageBox.Show(id + ": " + nev + " - " + uzlet);
                        }
                        
                    }
                }
               
            }
        }

        private void buttonszerkesztes_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            
        }

        private void ajandekListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ajandekListBox.SelectedItem!=null)
            {
                buttonszerkesztes.Enabled = true;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            // csak úgy lehet szerkeszteni ha a nevet és az üzletet is beírja

            string nev = textBox1.Text;
            string uzlet = textBox2.Text;
            string sql = @"UPDATE `ajandek` SET `nev`='" + nev+"',`uzlet`='"+uzlet+"' WHERE nev = '"+ajandekListBox.SelectedItem+"'";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            comm.ExecuteNonQuery();
            ajandekListBox.Items.Clear();
            AdatBetoltes();
        }
    }



}

