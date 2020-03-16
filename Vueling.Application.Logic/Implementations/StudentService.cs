
using System.Collections.Generic;
using Vueling.Application.Logic.Contracts;
using Vueling.Domain.Entities;
using Vueling.Infrastructure.Repositories.Contracts;

namespace Vueling.Application.Logic.Implementations
{
    public class StudentService : IService<Student>
    {
        readonly IRepository<Student> repository = null;

        public StudentService(IRepository<Student> repository)
        {
            this.repository = repository;
        }

        public Student Create(Student model)
        {
            return repository.Create(model);
        }

        public bool Delete(int id)
        {
            return repository.Delete(id);
        }

        public List<Student> GetAll()
        {
            return repository.GetAll();
        }

        public Student Update(Student model)
        {
            return repository.Update(model);
        }
    }
}
