using ASPPhotos.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPPhotos.Models
{
    public class BusinessLogic
    {
        PhotoContext adatbazias;

        public BusinessLogic(PhotoContext db)
        {
            this.adatbazias = db;
        }

        public void AddPhoto(PhotoViewModel viewmodel)
        {
            //vm -> m
        }

        public IEnumerable<PhotoModel> GetAll()
        {

        }

        public PhotoModel GetPhotoById(int id)
        {

        }
    }
}
