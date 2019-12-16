﻿using FinalProject.Areas.PayrollAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Areas.PayrollAdmin.ViewModel
{
    public class CompanyPaginationViewModel
    {
        public IEnumerable<Company> Companies { get; set; }

        public PaginationModel PaginationModel { get; set; }

        public Company Company { get;set; }
    }
}
