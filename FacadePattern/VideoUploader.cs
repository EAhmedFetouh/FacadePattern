using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class VideoUploader
    {
        public string Save(string fileName)
        {
            string path = $"uploads/{fileName}";
            Directory.CreateDirectory("uploads");
            File.WriteAllText(path, $"Mock data for {fileName}");
            return path;
        }
    }
}
