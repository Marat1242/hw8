﻿using System;
using System.Collections.Generic;

namespace Business.Data;

public partial class Attribute
{
    public int AttributeId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<AttributesPrice> AttributesPrices { get; } = new List<AttributesPrice>();
}
