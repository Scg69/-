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
    public partial class Form1 : Form
    {
        DB dB = new DB();
        Nick nick = new Nick();
        User user;
        
        public Form1(User user)
        {
            InitializeComponent();
            this.user = user;
            label1.Text = user.Name;
            Categoriy mob = new Categoriy { Name = "Мобильный" };
            Categoriy dom = new Categoriy { Name = "Домашний" };
            dB.categoriys.Add(mob);
            dB.categoriys.Add(dom);
            Group family = new Group { Name = "Семья" };
            Group Friends = new Group { Name = "Друзья" };
            Group Colleg = new Group { Name = "Коллеги" };
            dB.groups.Add(family);
            dB.groups.Add(Friends);
            dB.groups.Add(Colleg);
            timer1.Start();
        }

        private void добавитьНомерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2(dB).Show();
        }

        void show(List<Nick> Nicks)
        {
            listView1.Items.Clear();
            foreach (Nick nick in Nicks)
            {

                ListViewItem row = new ListViewItem(nick.Name +" "+ nick.Fname +" "+ nick.Oname);
                row.SubItems.Add(nick.phone.phone.ToString());
                row.Tag = nick;
                listView1.Items.Add(row);
            }
        }
        void show()
        {
            listView1.Items.Clear();
            foreach (Nick nick in dB.nicks)
            {

                ListViewItem row = new ListViewItem(nick.Name + " " + nick.Fname + " "+ nick.Oname);
                row.SubItems.Add(nick.phone.phone.ToString());
                row.Tag = nick;
                listView1.Items.Add(row);
            }
        }

        private void подробнееToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            Nick nick = (Nick)listView1.SelectedItems[0].Tag;
            new Form6(nick).Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count != 0)
                return;
            if(checkBox1.Checked & checkBox2.Checked & checkBox3.Checked)
            {
                show(dB.nicks.FindAll(s => s.group.Name == "Семья" || s.group.Name == "Друзья" || s.group.Name == "Коллеги"));
                return;
            }
            if (checkBox1.Checked & checkBox2.Checked )
            {
                show(dB.nicks.FindAll(s => s.group.Name == "Семья" || s.group.Name == "Друзья" ));
                return;
            }
            if (checkBox1.Checked  & checkBox3.Checked)
            {
                show(dB.nicks.FindAll(s => s.group.Name == "Семья"  || s.group.Name == "Коллеги"));
                return;

            }
            if (checkBox2.Checked & checkBox3.Checked)
            {
                show(dB.nicks.FindAll(s => s.group.Name == "Друзья" || s.group.Name == "Коллеги"));
                return;
            }
            if (checkBox1.Checked)
            {
                show(dB.nicks.FindAll(s => s.group.Name == "Семья"));
                return;

            }
            if (checkBox2.Checked)
            {
                show(dB.nicks.FindAll(s => s.group.Name == "Друзья"));
                return;
            }
            if (checkBox3.Checked)
            {
                show(dB.nicks.FindAll(s => s.group.Name == "Коллеги"));
                return;
            }

            show();
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3(dB).Show();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            Nick nick = (Nick)listView1.SelectedItems[0].Tag;
            Form7 form7 = new Form7(nick,dB);
            form7.ShowDialog();
            dB.Save();
            
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            Nick nick = (Nick)listView1.SelectedItems[0].Tag;   
            dB.nicks.Remove(nick);
            dB.Save();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
