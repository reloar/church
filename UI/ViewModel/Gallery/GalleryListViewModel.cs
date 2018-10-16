using Domain;
using PagedList;

namespace UI
{
    public class GalleryListViewModel
    {
        public IPagedList<IGallery> Pictures { get; set; }
    }
}