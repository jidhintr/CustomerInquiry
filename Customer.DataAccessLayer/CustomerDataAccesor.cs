using System;
using System.Linq;

namespace Customer.DataAccessLayer
{
    public class CustomerDataAccesor : ICustomerDbAccess
    {
        public Customer GetCustomer(int customerId)
        {
            try
            {
                var result = new Customer();
                using (var context = new CustomerInquiryEntities())
                {
                    result = context.Customers.Include(nameof(context.Transactions)).
                        Where(a => a.CustomerId == customerId).FirstOrDefault();
                }
                return result;
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public Customer GetCustomer(string mailId)
        {
            try
            {
                using (var context = new CustomerInquiryEntities())
                {
                    return context.Customers.Include(nameof(context.Transactions)).Where
                        (cust => cust.Mail.Equals(mailId, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
                }
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public Customer GetCustomer(int customerId, string mailId)
        {
            try
            {
                using (var context = new CustomerInquiryEntities())
                {
                    return context.Customers.Include(nameof(context.Transactions)).Where
                        (cust => cust.Mail.Equals(mailId, StringComparison.OrdinalIgnoreCase)
                        && cust.CustomerId == customerId).FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                // Log exception
                throw;
            }
        }
    }
}
