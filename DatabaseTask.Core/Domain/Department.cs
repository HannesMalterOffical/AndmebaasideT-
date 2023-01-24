using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    internal class Department
    {
        [Key]
        public int Id { get; set; }
        public string SectionType { get; set; }
        public int DepartmentNumber { get; set; }
    }
}
