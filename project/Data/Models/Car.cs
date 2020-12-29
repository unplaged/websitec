﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.Data.Models
{
    public class Car
    {
        public int id { set; get; }

        public string name { set; get; }

        public string shortDesc { set; get; }

        public string longDesc { set; get; }

        public string img { set; get; }

        public bool isFavourite { set; get; }

        public bool available { set; get; }

        public int categoryId { set; get; }

        public virtual Category Category { set; get; }

    }
}
