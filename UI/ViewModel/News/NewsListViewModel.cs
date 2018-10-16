using Domain;
using PagedList;

namespace UI
{
    public class NewsListViewModel
    {
        public IPagedList<INews> News { get; set; }
    }
}