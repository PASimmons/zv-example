using VemiMicroservice.Application.Models;
using MediatR;

namespace VemiMicroservice.Application.Commands.Readiness
{
    public class PerformReadinessCheckCommand : IRequest<CommandResult<string>>
    {
    }
}
