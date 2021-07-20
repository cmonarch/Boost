using CsvHelper.Configuration.Attributes;

namespace Domain
{
    public class OffenderModel
    {
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

        [Name(Constants.CsvHeaders.ETN)]
        public string ETN { get; set; }

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

        [Name(Constants.CsvHeaders.SKN)]
        public string SKN { get; set; }

        [Name(Constants.CsvHeaders.SMT)]
        public string SMT { get; set; }

        [Name(Constants.CsvHeaders.FPC)]
        public string FPC { get; set; }

        [Name(Constants.CsvHeaders.MNU)]
        public string MNU { get; set; }

        [Name(Constants.CsvHeaders.SOC)]
        public string SOC { get; set; }

        [Name(Constants.CsvHeaders.OLN)]
        public string OLN { get; set; }

        [Name(Constants.CsvHeaders.OLS)]
        public string OLS { get; set; }

        [Name(Constants.CsvHeaders.OLY)]
        public string OLY { get; set; }

        [Name(Constants.CsvHeaders.CRR)]
        public string CRR { get; set; }

        [Name(Constants.CsvHeaders.CON)]
        public string CON { get; set; }

        [Name(Constants.CsvHeaders.TIR)]
        public string TIR { get; set; }

        [Name(Constants.CsvHeaders.JUV)]
        public string JUV { get; set; }

        [Name(Constants.CsvHeaders.PLC)]
        public string PLC { get; set; }

        [Name(Constants.CsvHeaders.AOV)]
        public string AOV { get; set; }

        [Name(Constants.CsvHeaders.SOV)]
        public string SOV { get; set; }

        [Name(Constants.CsvHeaders.ROV)]
        public string ROV { get; set; }

        [Name(Constants.CsvHeaders.OCA)]
        public string OCA { get; set; }

        [Name(Constants.CsvHeaders.SID)]
        public string SID { get; set; }

        [Name(Constants.CsvHeaders.LKI)]
        public string LKI { get; set; }

        [Name(Constants.CsvHeaders.LKA)]
        public string LKA { get; set; }

        [Name(Constants.CsvHeaders.MIS)]
        public string MIS { get; set; }

        [Name(Constants.CsvHeaders.LIC)]
        public string LIC { get; set; }

        [Name(Constants.CsvHeaders.LIS)]
        public string LIS { get; set; }

        [Name(Constants.CsvHeaders.LIY)]
        public string LIY { get; set; }

        [Name(Constants.CsvHeaders.LIT)]
        public string LIT { get; set; }

        [Name(Constants.CsvHeaders.VIN)]
        public string VIN { get; set; }

        [Name(Constants.CsvHeaders.VYR)]
        public string VYR { get; set; }

        [Name(Constants.CsvHeaders.VMA)]
        public string VMA { get; set; }

        [Name(Constants.CsvHeaders.VMO)]
        public string VMO { get; set; }

        [Name(Constants.CsvHeaders.VST)]
        public string VST { get; set; }

        [Name(Constants.CsvHeaders.VCO)]
        public string VCO { get; set; }

        [Name(Constants.CsvHeaders.VOW)]
        public string VOW { get; set; }

        [Name(Constants.CsvHeaders.OFS)]
        public string OFS { get; set; }

        [Name(Constants.CsvHeaders.CMC)]
        public string CMC { get; set; }

        [Name(Constants.CsvHeaders.DNA)]
        public string DNA { get; set; }

        [Name(Constants.CsvHeaders.DLO)]
        public string DLO { get; set; }

        [Name(Constants.CsvHeaders.CTZ)]
        public string CTZ { get; set; }

        [Name(Constants.CsvHeaders.ADD)]
        public string ADD { get; set; }

        [Name(Constants.CsvHeaders.BDA)]
        public string BDA { get; set; }

        [Name(Constants.CsvHeaders.EDA)]
        public string EDA { get; set; }

        [Name(Constants.CsvHeaders.SNU)]
        public string SNU { get; set; }

        [Name(Constants.CsvHeaders.SNA)]
        public string SNA { get; set; }

        [Name(Constants.CsvHeaders.CTY)]
        public string CTY { get; set; }

        [Name(Constants.CsvHeaders.COU)]
        public string COU { get; set; }

        [Name(Constants.CsvHeaders.STA)]
        public string STA { get; set; }

        [Name(Constants.CsvHeaders.ZIP)]
        public string ZIP { get; set; }

        [Name(Constants.CsvHeaders.TNO)]
        public string TNO { get; set; }

        [Name(Constants.CsvHeaders.TNT)]
        public string TNT { get; set; }

        [Name(Constants.CsvHeaders.EML)]
        public string EML { get; set; }

        [Name(Constants.CsvHeaders.IID)]
        public string IID { get; set; }

        [Name(Constants.CsvHeaders.SHN)]
        public string SHN { get; set; }

        [Name(Constants.CsvHeaders.EMP)]
        public string EMP { get; set; }

        [Name(Constants.CsvHeaders.OCP)]
        public string OCP { get; set; }

        [Name(Constants.CsvHeaders.PLN)]
        public string PLN { get; set; }

        [Name(Constants.CsvHeaders.PLT)]
        public string PLT { get; set; }

        [Name(Constants.CsvHeaders.REG)]
        public string REG { get; set; }

        [Name(Constants.CsvHeaders.RES)]
        public string RES { get; set; }

        [Name(Constants.CsvHeaders.REY)]
        public string REY { get; set; }

        [Name(Constants.CsvHeaders.BHN)]
        public string BHN { get; set; }

        [Name(Constants.CsvHeaders.BYR)]
        public string BYR { get; set; }

        [Name(Constants.CsvHeaders.BMA)]
        public string BMA { get; set; }

        [Name(Constants.CsvHeaders.BTY)]
        public string BTY { get; set; }

        [Name(Constants.CsvHeaders.BMO)]
        public string BMO { get; set; }

        [Name(Constants.CsvHeaders.BCO)]
        public string BCO { get; set; }

        [Name(Constants.CsvHeaders.BLE)]
        public string BLE { get; set; }

        [Name(Constants.CsvHeaders.PRO)]
        public string PRO { get; set; }

        [Name(Constants.CsvHeaders.HUL)]
        public string HUL { get; set; }

        [Name(Constants.CsvHeaders.HSP)]
        public string HSP { get; set; }

        [Name(Constants.CsvHeaders.HPT)]
        public string HPT { get; set; }

        [Name(Constants.CsvHeaders.BNM)]
        public string BNM { get; set; }

        [Name(Constants.CsvHeaders.CGD)]
        public string CGD { get; set; }

        [Name(Constants.CsvHeaders.AKA01)]
        public string AKA01 { get; set; }

        [Name(Constants.CsvHeaders.AKA02)]
        public string AKA02 { get; set; }

        [Name(Constants.CsvHeaders.AKA03)]
        public string AKA03 { get; set; }

        [Name(Constants.CsvHeaders.AKA04)]
        public string AKA04 { get; set; }

        [Name(Constants.CsvHeaders.AKA05)]
        public string AKA05 { get; set; }

        [Name(Constants.CsvHeaders.AKA06)]
        public string AKA06 { get; set; }
    }
}