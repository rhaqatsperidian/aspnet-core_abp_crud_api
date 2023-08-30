using MyStudentApp.Dtos;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace MyStudentApp
{
    public class CreateUpdateStudentDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string FatherName { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
    }
    public class StudentDto : IEntityDto<Guid>
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string FatherName { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
    }

    public class StudentAppService : CrudAppService<
        Student, // The Student entity
        StudentDto, // Used to show students
        Guid, // Primary key of the entity
        PagedAndSortedResultRequestDto, // Used for paging/sorting
        CreateUpdateStudentDto> // Used to create/update a student
    {
        public StudentAppService(IRepository<Student, Guid> repository)
            : base(repository)
        {
        }
    }
}
