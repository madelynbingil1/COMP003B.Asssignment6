namespace COMP003B.Assignment6.Services
{
    public class MyTransientService
    {
        private readonly Guid _uniqueId;

        public MyTransientService()
        {
            _uniqueId = Guid.NewGuid();
        }

        public Guid GetUniqueId()
        {
            return _uniqueId;
        }
    }
}