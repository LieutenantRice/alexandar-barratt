using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberVowelGameReloaded
{

    public class NumLetterController
    {
        NumLetterView _view;
        public NumLetterModel _model;
        static int timer = new Random().Next(2);
        Random random = new Random(timer++);        
        Random random2 = new Random(timer++);



        string[] Klinkers = { "A", "E", "U", "I" };
    
        string[] medeklinkers = { "B", "C", "D","F", "G","H","J","K","L","M","N","P","Q","R","S","T","V","W","X","Y","Z" };


        public NumLetterController()
        {
            _model = new NumLetterModel();
            _view = new NumLetterView(this, _model);
            VeranderLabel();

        }
        public void VeranderLabel()
        {
            _view.PutNumletterInLabel();
        }

        public void GenereerNumLetter()
        {
   
            int kOM = random.Next(2);
            int switchnbrlet = random2.Next(2);

            Console.WriteLine("Order: " + kOM);
            Console.WriteLine("OrderBrl: " + switchnbrlet);

            if (kOM == 1)
            {
                if (switchnbrlet == 0)
                {
                    Random rnd = new Random();
                    int rndNbr = rnd.Next(1, 10);
                    int rndLtr = rnd.Next(21);
                    string result = rndNbr.ToString() + medeklinkers[rndLtr];
                    _model.Nummerletter = result;


                }
                else if (switchnbrlet == 1)
                {
                    Random rnd = new Random();
                    int rndNbr = rnd.Next(1, 10);
                    int rndLtr = rnd.Next(21);
                    string result = rndNbr.ToString() + medeklinkers[rndLtr];
                    _model.Nummerletter = result;
                }
                else
                {
                    _model.Nummerletter = "ERROR";
                }



            }
            else
            {
                if (switchnbrlet == 0)
                {
                    Random rnd = new Random();
                    int rndNbr = rnd.Next(1, 10);
                    int rndLtr = rnd.Next(4);
                    string result = rndNbr.ToString() + Klinkers[rndLtr];
                    _model.Nummerletter = result;


                }
                else if (switchnbrlet == 1)
                {
                    Random rnd = new Random();
                    int rndNbr = rnd.Next(1, 10);
                    int rndLtr = rnd.Next(4);
                    string result = rndNbr.ToString() + Klinkers[rndLtr];
                    _model.Nummerletter = result;
                }
                else
                {
                    _model.Nummerletter = "ERROR";
                }


            }




        }

    
        public NumLetterView GetView()
        {
            return _view;
        }




    }
}
