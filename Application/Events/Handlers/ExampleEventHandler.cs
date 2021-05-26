using Application.Events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Events.Handlers
{
    public class ExampleEventHandler : INotificationHandler<ExampleEvent>
    {
        public Task Handle(ExampleEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
