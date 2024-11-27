using SalesTransaction.Models;
using SalesTransaction.UserModels;

namespace SalesTransaction.Repositories;

public interface IRepository
{
    public User login(LoginRequestDTO request);
}
