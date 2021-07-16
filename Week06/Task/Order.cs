using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Order
    {
        private string category;
        private string product;
        private string deliveryOption;
        private string deliveryDate;
        private int mass;
        private int cost;

        public string Category { get => category; set => category = value; }
        public string Product { get => product; set => product = value; }
        public string DeliveryOption { get => deliveryOption; set => deliveryOption = value; }
        public string DeliveryDate { get => deliveryDate; set => deliveryDate = value; }
        public int Mass { get => mass; set => mass = value; }
        public int Cost { get => cost; set => cost = value; }
    }
}
