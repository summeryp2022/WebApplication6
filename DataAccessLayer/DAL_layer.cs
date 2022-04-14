using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DAL_layer
    {
        public List<string> GetCustomer_DAL()
        {
            Customer customer1 = new Customer();
            customer1.CustomerID = "10";
            customer1.CustomerName = "Pei";
            customer1.CustomerPhone = "4434702333";
            var list = new List<string>();
            list.Add(customer1.CustomerID);
            list.Add(customer1.CustomerName);
            list.Add(customer1.CustomerPhone);
            return list;
        }
    }

}
