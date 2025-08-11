using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class VideoConverter
    {
        public string ConvertToMp4(string inputPath)
        {
            string outputPath = inputPath.Replace(".avi", ".mp4");
            File.WriteAllText(outputPath, $"Converted to MP4 from {inputPath}");
            return outputPath;
        }
    }
}
