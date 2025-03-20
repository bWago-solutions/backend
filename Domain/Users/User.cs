using SharedKernel;

namespace Domain.Users;

public class User : Entity
{
    private User(Guid id, string email, string name) : base(id)
    {
        Email = email;
        Name = name;
    }
    
    private User(){}
    
    public string Email { get; private set; }
    public string Name { get; private set; }

    public static User Create(string email, string name)
    {
        return new User(Guid.NewGuid(), email, name);
    }

}