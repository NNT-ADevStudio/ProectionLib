using System.Collections.Generic;

namespace ProectionLib.Models
{
    public class ListModel<T>
    {
        public int Page { get; set; }

        public int Count { get; set; }

        public int TotalPages { get; set; }

        public int TotalItems { get; set; }

        public IEnumerable<T> Items { get; set; }
    }
}
