using System.Collections.Generic;

namespace DataLibrary
{
    public class MenuItem: BaseModelClass
    {
        public int Weight{ get; set; }
        public string Name { get; set; }
        public IEnumerable<string> Ingredients { get; set; }
    }
}
