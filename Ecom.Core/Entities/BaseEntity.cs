﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Core.Entities;

public class BaseEntity <TId>
{
    public TId Id { get; set; } = default!;
}
