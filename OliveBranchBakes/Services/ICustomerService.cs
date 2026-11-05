using OliveBranchBakes.Models;

namespace OliveBranchBakes.Services
{
    public interface ICustomerService
    {
        Customer Register(string firstName, string lastName, string email, string phone, string password);
        Customer Login(string email, string password);
        Customer FindByEmail(string email);
    }
}
