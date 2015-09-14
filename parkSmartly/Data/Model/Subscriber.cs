﻿using parkSmartly.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkSmartly.Data.Model
{
    public class Subscriber : MongoEntity
    {
        public string Email { get; set; }
        public DateTime DateRegistered { get; set; }
    }
}
