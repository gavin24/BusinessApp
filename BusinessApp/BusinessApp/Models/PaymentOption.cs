﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Enums;
using SQLite;
using SQLite.Net.Attributes;

namespace BusinessApp.Models
{
    public class PaymentOption : Model
    {
        [PrimaryKey, AutoIncrement]
        private long Id { get; set; }
        private long ClientId { get; set; }
        private PaymentType PayType { get; set; }

    }
}