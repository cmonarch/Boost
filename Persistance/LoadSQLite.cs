using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using System;

namespace Persistance
{
    public class LoadSQLite
    {
        public string filePath { get; set; }
        public static async Task Load(DataContext context, string filePath)
        {
            if (context.Offenders.Any()) return;
            
            var offenders = new List<Offender>
            {
                new Offender
                {
                    ORI = "ORI 1",
                    NIC = "NIC 1",
                    NAM = "NAM 1",
                    SEX = "SEX 1",
                    RAC = "RAC 1",
                    ETN = "ETN 1",
                    POB = "POB 1",
                    DOB = "DOB 1",
                    ORD = "ORD 1",
                    ERD = "ERD 1",
                    SXP = "SXP 1",
                    HGT = "HGT 1",
                    WGT = "WGT 1",
                    EYE = "EYE 1",
                    HAI = "HAI 1",
                    FBI = "FBI 1",
                },
                new Offender
                {
                    ORI = "ORI 2",
                    NIC = "NIC 2",
                    NAM = "NAM 2",
                    SEX = "SEX 2",
                    RAC = "RAC 2",
                    ETN = "ETN 2",
                    POB = "POB 2",
                    DOB = "DOB 2",
                    ORD = "ORD 2",
                    ERD = "ERD 2",
                    SXP = "SXP 2",
                    HGT = "HGT 2",
                    WGT = "WGT 2",
                    EYE = "EYE 2",
                    HAI = "HAI 2",
                    FBI = "FBI 2",
                }   
            };

            await context.Offenders.AddRangeAsync(offenders);
            await context.SaveChangesAsync();
        }
    }
}