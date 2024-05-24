using pr37savichev.Data.Models;
using System.Collections.Generic;

namespace pr37savichev.Data.ViewModell
{
    public class VMItems
    {
        public IEnumerable<Items> Items { get; set; }
        public IEnumerable<Categories> Categories { get; set; }

        public int SelectCategory = 0;
    }
}
