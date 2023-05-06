namespace COMP003B.Assignment6.Services
{
    public class MySingletonService
    {
        private readonly Guid _uniqueId;

        public MySingletonService()
        {
            _uniqueId = Guid.NewGuid();
        }

        public Guid GetUniqueId()
        {
            return _uniqueId;
        }
    }
}