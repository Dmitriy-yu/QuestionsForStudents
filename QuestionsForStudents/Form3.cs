using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionsForStudents
{
    public partial class Form3 : Form
    {
        SoundPlayer sp = new SoundPlayer("C:Баян, Полет Шмеля, Виртуоз (256  kbps) (1).wav");
       
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sp.PlayLooping();
                    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sp.Stop();
        }  
        private void button3_Click(object sender, EventArgs e)
        {
          int  count = 0;

            if (radioButton2.Checked == true)
            {
                count += 1;
            }
            if (radioButton7.Checked == true)
            {
                count += 1;
            }
            label3.Text = "Ваш результат равен:" + Convert.ToInt32(count);
        }
    }
}
