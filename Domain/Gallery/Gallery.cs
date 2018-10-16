using System;

namespace Domain
{
    public class Gallery:Entity, IGallery
    {
      
        public DateTime EventDate { get; set; }
        public string Name { get; set; }  
        public string PictureThumbnailUrl { get; set; }
        public string PictureUrl { get; set; }
        public string PictureDescription { get; set; }
   
    }
}
