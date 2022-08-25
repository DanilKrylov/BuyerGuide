namespace BuyerGuide.ApplicationInterfaces
{
    public interface IValidator
    {
        bool EmailIsUnique(string email);
    }
}
