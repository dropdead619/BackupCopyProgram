using System;
using System.Collections.Generic;
using System.Text;

namespace BackupCopyProgram
{
    public sealed class Flash : Storage
    {
        public double USB3SpeedInMbPerSecond { get; set; }
        public double MemorySize { get; set; }
 
        public override double GetMemoryVolume()
        {
            return MemorySize;
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
                else if(sizeOfData <= 0)
                {
                    Console.WriteLine($"Files are successfully copied to your devices. {countOfDevices} device(s) were used.\n" +
                        $"It took {((tmpSizeOfData * 1024) / ((USB3SpeedInMbPerSecond * 1000) / 8)) / 60} minutes");
                    isCopyFinished = false;
                }
                else
                {
                    countOfDevices++;
                    spaceOfMemory = MemorySize;
                }
            }        
        }
        public override string GetInfoAboutFreeVolumeOfMemoryOnDevice()
        {
            return $"There is: {spaceOfMemory} free space left.";
        }
        public override string GetFullInfoAboutDevice()
        {
            return $"Device name: {NameOfStorage} {Model}\nSpeed: {USB3SpeedInMbPerSecond}\nSize of memory: {MemorySize}";
        }
    }
}