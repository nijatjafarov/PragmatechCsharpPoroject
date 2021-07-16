using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void deliveryBtn_Click(object sender, EventArgs e)
        {
            Order order = new Order();

            if (categoryBox.Text != "" && productBox.Text != "" && deliveryBox.Text != "" && massValue.Value != 0 && costValue.Value != 0)
            {
                order.Category = categoryBox.Text;
                order.Product = productBox.Text;
                order.DeliveryOption = deliveryBox.Text;
                order.DeliveryDate = deliveryDate.Text;
                order.Mass = Convert.ToInt32(massValue.Value);
                order.Cost = Convert.ToInt32(costValue.Value);

                categoryBox.SelectedIndex = -1;
                productBox.SelectedIndex = -1;
                deliveryBox.SelectedIndex = -1;
                massValue.Value = 0;
                costValue.Value = 0;

                ListViewItem list = new ListViewItem();

                productList.Items.Add(list);

                list.Text = order.Category;
                list.SubItems.Add(order.Product);
                list.SubItems.Add(order.DeliveryOption);
                list.SubItems.Add(order.Mass.ToString());
                list.SubItems.Add(order.Cost.ToString());
                list.SubItems.Add(order.DeliveryDate);
            }
            else
            {
                MessageBox.Show("You have passed some fields");
            }
        }

        private void categoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] category1 = { "Product1(Category1)", "Product2(Category1)", "Product3(Category1)" };
            string[] category2 = { "Product1(Category2)", "Product2(Category2)", "Product3(Category2)" };
            string[] category3 = { "Product1(Category3)", "Product2(Category3)", "Product3(Category3)" };

            switch (categoryBox.Text)
            {
                case "Category1":
                    productBox.Items.Clear();
                    productBox.Items.AddRange(category1);
                    break;
                case "Category2":
                    productBox.Items.Clear();
                    productBox.Items.AddRange(category2);
                    break;
                case "Category3":
                    productBox.Items.Clear();
                    productBox.Items.AddRange(category3);
                    break;
                default:
                    break;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            for (int i = productList.SelectedItems.Count-1; i >= 0; i--)
            {
                productList.Items.Remove(productList.SelectedItems[i]);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            bool contains = false;

            for (int i = 0; i < productList.Items.Count; i++)
            {
                if (productList.Items[i].SubItems[1].Text.ToLower() == txtSearch.Text.ToLower())
                {
                    contains = true;
                    break;
                }
            }

            if (contains)
            {
                MessageBox.Show("This list contains such an item");
            }
            else
            {
                MessageBox.Show("This list doesn't contain such an item");
            }
        }
    }
}
