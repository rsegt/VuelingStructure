﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.Application.Logic.Contracts
{
    public interface IUpdate<T>
    {
        T Update(T model);
    }
}
