using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CornerMart.Modles
{
    internal class Users
    {
        public string Name { get; private set; }
        private string Password;
        public List<Orders> orders;
        public Users(string name, string password)
        {
            Name = name;
            Password = password;
            orders = new List<Orders>();
        }
        public bool Password_check(string password)
        {
            if (password == this.Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AddOrders(Orders order)
        {
            orders.Add(order);
        }
    }
}
