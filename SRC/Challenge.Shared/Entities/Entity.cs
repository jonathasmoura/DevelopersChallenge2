using System;
using Flunt.Notifications;

namespace Challenge.Shared.Entities
{
    public class Entity : Notifiable
    {
        public Entity()
        {
            Id = new int();
        }
        public int Id { get; private set; }
    }
}
