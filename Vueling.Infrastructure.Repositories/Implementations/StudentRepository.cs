using Dapper;
using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Vueling.Domain.Entities;
using Vueling.Infrastructure.Repositories.Contracts;

namespace Vueling.Infrastructure.Repositories.Implementations
{
    public class StudentRepository : IRepository<Student>
    {

        private readonly ILog logger = null;
        public StudentRepository()
        {

        }

        public StudentRepository(ILog logger)
        {
            this.logger = logger;
        }

        public Student Create(Student model)
        {
            using (var connection = new SqlConnection(Resources.connectionString))
            {
                if(model == null)
                {
                    throw new ArgumentNullException(nameof(model));
                }
                try
                {
                    var id = SqlMapper.Query<int>(connection, "INSERT INTO Student VALUES (@Name, @Lastname, @Birthday, @Guid);SELECT CAST(SCOPE_IDENTITY() AS INT);",
                        new { model.Name, model.Lastname, @Birthday = model.BirthDate, model.Guid }).Single();

                    return SqlMapper.Query<Student>(connection, "SELECT * FROM Student WHERE Id = @Id", new { @Id = id }).Single();
                }
                catch (InvalidOperationException e)
                {
                    logger.Error(e.Message, e);
                    throw;
                }
            }
        }

        public bool Delete(int id)
        {
            using (var connection = new SqlConnection(Resources.connectionString))
            {
                SqlMapper.Query<bool>(connection, "DELETE FROM Student WHERE Id = @Id", new { @Id = id });

                return true;
            }
        }

        public List<Student> GetAll()
        {
            using (var connection = new SqlConnection(Resources.connectionString))
            {
                logger.Info("GetAll method started");
                try
                {
                    return SqlMapper.Query<Student>(connection, "SELECT * FROM Student").ToList();
                }
                catch (ArgumentNullException ex)
                {
                    logger.Error(ex.Message, ex);
                    throw;
                }
            }
        }

        public Student Update(Student model)
        {
            if(model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            using (var connection = new SqlConnection(Resources.connectionString))
            {
                connection.Query<Student>("UPDATE Student SET Name = @Name, Lastname = @Lastname, Birthday = @BirthDate WHERE Id = @Id;",
                        new { model.Name, model.Lastname, model.BirthDate, model.Id });
                try
                {
                    var updatedStudent = SqlMapper.Query<Student>(connection, "SELECT * FROM Student WHERE Id = @Id", new { model.Id }).Single();

                    return updatedStudent;
                }
                catch (ArgumentNullException e)
                {
                    logger.Error(e.Message, e);
                    throw;
                }
                catch (InvalidOperationException e)
                {
                    logger.Error(e.Message, e);
                    throw;
                }
            }
        }
    }
}
