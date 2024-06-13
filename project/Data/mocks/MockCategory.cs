using project.Data.Interfaces;
using project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Modern", desc = "modern" },
                    new Category { categoryName = "Classic", desc = "classic" }
                };
            }
        }
    }
}
