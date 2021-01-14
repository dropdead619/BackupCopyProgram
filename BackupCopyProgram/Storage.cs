using System;
using System.Collections.Generic;
using System.Text;

namespace BackupCopyProgram
{
    public abstract class Storage
    {
        public string NameOfStorage { get; set; }
        public string Model { get; set; }
        public double spaceOfMemory = 0;
        public abstract double GetMemoryVolume();
        public abstract void CopyDataToDevice(double data);
        /* получение информации о свободном объеме памяти на устройстве;
         получение общей/полной информации об устройстве.*/
        public abstract string GetInfoAboutFreeVolumeOfMemoryOnDevice();
        public abstract string GetFullInfoAboutDevice();
    }
}