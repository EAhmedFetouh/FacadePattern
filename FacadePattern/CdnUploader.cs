using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class CdnUploader
    {
        public string Upload(string path)
        {
            var cdnUrl = $"https://cdn.udemy.com/{Path.GetFileName(path)}";
            Console.WriteLine($"☁️ Uploaded video to CDN: {cdnUrl}");
            return cdnUrl;
        }
    }
}
