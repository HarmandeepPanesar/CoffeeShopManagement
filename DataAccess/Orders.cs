using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.DataAccess
{
    public class Orders
    {
        public int OrderID { get; set; } // Primary Key  
        public int CustomerID { get; set; } // Foreign Key  
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        // Navigation Property  
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderItems> OrderItems { get; set; } // To hold ordered products 
    }
}
