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
                    new Category { categoryName = "Modern design", desc = "modern type of design" }
                    new Category { categoryName = "Classic design", desc = "classic type of design" }
                };
            }
        }
    }
}
