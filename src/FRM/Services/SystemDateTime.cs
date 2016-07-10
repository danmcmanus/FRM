using FRM.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FRM.Services
{
    public class SystemDateTime : IDateTime
    {
        public DateTime Now
        {
            get
            {
                return DateTime.Now;
            }
        }
    }
}
