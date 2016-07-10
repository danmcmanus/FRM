using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FRM.Contracts
{
    public interface IDateTime
    {
        DateTime Now { get; }
    }
}
