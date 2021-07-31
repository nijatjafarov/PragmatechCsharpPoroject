using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Pizza
    {
        private decimal size;
        private string name;
        private int price;
        private string edge;
        private int edgeCost;
        private List<string> ingridients = new List<string>();
        private int quantity;

        public decimal Size { get => size; set => size = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public string Edge { get => edge; set => edge = value; }
        public int EdgeCost { get => edgeCost; set => edgeCost = value; }
        public List<string> Ingridients { get => ingridients; }
        public int Quantity { get => quantity; set => quantity = value; }

        public void AddIngridient(string ingridient)
        {
            ingridients.Add(ingridient);
        }

        public decimal GetAmount()
        {
            return size * price * quantity + EdgeCost;
        }
    }
}
