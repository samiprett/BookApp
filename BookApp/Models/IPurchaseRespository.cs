﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Models
{
    public class IPurchaseRespository
    {
        IQueryable<Pay> Pay { get; }

        public void SavePayment(Pay payment)
        {

        }
    }
}
