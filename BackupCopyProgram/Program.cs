using System;

namespace BackupCopyProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            double sizeOfData = 565;
            double file = 0.78;

            var devices = new Storage[3] {
           new Flash{NameOfStorage = "USB",
               Model = "Transcend",
               USB3SpeedInMbPerSecond = 33.4,
               spaceOfMemory = 32.4,
               MemorySize = 32.4},
           new DVD{NameOfStorage = "DVD",
               Model = "R",
               WriteAndReadSpeedInMbPerSecond = 1.32,
               spaceOfMemory = 4.7,
               Type = 4.7},
             new HDD{NameOfStorage = "HDD",
               Model = "Transcend",
               USB2SpeedInMbPerSecond = 22.3,
               spaceOfMemory = 512,
               CountOfSections = 10,              
               SectionsVolume = 51.2}
           };
            foreach(var device in devices)
            {
                device.CopyDataToDevice(file, sizeOfData);
            }

        }
    }
}