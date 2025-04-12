using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Dtos.Departments
{
    public class DepartmentDetailsDto
    {
        public int Id { get; set; }
        public int createdby { get; set; }
        public DateTime createdon { get; set; }
        public int LastModifiedBy { get; set; }
        public int LastModifiedOn { get; set; }
        public bool IsDeleted { get; set; }

        public string Name { get; set; } = null!;
        public string code { get; set; } = null!;
        public string? Description { get; set; }

        public DateOnly CreationDate { get; set; }

    }
}
