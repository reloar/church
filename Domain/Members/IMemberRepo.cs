using System.Collections.Generic;

namespace Domain
{

    public interface IMemberRepo : IRepository<Member>
    {
        IEnumerable<Member> GetMember { get; }
    }
}
