﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SmartTest.DataAccess.Models
{
    public class Person
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public PersonType PersonType { get; set; }
        public int PersonTypeId { get; set; }

    }
}
