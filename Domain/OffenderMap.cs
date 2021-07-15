using CsvHelper.Configuration;

namespace Domain
{
    public class OffenderMap : ClassMap<OffenderModel>
    {
        public OffenderMap()
        {
            Map(m => m.MKE).Name(Constants.CsvHeaders.MKE);
            Map(m => m.ORI).Name(Constants.CsvHeaders.ORI);
            Map(m => m.NIC).Name(Constants.CsvHeaders.NIC);
            Map(m => m.NAM).Name(Constants.CsvHeaders.NAM);
            Map(m => m.SEX).Name(Constants.CsvHeaders.SEX);
            // Map(m => m.RAC).Name(Constants.CsvHeaders.RAC);
            // Map(m => m.POB).Name(Constants.CsvHeaders.POB);
            // Map(m => m.DOB).Name(Constants.CsvHeaders.DOB);
            // Map(m => m.ORD).Name(Constants.CsvHeaders.ORD);
            // Map(m => m.ERD).Name(Constants.CsvHeaders.ERD);
            // Map(m => m.SXP).Name(Constants.CsvHeaders.SXP);
            // Map(m => m.HGT).Name(Constants.CsvHeaders.HGT);
            // Map(m => m.WGT).Name(Constants.CsvHeaders.WGT);
            // Map(m => m.EYE).Name(Constants.CsvHeaders.EYE);
            // Map(m => m.HAI).Name(Constants.CsvHeaders.HAI);
            // Map(m => m.FBI).Name(Constants.CsvHeaders.FBI);
        }
    }
}