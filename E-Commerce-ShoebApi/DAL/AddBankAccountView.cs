﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce_ShoebApi.DAL
{
    public class AddBankAccountView
    {
        public int BankId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public long Mobile { get; set; }
        public int Balance { get; set; }
        public long AccountNumber { get; set; }
    }
}