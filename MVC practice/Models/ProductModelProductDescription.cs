﻿using System;
using System.Collections.Generic;

namespace MVC_practice.Models;

public partial class ProductModelProductDescription
{
    public int ProductModelId { get; set; }

    public int ProductDescriptionId { get; set; }

    public string Culture { get; set; } = null!;

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    public virtual ProductDescription ProductDescription { get; set; } = null!;

    public virtual ProductModel ProductModel { get; set; } = null!;
}
