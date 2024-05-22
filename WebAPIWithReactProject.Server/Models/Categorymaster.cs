using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Server.Models;

public partial class Categorymaster
{
    public int Srno { get; set; }

    public string? Catcode { get; set; }

    public string? Catname { get; set; }

    public string? P11 { get; set; }

    public string? P32 { get; set; }

    public string? P33 { get; set; }

    public string? P42 { get; set; }

    public string? P43 { get; set; }

    public string? POdd { get; set; }

    public string? PEven { get; set; }

    public string? Errorpunchday { get; set; }

    public string? Iomode { get; set; }

    public string? Setwrkhrs { get; set; }

    public string? Halfdayhrs { get; set; }

    public string? Absenthrs { get; set; }

    public string? Maxhours { get; set; }

    public string? Setot { get; set; }

    public string? Otstarts { get; set; }

    public string? Otonholiday { get; set; }

    public string? Otonwkoff { get; set; }

    public string? Checkintime { get; set; }

    public string? Setpunchtime { get; set; }

    public string? Setroundup { get; set; }

    public string? Rounduptype { get; set; }

    public string? Rounduptime { get; set; }

    public string? Setshortleave { get; set; }

    public string? Leavehrsmonth { get; set; }

    public string? Leavehrsmin { get; set; }

    public string? Setearly { get; set; }

    public string? Setlate { get; set; }

    public string? Latecount { get; set; }

    public string? Afterinterval { get; set; }

    public string? Latededtype { get; set; }

    public string? Latededday { get; set; }

    public string? Lateleavecode { get; set; }

    public string? Setlateearly { get; set; }

    public string? Setcompoff { get; set; }

    public string? Compoffhrs { get; set; }

    public string? Compoffothrs { get; set; }

    public string? Flag { get; set; }

    public string? Notes { get; set; }

    public string? Otaftershift { get; set; }

    public string? Minottime { get; set; }

    public string? Gracelate { get; set; }

    public string? Graceearly { get; set; }

    public string? Lateallowed { get; set; }

    public string? Maxcompoff { get; set; }

    public string? Otdeductbefore { get; set; }

    public string? Otdeductafter { get; set; }

    public string? Otsatrtbeforeshift { get; set; }

    public string? Approveot { get; set; }

    public string? Earlyallowed { get; set; }

    public string? Compid { get; set; }

    public string? Locationid { get; set; }

    public string? Otmaxlimit { get; set; }

    public string? Setotbeforeshift { get; set; }

    public string? Setotaftershift { get; set; }

    public string? Plusminus { get; set; }

    public string? Graceothrs { get; set; }

    public string? Earlyallowedtime { get; set; }

    public string? Usedflag { get; set; }

    public string? Caltype { get; set; }

    public DateTime? Fromdate { get; set; }

    public DateTime? Todate { get; set; }

    public string? Nopunch { get; set; }

    public string? Section { get; set; }

    public string? Compulsarydedbreak { get; set; }

    public string? Dedbreaktime { get; set; }

    public string? HolidayAbsent { get; set; }

    public string? WkoffAbsent { get; set; }

    public string? Contabsdays { get; set; }

    public string? Applylateallowed { get; set; }

    public string? Applyearlyallowed { get; set; }

    public string? Otsetroundup { get; set; }

    public string? Otrounduptype { get; set; }

    public string? Otrounduptime { get; set; }

    public string? Manualpunchlimit { get; set; }

    public string? Setmanualpaunch { get; set; }
}
