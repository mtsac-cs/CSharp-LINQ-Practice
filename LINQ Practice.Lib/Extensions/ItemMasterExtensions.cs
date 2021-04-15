using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;

namespace LINQ_Practice.Lib.Extensions
{
    public static class ItemMasterExtensions
    {
        // Default path to Zip file with all item masters. Located in the same directory as the solution
        private static string defaultFilePath = $"{Environment.CurrentDirectory}..\\..\\..\\..\\..\\item_collection.zip";

        public static string ToJson(this ItemMaster self) => JsonConvert.SerializeObject(self, Converter.Settings);

        public static async Task<List<ItemMaster>> LoadFromFile(this List<ItemMaster> itemMasters, string filePath = "")
        {
            if (string.IsNullOrEmpty(filePath))
                filePath = defaultFilePath;

            if (itemMasters.Count > 0) // clear all existing items so only loaded ones are in list
                itemMasters.Clear();

            using (ZipArchive zip = ZipFile.Open(filePath, ZipArchiveMode.Read))
            {
                foreach (ZipArchiveEntry entry in zip.Entries)
                {
                    using (StreamReader sr = new StreamReader(entry.Open()))
                    {
                        var text = await sr.ReadToEndAsync();
                        var itemMaster = ItemMaster.FromJson(text);
                        itemMasters.Add(itemMaster);
                    }
                }
            }

            return itemMasters;
        }
    }
}
