﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac2.Models
{
    interface IEmployeeRepository
    {
        Employee GetEmployee(int Id);
    }
}
