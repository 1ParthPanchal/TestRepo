using System;
using System.Collections.Generic;

#nullable disable

namespace pharmEasy.Models
{
    public partial class MasterTable
    {
        public MasterTable()
        {
            Attributes = new HashSet<Attribute>();
        }

        public int AttributeTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Attribute> Attributes { get; set; }
    }
}
