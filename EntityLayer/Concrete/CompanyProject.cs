﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CompanyProject
    {
        [Key]
        public int CompanyProjectID { get; set; }
        public int CompanyID { get; set; }
        public Company? Company { get; set; }
        public int ProjectID { get; set; }
        public Project? Project { get; set; }
    }
}
