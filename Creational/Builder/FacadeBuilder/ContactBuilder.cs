namespace Builder.FacadeBuilder
{
    public class ContactBuilder
    {
        protected Contact contact = new Contact();

        public ContactsJobBuilder Works => new ContactsJobBuilder(contact);
        public ContactAddressBuilder Lives => new ContactAddressBuilder(contact);


        public Contact Build(){
            return contact;
        }

        // public static implicit operator Contact(ContactBuilder cb){return cb.person;}
    }
}