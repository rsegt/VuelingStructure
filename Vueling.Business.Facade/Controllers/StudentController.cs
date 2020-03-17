using log4net;
using System.Web.Http;
using Vueling.Application.Logic.Contracts;
using Vueling.Domain.Entities;

namespace Vueling.Business.Facade.Controllers
{
    public class StudentController : ApiController
    {
        private readonly IService<Student> serviceProvider = null;
        private readonly ILog logger = null;

        public StudentController()
        {

        }

        public StudentController(IService<Student> serviceProvider, ILog logger)
        {
            this.serviceProvider = serviceProvider;
            this.logger = logger;
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            logger.Debug("Error log");
            return Ok(serviceProvider.GetAll());
        }

        [HttpPost]
        public IHttpActionResult Create([FromBody]Student model)
        {
            return Ok(serviceProvider.Create(model));
        }

        [HttpPut]
        public IHttpActionResult Update([FromBody]Student model)
        {
            return Ok(serviceProvider.Update(model));
        }

        [HttpDelete]
        public IHttpActionResult Delete([FromBody]int id)
        {
            return Ok(serviceProvider.Delete(id));
        }
    }
}
