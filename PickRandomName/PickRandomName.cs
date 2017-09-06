using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickRandomName
{
    public partial class PickRandomName : Form
    {
        public static String previousname;
        public PickRandomName()
        {
            InitializeComponent();
        }

        private void PickRandomName_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                String temp = listBox1.SelectedItem.ToString();
                listBox1.Items.Remove(temp);
            }
        }

        private void pick_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            int size = listBox1.Items.Count;
            textBox2.Text = listBox1.Items[ran.Next(0, size)].ToString();
        }
    }
}
