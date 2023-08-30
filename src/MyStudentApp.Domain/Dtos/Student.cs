using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace MyStudentApp.Dtos
{
   
    public class Student : Entity<Guid>
    {
        public string FirstName { get; set; }
        public string FatherName { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
    }
}
