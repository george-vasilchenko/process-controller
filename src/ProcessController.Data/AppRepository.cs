using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ProcessController.Data.Contexts;
using ProcessController.Data.Repositories;
using ProcessController.Domain;

namespace ProcessController.Data
{
    public class AppRepository : IAppRepository
    {
        private readonly ICollection<App> collection;

        private readonly IPersistenceContext<App> context;

        public AppRepository(IPersistenceContext<App> context)
        {
            this.context = context;
            this.collection = new Collection<App>(this.context.Load().ToList());
        }

        public void Add(IApp app)
        {
            if (app is null)
            {
                throw new ArgumentNullException(nameof(app));
            }

            var newProcess = App.CreateFromSpecification(app);

            this.collection.Add(newProcess);

            this.context.Save(this.collection);
        }

        public IEnumerable<IApp> GetAll()
        {
            return this.collection;
        }

        public IApp GetById(AppId id) => this.collection.Single(o => o.Id.Equals(id));
    }
}