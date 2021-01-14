using System;
using System.Collections.Generic;
using System.Text;

namespace BackupCopyProgram
{
    public sealed class DVD : Storage
    {
        public double WriteAndReadSpeedInMbPerSecond { get; set; }
        public double Type { get; set; }
        public override double GetMemoryVolume()
        {
            return Type;
        }
        public override void CopyDataToDevice(double data)
        {
            if (spaceOfMemory < Type)
            {
                spaceOfMemory += data;
            }
            else
            {
                Console.WriteLine($"Not enough memory, to copy this data! There is {Type - spaceOfMemory} free space left.");
            }
        }
        public override string GetInfoAboutFreeVolumeOfMemoryOnDevice()
        {
            return $"There is { Type - spaceOfMemory } free space left.";
        }
        public override string GetFullInfoAboutDevice()
        {
            return $"Device name: {NameOfStorage} {Model}\nSpeed: {WriteAndReadSpeedInMbPerSecond}\nSize of memory: {Type}";
        }
    }
}