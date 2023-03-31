
namespace Arretadinhos.Services.Exceptions
{
    public class DbConcurrenctyException : ApplicationException
    {
        public DbConcurrenctyException(string message) : base(message)
        {
            return;
        }
    }
}