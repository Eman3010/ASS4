﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.DAL.Models
{
    public class ModelBase
    {
        public int Id { get; set; } 
        public int createdby { get; set; }
        public DateTime createdon { get; set; }
        public int LastModifiedBy { get; set; }
        public int LastModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
