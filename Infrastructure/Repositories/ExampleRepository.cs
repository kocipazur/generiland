using Domain.Entities.Character;
using Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    class ExampleRepository : IExampleRepository
    {
        public async Task<ExampleEntity> Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
