namespace Contacts.Models.Contacts
{
    public class AllContactsQueryModel
    {
        public IEnumerable<ContactViewModel> Contacts { get; set; }
            = new List<ContactViewModel>();
    }
}
