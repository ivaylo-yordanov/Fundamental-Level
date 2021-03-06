﻿namespace HotelBookingSystem
{
    using Core;
    using Core.IO;
    using Data;

    public class HotelBookingSystemMain
    {
        public static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            var database = new HotelBookingSystemData();
            var reader = new ConsoleInputReader();
            var writer = new ConsoleOutputWriter();
            var engine = new Engine(database, reader, writer);

            engine.StartOperation();
        }
    }
}