using System.Collections.Generic;
using UWDN.FullScreenForm.Web.Models;
using UWDN.FullScreenForm.Web.Repositories;

namespace UWDN.FullScreenForm.Web.Services
{
	public class ContactService
    {
		public void Add(Contact contact)
		{
			new ContactRepository().Insert(contact);
		}

		public List<Contact> ListAll()
		{
			return new ContactRepository().List();
		}
    }
}
