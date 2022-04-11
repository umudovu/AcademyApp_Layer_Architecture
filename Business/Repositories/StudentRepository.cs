using DataAccess;
using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
        public bool Create(Student entity)
        {
            try
            {
                DataContext.Students.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Student entity)
        {
            DataContext.Students.Remove(entity);
            return true;
        }

        public List<Student> GetAll(Predicate<Student> filter = null)
        {
            try
            {
                return DataContext.Students.FindAll(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Student GetOne(Predicate<Student> filter = null)
        {
            try
            {
                return DataContext.Students.Find(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Student entity)
        {
            try
            {
                Student IsExsist = GetOne(s => s.Id==entity.Id);
                IsExsist=entity;
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
