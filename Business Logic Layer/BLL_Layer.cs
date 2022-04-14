using DataAccessLayer;
using System.Collections.Generic;
namespace Business_Logic_Layer
{
    public class BLL_Layer
    {
        DAL_layer customer2 = new DAL_layer();
        public List<string> GetCustomer_BLL()
        {
            var list = new List<string>();
            list= customer2.GetCustomer_DAL();
            return list;
        }
    }
   
}
