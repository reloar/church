using Domain;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI
{
    public class ContactListModel
    {
        public IPagedList<IContact> Contacts { get; set; }
    }
}