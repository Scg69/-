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
    public partial class Form3 : Form
    {
        DB dB;
        public Form3(DB dB)
        {
            InitializeComponent();
            this.dB = dB;
            comboBox1.DataSource = dB.categoriys;
            comboBox1.DisplayMember = "Name";
            comboBox1.SelectedIndex = 0;
        }
        void show(List <Nick> nicks)
        {
            
            listView1.Items.Clear();
            foreach(Nick nick in nicks)
            {

                ListViewItem row = new ListViewItem(nick.categoriy.Name);
                row.SubItems.Add(nick.Fname);
                row.SubItems.Add(nick.phone.phone);
                row.SubItems.Add(nick.Email);
                row.SubItems.Add(nick.Adres);
                row.Tag = nick;
                listView1.Items.Add(row);
            }

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (Nick nick in dB.nicks.Where(s => s.categoriy == (Categoriy)comboBox1.SelectedItem))
            {
                ListViewItem row = new ListViewItem(nick.categoriy.Name);
                row.SubItems.Add(nick.Fname);
                row.SubItems.Add(nick.phone.phone);
                row.SubItems.Add(nick.Email);
                row.SubItems.Add(nick.Adres);
                row.Tag = nick;
                listView1.Items.Add(row);
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (Nick nick in dB.nicks.Where(s => s.Fname.ToLower().Contains(textBox2.Text.ToLower())))
            {
                ListViewItem row = new ListViewItem(nick.categoriy.Name);
                row.SubItems.Add(nick.Fname);
                row.SubItems.Add(nick.phone.phone);
                row.SubItems.Add(nick.Email);
                row.SubItems.Add(nick.Adres);
                row.Tag = nick;
                listView1.Items.Add(row);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            foreach (Nick nick in dB.nicks.Where(s => s.phone.phone.ToLower().Contains(textBox4.Text.ToLower())))
            {
                ListViewItem row = new ListViewItem(nick.categoriy.Name);
                row.SubItems.Add(nick.Fname);
                row.SubItems.Add(nick.phone.phone);
                row.SubItems.Add(nick.Email);
                row.SubItems.Add(nick.Adres);
                row.Tag = nick;
                listView1.Items.Add(row);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            foreach (Nick nick in dB.nicks.Where(s => s.Email.ToLower().Contains(textBox5.Text.ToLower())))
            {
                ListViewItem row = new ListViewItem(nick.categoriy.Name);
                row.SubItems.Add(nick.Fname);
                row.SubItems.Add(nick.phone.phone);
                row.SubItems.Add(nick.Email);
                row.SubItems.Add(nick.Adres);
                row.Tag = nick;
                listView1.Items.Add(row);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            foreach (Nick nick in dB.nicks.Where(s => s.Adres.ToLower().Contains(textBox6.Text.ToLower())))
            {
                ListViewItem row = new ListViewItem(nick.categoriy.Name);
                row.SubItems.Add(nick.Fname);
                row.SubItems.Add(nick.phone.phone);
                row.SubItems.Add(nick.Email);
                row.SubItems.Add(nick.Adres);
                row.Tag = nick;
                listView1.Items.Add(row);
            }
        }
    }
}
