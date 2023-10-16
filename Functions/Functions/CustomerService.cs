namespace Functions
{
    public class Customer
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public Address Address { get; set; }

        public bool IsAuthorized { get; set; }

        public double Rating { get; set; }
    }


    public class Address
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }

    public class CustomerService
    {
        public void AddCustomer(string name, string lastName, string streetAddress, string city, string country, double rating)
        {

        }

        public void AddCustomer(Customer customer) { }

        public void ChangeCustomerAddress(int customerId, Address newAddress) { }

        public List<Customer> GetAuthorizedCustomers()
        {
            var customers = getCustomers();
            var authorizedCustomers = new List<Customer>();
            customers.ForEach(customer => addCustomerIfisAuthorized(authorizedCustomers, customer));
            return authorizedCustomers;
        }

        private void addCustomerIfisAuthorized(List<Customer> authorizedCustomers, Customer customer)
        {
            if (customer.IsAuthorized)
            {
                authorizedCustomers.Add(customer);
            }
        }

        private List<Customer> getCustomers()
        {
            throw new NotImplementedException();
        }
    }


}
