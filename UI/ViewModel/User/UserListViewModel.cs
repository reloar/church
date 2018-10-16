using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI
{
    public class UserListViewModel
    {
        public IEnumerable<User> Users { get; set; } = Enumerable.Empty<User>();

    }
}