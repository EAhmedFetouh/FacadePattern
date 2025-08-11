﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class MetadataExtractor
    {
        public VideoMetadata Extract(string path)
        {

            var random = new Random();
            return new VideoMetadata
            {
                Duration = $"{random.Next(5, 20)}:{random.Next(0, 60):D2}",
                Resolution = "1080p",
                SizeInMB = random.Next(50, 150)
            };
        }
    }
}
