using System;
using OO.ContentContext;

namespace OO.SubscriptionContext 
{
    public class Subscription : Base 
    {
        public Plan Plan { get; set; }

        public DateTime? EndDate { get; set; }

        public bool IsInactive => EndDate <= DateTime.Now;
    }
}