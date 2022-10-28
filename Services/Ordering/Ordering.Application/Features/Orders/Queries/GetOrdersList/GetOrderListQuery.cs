﻿using MediatR;
using Ordering.Application.Contracts.Persistence;

namespace Ordering.Application.Features.Orders.Queries.GetOrdersList
{
    public class GetOrderListQuery : IRequest<List<OrdersVm>>
    {
        public GetOrderListQuery(string userName)
        {
            UserName = userName ?? throw new ArgumentNullException(nameof(userName));
        }

        public string UserName { get; set; } = null!;

    }
}
