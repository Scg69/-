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
    public partial class Form2 : Form
    {
        DB dB;
      
        public Form2(DB dB)
        {
            InitializeComponent();
            this.dB = dB;
 
            comboBox3.DataSource = dB.categoriys;
            comboBox3.DisplayMember = "Name";
            comboBox4.DataSource = dB.groups;
            comboBox4.DisplayMember = "Name";
      
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nick nick = new Nick();
            nick.categoriy = (Categoriy)comboBox3.SelectedItem;
            nick.group = (Group)comboBox4.SelectedItem;
            nick.Name = textBox3.Text;
            nick.Fname = textBox2.Text;
            nick.Oname = textBox7.Text;
            nick.phone = new Phone();
            nick.phone.phone = textBox4.Text;
            nick.Email = textBox5.Text;
            nick.Adres = textBox6.Text;
            nick.Notes = textBox1.Text;
            dB.nicks.Add(nick);
            dB.Save();
            Close();


        }
    }
}
