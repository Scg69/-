using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public partial class Form4 : Form
    {
        DB dB;
        public Form4(DB dB)
        {
            InitializeComponent();
            this.dB = dB;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form5(dB).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dB.users.Find(s => s.Name == textBox1.Text & s.Parol == textBox2.Text) == null)
            {
                MessageBox.Show("Проверьте логин или пароль", MessageBoxButtons.OK.ToString());
            }
     
            else
            {
                User users = dB.users.Find(s => s.Name == textBox1.Text & s.Parol == textBox2.Text);
                new Form1(users).Show();
                Hide();
            }
           
            
        }
    }
}

