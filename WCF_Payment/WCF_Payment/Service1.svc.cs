using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF_Payment
{
    public class Service1 : IService1
    {
        static List<Customers> Customers = new List<Customers>();

        public List<Customers> deleteCustomer(string id, string name, string city)
        {
            throw new NotImplementedException();
        }

        public List<Customers> getCustomers()
        {
            Customers c = new Customers();
            c.id = 1;
            c.name = "customer1";
            c.city = "city1";
            Customers.Add(c);

            Customers c2 = new Customers();
            c2.id = 2;
            c2.name = "customer2";
            c2.city = "city2";
            Customers.Add(c2);
            return Customers;
        }
        
        public List<Customers> postCustomer(string id, string name, string city)
        {
            Customers customer = new Customers();
            customer.id = int.Parse(id);
            customer.name = name;
            customer.city = city;
            Customers.Add(customer);

            return Customers;
        }
    }
}
