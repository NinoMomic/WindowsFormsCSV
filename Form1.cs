using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace WindowsFormsCSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Osoba> listaOsoba = new List<Osoba>();

            String file = @"C:\Users\ucenik\Desktop\NinoMomic 3.D\WinForms.csv";
            String separator = ",";
            StringBuilder output = new StringBuilder();
            String[] headings = { "Ime", "Prezime", "E-mail", "GodinaRođenja" };
            output.AppendLine(string.Join(separator, headings));

            try
            {
                Osoba osoba = new Osoba(txtIme.Text, txtPrezime.Text, 
                    txtemail.Text, Convert.ToInt16(txtgodRod.Text));
                txtIme.Clear();
                txtPrezime.Clear();
                txtemail.Clear();
                txtgodRod.Clear();

                DialogResult upit = MessageBox.Show("Želite li unesti još podataka" + 
                    MessageBoxButtons.YesNo + MessageBoxIcon.Question);

                switch(upit)
                {
                    case DialogResult.Yes:
                    {
                        break;
                    }
                    case DialogResult.No:
                    {
                        listaOsoba.Add(osoba);

                        foreach(Osoba os in listaOsoba)
                        {
                                String[] newLine = { txtIme.Text, txtPrezime.Text,
                                         txtemail.Text, txtgodRod.ToString()};
                                output.AppendLine(string.Join(separator, newLine));

                                try
                                {
                                    File.AppendAllText(file, output.ToString());
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Data could not be written to the CSV file.");
                                    return;
                                }
                            }

                        break;
                    }

                }

            } catch (Exception greska)
            {
                MessageBox.Show(greska.Message, "Pogrešan unos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
