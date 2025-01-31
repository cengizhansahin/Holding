﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CompanyDepartment
    {
        [Key]
        public int CompanyDepartmentID { get; set; }
        public int CompanyID { get; set; }
        public Company? Company { get; set; }
        public int DepartmentID { get; set; }
        public Department? Department { get; set; }

    }
}
