﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA16.Interfaces
{
    public interface IWhichPlatform
    {
        Task<string> GetPlatformName();
    }
}
