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
    public partial class Form7 : Form
    {
        DB dB;
        Nick nick;
        public Form7(Nick nick,DB dB)
        {
            InitializeComponent();
            this.nick = nick;
            this.dB = dB;
            comboBox1.DataSource = dB.categoriys;
            comboBox1.DisplayMember = "Name";
            comboBox1.SelectedItem = nick.categoriy;
            comboBox2.DataSource = dB.groups;
            comboBox2.DisplayMember = "Name";
            comboBox2.SelectedItem = nick.group;
            textBox3.Text = nick.Name;
            textBox2.Text = nick.Fname;
            textBox7.Text = nick.Oname;
            textBox4.Text = nick.phone.phone;
            textBox5.Text = nick.Email;
            textBox6.Text = nick.Adres;
            textBox1.Text = nick.Notes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nick.categoriy = (Categoriy)comboBox1.SelectedItem;
            nick.group = (Group)comboBox2.SelectedItem;
            nick.Name = textBox3.Text;
            nick.Fname = textBox2.Text;
            nick.Oname = textBox7.Text;
            nick.phone = new Phone();
            nick.phone.phone = textBox4.Text;
            nick.Email = textBox5.Text;
            nick.Adres = textBox6.Text;
            nick.Notes = textBox1.Text;
            dB.Save();
            Close();
        }
    }
}
