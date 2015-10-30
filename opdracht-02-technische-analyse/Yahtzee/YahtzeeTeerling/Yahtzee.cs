using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeTeerling
{
    public partial class Yahtzee : Form
    {
        public Yahtzee()
        {
            InitializeComponent();
        }

        private void Yahtzee_Load(object sender, EventArgs e)
        {
            // Aantal teerlingen dat getoond moet worden
            int aantalTeerlingen = 5;

            // Maak een lijst aan waarin de teerlingen worden opgevangen
            List<TeerlingController> teerlingen = new List<TeerlingController>();

            // Maak instanties van de teerlingen aan en voeg deze toe aan de list
            for( int teerlingNummer = 0; teerlingNummer < aantalTeerlingen; ++teerlingNummer )
            {
                // maak nieuwe instantie van teerling controller;
                TeerlingController nieuweTeerling = new TeerlingController();

                // Voeg controller toe aan teerlingen lijst
                teerlingen.Add(nieuweTeerling);
            }

            // Maak instanties van de teerlingen aan en voeg deze toe aan de list
            for (int teerlingNummer = 0; teerlingNummer < aantalTeerlingen; ++teerlingNummer)
            {
                // Haal de teerling op basis van de key uit de teerlingen list 
                TeerlingController huidigeTeerling = teerlingen[ teerlingNummer ];

                // Haal de teerling view uit de teerling controller
                TeerlingView huidigeTeerlingview = huidigeTeerling.getView();

                // Bepaald de huidige x positie (horizontaal) van de teerling
                int xPos = huidigeTeerlingview.Width * teerlingNummer;

                // Zet de locatie van de teerling op basis van de x pos
                huidigeTeerlingview.Location = new Point(xPos, 0);

                // Voeg de view toe aan de huidige view
                Controls.Add(huidigeTeerlingview);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlController 
        }
    }
}
