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
    public partial class Form6 : Form
    {
        Nick nick;
        public Form6(Nick nick)
        {
            InitializeComponent();
            this.nick = nick;
            timer1.Start();
        }
        void show()
        {
            listView1.Items.Clear();
        
            ListViewItem row = new ListViewItem(nick.categoriy.Name);
            row.SubItems.Add(nick.Adres);
            row.SubItems.Add(nick.Email);
            row.SubItems.Add(nick.Notes);
            row.Tag = nick;
            listView1.Items.Add(row);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
                return;
            show();
        }
    }
}
