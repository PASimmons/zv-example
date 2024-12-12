using VemiMicroservice.Application.Models;
using VemiMicroservice.Domain.Models;
using MediatR;

namespace VemiMicroservice.Application.Queries.Example
{
    public class GetExampleByIdQuery : IRequest<QueryResult<Domain.Models.Example>>
    {
        public int Id { get; set; }
    }
}