using Azure.Data.Tables;
using System;

namespace StartupFAV4Net
{
    public class MyLoggerProvider : IMyLoggerProvider
    {
        private readonly TableServiceClient _tableClient = new TableServiceClient(Environment.GetEnvironmentVariable("connString"));

        public TableServiceClient GetTableClient()
        {
            return _tableClient;
        }
    }
}