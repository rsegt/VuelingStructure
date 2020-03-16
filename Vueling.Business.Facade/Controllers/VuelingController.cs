using System.Collections.Generic;
using System.Web.Http;
using Vueling.Application.Logic.Contracts;
using Vueling.Domain.Entities;

namespace Vueling.Business.Facade.Controllers
{
    public class VuelingController : ApiController
    {
        readonly IService<Student> serviceProvider = null;

        public VuelingController(IService<Student> serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        [Route("api/students")]
        public List<Student> GetAll()
        {
            return serviceProvider.GetAll();
        }

        [Route("api/add")]
        public Student Post(Student model)
        {
            return serviceProvider.Create(model);
        }

        [Route("api/update")]
        public Student Put(Student model)
        {
            return serviceProvider.Update(model);
        }

        [Route("api/delete/{id}")]
        public bool Delete(int id)
        {
            return serviceProvider.Delete(id);
        }
    }
}
