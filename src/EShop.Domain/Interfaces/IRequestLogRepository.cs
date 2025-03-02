﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Domain.Filters;
using EShop.Domain.Models;

namespace EShop.Domain.Interfaces
{
    public interface IRequestLogRepository : IBaseRepository<RequestLog, RequestLogFilter>
    {
    }
}
