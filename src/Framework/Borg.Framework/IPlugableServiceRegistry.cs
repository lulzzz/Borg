﻿using Borg.Infrastructure.Core.DI;
using System;
using System.Collections.Generic;

namespace Borg.Framework
{
    public interface IPlugableServiceRegistry
    {
        IEnumerable<(Type contract, Type service, PlugableServiceAttribute attribute)> RegisteredServices();
    }
}