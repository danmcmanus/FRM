using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FRM.Models
{
    public class FamilyMember
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }
        public DateTime Birthday { get; set; }

        [EnumDataType(typeof(RelationshipTypes))]
        public RelationshipTypes RelationshipType { get; set; }


    }
}