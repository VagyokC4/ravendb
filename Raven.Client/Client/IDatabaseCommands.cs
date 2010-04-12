using System;
using Newtonsoft.Json.Linq;
using Raven.Database;
using Raven.Database.Data;
using Raven.Database.Indexing;

namespace Raven.Client.Client
{
    public interface IDatabaseCommands : IDisposable
	{
		JsonDocument Get(string key);
		string Put(string key, Guid? etag, JObject document, JObject metadata);
		void Delete(string key, Guid? etag);
		string PutIndex(string name, string indexDef);
		QueryResult Query(string index, IndexQuery query);
		void DeleteIndex(string name);
		JArray GetDocuments(int start, int pageSize);
		JArray GetIndexNames(int start, int pageSize);
		JArray GetIndexes(int start, int pageSize);
	}
}