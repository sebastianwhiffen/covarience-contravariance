namespace Covariance;

public class SpecialCustomerRepository : IRepository<SpecialCustomer>
{
    public SpecialCustomer GetItem(int id) => new SpecialCustomer { Name = "SpecialCustomer " + id, SpecialInfo = "Info" + id };
}
