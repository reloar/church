using Domain;
using System.Collections.Generic;

namespace UI
{
    public class SermonViewModel
    {
        public IEnumerable<Sermon> Sermons { get; set; }
        public IEnumerable<SermonCategory> SermonCategory { get; set; }
        public string SermonCat { get; set; }    

    }
}