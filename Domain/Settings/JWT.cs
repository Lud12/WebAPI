﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Settings
{
    public class JWT
    {
        public string Key { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public string DurationInMinutes { get; set; }

    }
}
