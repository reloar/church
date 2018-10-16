using Domain;
using PagedList;

namespace UI
{
    public class MemberListViewModel
    {
            public IPagedList<IMember> Members { get; set; }
    
    }
}