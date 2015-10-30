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
    public partial class AnswerView : UserControl
    {
        public AnswerView()
        {
            InitializeComponent();
        }

        public void changetext(string Answer)
        {
            label1.Text = Answer;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
