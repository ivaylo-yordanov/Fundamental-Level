﻿namespace HotelBookingSystem.Core.IO
{
    using System;
    using Interfaces;

    public class ConsoleOutputWriter : IOutputWriter
    {
        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }

        public void Write(string text)
        {
            Console.Write(text);
        }
    }
}