using System;

namespace Domain
{
    public class Offender
    {
        public Guid Id { get; set; }
        public string ORI { get; set; }
        public string NIC { get; set; }
        public string NAM { get; set; }
        public string SEX { get; set; }
        public string RAC { get; set; }
        public string ETN { get; set; }
        public string POB { get; set; }
        public string DOB { get; set; }
        public string ORD { get; set; }
        public string ERD { get; set; }
        public string SXP { get; set; }
        public string HGT { get; set; }
        public string WGT { get; set; }
        public string EYE { get; set; }
        public string HAI { get; set; }
        public string FBI { get; set; }
        public string SKN { get; set; }
        public string SMT { get; set; }
        public string FPC { get; set; }
        public string MNU { get; set; }
        public string SOC { get; set; }
        public string OLN { get; set; }
        public string OLS { get; set; }
        public string OLY { get; set; }
        public string CRR { get; set; }
        public string CON { get; set; }
        public string TIR { get; set; }
        public string JUV { get; set; }
        public string PLC { get; set; }
        public string AOV { get; set; }
        public string SOV { get; set; }
        public string ROV { get; set; }
        public string OCA { get; set; }
        public string SID { get; set; }
        public string LKI { get; set; }
        public string LKA { get; set; }
        public string MIS { get; set; }
        public string LIC { get; set; }
        public string LIS { get; set; }
        public string LIY { get; set; }
        public string LIT { get; set; }
        public string VIN { get; set; }
        public string VYR { get; set; }
        public string VMA { get; set; }
        public string VMO { get; set; }
        public string VST { get; set; }
        public string VCO { get; set; }
        public string VOW { get; set; }
        public string OFS { get; set; }
        public string CMC { get; set; }
        public string DNA { get; set; }
        public string DLO { get; set; }
        public string CTZ { get; set; }
        public string ADD { get; set; }
        public string BDA { get; set; }
        public string EDA { get; set; }
        public string SNU { get; set; }
        public string SNA { get; set; }
        public string CTY { get; set; }
        public string COU { get; set; }
        public string STA { get; set; }
        public string ZIP { get; set; }
        public string TNO { get; set; }
        public string TNT { get; set; }
        public string EML { get; set; }
        public string IID { get; set; }
        public string SHN { get; set; }
        public string EMP { get; set; }
        public string OCP { get; set; }
        public string PLN { get; set; }
        public string PLT { get; set; }
        public string REG { get; set; }
        public string RES { get; set; }
        public string REY { get; set; }
        public string BHN { get; set; }
        public string BYR { get; set; }
        public string BMA { get; set; }
        public string BTY { get; set; }
        public string BMO { get; set; }
        public string BCO { get; set; }
        public string BLE { get; set; }
        public string PRO { get; set; }
        public string HUL { get; set; }
        public string HSP { get; set; }
        public string HPT { get; set; }
        public string BNM { get; set; }
        public string CGD { get; set; }
        public string AKA01 { get; set; }
        public string AKA02 { get; set; }
        public string AKA03 { get; set; }
        public string AKA04 { get; set; }
        public string AKA05 { get; set; }
        public string AKA06 { get; set; }

        public Offender()
        {

        }
        public Offender(Offender that) 
        {
            ORI = that.ORI;
            NIC = that.NIC;
            NAM = that.NAM;
            SEX = that.SEX;
            RAC = that.RAC;
            ETN = that.ETN;
            POB = that.POB;
            DOB = that.DOB;
            ORD = that.ORD;
            ERD = that.ERD;
            SXP = that.SXP;
            HGT = that.HGT;
            WGT = that.WGT;
            EYE = that.EYE;
            HAI = that.HAI;
            FBI = that.FBI;
            SKN = that.SKN;
            SMT = that.SMT;
            FPC = that.FPC;
            MNU = that.MNU;
            SOC = that.SOC;
            OLN = that.OLN;
            OLS = that.OLS;
            OLY = that.OLY;
            CRR = that.CRR;
            CON = that.CON;
            TIR = that.TIR;
            JUV = that.JUV;
            PLC = that.PLC;
            AOV = that.AOV;
            SOV = that.SOV;
            ROV = that.ROV;
            OCA = that.OCA;
            SID = that.SID;
            LKI = that.LKI;
            LKA = that.LKA;
            MIS = that.MIS;
            LIC = that.LIC;
            LIS = that.LIS;
            LIY = that.LIY;
            LIT = that.LIT;
            VIN = that.VIN;
            VYR = that.VYR;
            VMA = that.VMA;
            VMO = that.VMO;
            VST = that.VST;
            VCO = that.VCO;
            VOW = that.VOW;
            OFS = that.OFS;
            CMC = that.CMC;
            DNA = that.DNA;
            DLO = that.DLO;
            CTZ = that.CTZ;
            ADD = that.ADD;
            BDA = that.BDA;
            EDA = that.EDA;
            SNU = that.SNU;
            SNA = that.SNA;
            CTY = that.CTY;
            COU = that.COU;
            STA = that.STA;
            ZIP = that.ZIP;
            TNO = that.TNO;
            TNT = that.TNT;
            EML = that.EML;
            IID = that.IID;
            SHN = that.SHN;
            EMP = that.EMP;
            OCP = that.OCP;
            PLN = that.PLN;
            PLT = that.PLT;
            REG = that.REG;
            RES = that.RES;
            REY = that.REY;
            BHN = that.BHN;
            BYR = that.BYR;
            BMA = that.BMA;
            BTY = that.BTY;
            BMO = that.BMO;
            BCO = that.BCO;
            BLE = that.BLE;
            PRO = that.PRO;
            HUL = that.HUL;
            HSP = that.HSP;
            HPT = that.HPT;
            BNM = that.BNM;
            CGD = that.CGD;
            AKA01 = that.AKA01;
            AKA02 = that.AKA02;
            AKA03 = that.AKA03;
            AKA04 = that.AKA04;
            AKA05 = that.AKA05;
            AKA06 = that.AKA06;
        }
    }
}