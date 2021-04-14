﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadgeMVC.Data
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }


        [Display(Name = "Category Type")]
        [MaxLength(100, ErrorMessage = "Too long characters")]
        public string CategoryName { get; set; }

        public virtual List<Item> Items { get; set; } = new List<Item>();


    }
}
