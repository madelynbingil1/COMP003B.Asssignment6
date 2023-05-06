namespace COMP003B.Assignment6.Services
{
    public class MyScopedService
    {
        private readonly Guid _uniqueId;

        public MyScopedService()
        {
            _uniqueId = Guid.NewGuid();
        }

        public Guid GetUniqueId()
        {
            return _uniqueId;
        }
    }
}