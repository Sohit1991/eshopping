﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Messages.Events
{
    public class BasketCheckOutEventV2 : BaseIntegrationEvent
    {
        public string? UserName { get; set; }
        public decimal? TotalPrice { get; set; }
       

    }
}
