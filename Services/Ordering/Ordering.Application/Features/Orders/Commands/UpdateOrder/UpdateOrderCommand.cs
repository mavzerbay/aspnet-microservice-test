﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Features.Orders.Commands.UpdateOrder
{
    public class UpdateOrderCommand : IRequest
    {
        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public decimal TotalPrice { get; set; }

        // BillingAddress
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;
        public string AddressLine { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string State { get; set; } = null!;
        public string? ZipCode { get; set; }

        // Payment
        public string CardName { get; set; } = null!;
        public string CardNumber { get; set; } = null!;
        public string Expiration { get; set; } = null!;
        public string CVV { get; set; } = null!;
        public int PaymentMethod { get; set; }
    }
}