﻿using RedBadgeMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadgeMVC.Models.Home
{
    public class Item
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
