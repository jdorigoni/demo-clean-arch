using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infrastructure.Data.Context;

namespace CleanArch.Infrastructure.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDBContext _context;

        public CourseRepository(UniversityDBContext context)
        {
            _context = context;
        }

        public IQueryable<Course> GetCourses()
        {
            return _context.Courses;
        }

        public void Add(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

    }
}
