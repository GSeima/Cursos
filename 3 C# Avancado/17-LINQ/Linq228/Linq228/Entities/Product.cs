﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Linq228.Entities
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return "Id: " 
                + Id
                + ", Name: "
                + Name
                + ", Price: $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Category: "
                + Category.Name
                + ", Tier: "
                + Category.Tier;
        }
    }
}
