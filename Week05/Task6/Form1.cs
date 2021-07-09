using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rengBtn_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void markaQutusu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = markaQutusu.SelectedItem.ToString();

            string[] masin1 = {"Model1(Masin1)", "Model2(Masin1)", "Model3(Masin1)"};
            string[] masin2 = { "Model1(Masin2)", "Model2(Masin2)", "Model3(Masin2)" };
            string[] masin3 = { "Model1(Masin3)", "Model2(Masin3)", "Model3(Masin3)" };

            switch (item)
            {
                case "Masin1":
                    modelQutusu.Items.Clear();
                    modelQutusu.Items.AddRange(masin1);
                    break;
                case "Masin2":
                    modelQutusu.Items.Clear();
                    modelQutusu.Items.AddRange(masin2);
                    break;
                case "Masin3":
                    modelQutusu.Items.Clear();
                    modelQutusu.Items.AddRange(masin3);
                    break;
                default:
                    break;
            }
        }

        private void elaveEt_Click(object sender, EventArgs e)
        {
            string marka = markaQutusu.Text;
            string model = modelQutusu.Text;
            string yanacaq = yanacaqQutusu.Text;
            string ban = banQutusu.Text;
            string suret = suretQutusu.Text;
            string il = ilSecimi.Text;
            string reng = colorDialog1.Color.ToString();

            ListViewItem list = new ListViewItem();

            list.Text = marka;
            list.SubItems.Add(model);
            list.SubItems.Add(yanacaq);
            list.SubItems.Add(ban);
            list.SubItems.Add(suret);
            list.SubItems.Add(il);
            list.SubItems.Add(reng);

            listView1.Items.Add(list);
        }
    }
}
