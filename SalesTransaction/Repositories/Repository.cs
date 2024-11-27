using SalesTransaction.Models;
using SalesTransaction.UserModels;
using SalesTransaction.DBContext;

namespace SalesTransaction.Repositories;

public class Repository : IRepository
{
    private readonly ApplicationDbContext _db;

    public Repository(ApplicationDbContext db){
        _db = db;
    }
    public User login(LoginRequestDTO request)
    {
        var user = _db.users.Find(x)
    }
}
