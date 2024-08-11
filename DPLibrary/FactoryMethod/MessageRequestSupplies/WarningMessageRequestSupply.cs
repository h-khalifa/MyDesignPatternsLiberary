﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.MessageRequestSupplies
{
    public class WarningMessageRequestSupply : MessageRequestSupply
    {
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string LCode { get; set; }
    }
}
