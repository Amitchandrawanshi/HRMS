﻿using System;
using System.Collections.Generic;

namespace HRMS.DB.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Department { get; set; }
        public string Gender { get; set; }
    }
}
