using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_Session_01.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Ins_Id { get; set; }
        public DateOnly HiringDate { get; set; }
    }
}
