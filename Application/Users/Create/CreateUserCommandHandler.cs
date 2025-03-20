using Application.Abstractions.Messaging;
using Domain.Users;
using SharedKernel;

namespace Application.Users.Create;

public class CreateUserCommandHandler : ICommandHandler<CreateUserCommand, Guid>
{
    private readonly IUserRepository _userRepository;

    public CreateUserCommandHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<Result<Guid>> Handle(CreateUserCommand command, CancellationToken cancellationToken)
    {
        var user = User.Create(command.Email, command.Name);
        _userRepository.Insert(user);
        return user.Id;
    }
}