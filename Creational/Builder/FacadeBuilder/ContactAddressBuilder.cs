namespace Builder.FacadeBuilder
{
    public class ContactAddressBuilder : ContactBuilder
    {
        //might not work with value types... check it out with structs 
        public ContactAddressBuilder(Contact contact)
        {
            this.contact = contact;
        }

        public ContactAddressBuilder At(string steetname){
            contact.StreetAddress = steetname;
            return this;
        }
        public ContactAddressBuilder WithPostCode(string code){
            contact.Postcode = code;
            return this;
        }

        public ContactAddressBuilder In(string city){
            contact.City = city;
            return this;
        }
                // public string StreetAddress, Postcode, City;
 
    }
}