using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        //public virtual Address Address { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
