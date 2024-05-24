using pr37savichev.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pr37savichev.Data.Interfaces
{
    public interface IItems
    {
        public IEnumerable<Items> AllItems { get; }
    }
}
