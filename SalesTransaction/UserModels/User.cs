namespace SalesTransaction.Models;

public class User
{

    public int Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public long EmployeeId { get; set; }
    public string Password { get; set; }
    public string UserRole { get; set; }
}