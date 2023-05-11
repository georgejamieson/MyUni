﻿namespace MyUni.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public double Credits { get; set; }
        public ICollection<Enrollment> Enrollements { get; set; }

    }
}