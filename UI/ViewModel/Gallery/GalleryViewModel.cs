﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace UI
{
    public class GalleryViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Event Name")]
        public string Name { get; set; }

      
        [Display(Name = "UploadPicture")]
        public string PictureUrl { get; set; }


        [FileTypes("jpg,jpeg,png")]
        public HttpPostedFileBase PictureThumbnailUrl { get; set; }
        [Display(Name = "Date of Event")]
        public DateTime Date { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        public bool Done { get; set; } = false;
    }
}