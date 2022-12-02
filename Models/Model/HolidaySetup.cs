﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Models.Model
{
    public class HolidaySetup
    {
        [Key]
        public int HolidaySetupID { get; set; }
        public int FacilityID { get; set; }
        public string Description { get; set; }
        public string HolidayYear { get; set; }
        public string SetupStartMonth { get; set; }
        public string SetupEndMonth { get; set; }
        public bool Deleted { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}