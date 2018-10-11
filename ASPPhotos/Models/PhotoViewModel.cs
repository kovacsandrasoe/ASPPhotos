using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPPhotos.Models
{
    public class PhotoViewModel
    {
        public string PhotoName { get; set; }

        public IFormFile PhotoToUpload { get; set; }
    }
}
