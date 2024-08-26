using System;
using System.Collections.Generic;

namespace Orders.Models;

public partial class Order
{
    public int OrdersId { get; set; }

    public DateOnly? OrderDate { get; set; }

    public int? OrderStatus { get; set; }

    public int? StaffId { get; set; }
}
