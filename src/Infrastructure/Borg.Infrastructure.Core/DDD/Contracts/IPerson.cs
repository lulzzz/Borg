﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Borg.Infrastructure.Core.DDD.Contracts
{
    public interface IPerson : IHasEmail, IHasName
    {

        string SurName { get; set; }
    }
}
