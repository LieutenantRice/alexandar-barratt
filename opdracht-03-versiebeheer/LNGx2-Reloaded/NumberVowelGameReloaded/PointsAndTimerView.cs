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
    public partial class PointsAndTimerView : UserControl
    {
        PointsAndTimerController _controller;
        PointsAndTimerModel _model;


        public PointsAndTimerView(PointsAndTimerController Controller, PointsAndTimerModel model)
        {

            _model = model;
            _model.counter = 60;
            _controller = Controller;
            InitializeComponent();
            Timer();


        }


        public void Timer()
        {
            
                timer1 = new Timer();
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Interval = 1000;
                timer1.Start();
                _controller.tick();
                label4.Text = (_model.Minutes + ":" + _model.Seconds);
            



        }


        public void Score()
        {
            label3.Text = _controller._model.Score.ToString();
        }
        public void updatetime()
        {
            label4.Text = (_model.Minutes + ":" + _model.Seconds);
        }

        private void PointsAndTimerView_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_model.start == true)
            {
                _model.counter--;
                if (_model.counter <= 0)
                {
                    timer1.Stop();
                    _model.counter = 0;
                    _model.start = false;                   
                }


                _controller.tick();
                label4.Text = (_model.Minutes + ":" + _model.Seconds);
            }
        }
  
    }
}
