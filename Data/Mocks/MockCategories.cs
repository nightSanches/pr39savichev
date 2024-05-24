using pr37savichev.Data.Interfaces;
using pr37savichev.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pr37savichev.Data.Mocks
{
    public class MockCategories : ICategories
    {

        public IEnumerable<Categories> AllCategories
        {
            get
            {
                return new List<Categories>
                {
                    new Categories()
                    {
                        Id=0,
                        Name = "Микроволновые печи",
                        Description = "Микроволновая печь - электроприбор"
                    },
                    new Categories()
                    {
                        Id = 1,
                        Name = "Мультиварки",
                        Description = "Мультиварка - многофункциональный бытовой предмет"
                    }
                };
            }
        }
    }
}
