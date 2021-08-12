using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Order : IEntity
    {
        public Order()
        {
            
        }
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        //public virtual Address Address { get; set; }
        //public virtual Product Product { get; set; }

        public virtual Customer Customer { get; set; }

      
    }
}
