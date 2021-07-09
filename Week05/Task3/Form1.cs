using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Linq;

namespace Task3
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
                inputList.Items.Insert(0, input.Text.Trim());
            }
            input.Text = "";
            input.Focus();
        }

        private void mixBtn_Click(object sender, EventArgs e)
        {
            ArrayList cloneList = new ArrayList();
            Random random = new Random();

            for (int i = 0; i < inputList.Items.Count; i++)
            {
                object randomInput = inputList.Items[random.Next(inputList.Items.Count)];
                while (cloneList.Contains(randomInput))
                {
                    randomInput = inputList.Items[random.Next(inputList.Items.Count)];
                }
                cloneList.Add(randomInput);
            }

            for (int i = 0; i < inputList.Items.Count; i++)
            {
                inputList.Items[i] = cloneList[i];
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            for (int i = inputList.SelectedItems.Count-1; i >= 0; i--)
            {
                inputList.Items.Remove(inputList.SelectedItems[i]);
            }
        }
    }
}
