using System;
using System.Collections.Generic;
using System.Text;

namespace FHUBound.Models
{
    public class StoreItem
    {
        public  string Name { get; set; }

        public int Price { get; set; }

        public string ImageURL { get; set;}

        public string Description { get; set; }

        public StoreItem()
        {

        }
    }
}
