using System;

namespace Domain
{
    public class News : Entity, INews
    {

        public DateTime DueDate { get; set; }
        public string Name { get; set; }
        public string PictureThumbnailUrl { get; set; }
        public string PictureUrl { get; set; }
        public string Description { get; set; }
        public string Venue { get; set; }

    }
}
