using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entities
{
    public class Product: BaseEntity
    {

        public string ProductName { get; set; }
        public decimal Price { get; set; }

    }
}
