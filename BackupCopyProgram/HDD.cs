using System;
using System.Collections.Generic;
using System.Text;

namespace BackupCopyProgram
{
    public sealed class HDD : Storage
    {
        public double USB2SpeedInMbPerSecond { get; set; }
        public int CountOfSections { get; set; }
        public double SectionsVolume { get; set; }
        public override double GetMemoryVolume()
        {
            return CountOfSections * SectionsVolume;
        }
        public override void CopyDataToDevice(double data, double sizeOfData)
        {
            bool isCopyFinished = true;
            int countOfDevices = 0;
            double tmpSizeOfData = sizeOfData;
            while (isCopyFinished)
            {
                if (spaceOfMemory - data >= 0)
                {
                    spaceOfMemory -= data;
                    sizeOfData -= data;
                }
                else if (sizeOfData <= 0)
                {
                    Console.WriteLine($"Files are successfully copied to your devices. {countOfDevices} device(s) were used.\n" +
                        $"It took {((tmpSizeOfData * 1024) / ((USB2SpeedInMbPerSecond * 1000) / 8)) / 60} minutes");
                    isCopyFinished = false;
                }
                else
                {
                    countOfDevices++;
                    spaceOfMemory = CountOfSections * SectionsVolume;
                }
            }
        }
        public override string GetInfoAboutFreeVolumeOfMemoryOnDevice()
        {
            return $"There is {spaceOfMemory} free space left.";
        }
        public override string GetFullInfoAboutDevice()
        {
            return $"Device name: {NameOfStorage} {Model}\nSpeed: {USB2SpeedInMbPerSecond}\nSize of memory: {CountOfSections * SectionsVolume}";
        }
    }
}