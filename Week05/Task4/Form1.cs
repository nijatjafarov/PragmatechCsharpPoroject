using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrWhiteSpace(input.Text) || String.IsNullOrEmpty(input.Text)))
            {
                string value = input.Text.Trim();
                inputList.Items.Insert(0, value[0].ToString().ToUpper() + value.Substring(1));
            }
            input.Text = "";
            input.Focus();
        }

        private void countBtn_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < inputList.Items.Count; i++)
            {
                if (inputList.Items[i].ToString() == inputList.SelectedItem.ToString())
                {
                    ++count;
                }
            }
            MessageBox.Show(count.ToString());
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            bool contains = false;
            for (int i = 0; i < inputList.Items.Count; i++)
            {
                string value = search.Text.Trim();
                if (inputList.Items[i].ToString() == value[0].ToString().ToUpper() + value.Substring(1))
                {
                    contains = true;
                    break;
                }
            }

            if (contains)
            {
                MessageBox.Show("List contains this item");
            }
            else
            {
                MessageBox.Show("List doesn't contain this item");
            }
        }
    }
}
