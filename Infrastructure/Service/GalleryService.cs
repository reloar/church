using Domain;

namespace Infrastructure
{
    public class GalleryService:IService<Gallery>
    {
        private readonly IRepository<Gallery> _galleryrepo;
        public GalleryService(IRepository<Gallery> galleryrepo)
        {
            _galleryrepo = galleryrepo;
        }
        public void AddItem(Gallery entity)
        {
            _galleryrepo.Add(entity);
        }

        public void Clear()
        {

        }

        public void RemoveItem(Gallery entity)
        {
            _galleryrepo.Remove(entity);
        }
    }
}
