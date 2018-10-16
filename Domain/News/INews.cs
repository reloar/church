using System;

namespace Domain
{
    public interface INews
    {
        int Id { get; set; }

        DateTime DueDate { get; set; }
        string Name { get; set; }

        string PictureThumbnailUrl { get; set; }
        string PictureUrl { get; set; }
        string Description { get; set; }
        string Venue { get; set; }
    }
}
