﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace authSql.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string MailStatus { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string CreditCard { get; set; }
        public string ConnectionStatus { get; set; }

        public string Message { get; set; }
    }
}
