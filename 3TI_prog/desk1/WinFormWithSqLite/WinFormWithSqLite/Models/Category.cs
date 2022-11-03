﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace WinFormWithSqLite.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string? Name { get; set; }

        public virtual List<Product> Products { get; set; }

        //public virtual ObservableCollectionListSource<Product> Products { get; set; }

    }
}
