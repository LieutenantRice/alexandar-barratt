using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberVowelGameReloaded
{
    public class PointsAndTimerController
    {
        public PointsAndTimerModel _model;
        public PointsAndTimerView _view;

        public PointsAndTimerController()
        {
            _model = new PointsAndTimerModel();
            _view = new PointsAndTimerView(this,_model);

        }

        public void updateScore()
        {
           _view.Score();
            if (_model.Score>_model.highScore)
            {
                _model.highScore = _model.Score;
                Console.WriteLine(_model.highScore);
            }
        }
        public PointsAndTimerView GetView()
        {
            return _view;
        }

        public void tick()
        {
           
            if (_model.counter / 60 != 0)
            {
                float i = _model.counter / 60;
                _model.minutes = (int)Math.Floor(i);
            }
            else
            {
                _model.minutes = _model.counter / 60;
            }

            if (_model.counter % 60 != 0)
            {
                float i = _model.counter % 60;
                _model.seconds = (int)Math.Floor(i);
            }
            else
            {
                _model.seconds = _model.counter % 60;
            }


            if (_model.minutes < 10)
            {

                _model.Minutes = "0" + _model.minutes.ToString();
            }
            else
            {
                _model.Minutes = _model.minutes.ToString();
            }
            if (_model.seconds < 10)
            {
                _model.Seconds = "0" + _model.seconds.ToString();
            }
            else
            {
                _model.Seconds = _model.seconds.ToString();
            }
            
        }
    }
}
