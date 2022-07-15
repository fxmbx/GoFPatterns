namespace Builder.FacadeBuilder
{
    public class ContactsJobBuilder : ContactBuilder
    {

        public ContactsJobBuilder(Contact contact)
        {
            //this.contact is from ContactBuilder class
            this.contact = contact;
        }

        public ContactsJobBuilder At(string name){
            contact.CompanyName = name;
            return this;
        }
        public ContactsJobBuilder AsA(string position){
            contact.Position = position;
            return this;
        }

        public ContactsJobBuilder Earning(int amount){
            contact.AnnualIncome = amount;
            return this;
        }
    }
}