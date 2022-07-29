using System;
using System.Collections.Generic;

namespace DataLibrary
{
    public class Basket: BaseModelClass
    {
        public List<MenuItem> Order { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
