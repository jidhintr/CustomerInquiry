namespace Customer.DataAccessLayer
{
    public interface ICustomerDbAccess
    {
        Customer GetCustomer(int customerId);
        Customer GetCustomer(string mailId);
        Customer GetCustomer(int customerId, string mailId);


    }
}
