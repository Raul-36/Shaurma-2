using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShaurmaN0.Models;

    public class Order
    {
        public int Id { get; set; }        
        public int MenuItemId { get; set; }        
        public MenuItem? MenuItem { get; set; }        
    }