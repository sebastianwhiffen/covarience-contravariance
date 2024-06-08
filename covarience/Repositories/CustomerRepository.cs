public class CustomerRepository : IRepository<Customer>
{
    public Customer GetItem(int id) => new Customer { Name = "Customer" + id };
}
