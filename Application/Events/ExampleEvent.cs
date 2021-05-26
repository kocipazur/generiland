using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Events
{
    public class ExampleEvent : INotification
    {
        public string Message { get; }
        public ExampleEvent(string message)
        {
            Message = message;
        }
    }
}
