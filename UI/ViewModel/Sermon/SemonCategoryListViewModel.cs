using Domain;
using System.Collections.Generic;
using System.Linq;

namespace UI
{
    public class SermonCategoryListViewModel
    {
        public IEnumerable<ISermonCategory> SermonCategories { get; set; } = Enumerable.Empty<ISermonCategory>();

    }
}