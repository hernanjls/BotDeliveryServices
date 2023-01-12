using DroneDelivery.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneDelivery.Services.FileService
{
    public class FileManager : IFileManager<string[]>
    {
        public string[] GetFile()
        {
            var fileDirPath = FileHelper.AssemblyDirectory;
            string txtFilePath = string.Format("{0}\\Sources\\InputFile.txt", fileDirPath);
            string[] text =  System.IO.File.ReadAllLines(txtFilePath);
            return text;
        }
    }
}
