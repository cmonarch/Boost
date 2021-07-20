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

        //
        // In Postman this is http://localhost:5000/api/offenders
        //
        [HttpGet]
        public async Task<ActionResult<List<Offender>>> GetOffenders()
        {
           return await _context.Offenders.ToListAsync(); 
        }

        //
        // In Postman this is http://localhost:5000/api/offenders/drop
        //
        [HttpGet("drop")]
        public async void DropDatabase()
        {
           await _context.Database.EnsureDeletedAsync();
        }

        //
        // In Postman this is http://localhost:5000/api/offenders/load
        //
        [HttpGet("load")]
        public async Task<ActionResult<List<Offender>>> LoadOffenders()
        {
//            string path = @"D:\UDEMY\test1\Data\BoostTestSetTiny.csv";
            string path = @"D:\UDEMY\test1\Data\BoostTestSetSmall.csv";
//            string path = @"D:\UDEMY\test1\Data\BoostTestSetFull.csv";

           _context.Database.Migrate();
           await LoadSQLite.Load(_context, path);           
           return await _context.Offenders.ToListAsync();   // display what we loaded
        }

        //
        // In Postman this is http://localhost:5000/api/offenders/offender/[guid goes here]
        //
        [HttpGet("offender/{Id}")]
        public async Task<ActionResult<Offender>> GetOffender(Guid Id)
        {
            return await _context.Offenders.FindAsync(Id);
        }

        //
        // In Postman this is http://localhost:5000/api/offenders/[10, 100, 1000, 10000, 100000]
        //
        [HttpGet("{filecount}")]
        public List<OffenderModel> Get(int filecount)
        {
            string path;
            if(filecount == 10)
            {
              path = @"D:\UDEMY\test1\Data\BoostTest_10rows.csv";
            }
            else if(filecount == 100)
            {
              path = @"D:\UDEMY\test1\Data\BoostTest_100rows.csv";
            }
            else if(filecount == 1000)
            {
              path = @"D:\UDEMY\test1\Data\BoostTest_1000rows.csv";
            }
            else if(filecount == 10000)
            {
              path = @"D:\UDEMY\test1\Data\BoostTest_10000rows.csv";
            }
            else if(filecount == 100000)
            {
              path = @"D:\UDEMY\test1\Data\BoostTest_100000rows.csv";
            }
            else
            {
              path = @"D:\UDEMY\test1\Data\BoostTest_10rows.csv";
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