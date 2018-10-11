using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPPhotos.Models
{
    public class PhotoModel
    {
        public string PhotoName { get; set; }

        public byte[] PhotoData { get; set; }

        public string ContentType { get; set; }

    }
}
