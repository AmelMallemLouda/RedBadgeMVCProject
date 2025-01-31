﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadgeMVC.Models.ReviewModels
{
    public class ReviewDetails
    {
        public int ReviewId { get; set; }
        [Display(Name = "Review")]
        public string Reviews { get; set; }

    
        [Display(Name = "Item Name")]
        public string ItemName { get; set; }
        public string ItemImage { get; set; }
    }
}
