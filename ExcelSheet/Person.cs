﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelSheet
{
    public class Person
    {
        public string Name {  get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public override string ToString() => $"{Name} and Phone is {Phone} and Email {Email}";
    }
}
