using System.Collections.Generic;
using System.Linq;
using UWDN.FullScreenForm.Web.Models;

namespace UWDN.FullScreenForm.Web.Repositories
{
	// In memory repository
	public class ContactRepository
    {
		public static List<Contact> _contacts = new List<Contact>();

		public void Insert(Contact contact)
		{
			_contacts.Add(contact);
		}

		public List<Contact> List()
		{
			return _contacts.ToList();
		}
    }
}
