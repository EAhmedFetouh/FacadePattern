using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class AudioNormalizer
    {
        public void Normalize(string path)
        {
            var content = File.ReadAllText(path);
            content += "\n[Audio Normalized]";
            File.WriteAllText(path, content);
        }
    }
}
