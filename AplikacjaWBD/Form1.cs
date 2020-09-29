using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Oracle.DataAccess.Client;

namespace AplikacjaWBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private OracleConnection nowe_polaczenie = new OracleConnection();
        private OracleCommand control_manager_dialog;
        private OracleDataAdapter data_adapter;
        private OracleCommandBuilder comand_builer;
        private DataSet wybor_danych;
        private DataView wyswietlanie_danych;



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonPolacz_Click(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Zawartość wczytanej bazy danych, liczba atrybutów: "
                   + wybor_danych.Tables[0].Columns.Count + ", liczba rekordów"
                   + wybor_danych.Tables[0].Rows.Count;
                nowe_polaczenie.Close();
                nowe_polaczenie.ConnectionString = "User Id=" + textBoxUzytkownik.Text + ";Password=" + textBoxHaslo.Text + ";Data Source=orc;";
                //nowe_polaczenie.ConnectionString = "User Id=SYSTEM;Password=7R9Mpkp19;Data Source=orc;";
                nowe_polaczenie.Open();

                comboBoxNazwyKolumn.Items.Clear();
                comboBoxNazwyKolumn.ResetText();
                textBoxSzukaj.Clear();



                string sql = "SELECT " + textBox1.Text + " FROM " + textBoxZapytanieSQL.Text;

                control_manager_dialog = new OracleCommand(sql, nowe_polaczenie);
                control_manager_dialog.CommandType = CommandType.Text;
                OracleDataReader dr = control_manager_dialog.ExecuteReader();

                data_adapter = new OracleDataAdapter(control_manager_dialog);
                comand_builer = new OracleCommandBuilder(data_adapter);
                wybor_danych = new DataSet();

                data_adapter.Fill(wybor_danych);

                dataGridViewTablicaDanych.DataSource = wybor_danych.Tables[0];

                MessageBox.Show("Zawartość wczytanej bazy danych:\n-liczba atrybutów:\t"
                    + wybor_danych.Tables[0].Columns.Count + "\n-liczba rekordów:\t"
                    + wybor_danych.Tables[0].Rows.Count);

                this.Text = "Zawartość wczytanej bazy danych, liczba atrybutów: "
                    + wybor_danych.Tables[0].Columns.Count + ", liczba rekordów"
                    + wybor_danych.Tables[0].Rows.Count;

            }

            catch (OracleException ex)
            {
                switch (ex.Number)
                {
                    case 1:
                        MessageBox.Show("Error attempting to insert duplicate data.");
                        break;
                    case 12560:
                        MessageBox.Show("The database is unvailable.");
                        break;
                    default:
                        MessageBox.Show("Database error: " + ex.Message.ToString());
                        break;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                try
                {
                    //conn.Dispose()
                    for (int i = 0; i < wybor_danych.Tables[0].Columns.Count; i++)
                    {
                        comboBoxNazwyKolumn.Items.Add(wybor_danych.Tables[0].Columns[i].ToString());
                    }
                }
                catch
                {
                }
            }
        }

        private void textBoxHaslo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUzytkownik_TextChanged(object sender, EventArgs e)
        {


        }

        private void dataGridViewTablicaDanych_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonPokazWszystko_Click(object sender, EventArgs e)
        {
            dataGridViewTablicaDanych.DataSource = wybor_danych.Tables[0].DefaultView;
        }

        private void textBoxZapytanieSQL_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSzukaj_Click(object sender, EventArgs e)
        {
            try
            {
                wyswietlanie_danych = new DataView(wybor_danych.Tables[0], comboBoxNazwyKolumn.Text + " = '"
                    + textBoxSzukaj.Text + "' ", comboBoxNazwyKolumn.Text + " Desc", DataViewRowState.CurrentRows);
                dataGridViewTablicaDanych.DataSource = wyswietlanie_danych;
                if(wyswietlanie_danych.Count==0)
                {
                    MessageBox.Show("Brak jest rekordów o tej frazie", "UWAGA");
                }
            }
            catch
            {
                MessageBox.Show("Fraza jest niepoprawna, spróbuj ponownie", "UWAGA");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                data_adapter.Update(wybor_danych.Tables[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void buttonZapytanie_Click(object sender, EventArgs e)
        {
            try
            {
                wyswietlanie_danych = new DataView();
                wyswietlanie_danych.Table = wybor_danych.Tables[0];
                wyswietlanie_danych.RowFilter = textBoxSortowanieWarunkowe.Text;
                dataGridViewTablicaDanych.DataSource = wyswietlanie_danych;

                MessageBox.Show("Znaleziono rekordów: " + wyswietlanie_danych.Count, "INFORMACJA");

            }
            catch
            {
                MessageBox.Show("Warunek jest niepoprawny, spróbuj ponownie", "UWAGA");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSortowanieWarunkowe_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {

        }
    }
}
