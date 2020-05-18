using System;
using System.Configuration;
using ProcessController.Data;

namespace ProcessController.WinForms.Configurations
{
    public class JsonContextConfiguration : IJsonContextConfiguration
    {
        private const string JsonDataFilePathVariableName = "JsonDataFilePath";

        public JsonContextConfiguration()
        {
            var pathValue = ConfigurationManager.AppSettings.Get(JsonDataFilePathVariableName);

            if (string.IsNullOrWhiteSpace(pathValue))
            {
                throw new MissingFieldException($"App setting key {JsonDataFilePathVariableName} is not defined.");
            }

            this.FilePath = pathValue;
        }

        public string FilePath { get; }
    }
}