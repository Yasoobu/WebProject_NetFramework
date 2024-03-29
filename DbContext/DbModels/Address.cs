﻿using System.ComponentModel.DataAnnotations.Schema;

namespace WebProject_NetFramework.DbContext.DbModels
{

    public class Address : BaseDbModels.BaseDbClass
    {
        [Column("Address")] public string Address1 { get; set; }

        public string StateOfRegion { get; set; }

        public string ZipCode { get; set; }

        public string Email { get; set; }

        public string City { get; set; }

        public string MobilePhone { get; set; }
    }
}