using Domain;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class UserRepo : Repository<User>, IUserRepo<IUser>
    {
        private readonly PraiseDbContext _DbContext;
        public UserRepo(PraiseDbContext context) : base(context)
        {
            _DbContext = context;
        }       

        public List<IUser> UserList
        {
            get
            {
                return _DbContext.Users.ToList<IUser>();
            }
        }
       
    }
}
