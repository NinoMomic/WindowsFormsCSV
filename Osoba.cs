using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCSV
{
    internal class Osoba
    {
        string ime, prezime, email;
        int godRod;

        public override string ToString()
        {
            string ispis = "Ime: " + this.Ime +
                "Prezime: " + this.Prezime +
                "Godina rođenja: " + this.GodRod +
                "E-mail: " + this.Email;


                return ispis;
        }

        public Osoba(string ime, string prezime, string email, int godRod)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.email = email;
            this.godRod = godRod;
        }
        public string Ime  { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Email { get => email; set => email = value; }
        public int GodRod { get => godRod; set => godRod = value; }
    }
}
