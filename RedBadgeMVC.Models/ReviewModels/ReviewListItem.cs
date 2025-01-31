﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadgeMVC.Models.ReviewModels
{
    public class ReviewListItem
    {
        [Key]
        public int ReviewId { get; set; }

        [Display(Name = "Review")]
       public string Reviews { get; set; }


        [Display(Name = "Product Name")]
        public string ItemName { get; set; }

        [Display(Name = "Product Image")]
        public string ItemImage { get; set; }
    }
}
