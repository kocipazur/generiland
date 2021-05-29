﻿using Domain.Entities.Character;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Interfaces
{
    public interface IExampleRepository
    {
        public Task<ExampleEntity> Get(int id);
    }
}
