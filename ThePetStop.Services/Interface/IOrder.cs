﻿using System;
using System.Collections.Generic;
using System.Text;
using ThePetStop.Domain.DomainModels;

namespace ThePetStop.Services.Interface
{
    public interface IOrderService
    {
        public List<Order> getAllOrders();
        public Order getOrderDetails(BaseEntity model);
    }
}
