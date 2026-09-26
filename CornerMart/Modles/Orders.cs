using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CornerMart.Modles
{
    internal class Orders
    {
        public List<Products> products { get; private set; }
        public string ID { get; private set; }
        public string Status { get; private set; }
        private static Random random = new Random();
        public Orders()
        {
            products = new List<Products>();
            ID = random.Next(1, 100000).ToString("D6");
            Status = "Pendding...";
        }
        public Orders(string id, string status)
        {
            products = new List<Products>();
            ID = id;
            Status = status;
        }
        internal void set_product(string name, string size)
        {
            products.Add(new Products(name, size));
        }
        internal void delete_Order()
        {
            Status = "Canceled";
        }
        public override string ToString()
        {
            return $"||{this.ID}||{this.Status}||";
        }
        public string get_order_information()
        {
            string info = "";
            info += $"訂單編號：{ID}\n";
            info += $"訂單編號：{Status}\n";
            foreach (Products item in products)
            {
                info += $"{item.Name}：{item.Size}\n";
            }
            return info;
        }
        public void initialize_order()
        {
            products.Clear();
            Status = "Pendding...";
        }
    }
}
