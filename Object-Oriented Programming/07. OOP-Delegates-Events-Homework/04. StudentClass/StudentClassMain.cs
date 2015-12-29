﻿using System;

namespace _04.StudentClass
{
    class StudentClassMain
    {
        static void Main(string[] args)
        {
            Student student = new Student("Peter", 22);
            student.OnPropertyChange += (sender, eventArgs) =>
            {
                Console.WriteLine("Property changed: {0} (from {1} to {2})",
                    eventArgs.PropName, eventArgs.PreviousData, eventArgs.NewData);
            };
            student.Name = "Maria";
            student.Age = 19;

        }

        private static void EventChanges(object sender, PropertyChangedEventArgs args)
        {
            Console.WriteLine(
                $"{args.PropName} property has chnaged from {args.PreviousData} to {args.NewData}");
        }
    }
}
