using Domain.Entities.Character.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Character
{
    public class ExampleEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ExampleEnum ExampleEnumValue { get; set; }
        public bool Active { get; set; }
        public string AddedColumn { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
