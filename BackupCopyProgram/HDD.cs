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
        public override void CopyDataToDevice(double data)
        {
            if (spaceOfMemory < (CountOfSections * SectionsVolume))
            {
                spaceOfMemory += data;
            }
            else
            {
                Console.WriteLine($"Not enough memory, to copy this data! There is {(CountOfSections * SectionsVolume) - spaceOfMemory} free space left.");
            }
        }
        public override string GetInfoAboutFreeVolumeOfMemoryOnDevice()
        {
            return $"There is {(CountOfSections * SectionsVolume) - spaceOfMemory} free space left.";
        }
        public override string GetFullInfoAboutDevice()
        {
            return $"Device name: {NameOfStorage} {Model}\nSpeed: {USB2SpeedInMbPerSecond}\nSize of memory: {CountOfSections * SectionsVolume}";
        }
    }
}