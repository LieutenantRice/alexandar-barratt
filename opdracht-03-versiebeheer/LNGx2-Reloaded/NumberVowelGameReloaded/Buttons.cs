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
    public partial class Buttons : UserControl
    {

        NumLetterController _NumLetterController;
        ButtonController _buttonController;
        NumLetterModel _numLetterModel;
        PointsAndTimerController _PointsAndTimerController;

        public Buttons(NumLetterController NumLetterController, ButtonController ButtonController, NumLetterModel NumLetterModel , PointsAndTimerController pointsAndTimerController)
        {
            _NumLetterController = NumLetterController;
            _buttonController = ButtonController;
            _numLetterModel = NumLetterModel;
            _PointsAndTimerController = pointsAndTimerController;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (_PointsAndTimerController._model.start== true)
            //{
            //    if (_PointsAndTimerController._model.counter > 0)
            //    {
            //        _buttonController._model.yesOrNo = true;
            //        _buttonController.checkAnswer(_numLetterModel.Nummerletter, _numLetterModel.BovenOfOnder);
            //        _NumLetterController.VeranderLabel();
            //        Console.WriteLine("---RUN COMPLETE---");
            //    }
            //}
        
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (_PointsAndTimerController._model.start == true)
            //{
            //    if (_PointsAndTimerController._model.counter > 0)
            //    {
            //        _buttonController._model.yesOrNo = false;
            //        _buttonController.checkAnswer(_numLetterModel.Nummerletter, _numLetterModel.BovenOfOnder);
            //        _NumLetterController.VeranderLabel();
            //        Console.WriteLine("---RUN COMPLETE---");
            //    }
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_PointsAndTimerController._model.start == false)
            {
                _PointsAndTimerController._model.start = true;
                _PointsAndTimerController._model.counter = 60;
                _PointsAndTimerController._model.Score = 0;
                _PointsAndTimerController._view.Score();
                _PointsAndTimerController._view.Timer();
            }
            
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P)
            {
                if (_PointsAndTimerController._model.start == true)
                {
                    if (_PointsAndTimerController._model.counter > 0)
                    {
                        _buttonController._model.yesOrNo = true;
                        _buttonController.checkAnswer(_numLetterModel.Nummerletter, _numLetterModel.BovenOfOnder);
                        _NumLetterController.VeranderLabel();
                        Console.WriteLine("---RUN COMPLETE---");
                    }
                }
                Console.WriteLine("You YES");
            }
            else if(e.KeyCode == Keys.O)
            {
                if (_PointsAndTimerController._model.start == true)
                {
                    if (_PointsAndTimerController._model.counter > 0)
                    {
                        _buttonController._model.yesOrNo = false;
                        _buttonController.checkAnswer(_numLetterModel.Nummerletter, _numLetterModel.BovenOfOnder);
                        _NumLetterController.VeranderLabel();
                        Console.WriteLine("---RUN COMPLETE---");
                    }
                }
                Console.WriteLine("You NO");
            }
        }
    }
}
