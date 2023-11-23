
using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Concretes
{
    public class Category : IEntity
    {        
        public int Id { get; set; }
        public string Name { get; set; }
        public Course[] Courses { get; set; }
    }
}
