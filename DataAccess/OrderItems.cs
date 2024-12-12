using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.DataAccess
{
    public class OrderItems
    {
        public int OrderItemID { get; set; } // Primary Key  
        public int OrderID { get; set; } // Foreign Key  
        public int ProductID { get; set; } // Foreign Key  
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }

        // Navigation Properties  
        public virtual Orders Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
