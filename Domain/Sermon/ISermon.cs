using System;

namespace Domain
{
    public interface ISermon
    {
        int Id { get; set; }
        string PreacherName { get; set; }

        string Title { get; set; }
        string LongDescription { get; set; }

        string Bibletext { get; set; }

        DateTime SermonDate { get; set; }
        string ImageUrl { get; set; }

        string ImageThumbnailUrl { get; set; }
        //string SermonvideoUrl { get; set; }
        //string SermonvideoThumbnail { get; set; }

        bool IsLiked { get; set; }

    }
}
