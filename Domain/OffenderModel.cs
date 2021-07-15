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
    }
}