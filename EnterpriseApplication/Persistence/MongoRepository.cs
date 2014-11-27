using MongoDB.Driver;

namespace Persistence
{
    public class MongoRepository
    {
        readonly MongoClient mongo;

        public MongoRepository(MongoClient mongo)
        {
            this.mongo = mongo;
        }

        protected MongoDatabase Database
        {
            get
            {
                var server = mongo.GetServer();
                return server.GetDatabase("EnterpriseApplication");
            }
        }
    }
}
