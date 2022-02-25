using MediatR;
using System;
using System.Collections.Generic;

namespace Ordering.Application.Features.Orders.Queries.GetOrdersList
{
    public class GetOrdersListQuery : IRequest<List<OrdersVm>>
    {
        public GetOrdersListQuery(string username)
        {
            Username = username ?? throw new ArgumentNullException(nameof(username));
        }

        public string Username { get; set; }
    }
}
