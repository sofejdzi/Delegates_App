using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public delegate void PorukaDelegat(string x);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.buttonRacunskeOperacije.Click += this.buttonRacunskeOperacije_Click;
            //this.buttonRacunskeOperacije.Click += this.buttonPoruke_Click;
        }

        private void poruka1(string tekst)
        {
            MessageBox.Show(tekst);
        }

        private void poruka2(string tekst)
        {
            MessageBox.Show(tekst, "Naslov dijaloga");
        }

        private void buttonRacunskeOperacije_Click(object sender, EventArgs e)
        {
            // Delegatu se dodeljuje staticki metod
            RacunskeOperacijeDelegat nasDelegat;
            nasDelegat = RacunskeOperacije.Saberi;
            int a = 2;
            int c = nasDelegat(a, 3);

            nasDelegat = RacunskeOperacije.Oduzmi;
            int d = nasDelegat(a, 3);

            nasDelegat += RacunskeOperacije.Saberi;
            nasDelegat += RacunskeOperacije.Saberi;
            int f = nasDelegat(a, 3);

            nasDelegat -= RacunskeOperacije.Saberi;
            nasDelegat -= RacunskeOperacije.Saberi;
            nasDelegat -= RacunskeOperacije.Saberi;

            int g = nasDelegat(a, 3);

            nasDelegat += RacunskeOperacije.Saberi;
            nasDelegat += RacunskeOperacije.Oduzmi;
            nasDelegat += RacunskeOperacije.Saberi;

            int h = nasDelegat(a, 3);
            nasDelegat -= RacunskeOperacije.Saberi;
            int i = nasDelegat(a, 3);

            nasDelegat -= RacunskeOperacije.Saberi;
            nasDelegat -= RacunskeOperacije.Oduzmi;
            nasDelegat -= RacunskeOperacije.Oduzmi;

            //int j = nasDelegat(a, 3);
        }

        private void buttonPoruke_Click(object sender, EventArgs e)
        {
            // delegatu se dodeljuje objekat i metod instance (kad se metod poziva za objekat)
            PorukaDelegat delegatPoruka;
            delegatPoruka = this.poruka1;
            delegatPoruka("Dobro jutro delegati!");
            delegatPoruka += this.poruka2;
            delegatPoruka("Dobro veče delegati!");
        }
    }
}
