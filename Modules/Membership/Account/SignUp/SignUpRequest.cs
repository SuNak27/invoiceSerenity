﻿using Serenity.Services;
using System;

namespace InvoiceKu.Membership
{
    public class SignUpRequest : ServiceRequest
    {
        public String CompanyName { get; set; }
        public String DisplayName { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
    }
}