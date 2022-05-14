using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuestionsForStudents
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:Картинки\s_govor2.jpg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:Картинки\IMG_9562.jpg");
        }
    
    }
}
