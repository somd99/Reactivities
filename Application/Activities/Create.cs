using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Activities
{
    public class Create
    {
        public class Command : IRequest
        {
            public Activity Activity { get; set; } //want to receive as a parameter from an API
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.Activities.Add(request.Activity); //not accessing database at this point so won't use AddAsync for now

                await _context.SaveChangesAsync();

                return Unit.Value; //equivalent tor returning nothing, just to let an API know we finished
            }
        }
    }
}