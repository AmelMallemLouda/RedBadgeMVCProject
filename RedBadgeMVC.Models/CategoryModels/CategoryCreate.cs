﻿using RedBadgeMVC.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadgeMVC.Models.CategoryModels
{
    public class CategoryCreate
    {
        [Display(Name = "Category Type")]
        public string CategoryName { get; set; }


        [Display(Name = "Category Image")]
        public string CategoryImage { get; set; }
    }
}
