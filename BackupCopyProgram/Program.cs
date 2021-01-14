using System;

namespace BackupCopyProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            double sizeOfData = 565;
            double file = 780 / 1000;

            var devices = new Storage[3] {
           new Flash{NameOfStorage = "USB",
               Model = "Transcend",
               USB3SpeedInMbPerSecond = 1,
               MemorySize = 32.4},
           new DVD{NameOfStorage = "DVD",
               Model = "R",
               WriteAndReadSpeedInMbPerSecond = 1.32,
               Type = 4.7},
             new HDD{NameOfStorage = "HDD",
               Model = "Transcend",
               USB2SpeedInMbPerSecond = 1,
               CountOfSections = 2,
               SectionsVolume = 512}
           };


        }
    }
}