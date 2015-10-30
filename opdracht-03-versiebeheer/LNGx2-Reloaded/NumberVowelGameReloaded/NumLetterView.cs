using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberVowelGameReloaded
{
    public partial class NumLetterView : UserControl
    {
        NumLetterController _controller;
        NumLetterModel _model;
        static int timer = new Random().Next(2) + 5;
        Random random = new Random(timer++);

        public NumLetterView(NumLetterController Controller , NumLetterModel Model)
        {
            _controller = Controller;
            _model = Model;
            InitializeComponent();
           
        }

        public void PutNumletterInLabel()
        {
            
            int rndLabel = random.Next(2);
            Console.WriteLine("Orderview: " + rndLabel);
            _controller.GenereerNumLetter();

            if (rndLabel == 0)
            {
                label2.Text = "";
                label1.Text = _model.Nummerletter;               
                _model.BovenOfOnder = "boven";
            }
            else if(rndLabel == 1)
            {
                label1.Text = "";
                label2.Text = _model.Nummerletter;                
                _model.BovenOfOnder = "onder";
            }
            else
            {
                label1.Text = "ERROR";
                label2.Text = "ERROR";
            }

        }

   

        private void NumLetterView_Load(object sender, EventArgs e)
        {

        }
    }
}
