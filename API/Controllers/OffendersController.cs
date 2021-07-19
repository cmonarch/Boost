using CsvHelper;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using Microsoft.EntityFrameworkCore;
using Persistance;
using System;

namespace API.Controllers
{
    public class OffendersController : BaseAPIController
    {
        private readonly DataContext _context;
        public OffendersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Offender>>> GetOffenders()
        {
           return await _context.Offenders.ToListAsync(); 
        }

//        [HttpGet("drop")]
      //  public async Task<ActionResult<List<Offender>>> LoadOffenders()
      //  {
  //          string path = @"D:\WatchSystems\CSVHelperExample-master\BoostTest_10rows.csv";

    //       _context.Database.Migrate();
       //    await LoadSQLite.Load(_context, path);
       //    return await _context.Offenders.ToListAsync(); 
//           return null;
     //   }

        [HttpGet("load")]
        public async Task<ActionResult<List<Offender>>> LoadOffenders()
        {
            string path = @"D:\WatchSystems\CSVHelperExample-master\BoostTest_10rows.csv";

           _context.Database.Migrate();
           await LoadSQLite.Load(_context, path);
           return await _context.Offenders.ToListAsync(); 
//           return null;
        }

        [HttpGet("offender/{Id}")]
        public async Task<ActionResult<Offender>> GetOffender(Guid Id)
        {
            return await _context.Offenders.FindAsync(Id);
        }

        [HttpGet("{filecount}")]
        public List<OffenderModel> Get(int filecount)
        {
            string path;
            if(filecount == 10)
            {
              path = @"D:\WatchSystems\CSVHelperExample-master\BoostTest_10rows.csv";
            }
            else if(filecount == 100)
            {
              path = @"D:\WatchSystems\CSVHelperExample-master\BoostTest_100rows.csv";
            }
            else if(filecount == 1000)
            {
              path = @"D:\WatchSystems\CSVHelperExample-master\BoostTest_1000rows.csv";
            }
            else if(filecount == 10000)
            {
              path = @"D:\WatchSystems\CSVHelperExample-master\BoostTest_10000rows.csv";
            }
            else if(filecount == 100000)
            {
              path = @"D:\WatchSystems\CSVHelperExample-master\BoostTest_100000rows.csv";
            }
//            else if(filecount == 1000000)
//            {
//              path = @"D:\WatchSystems\CSVHelperExample-master\BoostTest_1000000rows.csv";
//            }
            else
            {
              path = @"D:\WatchSystems\CSVHelperExample-master\BoostTest_10rows.csv";
            }

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<OffenderModel>().ToList();
                return records;
            }
        }
    }
}