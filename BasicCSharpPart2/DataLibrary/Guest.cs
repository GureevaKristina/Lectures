using System.Collections.Generic;

namespace DataLibrary
{
    public class Guest: BaseModelClass
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public List<Basket> HistoryOrders{ get; set; }
    }
}
