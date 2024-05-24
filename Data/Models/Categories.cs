using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pr37savichev.Data.Models
{
    public class Categories
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public List<Items> Items { get; set; }
    }
}
