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
        public override void CopyDataToDevice(double data)
        {
            if (spaceOfMemory <= MemorySize)
            {
                spaceOfMemory += data;
            }
            else
            {
                Console.WriteLine($"Not enough memory, to copy this data! There is {MemorySize - spaceOfMemory} free space left.");
            }
        }
        public override string GetInfoAboutFreeVolumeOfMemoryOnDevice()
        {
            return $"There is: {MemorySize - spaceOfMemory} free space left.";
        }
        public override string GetFullInfoAboutDevice()
        {
            return $"Device name: {NameOfStorage} {Model}\nSpeed: {USB3SpeedInMbPerSecond}\nSize of memory: {MemorySize}";
        }
    }
}