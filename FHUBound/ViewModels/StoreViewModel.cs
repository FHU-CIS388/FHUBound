using System;
using System.Collections.Generic;
using System.Text;
using FHUBound.Models;
namespace FHUBound.ViewModels
{
    class StoreViewModel: BaseViewModel
    {
      public static StoreItem TShirt { get; set; }
      
      public string Name { get; set; }
      public string ImageURL { get; set; }
      public int Price { get; set; }
      public string Description { get; set; }
        public StoreViewModel()
        {
            TShirt = new StoreItem()
            {
                Name = "Freed Hardeman T-Shirt!",
                ImageURL = "freedtshirt.jpg",
                Price = 50,
                Description = "It's a Freed T-Shirt"
            };
            Name = "Freed Hardeman T-Shirt!";
                                      
        }
      
        }
       
        }
    

