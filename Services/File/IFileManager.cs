using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneDelivery.Services.FileService
{
    public interface IFileManager<T>
    {
        T GetFile();
    }
}
