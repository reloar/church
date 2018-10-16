using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.Linq;

namespace UI
{
    public class RoleListViewModel
    {
        public IEnumerable<IdentityRole> Roles { get; set; } = Enumerable.Empty<IdentityRole>();
    }
}