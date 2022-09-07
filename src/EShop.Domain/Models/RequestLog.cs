﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Models
{
    public class RequestLog : BaseModel
    {
        public string? Path { get; set; }

        public string? IpAddress { get; set; }

        public string? AccessToken { get; set; }

        public string? ContentType { get; set; }


    }
}
