using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_Session_01.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        
        public string FName { get; set; }
        public string? LName { get; set; }
        public string? Address {  get; set; }
        public int Age { get; set; }
        public int Dept_Id {  get; set; }
    }
}
