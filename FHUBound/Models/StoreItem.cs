using System;
using System.Collections.Generic;
using System.Text;

namespace FHUBound.Models
{
    public class StoreItem
    {
        public string ItemName { get; set; } = "";
        public string ImageUrl { get; set; } = "";
        public int Price { get; set; }

        public StoreItem()
        {

        }
    }
}
