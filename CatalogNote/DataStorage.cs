using System;
using System.IO;
using System.Runtime.Serialization.Json;

namespace CatalogNote
{
    internal static class DataStorage
    {
        private static readonly string FilePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "catalog.json");

        public static CatalogData Load()
        {
            if (!File.Exists(FilePath))
                return new CatalogData();

            using (FileStream fs = File.OpenRead(FilePath))
            {
                var serializer = new DataContractJsonSerializer(typeof(CatalogData));
                return (CatalogData)serializer.ReadObject(fs);
            }
        }

        public static void Save(CatalogData data)
        {
            using (FileStream fs = File.Create(FilePath))
            {
                var serializer = new DataContractJsonSerializer(typeof(CatalogData));
                serializer.WriteObject(fs, data);
            }
        }
    }
}
