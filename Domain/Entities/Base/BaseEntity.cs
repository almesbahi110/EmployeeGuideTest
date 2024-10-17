using Domain.Enums;

namespace Domain.Entities.Base
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now; 
        public State State { get; set; }= State.New;
    }
}