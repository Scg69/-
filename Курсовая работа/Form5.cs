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
    public partial class Form5 : Form
    {
        DB dB;
     
        public Form5(DB dB)
        {
            InitializeComponent();
            this.dB = dB;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dB.users.Find(s => s.phone.phone == textBox2.Text) != null)
            {
                MessageBox.Show("Такая почта уже используется,введите другую", MessageBoxButtons.OK.ToString());
                return;
            }
            else
            {
                User user = new User();
                user.Name = textBox1.Text;
                user.phone = new Phone();
                user.phone.phone = textBox2.Text;
                user.Parol = textBox3.Text;
                dB.users.Add(user);
                dB.Save();
                Close();
            }
           
          
        }
    }
}
