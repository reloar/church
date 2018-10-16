using Domain;
using PagedList;

namespace UI
{
    public class SermonListViewModel
    {
        public IPagedList<ISermon> Sermons { get; set; }
    }
}