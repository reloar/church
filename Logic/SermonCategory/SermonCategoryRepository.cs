using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class SermonCategoryRepository : Repository<SermonCategory>, ISermonCategoryRepo
    {
        public SermonCategoryRepository(PraiseDbContext context) : base(context)
        {
            //_DbContext = context;
        }
        public IEnumerable<SermonCategory> SermonCategories
        {
            get { return this.GetAll(); }
        }
    }
}
