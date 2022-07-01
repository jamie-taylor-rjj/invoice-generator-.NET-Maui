namespace InvoiceGenerator.Maui.Domain
{
    public interface IRepository<T> where T : class
    {
        int Add(T item);
        List<T> GetAll();
    }
}
