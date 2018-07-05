﻿using System;
using System.Collections.Generic;

namespace CoreSampleApp.Business.Data.AdventureWorks2017
{
    public partial class PhoneNumberType
    {
        public PhoneNumberType()
        {
            PersonPhone = new HashSet<PersonPhone>();
        }

        public int PhoneNumberTypeId { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ICollection<PersonPhone> PersonPhone { get; set; }
    }
}
