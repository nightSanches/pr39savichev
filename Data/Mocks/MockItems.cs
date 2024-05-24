using pr37savichev.Data.Interfaces;
using pr37savichev.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pr37savichev.Data.Mocks
{
    public class MockItems : IItems
    {
        public ICategories _category = new MockCategories();

        public IEnumerable<Items> AllItems
        {
            get
            {
                return new List<Items>()
                {
                    new Items()
                    {
                        Id = 0,
                        Name = "DEXP MS-70",
                        Description = "Описание описание бла-бла-бла-бла-бла-бла-бла-бла",
                        Img = "https://c.dns-shop.ru/thumb/st1/fit/500/500/59a87f71c12f41fa3c6ad251a93b7811/b1a761fddbd2197e22bdcf5ee0cd1cfd773ce824ab6ef6eba7411b9a626c50a7.jpg.webp",
                        Price = 3699,
                        Category = _category.AllCategories.Where(x=>x.Id == 0).First()
                    },
                    new Items()
                    {
                        Id = 1,
                        Name = "MP-153",
                        Description = "Описание2 описание2 уэээээээээээээээээ бла-бла-бла-бла-бла-бла-бла-бла",
                        Img = "https://c.dns-shop.ru/thumb/st1/fit/500/500/59a87f71c12f41fa3c6ad251a93b7811/b1a761fddbd2197e22bdcf5ee0cd1cfd773ce824ab6ef6eba7411b9a626c50a7.jpg.webp",
                        Price = 17555,
                        Category = _category.AllCategories.Where(x=>x.Id == 1).First()
                    }
                };
            }
        }
    }
}
