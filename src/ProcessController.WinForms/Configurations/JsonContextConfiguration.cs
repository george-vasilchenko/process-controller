using System;
using System.Configuration;
using ProcessController.Data;

namespace ProcessController.WinForms.Configurations
{
    public class JsonContextConfiguration : IJsonContextConfiguration
    {
        private const string StoreFilePathElementName = "StoreFilePath";

        public JsonContextConfiguration()
        {
            var filePathValue = ConfigurationManager.AppSettings.Get(StoreFilePathElementName);

            if (string.IsNullOrWhiteSpace(filePathValue))
            {
                throw new MissingFieldException($"App setting key {StoreFilePathElementName} is not defined.");
            }

            this.FilePath = filePathValue;
        }

        public string FilePath { get; }
    }
}