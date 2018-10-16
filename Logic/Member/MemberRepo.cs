using Domain;
using Logic;
using System.Collections.Generic;

namespace Logic
{
    public class MemberRepo : Repository<Member>, IMemberRepo
    {
        public MemberRepo(PraiseDbContext context) : base(context)
        {

        }

        public IEnumerable<Member> GetMember
        {
            get { return GetAll(); }
        }
    }
}
