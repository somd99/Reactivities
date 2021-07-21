using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Activities
{
    public class Details
    {
        public class Query : IRequest<Activity>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Activity>
        {
            private readonly DataContext _contect;
            public Handler(DataContext contect)
            {
                _contect = contect;
            }

            public async Task<Activity> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _contect.Activities.FindAsync(request.Id);
            }
        }
    }
}