using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.DataAccessLayer
{
    public class Program
    {

        void test()
        {
            var db = new CustomerDataAccesor();
            var res = db.GetCustomer(1);
            if (res != null)
                Console.WriteLine($"With Id - {res.CustomerId} --- {res.Name }" +
                    $" --- {res.Mail} --- {res.Mobile} --- { res.Transactions?.FirstOrDefault().TransactionDate  }" +
            $" --- {res.Transactions?.FirstOrDefault().Status } --- {res.Transactions?.FirstOrDefault().Currency  }");

        }
    }
}
