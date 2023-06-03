using System;
using System.Collections.Generic;

namespace Business.Data;
public partial class TransactStatus
{
    public int TransactStatusId { get; set; }

    public string? Status { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
