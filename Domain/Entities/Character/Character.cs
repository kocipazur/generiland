using Application.Character.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Entities.Character
{
    public class Character
    {
        public string Name { get; private set; }
        public State State { get; set; }

        public Character(string name)
        {
            Name = name;
            State = new State { StateType = StateTypeEnum.Idle };
        }
    }
}
