using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.ClassFolder
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }

        public int Length { get; set; }

        public double Price { get; set; }

        public string Bio { get; set; }
        public int TeacherId { get; set; }
        public double Rating { get; set; }
        public List<int> Subscribers { get; set; } = new List<int>();
        public Course(string name, string subject, int length, double price, string bio, int teacherId)
        {
            Id = Guid.NewGuid().GetHashCode();
            if (Id < 0) Id = Id * -1;
            Name = name; 
            Subject = subject; 
            Length = length; 
            Price = price; 
            Bio = bio;
            TeacherId = teacherId;
            Rating = 100;

        }

        public Course()
        {
            
        }

    }
}
