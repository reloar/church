using Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class GalleryRepo : Repository<Gallery>, IGalleryRepo
    {
        public GalleryRepo(PraiseDbContext context) : base(context)
        {

        }
        public IEnumerable<Gallery> Gallery
        {
            get { return this.GetAll(); }
        }

        public Gallery GetNextPicture
        {
            get { return this.Find(c => c.EventDate <= DateTime.Now).Take(1).OrderBy(c => c.Name).FirstOrDefault(); }

        }
    }
}
