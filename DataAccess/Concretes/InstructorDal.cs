using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class InstructorDal : IInsturctorDal
    {
        public List<Instructor> instructors;
        public InstructorDal()
        {
            instructors = new List<Instructor>()
            {
                new Instructor {Id=1,FirstName="Engin", LastName="Demiroğ" },
                new Instructor {Id = 2, FirstName = "Başka", LastName = "Biri"},
                new Instructor {Id = 3, FirstName = "Başka", LastName = "Biri 2"}
            };

        }
        public void Add(Instructor entity)
        {
            instructors.Add(entity);
        }

        public void Delete(Instructor entity)
        {
            var deletedInstructor = instructors.First(c => c.Id == entity.Id);
            instructors.Remove(deletedInstructor);
        }

        public Instructor Get(int id)
        {
            return instructors.First(c => c.Id == id);
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public void Update(Instructor entity)
        {
            var updatedInstructor = instructors.First(c => c.Id == entity.Id);
            updatedInstructor.Id = entity.Id;
            updatedInstructor.FirstName = entity.FirstName;
            updatedInstructor.LastName = entity.LastName;
        }
    }
}
