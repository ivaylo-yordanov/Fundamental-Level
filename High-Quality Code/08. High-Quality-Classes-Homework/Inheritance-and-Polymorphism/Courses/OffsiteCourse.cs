﻿using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism.Courses
{
    public class OffsiteCourse : Course
    {
        public OffsiteCourse(string courseName, string teacherName, IList<string> students, string town)
            : base(courseName, teacherName, students)
        {
            this.Town = town;
        }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students)
            : this(courseName, teacherName, students, null)
        {
        }

        public OffsiteCourse(string courseName, string teacherName)
            : this(courseName, teacherName, null, null)
        {
        }

        public OffsiteCourse(string courseName)
            : this(courseName, null, null, null)
        {
        }

        public string Town { get; set; }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(base.ToString());

            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}
