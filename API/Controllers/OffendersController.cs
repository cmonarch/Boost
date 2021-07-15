using CsvHelper;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace API.Controllers
{
    public class OffendersController : BaseAPIController
    {

        [HttpGet]
        public List<OffenderModel> Get()
        {
            string path = @"D:\WatchSystems\CSVHelperExample-master\BoostTest_Smaller.csv";
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<OffenderModel>().ToList();
                return records;
            }




            //  return Enumerable.Range(1, 5).Select(index => new OffenderModel
            //  {
            //      MKE = "Test",   //DateTime.Now.AddDays(index),
            //      ORI = "Test 2", //rng.Next(-20, 55),
            //      NIC = "Test 3", 
            //      NAM = "Monarch, Chuck", 
            //      SEX = "M" 
            //  })
            //  .ToList();
        }
    }
}