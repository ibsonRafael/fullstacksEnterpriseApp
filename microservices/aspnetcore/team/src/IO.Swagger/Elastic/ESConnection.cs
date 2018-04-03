using System;
using Elasticsearch.Net;
using Nest;
//https://social.technet.microsoft.com/wiki/contents/articles/35095.crud-operation-in-elasticsearch-using-c-and-nest.aspx
//https://bytefish.de/blog/elasticsearch_net/
namespace IO.Swagger.Elastic
{
    public class ESConnection
    {
        public ESConnection()
        {
        }

        public static ElasticClient EsClient()
        {
            ConnectionSettings connectionSettings;
            ElasticClient elasticClient;
            StaticConnectionPool connectionPool;

            //Connection string for Elasticsearch
            /*connectionSettings = new ConnectionSettings(new Uri("http://localhost Jump :9200/")); //local PC
            elasticClient = new ElasticClient(connectionSettings);*/

            //Multiple node for fail over (cluster addresses)
            var nodes = new Uri[]
            {
                new Uri("http://localhost:9200/")
            };

            connectionPool = new StaticConnectionPool(nodes);
            connectionSettings = new ConnectionSettings(connectionPool);
            elasticClient = new ElasticClient(connectionSettings);

            return elasticClient;
        }
    }
}
