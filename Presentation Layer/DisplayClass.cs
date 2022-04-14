using Business_Logic_Layer;
using System;
using System.Collections.Generic;

namespace Presentation_Layer
{

    public class DisplayClass
    {
        public void Main(string arr)
        {
            BLL_Layer customer3 = new BLL_Layer();
            var list = new List<string>();
            list = customer3.GetCustomer_BLL();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
