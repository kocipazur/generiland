using Application.Events;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Controllers.Actors
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CharacterController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task MyAction(CancellationToken cancellationToken)
        {
            await _mediator.Publish(new ExampleEvent("Dante"), cancellationToken);
        }
    }
}
