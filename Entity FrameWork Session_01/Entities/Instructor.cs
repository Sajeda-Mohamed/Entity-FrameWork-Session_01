using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_Session_01.Entities
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public float Salary {  get; set; }
        public string? Address {  get; set; }
        public float HourRateBonus {  get; set; }
        public int Dept_Id {  get; set; }
    }
}
