using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseProject.Core.Entities;

namespace Entities.Concretes
{
    public class Instructor : IEntity
    {
        public int Id { get; set; }
        public string FirstName{ get; set; }
        public string LastName { get; set; }

    }
}
