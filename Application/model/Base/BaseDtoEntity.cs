using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.model.Base
{
    public class BaseDtoEntity
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public State State { get; set; } = State.New;
    }
}
