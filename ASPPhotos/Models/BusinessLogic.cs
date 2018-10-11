using ASPPhotos.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPPhotos.Models
{
    public class BusinessLogic
    {
        PhotoContext adatbazis;

        public BusinessLogic(PhotoContext db)
        {
            this.adatbazis = db;
        }

        public void AddPhoto(PhotoViewModel viewmodel)
        {
            //vm -> m
            byte[] picturedata = new byte[viewmodel.PhotoToUpload.Length];
            using (var stream = viewmodel.PhotoToUpload.OpenReadStream())
            {
                stream.Read(picturedata, 0, (int)viewmodel.PhotoToUpload.Length);
            }

            PhotoModel model = new PhotoModel()
            {
                PhotoName = viewmodel.PhotoName,
                PhotoData = picturedata,
                ContentType = viewmodel.PhotoToUpload.ContentType
            };

            adatbazis.Photos.Add(model);
            adatbazis.SaveChanges();
        }

        public IEnumerable<PhotoModel> GetAll()
        {
            return this.adatbazis.Photos;
        }

        public PhotoModel GetPhotoById(int id)
        {
            var q = from x in adatbazis.Photos
                    where x.Id == id
                    select x;
            return q.FirstOrDefault();
        }
    }
}
