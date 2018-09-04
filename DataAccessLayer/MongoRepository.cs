using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;

namespace DataAccessLayer
{
    public class MongoRepository<T> : IMongoRepository<T> where T : class
    {
        private readonly IMongoClient _client;

        public MongoRepository(IMongoClient client)
        {
            _client = client;
        }
    }
}
