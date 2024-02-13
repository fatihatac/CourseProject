using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        public List<Category> categories;
        public CategoryDal()
        {
            categories = new List<Category>() { 
                new Category { Id = 1, Name = "Backend", Description = "Backend kursları" },
                new Category{Id=2,Name="Frontend",Description="Frontend kursları"} };

        }
        public void Add(Category entity)
        {
            categories.Add(entity);
        }

        public void Delete(Category entity)
        {
            var deletedCategory = categories.First(c => c.Id == entity.Id);
            categories.Remove(deletedCategory);
        }

        public Category Get(int id)
        {
            return categories.First(c => c.Id == id);
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public void Update(Category entity)
        {
            var updatedCategory = categories.First(c => c.Id == entity.Id);
            updatedCategory.Id = entity.Id;
            updatedCategory.Description = entity.Description;
            updatedCategory.Name = entity.Name;

        }
    }
}
