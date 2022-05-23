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
        string[]files;
        string[]files1;
        string[]files2;
        int index;


        private void button1_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Image = new Bitmap(files[index++]);
            if (index == files.Length)
                index = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(files1[index++]);
            if (index==files1.Length)
            {
                index = 0;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            files = Directory.GetFiles(@"C:Картинки\1.Тема");
            files1 = Directory.GetFiles(@"C:Картинки\2.Тема");
            files2 = Directory.GetFiles(@"C:Картинки\3.Тема");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(File.ReadAllLines(@"C:Картинки\1.Посадка.txt", Encoding.UTF8));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            listBox1.Items.AddRange(File.ReadAllLines(@"C:Картинки\2.Учим ноты.txt", Encoding.UTF8));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(files2[index++]);
            if (index==files2.Length)
            {
                index=0;
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(File.ReadAllLines(@"C:Картинки\3.Играем левой рукой.txt",Encoding.UTF8));
        }
    }
}
