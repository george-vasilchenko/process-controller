using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using Newtonsoft.Json;
using ProcessController.Data.Contexts;
using ProcessController.Domain;

namespace ProcessController.Data
{
    public class AppContext : IPersistenceContext<App>
    {
        private readonly IJsonContextConfiguration configuration;

        public AppContext(IJsonContextConfiguration configuration)
        {
            this.configuration = configuration;

            if (!File.Exists(this.configuration.FilePath))
            {
                this.SaveInternal(new Collection<App>());
            }
        }

        public IEnumerable<App> Load()
        {
            var fileContent = File.ReadAllText(this.configuration.FilePath);
            var container = JsonConvert.DeserializeObject<JsonContainer<App>>(fileContent);

            if (container == null)
            {
                throw new NullReferenceException("Json container must is unexpectedly null. Check file content.");
            }

            return container.Elements;
        }

        public void Save(IEnumerable<App> collection)
        {
            if (collection is null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            this.SaveInternal(collection);
        }

        private void SaveInternal(IEnumerable<App> collection)
        {
            var container = JsonConvert.SerializeObject(new JsonContainer<App>(collection));
            File.WriteAllText(this.configuration.FilePath, container);
        }
    }
}