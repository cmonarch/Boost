using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using System;
using System.IO;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;

namespace Persistance
{
    public class LoadSQLite
    {
        public string filePath { get; set; }
        public static async Task Load(DataContext context, string filePath)
        {
            if (context.Offenders.Any()) return;

            var offenders = new List<Offender>();

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HeaderValidated = null,
                MissingFieldFound = null,
            };
            
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, config))
            {
                var record = new Offender();
                var records = csv.EnumerateRecords(record);
                foreach(var r in records)
                {
                    offenders.Add(new Offender(r)); 
                }
            }

            await context.Offenders.AddRangeAsync(offenders);
            await context.SaveChangesAsync();
        }
    }
}