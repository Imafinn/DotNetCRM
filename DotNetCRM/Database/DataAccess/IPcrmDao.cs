﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.DataAccess
{
    interface IPcrmDao
    {
        Employee GetEmployee(int id);
    }
}
