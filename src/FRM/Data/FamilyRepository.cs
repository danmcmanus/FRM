using FRM.Contracts;
using FRM.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FRM.Data
{
    public class FamilyRepository : RepositoryBase<Family>
    {
        public FamilyRepository(ApplicationDbContext context, UserManager<ApplicationUser> manager) : base(context, manager)
        {
            if (context == null)
            {
                throw new NullReferenceException();
            }
        }
    }
}
