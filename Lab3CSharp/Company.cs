
namespace Lab3CSharp
{
    internal class Company
    {
        protected string companyName;
        protected int yearFounded;

        public Company(string name, int year)
        {
            companyName = name;
            yearFounded = year;
        }
        public int GetYearFounded()
        { return yearFounded; }
        public virtual void Show()
        {
            Console.WriteLine($"Company: {companyName}, Year Founded: {yearFounded}");
        }
    }
}
