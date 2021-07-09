using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text.Trim();
            string surname = surnameInput.Text.Trim();
            string phoneNum = numInput.Text;
            string date = dateInput.Text;

            ListViewItem list = new ListViewItem();

            list.Text = name;
            list.SubItems.Add(surname);
            list.SubItems.Add(phoneNum);
            list.SubItems.Add(date);

            inputList.Items.Add(list);

            nameInput.Clear();
            surnameInput.Clear();
            numInput.Clear();
            nameInput.Focus();
        }
    }
}
