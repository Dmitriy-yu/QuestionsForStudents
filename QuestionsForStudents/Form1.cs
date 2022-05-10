using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionsForStudents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
        }
        Form2 form2;
        string login = "Mus";
        string parol = "Veronica";
        private void button1_Click(object sender, EventArgs e)
        {
            string Log = textBox1.Text;
           string Par = textBox2.Text;
            if (Log==login&&Par==parol)
            {
                form2.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Введите заново");
            }
            
        }
    }
}
