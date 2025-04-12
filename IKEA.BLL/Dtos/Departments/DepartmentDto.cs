using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Dtos.Departments
{
    public class DepartmentDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;
        public string code { get; set; } = null!;

        public DateOnly CreationDate { get; set; }
    }
}
