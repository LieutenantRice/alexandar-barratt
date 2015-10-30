using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberVowelGameReloaded
{
    public class AnswerController
    {

        AnswerView _view;

        public AnswerController()
        {

            _view = new AnswerView();

        }
        public void answer(string Answer)
        {
            _view.changetext(Answer);
        }


        public AnswerView GetView()
        {
            return _view;
        }
    }
}
