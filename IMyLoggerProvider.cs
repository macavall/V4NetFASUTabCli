

using Azure.Data.Tables;

namespace StartupFAV4Net
{
    public interface IMyLoggerProvider
    {
        public TableServiceClient GetTableClient();
    }
}