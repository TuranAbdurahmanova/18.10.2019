﻿using FinalProject.Areas.PayrollAdmin.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Areas.PayrollAdmin.ViewModel
{
    public class ShopBonusViewModel
    {
        public ShopBonus ShopBonus { get; set; }
        public SelectList Shops { get; set; }
        public int ShopId { get; set; }
    }
}
