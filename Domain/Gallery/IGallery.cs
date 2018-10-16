using System;

namespace Domain
{
    public interface IGallery
    {
        int Id { get; set; }
      
        DateTime EventDate { get; set; }
        string Name { get; set; }

        string PictureThumbnailUrl { get; set; }
        string PictureUrl { get; set; }
        string PictureDescription { get; set; }
    }
}
