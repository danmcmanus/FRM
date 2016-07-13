using FRM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FRM.ViewModels
{
    public class FamilyMemberViewModel
    {
        public string FamilyName { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public List<FamilyMember> FamilyMembers { get; set; }
        [EnumDataType(typeof(RelationshipTypes))]
        public RelationshipTypes RelationshipType { get; set; }

    }
}
