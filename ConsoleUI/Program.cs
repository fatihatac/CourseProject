

using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;

// instructor

IInstructorService instructorService = new InstructorManager(new InstructorDal());


instructorService.Add(new Instructor {Id = 4,FirstName="Fatih",LastName= "Ataç" });
instructorService.Update(new Instructor { Id = 4, FirstName = "Fatih", LastName = "Ataçç" });

foreach (var instructor in instructorService.GetAll())
{
    Console.WriteLine(instructor.FirstName + " " + instructor.LastName);
}

instructorService.Delete(new Instructor { Id = 4 });

foreach (var instructor in instructorService.GetAll())
{
    Console.WriteLine(instructor.FirstName + " " + instructor.LastName);
}

Console.WriteLine(instructorService.GetById(1).FirstName);



Console.WriteLine();
// category

ICategoryService categoryService = new CategoryManager(new CategoryDal());

categoryService.Add(new Category { Id = 3, Name = "Machine Learning", Description = "Machine Learning Courses" });
categoryService.Update(new Category { Id = 3, Name = "Not Machine Learning", Description = "Not Machine Learning Courses" });

foreach (var category in categoryService.GetAll())
{
    Console.WriteLine(category.Name);
}

categoryService.Delete(new Category { Id=3});
foreach (var category in categoryService.GetAll())
{
    Console.WriteLine(category.Name);
}

Console.WriteLine(categoryService.GetById(1).Name);
categoryService.Add(new Category { Id = 3, Name = "Machine Learning", Description = "Machine Learning Courses" });



Console.WriteLine();
// course

ICourseService courseService = new CourseManager(new CourseDal());

courseService.Add(new Course { Id = 4, Name = "TensorFlow", CategoryId = 3, Description = "description", InstructorId = 4 });
courseService.Update(new Course { Id = 4, Name = "Pytorch", CategoryId = 3, Description = "description", InstructorId = 4 });
foreach (var course in courseService.GetAll())
{
    Console.WriteLine(course.Name);
}

courseService.Delete(new Course { Id = 4 });
foreach (var course in courseService.GetAll())
{
    Console.WriteLine(course.Name);
}

Console.WriteLine(courseService.GetById(1).Name);