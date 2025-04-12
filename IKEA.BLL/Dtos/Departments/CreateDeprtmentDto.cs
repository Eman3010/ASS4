using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Dtos.Departments
{
    public class CreateDeprtmentDto
    {
        public string Name { get; set; } = null!;
        public string code { get; set; } = null!;
        public string? Description { get; set; }

        public DateOnly CreationDate { get; set; }

    }
}
