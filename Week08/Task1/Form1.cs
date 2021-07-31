using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public decimal total = 0;
        Pizza pizza = new Pizza();
        private void calculateBtn_Click(object sender, EventArgs e)
        {

            if (pizzaSize.Text != null && listPizzas.SelectedItem != null && pizzaQuantity.Value != 0)
            {
                Dictionary<string, decimal> sizes = new Dictionary<string, decimal>();

                sizes.Add(pizzaSize.Items[0].ToString(), 1);
                sizes.Add(pizzaSize.Items[1].ToString(), 1.25m);
                sizes.Add(pizzaSize.Items[2].ToString(), 1.75m);
                sizes.Add(pizzaSize.Items[3].ToString(), 2);

                Dictionary<string, int> names = new Dictionary<string, int>();

                names.Add(listPizzas.Items[0].ToString(), 9);
                names.Add(listPizzas.Items[1].ToString(), 10);
                names.Add(listPizzas.Items[2].ToString(), 13);
                names.Add(listPizzas.Items[3].ToString(), 11);
                names.Add(listPizzas.Items[4].ToString(), 14);
                names.Add(listPizzas.Items[5].ToString(), 13);

                pizza.Size = sizes[pizzaSize.Text];
                pizza.Name = listPizzas.SelectedItem.ToString();
                pizza.Price = names[listPizzas.SelectedItem.ToString()];

                if (thin.Checked)
                {
                    pizza.Edge = thin.Text;
                    pizza.EdgeCost = 0;
                }
                else if (thick.Checked)
                {
                    pizza.Edge = thick.Text;
                    pizza.EdgeCost = 2;
                }
                foreach (CheckBox item in ingridientsGroup.Controls)
                {
                    if (item.Checked)
                    {
                        pizza.AddIngridient(item.Text);
                    }
                }


            
                pizza.Quantity = (int)pizzaQuantity.Value;
                quantity.Text = pizza.GetAmount().ToString();
            }
            else
            {
                MessageBox.Show("Olcu, ad ve ya say secmemisiniz");
            }
            
            
        }

        private void addToCardBtn_Click(object sender, EventArgs e)
        {
            total += pizza.GetAmount();

            string order = $"{pizzaSize.SelectedItem}, {pizza.Name}, {pizza.Edge}";

            if (pizza.Ingridients != null)
            {
                foreach (string ingridient in pizza.Ingridients)
                {
                    order += $", {ingridient}";
                }
            }

            order += $", {pizza.Quantity}, {pizza.GetAmount()}";

            listShopping.Items.Add(order);

            pizzaSize.SelectedItem = null;

            listPizzas.SelectedItem = null;

            thin.Checked = true;

            foreach (CheckBox item in ingridientsGroup.Controls)
            {
                if (item.Checked)
                {
                    item.Checked = false;
                }
            }

            pizzaQuantity.Value = 0;

            quantity.Text = null;

        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            price.Text = total.ToString();
        }
    }
}
