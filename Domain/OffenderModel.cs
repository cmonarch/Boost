using CsvHelper.Configuration.Attributes;

namespace Domain
{
    public class OffenderModel
    {
        [Name(Constants.CsvHeaders.MKE)]
        public string MKE { get; set; }

        [Name(Constants.CsvHeaders.ORI)]
        public string ORI { get; set; }

        [Name(Constants.CsvHeaders.NIC)]
        public string NIC { get; set; }

        [Name(Constants.CsvHeaders.NAM)]
        public string NAM { get; set; }

        [Name(Constants.CsvHeaders.SEX)]
        public string SEX { get; set; }

        [Name(Constants.CsvHeaders.RAC)]
        public string RAC { get; set; }

        [Name(Constants.CsvHeaders.POB)]
        public string POB { get; set; }

        [Name(Constants.CsvHeaders.DOB)]
        public string DOB { get; set; }

        [Name(Constants.CsvHeaders.ORD)]
        public string ORD { get; set; }

        [Name(Constants.CsvHeaders.ERD)]
        public string ERD { get; set; }

        [Name(Constants.CsvHeaders.SXP)]
        public string SXP { get; set; }

        [Name(Constants.CsvHeaders.HGT)]
        public string HGT { get; set; }

        [Name(Constants.CsvHeaders.WGT)]
        public string WGT { get; set; }

        [Name(Constants.CsvHeaders.EYE)]
        public string EYE { get; set; }

        [Name(Constants.CsvHeaders.HAI)]
        public string HAI { get; set; }

        [Name(Constants.CsvHeaders.FBI)]
        public string FBI { get; set; }

    }
}