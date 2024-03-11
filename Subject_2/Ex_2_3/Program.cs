namespace Ex_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address organizationAddress = new Address();
            organizationAddress.SetCountry("Беларусь"); 
            organizationAddress.SetCity("Гродно");
            organizationAddress.SetStreet("Советская");
            organizationAddress.SetHouseNumber(13);

            organizationAddress.DisplayAddress();
        }
    }
}