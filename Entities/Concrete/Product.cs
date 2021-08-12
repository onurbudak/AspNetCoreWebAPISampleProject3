using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public Product()
        {

        }
        public Guid Id { get; set; }
        public int ImageUrl { get; set; }
        public int Name { get; set; }
    }
}
