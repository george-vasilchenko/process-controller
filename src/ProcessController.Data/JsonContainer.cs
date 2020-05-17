using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ProcessController.Data
{
    public class JsonContainer<TEntity> where TEntity : class
    {
        public JsonContainer(IEnumerable<TEntity> elements)
        {
            this.TimeStamp = DateTime.Now;
            this.Elements = elements;
        }

        [JsonConstructor]
        private JsonContainer()
        {
        }

        [JsonProperty("timeStamp")]
        public DateTime TimeStamp { get; private set; }

        [JsonProperty("elements")]
        public IEnumerable<TEntity> Elements { get; private set; }
    }
}