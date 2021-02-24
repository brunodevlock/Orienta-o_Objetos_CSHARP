using System;
using OO.NotificationContext;

namespace OO.ContentContext
{
    public abstract class Base : Notifiable
    {

        public Base()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}