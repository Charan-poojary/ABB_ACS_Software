using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebAPIWithReactProject.Server.Models;

public partial class BpclWarangalAuditDbContext : DbContext
{
    public BpclWarangalAuditDbContext()
    {
    }

    public BpclWarangalAuditDbContext(DbContextOptions<BpclWarangalAuditDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccFormDetail> AccFormDetails { get; set; }

    public virtual DbSet<AccGraph> AccGraphs { get; set; }

    public virtual DbSet<AccMastercontroller> AccMastercontrollers { get; set; }

    public virtual DbSet<AccMastergraph> AccMastergraphs { get; set; }

    public virtual DbSet<AccMasterreader> AccMasterreaders { get; set; }

    public virtual DbSet<AccMastertz> AccMastertzs { get; set; }

    public virtual DbSet<AccTran> AccTrans { get; set; }

    public virtual DbSet<AccUserRight> AccUserRights { get; set; }

    public virtual DbSet<AccauditLog> AccauditLogs { get; set; }

    public virtual DbSet<Accauthtypemaster> Accauthtypemasters { get; set; }

    public virtual DbSet<AccessHoliday> AccessHolidays { get; set; }

    public virtual DbSet<Accesstimesupload> Accesstimesuploads { get; set; }

    public virtual DbSet<Acscard> Acscards { get; set; }

    public virtual DbSet<Acsetting> Acsettings { get; set; }

    public virtual DbSet<Activitylog> Activitylogs { get; set; }

    public virtual DbSet<Activitymaster> Activitymasters { get; set; }

    public virtual DbSet<Acueventlog> Acueventlogs { get; set; }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Alarmlog> Alarmlogs { get; set; }

    public virtual DbSet<Alarmsetting> Alarmsettings { get; set; }

    public virtual DbSet<Alarmsupload> Alarmsuploads { get; set; }

    public virtual DbSet<Alertlog> Alertlogs { get; set; }

    public virtual DbSet<Alertsetting> Alertsettings { get; set; }

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<Appointmentsetting> Appointmentsettings { get; set; }

    public virtual DbSet<ApprovedOt> ApprovedOts { get; set; }

    public virtual DbSet<AttGraph> AttGraphs { get; set; }

    public virtual DbSet<AttMastergraph> AttMastergraphs { get; set; }

    public virtual DbSet<AttReader> AttReaders { get; set; }

    public virtual DbSet<AuditLog> AuditLogs { get; set; }

    public virtual DbSet<AuditLogclm> AuditLogclms { get; set; }

    public virtual DbSet<Backuplog> Backuplogs { get; set; }

    public virtual DbSet<Backupsetting> Backupsettings { get; set; }

    public virtual DbSet<Banlist> Banlists { get; set; }

    public virtual DbSet<BioMetric> BioMetrics { get; set; }

    public virtual DbSet<BuildingMaster> BuildingMasters { get; set; }

    public virtual DbSet<BusMaster> BusMasters { get; set; }

    public virtual DbSet<CExtraDatum> CExtraData { get; set; }

    public virtual DbSet<Camset> Camsets { get; set; }

    public virtual DbSet<CanteenTransaction> CanteenTransactions { get; set; }

    public virtual DbSet<CanteenTransactionDetail> CanteenTransactionDetails { get; set; }

    public virtual DbSet<CardFormat> CardFormats { get; set; }

    public virtual DbSet<Carddatum> Carddata { get; set; }

    public virtual DbSet<Cardmaster> Cardmasters { get; set; }

    public virtual DbSet<Cardsetting> Cardsettings { get; set; }

    public virtual DbSet<Cardstoregister> Cardstoregisters { get; set; }

    public virtual DbSet<Cardstounregister> Cardstounregisters { get; set; }

    public virtual DbSet<Categorymaster> Categorymasters { get; set; }

    public virtual DbSet<Cinterface> Cinterfaces { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Clientcount> Clientcounts { get; set; }

    public virtual DbSet<Clientdetail> Clientdetails { get; set; }

    public virtual DbSet<ClmsEmaillog> ClmsEmaillogs { get; set; }

    public virtual DbSet<ClmsEmailsetting> ClmsEmailsettings { get; set; }

    public virtual DbSet<Clmscategorymaster> Clmscategorymasters { get; set; }

    public virtual DbSet<Clmsdesklog> Clmsdesklogs { get; set; }

    public virtual DbSet<Clog> Clogs { get; set; }

    public virtual DbSet<ComOffrequest> ComOffrequests { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<CompanyMaster> CompanyMasters { get; set; }

    public virtual DbSet<Compoffdatum> Compoffdata { get; set; }

    public virtual DbSet<Condone> Condones { get; set; }

    public virtual DbSet<CondoneEntryRequest> CondoneEntryRequests { get; set; }

    public virtual DbSet<ConfigFile> ConfigFiles { get; set; }

    public virtual DbSet<ContractDatum> ContractData { get; set; }

    public virtual DbSet<ContractGatepassdetail> ContractGatepassdetails { get; set; }

    public virtual DbSet<ContractVisitor> ContractVisitors { get; set; }

    public virtual DbSet<Contractortype> Contractortypes { get; set; }

    public virtual DbSet<ControlTaskLog> ControlTaskLogs { get; set; }

    public virtual DbSet<Countrymaster> Countrymasters { get; set; }

    public virtual DbSet<Currentprocess> Currentprocesses { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Dashboardsetting> Dashboardsettings { get; set; }

    public virtual DbSet<Dateconfiguration> Dateconfigurations { get; set; }

    public virtual DbSet<Delemployee> Delemployees { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<DeptCode> DeptCodes { get; set; }

    public virtual DbSet<DescMaster> DescMasters { get; set; }

    public virtual DbSet<DeviceAccessgroup> DeviceAccessgroups { get; set; }

    public virtual DbSet<DeviceElevator> DeviceElevators { get; set; }

    public virtual DbSet<DeviceInterface> DeviceInterfaces { get; set; }

    public virtual DbSet<DeviceIorule> DeviceIorules { get; set; }

    public virtual DbSet<DeviceLog> DeviceLogs { get; set; }

    public virtual DbSet<DeviceMultiman> DeviceMultimen { get; set; }

    public virtual DbSet<DeviceReader> DeviceReaders { get; set; }

    public virtual DbSet<DeviceSetting> DeviceSettings { get; set; }

    public virtual DbSet<DeviceStatus> DeviceStatuses { get; set; }

    public virtual DbSet<Devicetran> Devicetrans { get; set; }

    public virtual DbSet<Dfalarm> Dfalarms { get; set; }

    public virtual DbSet<DistrictMaster> DistrictMasters { get; set; }

    public virtual DbSet<DoorControl> DoorControls { get; set; }

    public virtual DbSet<DriverDetail> DriverDetails { get; set; }

    public virtual DbSet<Emailalert> Emailalerts { get; set; }

    public virtual DbSet<Emailalertlog> Emailalertlogs { get; set; }

    public virtual DbSet<Emailid> Emailids { get; set; }

    public virtual DbSet<Emailsetting> Emailsettings { get; set; }

    public virtual DbSet<EmpCardUpload> EmpCardUploads { get; set; }

    public virtual DbSet<EmpCatMaster> EmpCatMasters { get; set; }

    public virtual DbSet<EmpClassification> EmpClassifications { get; set; }

    public virtual DbSet<EmpDeptMaster> EmpDeptMasters { get; set; }

    public virtual DbSet<EmpRoaster> EmpRoasters { get; set; }

    public virtual DbSet<EmpShiftMaster> EmpShiftMasters { get; set; }

    public virtual DbSet<EmpViolationStatus> EmpViolationStatuses { get; set; }

    public virtual DbSet<Empimage> Empimages { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Employee2> Employee2s { get; set; }

    public virtual DbSet<EmployeeLeave> EmployeeLeaves { get; set; }

    public virtual DbSet<Employeeawayentry> Employeeawayentries { get; set; }

    public virtual DbSet<Employeepassentry> Employeepassentries { get; set; }

    public virtual DbSet<Employeerenewcancel> Employeerenewcancels { get; set; }

    public virtual DbSet<Empviewreport> Empviewreports { get; set; }

    public virtual DbSet<Engineer> Engineers { get; set; }

    public virtual DbSet<Erpreportsetting> Erpreportsettings { get; set; }

    public virtual DbSet<Errorlog> Errorlogs { get; set; }

    public virtual DbSet<EventMaster> EventMasters { get; set; }

    public virtual DbSet<Failedapihit> Failedapihits { get; set; }

    public virtual DbSet<Failnotify> Failnotifies { get; set; }

    public virtual DbSet<FloorMaster> FloorMasters { get; set; }

    public virtual DbSet<FormDetail> FormDetails { get; set; }

    public virtual DbSet<FormatsUpload> FormatsUploads { get; set; }

    public virtual DbSet<Fpmaster> Fpmasters { get; set; }

    public virtual DbSet<Fptemplate> Fptemplates { get; set; }

    public virtual DbSet<FptemplatesDriver> FptemplatesDrivers { get; set; }

    public virtual DbSet<FptemplatesHelper> FptemplatesHelpers { get; set; }

    public virtual DbSet<Fptemplatescontractvisitor> Fptemplatescontractvisitors { get; set; }

    public virtual DbSet<Fptemplatesvisitor> Fptemplatesvisitors { get; set; }

    public virtual DbSet<GadgetAllowed> GadgetAlloweds { get; set; }

    public virtual DbSet<Gatedetail> Gatedetails { get; set; }

    public virtual DbSet<GatepassProfile> GatepassProfiles { get; set; }

    public virtual DbSet<Gatepassdetail> Gatepassdetails { get; set; }

    public virtual DbSet<Gatepassentry> Gatepassentries { get; set; }

    public virtual DbSet<HEvent> HEvents { get; set; }

    public virtual DbSet<HelperDetail> HelperDetails { get; set; }

    public virtual DbSet<HiMajorevent> HiMajorevents { get; set; }

    public virtual DbSet<HiMasterapb> HiMasterapbs { get; set; }

    public virtual DbSet<HiMinorevent> HiMinorevents { get; set; }

    public virtual DbSet<HikIorule> HikIorules { get; set; }

    public virtual DbSet<Htmplogtbl> Htmplogtbls { get; set; }

    public virtual DbSet<Htmplogtbl2> Htmplogtbl2s { get; set; }

    public virtual DbSet<IdproofType> IdproofTypes { get; set; }

    public virtual DbSet<Imagemaster> Imagemasters { get; set; }

    public virtual DbSet<Imgpath> Imgpaths { get; set; }

    public virtual DbSet<Input> Inputs { get; set; }

    public virtual DbSet<Iofunction> Iofunctions { get; set; }

    public virtual DbSet<IolinkerRule> IolinkerRules { get; set; }

    public virtual DbSet<IolinkerUpload> IolinkerUploads { get; set; }

    public virtual DbSet<Iorule> Iorules { get; set; }

    public virtual DbSet<Iostatus> Iostatuses { get; set; }

    public virtual DbSet<IsecureEmailLog> IsecureEmailLogs { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<Laptopassignmentsetting> Laptopassignmentsettings { get; set; }

    public virtual DbSet<Lateearlypenalty> Lateearlypenalties { get; set; }

    public virtual DbSet<LeaveAccumulation> LeaveAccumulations { get; set; }

    public virtual DbSet<LeaveAllocation> LeaveAllocations { get; set; }

    public virtual DbSet<LeaveDetail> LeaveDetails { get; set; }

    public virtual DbSet<LeaveMaster> LeaveMasters { get; set; }

    public virtual DbSet<LeaveRule> LeaveRules { get; set; }

    public virtual DbSet<LeaveYear> LeaveYears { get; set; }

    public virtual DbSet<Leavelock> Leavelocks { get; set; }

    public virtual DbSet<Leaverequest> Leaverequests { get; set; }

    public virtual DbSet<Leavesanctioned> Leavesanctioneds { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<LocationMaster> LocationMasters { get; set; }

    public virtual DbSet<Locationlinkvm> Locationlinkvms { get; set; }

    public virtual DbSet<Logtbl> Logtbls { get; set; }

    public virtual DbSet<Lookupmaster> Lookupmasters { get; set; }

    public virtual DbSet<Lwp> Lwps { get; set; }

    public virtual DbSet<MHoliday> MHolidays { get; set; }

    public virtual DbSet<MLeaf> MLeaves { get; set; }

    public virtual DbSet<ManualPunchRequest> ManualPunchRequests { get; set; }

    public virtual DbSet<MasterControllerType> MasterControllerTypes { get; set; }

    public virtual DbSet<Masterag> Masterags { get; set; }

    public virtual DbSet<Masteragdetail> Masteragdetails { get; set; }

    public virtual DbSet<Masteragupload> Masteraguploads { get; set; }

    public virtual DbSet<Masterapbzone> Masterapbzones { get; set; }

    public virtual DbSet<Masterassetassignment> Masterassetassignments { get; set; }

    public virtual DbSet<Masterassetsetting> Masterassetsettings { get; set; }

    public virtual DbSet<Masterassettype> Masterassettypes { get; set; }

    public virtual DbSet<Masterat> Masterats { get; set; }

    public virtual DbSet<Masteratdetail> Masteratdetails { get; set; }

    public virtual DbSet<Mastercardassignment> Mastercardassignments { get; set; }

    public virtual DbSet<Mastercardinventory> Mastercardinventories { get; set; }

    public virtual DbSet<Mastercontroller> Mastercontrollers { get; set; }

    public virtual DbSet<Masterdg> Masterdgs { get; set; }

    public virtual DbSet<Masterdgdetail> Masterdgdetails { get; set; }

    public virtual DbSet<Masterdgupload> Masterdguploads { get; set; }

    public virtual DbSet<Masterdsg> Masterdsgs { get; set; }

    public virtual DbSet<Masterdtz> Masterdtzs { get; set; }

    public virtual DbSet<Masterdtzdetail> Masterdtzdetails { get; set; }

    public virtual DbSet<Mastereg> Masteregs { get; set; }

    public virtual DbSet<Masteregdetail> Masteregdetails { get; set; }

    public virtual DbSet<Mastereventsv> Mastereventsvs { get; set; }

    public virtual DbSet<Masterfc> Masterfcs { get; set; }

    public virtual DbSet<Masterhg> Masterhgs { get; set; }

    public virtual DbSet<Masterhgdetail> Masterhgdetails { get; set; }

    public virtual DbSet<Masterhgupload> Masterhguploads { get; set; }

    public virtual DbSet<Masterig> Masterigs { get; set; }

    public virtual DbSet<Masterigdetail> Masterigdetails { get; set; }

    public virtual DbSet<Masterinput> Masterinputs { get; set; }

    public virtual DbSet<Masterlaptop> Masterlaptops { get; set; }

    public virtual DbSet<Masterlaptopassignment> Masterlaptopassignments { get; set; }

    public virtual DbSet<Masterlift> Masterlifts { get; set; }

    public virtual DbSet<Masterliftdetail> Masterliftdetails { get; set; }

    public virtual DbSet<Masterlocksetting> Masterlocksettings { get; set; }

    public virtual DbSet<Mastermsgdetail> Mastermsgdetails { get; set; }

    public virtual DbSet<Masteroutput> Masteroutputs { get; set; }

    public virtual DbSet<Masterpartition> Masterpartitions { get; set; }

    public virtual DbSet<Masterpass> Masterpasses { get; set; }

    public virtual DbSet<Masterreader> Masterreaders { get; set; }

    public virtual DbSet<Masterrole> Masterroles { get; set; }

    public virtual DbSet<Mastersg> Mastersgs { get; set; }

    public virtual DbSet<Mastersgdetail> Mastersgdetails { get; set; }

    public virtual DbSet<Mastersgupload> Mastersguploads { get; set; }

    public virtual DbSet<Mastertz> Mastertzs { get; set; }

    public virtual DbSet<Mastertzdetail> Mastertzdetails { get; set; }

    public virtual DbSet<Mastervagdetail> Mastervagdetails { get; set; }

    public virtual DbSet<Mastervehicle> Mastervehicles { get; set; }

    public virtual DbSet<Masterzone> Masterzones { get; set; }

    public virtual DbSet<Masterzonedetail> Masterzonedetails { get; set; }

    public virtual DbSet<Masterzonev> Masterzonevs { get; set; }

    public virtual DbSet<MaterialEmailMaster> MaterialEmailMasters { get; set; }

    public virtual DbSet<MaterialMaster> MaterialMasters { get; set; }

    public virtual DbSet<Mcsetting> Mcsettings { get; set; }

    public virtual DbSet<MenuMaster> MenuMasters { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<Mobileno> Mobilenos { get; set; }

    public virtual DbSet<Monthpass> Monthpasses { get; set; }

    public virtual DbSet<Mtmplogtbl> Mtmplogtbls { get; set; }

    public virtual DbSet<Mtmplogtbl2> Mtmplogtbl2s { get; set; }

    public virtual DbSet<Multimandetail> Multimandetails { get; set; }

    public virtual DbSet<Multimanmaster> Multimanmasters { get; set; }

    public virtual DbSet<Muster> Musters { get; set; }

    public virtual DbSet<NationalityMaster> NationalityMasters { get; set; }

    public virtual DbSet<NewCompOffRequest> NewCompOffRequests { get; set; }

    public virtual DbSet<Newsection> Newsections { get; set; }

    public virtual DbSet<Odentry> Odentries { get; set; }

    public virtual DbSet<OdentryRequest> OdentryRequests { get; set; }

    public virtual DbSet<Odrequest> Odrequests { get; set; }

    public virtual DbSet<Odrequestnew> Odrequestnews { get; set; }

    public virtual DbSet<Organizational> Organizationals { get; set; }

    public virtual DbSet<Orglogo> Orglogos { get; set; }

    public virtual DbSet<Otptransaction> Otptransactions { get; set; }

    public virtual DbSet<Output> Outputs { get; set; }

    public virtual DbSet<PeerGroup> PeerGroups { get; set; }

    public virtual DbSet<PendingAppointment> PendingAppointments { get; set; }

    public virtual DbSet<Pendingactivity> Pendingactivities { get; set; }

    public virtual DbSet<Preapprovelist> Preapprovelists { get; set; }

    public virtual DbSet<ProcessData012022> ProcessData012022s { get; set; }

    public virtual DbSet<ProcessData012023> ProcessData012023s { get; set; }

    public virtual DbSet<ProcessData012024> ProcessData012024s { get; set; }

    public virtual DbSet<ProcessData022022> ProcessData022022s { get; set; }

    public virtual DbSet<ProcessData022023> ProcessData022023s { get; set; }

    public virtual DbSet<ProcessData022024> ProcessData022024s { get; set; }

    public virtual DbSet<ProcessData032022> ProcessData032022s { get; set; }

    public virtual DbSet<ProcessData032023> ProcessData032023s { get; set; }

    public virtual DbSet<ProcessData042022> ProcessData042022s { get; set; }

    public virtual DbSet<ProcessData042023> ProcessData042023s { get; set; }

    public virtual DbSet<ProcessData052022> ProcessData052022s { get; set; }

    public virtual DbSet<ProcessData052023> ProcessData052023s { get; set; }

    public virtual DbSet<ProcessData062022> ProcessData062022s { get; set; }

    public virtual DbSet<ProcessData062023> ProcessData062023s { get; set; }

    public virtual DbSet<ProcessData072022> ProcessData072022s { get; set; }

    public virtual DbSet<ProcessData072023> ProcessData072023s { get; set; }

    public virtual DbSet<ProcessData082022> ProcessData082022s { get; set; }

    public virtual DbSet<ProcessData082023> ProcessData082023s { get; set; }

    public virtual DbSet<ProcessData092022> ProcessData092022s { get; set; }

    public virtual DbSet<ProcessData092023> ProcessData092023s { get; set; }

    public virtual DbSet<ProcessData102021> ProcessData102021s { get; set; }

    public virtual DbSet<ProcessData102022> ProcessData102022s { get; set; }

    public virtual DbSet<ProcessData102023> ProcessData102023s { get; set; }

    public virtual DbSet<ProcessData112021> ProcessData112021s { get; set; }

    public virtual DbSet<ProcessData112022> ProcessData112022s { get; set; }

    public virtual DbSet<ProcessData112023> ProcessData112023s { get; set; }

    public virtual DbSet<ProcessData122021> ProcessData122021s { get; set; }

    public virtual DbSet<ProcessData122022> ProcessData122022s { get; set; }

    public virtual DbSet<ProcessData122023> ProcessData122023s { get; set; }

    public virtual DbSet<ProcessDatum> ProcessData { get; set; }

    public virtual DbSet<Profile> Profiles { get; set; }

    public virtual DbSet<ProfileFormDetail> ProfileFormDetails { get; set; }

    public virtual DbSet<ProfileImage> ProfileImages { get; set; }

    public virtual DbSet<ProfileLine> ProfileLines { get; set; }

    public virtual DbSet<ProfileMaster> ProfileMasters { get; set; }

    public virtual DbSet<Projectmaster> Projectmasters { get; set; }

    public virtual DbSet<Projectnamemaster> Projectnamemasters { get; set; }

    public virtual DbSet<Purpose> Purposes { get; set; }

    public virtual DbSet<Recharge> Recharges { get; set; }

    public virtual DbSet<Registerkey> Registerkeys { get; set; }

    public virtual DbSet<Removedwatchlist> Removedwatchlists { get; set; }

    public virtual DbSet<Reportsetting> Reportsettings { get; set; }

    public virtual DbSet<RequestAppointment> RequestAppointments { get; set; }

    public virtual DbSet<RequestMail> RequestMails { get; set; }

    public virtual DbSet<RewardSafetyvoilation> RewardSafetyvoilations { get; set; }

    public virtual DbSet<RoasterDaily> RoasterDailies { get; set; }

    public virtual DbSet<RoasterMaster> RoasterMasters { get; set; }

    public virtual DbSet<RoasterMonthly> RoasterMonthlies { get; set; }

    public virtual DbSet<RoasterWeekly> RoasterWeeklies { get; set; }

    public virtual DbSet<Rosterdetail> Rosterdetails { get; set; }

    public virtual DbSet<Safetylog> Safetylogs { get; set; }

    public virtual DbSet<Scandoc> Scandocs { get; set; }

    public virtual DbSet<Sectionmaster> Sectionmasters { get; set; }

    public virtual DbSet<Securitymessage> Securitymessages { get; set; }

    public virtual DbSet<Serverauth> Serverauths { get; set; }

    public virtual DbSet<Servicestatus> Servicestatuses { get; set; }

    public virtual DbSet<SetAccesstime> SetAccesstimes { get; set; }

    public virtual DbSet<SetDoorMonitor> SetDoorMonitors { get; set; }

    public virtual DbSet<SetMemoryAddress> SetMemoryAddresses { get; set; }

    public virtual DbSet<SetMonitor> SetMonitors { get; set; }

    public virtual DbSet<SetPortNo> SetPortNos { get; set; }

    public virtual DbSet<Setcolour> Setcolours { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<ShiftCalendar> ShiftCalendars { get; set; }

    public virtual DbSet<ShiftGroup> ShiftGroups { get; set; }

    public virtual DbSet<ShiftRoster> ShiftRosters { get; set; }

    public virtual DbSet<Shiftmaster> Shiftmasters { get; set; }

    public virtual DbSet<SignatureMaster> SignatureMasters { get; set; }

    public virtual DbSet<Sm> Sms { get; set; }

    public virtual DbSet<Smsgatewaysetting> Smsgatewaysettings { get; set; }

    public virtual DbSet<Smssetting> Smssettings { get; set; }

    public virtual DbSet<Smssetting1> Smssettings1 { get; set; }

    public virtual DbSet<StateMaster> StateMasters { get; set; }

    public virtual DbSet<Stmplogtbl> Stmplogtbls { get; set; }

    public virtual DbSet<Stmplogtbl2> Stmplogtbl2s { get; set; }

    public virtual DbSet<Supremafptemplate> Supremafptemplates { get; set; }

    public virtual DbSet<TalukaMaster> TalukaMasters { get; set; }

    public virtual DbSet<TblVendor> TblVendors { get; set; }

    public virtual DbSet<TblWorkorder> TblWorkorders { get; set; }

    public virtual DbSet<Teammaster> Teammasters { get; set; }

    public virtual DbSet<TempapprovedOt> TempapprovedOts { get; set; }

    public virtual DbSet<Tempemployee> Tempemployees { get; set; }

    public virtual DbSet<Tempimage> Tempimages { get; set; }

    public virtual DbSet<Tempscandoc> Tempscandocs { get; set; }

    public virtual DbSet<Timesheet> Timesheets { get; set; }

    public virtual DbSet<Tmplogtbl> Tmplogtbls { get; set; }

    public virtual DbSet<Tmplogtbl2> Tmplogtbl2s { get; set; }

    public virtual DbSet<Tokendetail> Tokendetails { get; set; }

    public virtual DbSet<TourEntry> TourEntries { get; set; }

    public virtual DbSet<TourEntryRequest> TourEntryRequests { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    public virtual DbSet<TransactionConfiguration> TransactionConfigurations { get; set; }

    public virtual DbSet<Transactions012022> Transactions012022s { get; set; }

    public virtual DbSet<Transactions012023> Transactions012023s { get; set; }

    public virtual DbSet<Transactions012024> Transactions012024s { get; set; }

    public virtual DbSet<Transactions022022> Transactions022022s { get; set; }

    public virtual DbSet<Transactions022023> Transactions022023s { get; set; }

    public virtual DbSet<Transactions022024> Transactions022024s { get; set; }

    public virtual DbSet<Transactions032022> Transactions032022s { get; set; }

    public virtual DbSet<Transactions032023> Transactions032023s { get; set; }

    public virtual DbSet<Transactions042022> Transactions042022s { get; set; }

    public virtual DbSet<Transactions042023> Transactions042023s { get; set; }

    public virtual DbSet<Transactions052022> Transactions052022s { get; set; }

    public virtual DbSet<Transactions052023> Transactions052023s { get; set; }

    public virtual DbSet<Transactions062021> Transactions062021s { get; set; }

    public virtual DbSet<Transactions062022> Transactions062022s { get; set; }

    public virtual DbSet<Transactions062023> Transactions062023s { get; set; }

    public virtual DbSet<Transactions072021> Transactions072021s { get; set; }

    public virtual DbSet<Transactions072022> Transactions072022s { get; set; }

    public virtual DbSet<Transactions072023> Transactions072023s { get; set; }

    public virtual DbSet<Transactions082021> Transactions082021s { get; set; }

    public virtual DbSet<Transactions082022> Transactions082022s { get; set; }

    public virtual DbSet<Transactions082023> Transactions082023s { get; set; }

    public virtual DbSet<Transactions092021> Transactions092021s { get; set; }

    public virtual DbSet<Transactions092022> Transactions092022s { get; set; }

    public virtual DbSet<Transactions092023> Transactions092023s { get; set; }

    public virtual DbSet<Transactions102021> Transactions102021s { get; set; }

    public virtual DbSet<Transactions102022> Transactions102022s { get; set; }

    public virtual DbSet<Transactions102023> Transactions102023s { get; set; }

    public virtual DbSet<Transactions112021> Transactions112021s { get; set; }

    public virtual DbSet<Transactions112022> Transactions112022s { get; set; }

    public virtual DbSet<Transactions112023> Transactions112023s { get; set; }

    public virtual DbSet<Transactions122021> Transactions122021s { get; set; }

    public virtual DbSet<Transactions122022> Transactions122022s { get; set; }

    public virtual DbSet<Transactions122023> Transactions122023s { get; set; }

    public virtual DbSet<TransportModeMaster> TransportModeMasters { get; set; }

    public virtual DbSet<UserRight> UserRights { get; set; }

    public virtual DbSet<UserShiftmaster> UserShiftmasters { get; set; }

    public virtual DbSet<UserTimelog> UserTimelogs { get; set; }

    public virtual DbSet<Useraccess> Useraccesses { get; set; }

    public virtual DbSet<Vehicletype> Vehicletypes { get; set; }

    public virtual DbSet<VendorMenuMaster> VendorMenuMasters { get; set; }

    public virtual DbSet<Versionmaster> Versionmasters { get; set; }

    public virtual DbSet<VillageMaster> VillageMasters { get; set; }

    public virtual DbSet<Visitarea> Visitareas { get; set; }

    public virtual DbSet<Visitor> Visitors { get; set; }

    public virtual DbSet<VisitorCard> VisitorCards { get; set; }

    public virtual DbSet<VisitorCardUpload> VisitorCardUploads { get; set; }

    public virtual DbSet<VisitorCardnoEnrollno> VisitorCardnoEnrollnos { get; set; }

    public virtual DbSet<Visitorentry> Visitorentries { get; set; }

    public virtual DbSet<Visitormaster> Visitormasters { get; set; }

    public virtual DbSet<Visitortype> Visitortypes { get; set; }

    public virtual DbSet<Vmscompany> Vmscompanies { get; set; }

    public virtual DbSet<Watchlist> Watchlists { get; set; }

    public virtual DbSet<Weeklyoff> Weeklyoffs { get; set; }

    public virtual DbSet<Weeklypattern> Weeklypatterns { get; set; }

    public virtual DbSet<Weekmaster> Weekmasters { get; set; }

    public virtual DbSet<Workarea> Workareas { get; set; }

    public virtual DbSet<WorkareaProject> WorkareaProjects { get; set; }

    public virtual DbSet<Zone> Zones { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DIAMOND\\SQLEXPRESS;Database=BPCL_Warangal_audit_DB;User Id=tasuser;Password=admin123#;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccFormDetail>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Displayname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("displayname");
            entity.Property(e => e.Flag)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Formname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("formname");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Userlevel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("userlevel");
        });

        modelBuilder.Entity<AccGraph>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("acc_graphs");

            entity.Property(e => e.Details)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Graphid).HasColumnName("graphid");
            entity.Property(e => e.Slot).HasColumnName("slot");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<AccMastercontroller>(entity =>
        {
            entity.HasKey(e => e.Cid);

            entity.ToTable("acc_mastercontroller");

            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Cname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("cname");
            entity.Property(e => e.Cntuploadedyn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cntuploadedyn");
            entity.Property(e => e.Compid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Doorconfig)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("doorconfig");
            entity.Property(e => e.Doorheldyn)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("doorheldyn");
            entity.Property(e => e.Flag)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Ip)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ip");
            entity.Property(e => e.Lastconnected)
                .HasColumnType("datetime")
                .HasColumnName("lastconnected");
            entity.Property(e => e.Lasttransid).HasColumnName("lasttransid");
            entity.Property(e => e.Locationid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Normalaccess).HasColumnName("normalaccess");
            entity.Property(e => e.Port).HasColumnName("port");
            entity.Property(e => e.Readercnt).HasColumnName("readercnt");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Timezone)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("timezone");
        });

        modelBuilder.Entity<AccMastergraph>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("acc_mastergraphs");

            entity.Property(e => e.Graphid).HasColumnName("graphid");
            entity.Property(e => e.Graphname)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("graphname");
            entity.Property(e => e.Graphtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("graphtype");
        });

        modelBuilder.Entity<AccMasterreader>(entity =>
        {
            entity.HasKey(e => e.Rid);

            entity.ToTable("acc_masterreader");

            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Attyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("attyn");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Compid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Doorheld).HasColumnName("doorheld");
            entity.Property(e => e.Iostatus)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("iostatus");
            entity.Property(e => e.Locationid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Mainentryorexit)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("mainentryorexit");
            entity.Property(e => e.Normal).HasColumnName("normal");
            entity.Property(e => e.Rname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("rname");
            entity.Property(e => e.Rno).HasColumnName("rno");
            entity.Property(e => e.Rnotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("rnotes");
            entity.Property(e => e.Rnotes1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("rnotes1");
            entity.Property(e => e.Rnotes2)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("rnotes2");
            entity.Property(e => e.Rtype)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("rtype");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("uploadedyn");
        });

        modelBuilder.Entity<AccMastertz>(entity =>
        {
            entity.HasKey(e => e.Tzid);

            entity.ToTable("acc_mastertz");

            entity.Property(e => e.Tzid).HasColumnName("tzid");
            entity.Property(e => e.Day).HasColumnName("day");
            entity.Property(e => e.Endtime)
                .HasColumnType("datetime")
                .HasColumnName("endtime");
            entity.Property(e => e.Starttime)
                .HasColumnType("datetime")
                .HasColumnName("starttime");
            entity.Property(e => e.Tzname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("tzname");
        });

        modelBuilder.Entity<AccTran>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("acc_trans");

            entity.Property(e => e.Cardno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardno");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Inout)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("inout");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
        });

        modelBuilder.Entity<AccUserRight>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Formid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("formid");
            entity.Property(e => e.Formvalue)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("formvalue");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Userid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("userid");
        });

        modelBuilder.Entity<AccauditLog>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("accaudit_log$PrimaryKey");

            entity.ToTable("accaudit_log");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Day).HasColumnName("day");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.EventId)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("eventId");
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.LogDate)
                .HasDefaultValueSql("((0))")
                .HasColumnType("datetime")
                .HasColumnName("logDate");
            entity.Property(e => e.LogTime)
                .HasColumnType("datetime")
                .HasColumnName("logTime");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("username");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<Accauthtypemaster>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("accauthtypemaster");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Andoperation).HasColumnName("andoperation");
            entity.Property(e => e.Card).HasColumnName("card");
            entity.Property(e => e.Cardid).HasColumnName("cardid");
            entity.Property(e => e.Finger).HasColumnName("finger");
            entity.Property(e => e.Fpcard).HasColumnName("fpcard");
            entity.Property(e => e.Name)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Password).HasColumnName("password");
        });

        modelBuilder.Entity<AccessHoliday>(entity =>
        {
            entity.HasKey(e => e.SrNo).HasName("access_holiday$PrimaryKey");

            entity.ToTable("access_holiday");

            entity.Property(e => e.SrNo).ValueGeneratedNever();
            entity.Property(e => e.Compid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Days)
                .HasDefaultValue(0)
                .HasColumnName("days");
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.HDate)
                .HasColumnType("datetime")
                .HasColumnName("H_Date");
            entity.Property(e => e.HToDate)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("H_ToDate");
            entity.Property(e => e.Holidayname)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Locationid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Mons)
                .HasDefaultValue(0)
                .HasColumnName("mons");
            entity.Property(e => e.Notes)
                .HasColumnType("datetime")
                .HasColumnName("notes");
            entity.Property(e => e.Usedflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usedflag");
            entity.Property(e => e.Years)
                .HasDefaultValue(0)
                .HasColumnName("years");
        });

        modelBuilder.Entity<Accesstimesupload>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("Accesstimesupload");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Acctimesrno).HasColumnName("acctimesrno");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uploadedyn");
        });

        modelBuilder.Entity<Acscard>(entity =>
        {
            entity.HasKey(e => e.Acsid);

            entity.ToTable("acscard");

            entity.Property(e => e.Acsid).HasColumnName("acsid");
            entity.Property(e => e.AcsCardNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("acsCardNo");
        });

        modelBuilder.Entity<Acsetting>(entity =>
        {
            entity.ToTable("acsettings");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Type)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.Value)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("value");
        });

        modelBuilder.Entity<Activitylog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("activitylog");

            entity.Property(e => e.Activitytype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("activitytype");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Details)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Details1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("details1");
            entity.Property(e => e.Execdates)
                .HasColumnType("datetime")
                .HasColumnName("execdates");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.Returncode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("returncode");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Status)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Username)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Activitymaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("activitymaster");

            entity.Property(e => e.Activity)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("activity");
            entity.Property(e => e.Anotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("anotes");
            entity.Property(e => e.Anotes1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("anotes1");
            entity.Property(e => e.Anotes2)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("anotes2");
            entity.Property(e => e.Details)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<Acueventlog>(entity =>
        {
            entity.ToTable("acueventlog");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Account).HasColumnName("account");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Datetime)
                .HasColumnType("datetime")
                .HasColumnName("datetime");
            entity.Property(e => e.Partition).HasColumnName("partition");
            entity.Property(e => e.Qualifier).HasColumnName("qualifier");
            entity.Property(e => e.Targetid).HasColumnName("targetid");
            entity.Property(e => e.Terminalid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminalid");
        });

        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__admin__03F0984C");

            entity.ToTable("admin");

            entity.Property(e => e.Accesscontrol)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("accesscontrol");
            entity.Property(e => e.Accessgroupids)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("accessgroupids");
            entity.Property(e => e.Addedby)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("addedby");
            entity.Property(e => e.Allaccessgroups)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("allaccessgroups");
            entity.Property(e => e.Allcontrollers)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("allcontrollers");
            entity.Property(e => e.Attendance)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("attendance");
            entity.Property(e => e.Compid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Controllerids)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("controllerids");
            entity.Property(e => e.Dept)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dept");
            entity.Property(e => e.Details)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Empid)
                .HasDefaultValue(0)
                .HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("Active")
                .HasColumnName("flag");
            entity.Property(e => e.Fname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fname");
            entity.Property(e => e.Lastlogin)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("lastlogin");
            entity.Property(e => e.Lname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("lname");
            entity.Property(e => e.Locationid)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Logintype).HasColumnName("logintype");
            entity.Property(e => e.Mobno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("mobno");
            entity.Property(e => e.Names)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("names");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Pass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pass");
            entity.Property(e => e.Phno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("phno");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.Uname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uname");
            entity.Property(e => e.Utype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("utype");
            entity.Property(e => e.Vmsflag).HasColumnName("vmsflag");
        });

        modelBuilder.Entity<Alarmlog>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("alarmlogs");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Ack)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Ackdatetimes)
                .HasColumnType("datetime")
                .HasColumnName("ackdatetimes");
            entity.Property(e => e.Alarmdesc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("alarmdesc");
            entity.Property(e => e.Alarmtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("alarmtype");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Emailsentstatus)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("emailsentstatus");
            entity.Property(e => e.Flag)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Flag1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("flag1");
            entity.Property(e => e.Flag2)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("flag2");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Showflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("showflag");
            entity.Property(e => e.Smssentstatus)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("smssentstatus");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
        });

        modelBuilder.Entity<Alarmsetting>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("alarmsettings");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.Alarmtype)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("alarmtype");
            entity.Property(e => e.Alarmtypedesc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("alarmtypedesc");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("note1");
            entity.Property(e => e.Note2)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("note2");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Popup)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("popup");
            entity.Property(e => e.Showflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("showflag");
        });

        modelBuilder.Entity<Alarmsupload>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("alarmsupload");

            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<Alertlog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("alertlogs");

            entity.Property(e => e.Alertid).HasColumnName("alertid");
            entity.Property(e => e.Details)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Logtime)
                .HasColumnType("datetime")
                .HasColumnName("logtime");
            entity.Property(e => e.Mobnos)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("mobnos");
            entity.Property(e => e.Readerid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("readerid");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<Alertsetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("alertsettings");

            entity.Property(e => e.Alertname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("alertname");
            entity.Property(e => e.Authorisednos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("authorisednos");
            entity.Property(e => e.Grantdeny)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("grantdeny");
            entity.Property(e => e.Readerids)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("readerids");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__appointment__45F365D3");

            entity.ToTable("appointment");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Abuildingno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("abuildingno");
            entity.Property(e => e.Address)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.Afloorno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("afloorno");
            entity.Property(e => e.Avisitarea)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("avisitarea");
            entity.Property(e => e.Aworkarea)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("aworkarea");
            entity.Property(e => e.Carrlaptop)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("carrlaptop");
            entity.Property(e => e.Carrmob)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("carrmob");
            entity.Property(e => e.Carrmobwithcamera)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("carrmobwithcamera");
            entity.Property(e => e.Carrother)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("carrother");
            entity.Property(e => e.Carrotherdetails)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("carrotherdetails");
            entity.Property(e => e.Carrtoolkit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("carrtoolkit");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Compname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("compname");
            entity.Property(e => e.Contactno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contactno");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Gateno).HasColumnName("gateno");
            entity.Property(e => e.Gatepassno)
                .HasDefaultValueSql("('0')")
                .HasColumnName("gatepassno");
            entity.Property(e => e.Lapproveflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lapproveflag");
            entity.Property(e => e.Mapproveflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mapproveflag");
            entity.Property(e => e.Note)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("note");
            entity.Property(e => e.Purpose)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("purpose");
            entity.Property(e => e.Smstext)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("smstext");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Todate)
                .HasColumnType("datetime")
                .HasColumnName("todate");
            entity.Property(e => e.Visitorname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("visitorname");
        });

        modelBuilder.Entity<Appointmentsetting>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK_AppointmentSettings");

            entity.ToTable("appointmentsettings");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.AdminApproval)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SmstoEmployee)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SMStoEmployee");
            entity.Property(e => e.SmstoVisitor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SMStoVisitor");
        });

        modelBuilder.Entity<ApprovedOt>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("approvedOT$PrimaryKey");

            entity.ToTable("approvedOT");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.AddDates)
                .HasColumnType("datetime")
                .HasColumnName("add dates");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("approvedby");
            entity.Property(e => e.Days)
                .HasDefaultValue(0)
                .HasColumnName("days");
            entity.Property(e => e.Empid)
                .HasDefaultValue(0)
                .HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Mons)
                .HasDefaultValue(0)
                .HasColumnName("mons");
            entity.Property(e => e.Othrs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("othrs");
            entity.Property(e => e.Punchtimes)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("punchtimes");
            entity.Property(e => e.Yrs)
                .HasDefaultValue(0)
                .HasColumnName("yrs");
        });

        modelBuilder.Entity<AttGraph>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_graphs");

            entity.Property(e => e.Details)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Graphid).HasColumnName("graphid");
            entity.Property(e => e.Slot).HasColumnName("slot");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<AttMastergraph>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_mastergraphs");

            entity.Property(e => e.Graphid).HasColumnName("graphid");
            entity.Property(e => e.Graphname)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("graphname");
            entity.Property(e => e.Graphtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("graphtype");
        });

        modelBuilder.Entity<AttReader>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Compid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.ControllerName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Y")
                .HasColumnName("flag");
            entity.Property(e => e.Locationid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("locationid");
        });

        modelBuilder.Entity<AuditLog>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("audit_log$PrimaryKey");

            entity.ToTable("audit_log");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Day).HasColumnName("day");
            entity.Property(e => e.Description)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.EventId)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("eventId");
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.LogDate)
                .HasDefaultValueSql("((0))")
                .HasColumnType("datetime")
                .HasColumnName("logDate");
            entity.Property(e => e.LogTime)
                .HasColumnType("datetime")
                .HasColumnName("logTime");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("username");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<AuditLogclm>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("audit_logclms$PrimaryKey");

            entity.ToTable("audit_logclms");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Day).HasColumnName("day");
            entity.Property(e => e.Description)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Empcode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("empcode");
            entity.Property(e => e.EventId)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("eventId");
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.LogDate)
                .HasDefaultValueSql("((0))")
                .HasColumnType("datetime")
                .HasColumnName("logDate");
            entity.Property(e => e.LogTime)
                .HasColumnType("datetime")
                .HasColumnName("logTime");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Prevlldate)
                .HasColumnType("datetime")
                .HasColumnName("prevlldate");
            entity.Property(e => e.Prevtodate)
                .HasColumnType("datetime")
                .HasColumnName("prevtodate");
            entity.Property(e => e.Prevwcdate)
                .HasColumnType("datetime")
                .HasColumnName("prevwcdate");
            entity.Property(e => e.Tokenno)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("tokenno");
            entity.Property(e => e.Updatedecdate)
                .HasColumnType("datetime")
                .HasColumnName("updatedecdate");
            entity.Property(e => e.Updatedlldate)
                .HasColumnType("datetime")
                .HasColumnName("updatedlldate");
            entity.Property(e => e.Updatetodate)
                .HasColumnType("datetime")
                .HasColumnName("updatetodate");
            entity.Property(e => e.Username)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("username");
            entity.Property(e => e.Workorderno)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("workorderno");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<Backuplog>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("backuplog");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Backuppath)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("backuppath");
            entity.Property(e => e.Backupstatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("backupstatus");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Logerror)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("logerror");
            entity.Property(e => e.Lognotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("lognotes");
            entity.Property(e => e.Lognotes1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("lognotes1");
            entity.Property(e => e.Lognotes2)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("lognotes2");
            entity.Property(e => e.Times)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("times");
        });

        modelBuilder.Entity<Backupsetting>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("backupsettings");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Backuppath)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("backuppath");
            entity.Property(e => e.Backuptype)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("backuptype");
            entity.Property(e => e.Bknotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("bknotes");
            entity.Property(e => e.Bknotes1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("bknotes1");
            entity.Property(e => e.Bknotes2)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("bknotes2");
            entity.Property(e => e.Bknotes3)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("bknotes3");
            entity.Property(e => e.Day).HasColumnName("day");
            entity.Property(e => e.Setflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("setflag");
            entity.Property(e => e.Time)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("time");
        });

        modelBuilder.Entity<Banlist>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__banlist__1209AD79");

            entity.ToTable("banlist");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Addedby)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("addedby");
            entity.Property(e => e.Empid)
                .HasDefaultValueSql("('0')")
                .HasColumnName("empid");
            entity.Property(e => e.Note)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("note");
            entity.Property(e => e.Visitorid).HasColumnName("visitorid");
            entity.Property(e => e.Visname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("visname");
        });

        modelBuilder.Entity<BioMetric>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BioMetric");

            entity.Property(e => e.AutoId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AutoID");
            entity.Property(e => e.DateAndTime).HasColumnType("datetime");
            entity.Property(e => e.LocationName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TruckId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TruckID");
        });

        modelBuilder.Entity<BuildingMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BuildingMaster");

            entity.Property(e => e.BuildingNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Details)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Note)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Srno).HasColumnName("srno");
        });

        modelBuilder.Entity<BusMaster>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("BusMaster$PrimaryKey");

            entity.ToTable("BusMaster");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Buscode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("buscode");
            entity.Property(e => e.Busroute)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("busroute");
            entity.Property(e => e.Compid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Locationid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("locationid");
        });

        modelBuilder.Entity<CExtraDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cExtraData");

            entity.Property(e => e.Cdfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cdfield1");
            entity.Property(e => e.Cdfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cdfield2");
            entity.Property(e => e.Cdfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cdfield3");
            entity.Property(e => e.Cdfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cdfield4");
            entity.Property(e => e.Cdfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cdfield5");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<Camset>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("camset");

            entity.Property(e => e.Camip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("camip");
            entity.Property(e => e.Camname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("camname");
            entity.Property(e => e.Campass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("campass");
            entity.Property(e => e.Camport)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("camport");
            entity.Property(e => e.Camuser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("camuser");
            entity.Property(e => e.Details)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<CanteenTransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CanteenTransaction");

            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.Vendorid).HasColumnName("vendorid");
        });

        modelBuilder.Entity<CanteenTransactionDetail>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Menuid).HasColumnName("menuid");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Rate).HasColumnName("rate");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.Transid).HasColumnName("transid");
            entity.Property(e => e.Vendorid).HasColumnName("vendorid");
        });

        modelBuilder.Entity<CardFormat>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Facilitycode).HasColumnName("facilitycode");
            entity.Property(e => e.Filedata).HasColumnName("filedata");
            entity.Property(e => e.Filepath)
                .IsUnicode(false)
                .HasColumnName("filepath");
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Formatname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("formatname");
            entity.Property(e => e.Noofbits).HasColumnName("noofbits");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("false")
                .HasColumnName("uploadedyn");
        });

        modelBuilder.Entity<Carddatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("carddata");

            entity.Property(e => e.Accessgroups)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("accessgroups");
            entity.Property(e => e.Accesstype).HasColumnName("accesstype");
            entity.Property(e => e.Cardno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cardno");
            entity.Property(e => e.Facilitycode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("facilitycode");
            entity.Property(e => e.Nofmt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nofmt");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Uniqueid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("uniqueid");
        });

        modelBuilder.Entity<Cardmaster>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("cardmaster");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardno");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("Active")
                .HasColumnName("flag");
            entity.Property(e => e.Floorno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("floorno");
            entity.Property(e => e.Gateno)
                .HasDefaultValue(0)
                .HasColumnName("gateno");
            entity.Property(e => e.Gatepassno)
                .HasDefaultValue(0)
                .HasColumnName("gatepassno");
            entity.Property(e => e.Status)
                .HasDefaultValue(0)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Cardsetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cardsetting");

            entity.Property(e => e.Applyformat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("applyformat");
        });

        modelBuilder.Entity<Cardstoregister>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cardstoregister");

            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<Cardstounregister>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cardstounregister");

            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<Categorymaster>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("categorymaster$PrimaryKey");

            entity.ToTable("categorymaster");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Absenthrs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("absenthrs");
            entity.Property(e => e.Afterinterval)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("afterinterval");
            entity.Property(e => e.Applyearlyallowed)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("applyearlyallowed");
            entity.Property(e => e.Applylateallowed)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("applylateallowed");
            entity.Property(e => e.Approveot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("approveot");
            entity.Property(e => e.Caltype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("caltype");
            entity.Property(e => e.Catcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("catcode");
            entity.Property(e => e.Catname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("catname");
            entity.Property(e => e.Checkintime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("checkintime");
            entity.Property(e => e.Compid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Compoffhrs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("compoffhrs");
            entity.Property(e => e.Compoffothrs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("compoffothrs");
            entity.Property(e => e.Compulsarydedbreak)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("compulsarydedbreak");
            entity.Property(e => e.Contabsdays)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contabsdays");
            entity.Property(e => e.Dedbreaktime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dedbreaktime");
            entity.Property(e => e.Earlyallowed)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("earlyallowed");
            entity.Property(e => e.Earlyallowedtime)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("earlyallowedtime");
            entity.Property(e => e.Errorpunchday)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("errorpunchday");
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Fromdate)
                .HasColumnType("datetime")
                .HasColumnName("fromdate");
            entity.Property(e => e.Graceearly)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("graceearly");
            entity.Property(e => e.Gracelate)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("gracelate");
            entity.Property(e => e.Graceothrs)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("graceothrs");
            entity.Property(e => e.Halfdayhrs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("halfdayhrs");
            entity.Property(e => e.HolidayAbsent)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Iomode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IOmode");
            entity.Property(e => e.Lateallowed)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lateallowed");
            entity.Property(e => e.Latecount)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("latecount");
            entity.Property(e => e.Latededday)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("latededday");
            entity.Property(e => e.Latededtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("latededtype");
            entity.Property(e => e.Lateleavecode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lateleavecode");
            entity.Property(e => e.Leavehrsmin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("leavehrsmin");
            entity.Property(e => e.Leavehrsmonth)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("leavehrsmonth");
            entity.Property(e => e.Locationid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Manualpunchlimit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("manualpunchlimit");
            entity.Property(e => e.Maxcompoff)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maxcompoff");
            entity.Property(e => e.Maxhours)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maxhours");
            entity.Property(e => e.Minottime)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("minottime");
            entity.Property(e => e.Nopunch)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nopunch");
            entity.Property(e => e.Notes)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Otaftershift)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("otaftershift");
            entity.Property(e => e.Otdeductafter)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("otdeductafter");
            entity.Property(e => e.Otdeductbefore)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("otdeductbefore");
            entity.Property(e => e.Otmaxlimit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("otmaxlimit");
            entity.Property(e => e.Otonholiday)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("otonholiday");
            entity.Property(e => e.Otonwkoff)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("otonwkoff");
            entity.Property(e => e.Otrounduptime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("otrounduptime");
            entity.Property(e => e.Otrounduptype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("otrounduptype");
            entity.Property(e => e.Otsatrtbeforeshift)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("otsatrtbeforeshift");
            entity.Property(e => e.Otsetroundup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("otsetroundup");
            entity.Property(e => e.Otstarts)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("otstarts");
            entity.Property(e => e.P11)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("p1_1");
            entity.Property(e => e.P32)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("p3_2");
            entity.Property(e => e.P33)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("p3_3");
            entity.Property(e => e.P42)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("p4_2");
            entity.Property(e => e.P43)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("p4_3");
            entity.Property(e => e.PEven)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("p_even");
            entity.Property(e => e.POdd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("p_odd");
            entity.Property(e => e.Plusminus)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("plusminus");
            entity.Property(e => e.Rounduptime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("rounduptime");
            entity.Property(e => e.Rounduptype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("rounduptype");
            entity.Property(e => e.Section)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("section");
            entity.Property(e => e.Setcompoff)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("setcompoff");
            entity.Property(e => e.Setearly)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("setearly");
            entity.Property(e => e.Setlate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("setlate");
            entity.Property(e => e.Setlateearly)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("setlateearly");
            entity.Property(e => e.Setmanualpaunch)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SETmanualpaunch");
            entity.Property(e => e.Setot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("setot");
            entity.Property(e => e.Setotaftershift)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("setotaftershift");
            entity.Property(e => e.Setotbeforeshift)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("setotbeforeshift");
            entity.Property(e => e.Setpunchtime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("setpunchtime");
            entity.Property(e => e.Setroundup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("setroundup");
            entity.Property(e => e.Setshortleave)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("setshortleave");
            entity.Property(e => e.Setwrkhrs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("setwrkhrs");
            entity.Property(e => e.Todate)
                .HasColumnType("datetime")
                .HasColumnName("todate");
            entity.Property(e => e.Usedflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("usedflag");
            entity.Property(e => e.WkoffAbsent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("wkoffAbsent");
        });

        modelBuilder.Entity<Cinterface>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("cinterface");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Cnotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("cnotes");
            entity.Property(e => e.Dooropt)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("dooropt");
            entity.Property(e => e.Icnt).HasColumnName("icnt");
            entity.Property(e => e.Iid).HasColumnName("iid");
            entity.Property(e => e.Types)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("types");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Clientid)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("clientid");
            entity.Property(e => e.Clientname)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Keys)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("keys");
        });

        modelBuilder.Entity<Clientcount>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__clientco__36B150C694B95FBE");

            entity.ToTable("clientcount");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Clientcount1).HasColumnName("clientcount");
            entity.Property(e => e.Empcount)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empcount");
        });

        modelBuilder.Entity<Clientdetail>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__clientde__36B150C68005B381");

            entity.ToTable("clientdetails");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Clientid)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("clientid");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<ClmsEmaillog>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("clms_emaillogs");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Details)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Emailfrom)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Emailto)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<ClmsEmailsetting>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("clms_emailsettings");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Pochangemail)
                .IsUnicode(false)
                .HasColumnName("pochangemail");
        });

        modelBuilder.Entity<Clmscategorymaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("clmscategorymaster");

            entity.Property(e => e.Categoryname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("categoryname");
            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<Clmsdesklog>(entity =>
        {
            entity.ToTable("clmsdesklogs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Clmspasstype)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("clmspasstype");
            entity.Property(e => e.Datetime)
                .HasColumnType("datetime")
                .HasColumnName("datetime");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Tokenno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tokenno");
            entity.Property(e => e.Workorderno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("workorderno");
        });

        modelBuilder.Entity<Clog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("clogs");

            entity.Property(e => e.Cdata)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("cdata");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<ComOffrequest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ComOffrequest");

            entity.Property(e => e.DateWork).HasColumnType("datetime");
            entity.Property(e => e.Datecomp)
                .HasColumnType("datetime")
                .HasColumnName("datecomp");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Details)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs).HasColumnName("hrs");
            entity.Property(e => e.Mins).HasColumnName("mins");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.PunchTime)
                .HasColumnType("datetime")
                .HasColumnName("punchTime");
            entity.Property(e => e.Requestid).HasColumnName("requestid");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.SrNo).HasName("PK__company__02C769E9");

            entity.ToTable("company");

            entity.Property(e => e.Company1)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("company");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("Active")
                .HasColumnName("flag");
            entity.Property(e => e.Location)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("location");
        });

        modelBuilder.Entity<CompanyMaster>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("CompanyMaster$PrimaryKey");

            entity.ToTable("CompanyMaster");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Compname)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("compname");
            entity.Property(e => e.Details)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Emailid)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("emailid");
            entity.Property(e => e.Finendyear)
                .HasColumnType("datetime")
                .HasColumnName("finendyear");
            entity.Property(e => e.Finstartyear)
                .HasColumnType("datetime")
                .HasColumnName("finstartyear");
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Logo)
                .HasColumnType("image")
                .HasColumnName("logo");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Phno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phno");
            entity.Property(e => e.Usedflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usedflag");
        });

        modelBuilder.Entity<Compoffdatum>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("compoffdata$PrimaryKey");

            entity.ToTable("compoffdata");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.ApproveDate).HasColumnType("datetime");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Approvers)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Availableot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("availableot");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Empid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empid");
            entity.Property(e => e.Fdday)
                .HasDefaultValue(0)
                .HasColumnName("fdday");
            entity.Property(e => e.Fdmonth)
                .HasDefaultValue(0)
                .HasColumnName("fdmonth");
            entity.Property(e => e.Fdyear)
                .HasDefaultValue(0)
                .HasColumnName("fdyear");
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Fromdate)
                .HasColumnType("datetime")
                .HasColumnName("fromdate");
            entity.Property(e => e.IsNotify)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("isNotify");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Punchtime)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("punchtime");
            entity.Property(e => e.Requestid).HasColumnName("requestid");
            entity.Property(e => e.Smstext)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("smstext");
            entity.Property(e => e.Tdday)
                .HasDefaultValue(0)
                .HasColumnName("tdday");
            entity.Property(e => e.Tdmonth)
                .HasDefaultValue(0)
                .HasColumnName("tdmonth");
            entity.Property(e => e.Tdyear)
                .HasDefaultValue(0)
                .HasColumnName("tdyear");
            entity.Property(e => e.ToApprove)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Todate)
                .HasColumnType("datetime")
                .HasColumnName("todate");
        });

        modelBuilder.Entity<Condone>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("Condone$PrimaryKey");

            entity.ToTable("Condone");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Compoffdate)
                .HasColumnType("datetime")
                .HasColumnName("compoffdate");
            entity.Property(e => e.Condonehrs)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("condonehrs");
            entity.Property(e => e.Condonetype)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("condonetype");
            entity.Property(e => e.Dates)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Notes)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Years).HasColumnName("years");
        });

        modelBuilder.Entity<CondoneEntryRequest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CondoneEntryRequest");

            entity.Property(e => e.CondoneHrs).HasColumnType("datetime");
            entity.Property(e => e.CondoneType)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Dates).HasColumnType("datetime");
            entity.Property(e => e.Details)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<ConfigFile>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Cname)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("cname");
            entity.Property(e => e.Controllerpath)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("controllerpath");
            entity.Property(e => e.Filepath)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("filepath");
            entity.Property(e => e.Filetype)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("filetype");
            entity.Property(e => e.Ids)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ids");
            entity.Property(e => e.Macaddr)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("macaddr");
            entity.Property(e => e.Names)
                .HasMaxLength(800)
                .IsUnicode(false)
                .HasColumnName("names");
        });

        modelBuilder.Entity<ContractDatum>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ContractNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Details)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ContractGatepassdetail>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("contract_gatepassdetails");

            entity.Property(e => e.Srno)
                .ValueGeneratedNever()
                .HasColumnName("srno");
            entity.Property(e => e.Intime)
                .HasColumnType("datetime")
                .HasColumnName("intime");
            entity.Property(e => e.Notes)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("notes");
            entity.Property(e => e.Outtime)
                .HasColumnType("datetime")
                .HasColumnName("outtime");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("status");
            entity.Property(e => e.Visitorid).HasColumnName("visitorid");
        });

        modelBuilder.Entity<ContractVisitor>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__ContractVisitor__76619304");

            entity.ToTable("ContractVisitor");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Addedby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("addedby");
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.Cardformat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardformat");
            entity.Property(e => e.Cardno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardno");
            entity.Property(e => e.Compname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("compname");
            entity.Property(e => e.Districtid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("districtid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Fpdata).HasColumnName("fpdata");
            entity.Property(e => e.Fpimage)
                .HasColumnType("image")
                .HasColumnName("fpimage");
            entity.Property(e => e.Idproof)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("idproof");
            entity.Property(e => e.Idtype)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("idtype");
            entity.Property(e => e.Image)
                .HasColumnType("image")
                .HasColumnName("image");
            entity.Property(e => e.Noformat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("noformat");
            entity.Property(e => e.Phno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phno");
            entity.Property(e => e.SigImage)
                .HasColumnType("image")
                .HasColumnName("sigImage");
            entity.Property(e => e.Stateid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("stateid");
            entity.Property(e => e.Tmpsize)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tmpsize");
            entity.Property(e => e.Villageid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("villageid");
            entity.Property(e => e.Visid).HasColumnName("visid");
            entity.Property(e => e.Visname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("visname");
        });

        modelBuilder.Entity<Contractortype>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__contractortype__7849DB76");

            entity.ToTable("contractortype");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Contype)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("contype");
            entity.Property(e => e.Details)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("details");
        });

        modelBuilder.Entity<ControlTaskLog>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("ControlTask_log");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Status)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Task)
                .IsUnicode(false)
                .HasColumnName("task");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
        });

        modelBuilder.Entity<Countrymaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("countrymaster");

            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<Currentprocess>(entity =>
        {
            entity.ToTable("currentprocess");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Process)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("process");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.Property(e => e.CustomerName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Details)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Dashboardsetting>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("dashboardsetting");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Dashkey)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("dashkey");
            entity.Property(e => e.Dashtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dashtype");
            entity.Property(e => e.Dashvalue)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("dashvalue");
        });

        modelBuilder.Entity<Dateconfiguration>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dateconfiguration");

            entity.Property(e => e.Continues)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("continues");
            entity.Property(e => e.Fromdate)
                .HasColumnType("datetime")
                .HasColumnName("fromdate");
            entity.Property(e => e.Noofdays)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("noofdays");
            entity.Property(e => e.Remark)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.Settingfor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("settingfor");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Todate)
                .HasColumnType("datetime")
                .HasColumnName("todate");
        });

        modelBuilder.Entity<Delemployee>(entity =>
        {
            entity.HasKey(e => e.Empid).HasName("delemployee$PrimaryKey");

            entity.ToTable("delemployee");

            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Accessgroups)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("accessgroups");
            entity.Property(e => e.Accesstype)
                .HasDefaultValue(0)
                .HasColumnName("accesstype");
            entity.Property(e => e.Autoshift)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("autoshift");
            entity.Property(e => e.Busid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("busid");
            entity.Property(e => e.Caddress)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CAddress");
            entity.Property(e => e.Cardno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cardno");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Compid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.DeptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dob)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DOB");
            entity.Property(e => e.Doj)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DOJ");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Empno).HasColumnName("empno");
            entity.Property(e => e.Emptype)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("emptype");
            entity.Property(e => e.Extendedyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("extendedyn");
            entity.Property(e => e.Facilitycode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("facilitycode");
            entity.Property(e => e.FatherName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FName");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Ldate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LDate");
            entity.Property(e => e.Lname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LName");
            entity.Property(e => e.Locationid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Paddress)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PAddress");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pbexemptyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("pbexemptyn");
            entity.Property(e => e.Phno)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Picture).HasColumnType("image");
            entity.Property(e => e.Pin)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("pin");
            entity.Property(e => e.Pincmdsyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("pincmdsyn");
            entity.Property(e => e.Pincode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Pinexemptyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("pinexemptyn");
            entity.Property(e => e.Qualification)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReasonL)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Roasterpattern)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("roasterpattern");
            entity.Property(e => e.Section)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("section");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Active")
                .HasColumnName("status");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("uploadedyn");
            entity.Property(e => e.Wkoff)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("wkoff");
            entity.Property(e => e.Woff)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.SrNo).HasName("PK__department__6DCC4D03");

            entity.ToTable("department");

            entity.Property(e => e.Compid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Deptname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deptname");
            entity.Property(e => e.Details)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Flag)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Locationid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Usedflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usedflag");
        });

        modelBuilder.Entity<DeptCode>(entity =>
        {
            entity.HasKey(e => e.SrNo).HasName("dept_codes$PrimaryKey");

            entity.ToTable("dept_codes");

            entity.Property(e => e.Compid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.DeptName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Details)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Flag)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Locationid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Section)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("section");
            entity.Property(e => e.Usedflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usedflag");
        });

        modelBuilder.Entity<DescMaster>(entity =>
        {
            entity.HasKey(e => e.SrNo).HasName("PK__desc_master__35BCFE0A");

            entity.ToTable("desc_master");

            entity.Property(e => e.Compid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Designation)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Details)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Locationid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Section)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("section");
            entity.Property(e => e.Usedflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usedflag");
        });

        modelBuilder.Entity<DeviceAccessgroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("device_accessgroup");

            entity.Property(e => e.Agid).HasColumnName("agid");
            entity.Property(e => e.Agname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("agname");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Lastfetchtime)
                .HasColumnType("datetime")
                .HasColumnName("lastfetchtime");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<DeviceElevator>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("device_elevator");

            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Grpid).HasColumnName("grpid");
            entity.Property(e => e.Ifid).HasColumnName("ifid");
            entity.Property(e => e.Iid).HasColumnName("iid");
            entity.Property(e => e.Lastfetchtime)
                .HasColumnType("datetime")
                .HasColumnName("lastfetchtime");
            entity.Property(e => e.Readerid).HasColumnName("readerid");
            entity.Property(e => e.Relays)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("relays");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<DeviceInterface>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("device_interface");

            entity.Property(e => e.Cardincardout)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cardincardout");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Interfaceid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("interfaceid");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<DeviceIorule>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("device_iorules");

            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Iorule)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("iorule");
            entity.Property(e => e.Lastfetchtime)
                .HasColumnType("datetime")
                .HasColumnName("lastfetchtime");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<DeviceLog>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("device_logs");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloadtime)
                .HasColumnType("datetime")
                .HasColumnName("downloadtime");
            entity.Property(e => e.Logdesc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("logdesc");
            entity.Property(e => e.Majoreventtype).HasColumnName("majoreventtype");
            entity.Property(e => e.Minoreventtype).HasColumnName("minoreventtype");
        });

        modelBuilder.Entity<DeviceMultiman>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("device_multiman");

            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Entrytype)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("entrytype");
            entity.Property(e => e.Lastfetchtime)
                .HasColumnType("datetime")
                .HasColumnName("lastfetchtime");
            entity.Property(e => e.Multimanindx).HasColumnName("multimanindx");
            entity.Property(e => e.Preserveseq)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("preserveseq");
            entity.Property(e => e.Roleids)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("roleids");
            entity.Property(e => e.Rolescnt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("rolescnt");
            entity.Property(e => e.Seqtimeout)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("seqtimeout");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<DeviceReader>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("device_reader");

            entity.Property(e => e.Accesstype)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("accesstype");
            entity.Property(e => e.Apbaction)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("apbaction");
            entity.Property(e => e.Apbtimeout)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("apbtimeout");
            entity.Property(e => e.Apbtype)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("apbtype");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Doorheld)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("doorheld");
            entity.Property(e => e.Extended)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("extended");
            entity.Property(e => e.Iid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("iid");
            entity.Property(e => e.Lastfetchtime)
                .HasColumnType("datetime")
                .HasColumnName("lastfetchtime");
            entity.Property(e => e.Minimum)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("minimum");
            entity.Property(e => e.Normal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("normal");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Rno).HasColumnName("rno");
            entity.Property(e => e.Rtype)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("rtype");
            entity.Property(e => e.Ruleid).HasColumnName("ruleid");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<DeviceSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("device_settings");

            entity.Property(e => e.Cardincardout)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cardincardout");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Lastfetchtime)
                .HasColumnType("datetime")
                .HasColumnName("lastfetchtime");
            entity.Property(e => e.Noofcards)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("noofcards");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Translogsize).HasColumnName("translogsize");
            entity.Property(e => e.V100)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("v100");
            entity.Property(e => e.V200)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("v200");
            entity.Property(e => e.V300)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("v300");
        });

        modelBuilder.Entity<DeviceStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("device_status");

            entity.Property(e => e.Cid)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("cid");
            entity.Property(e => e.Doorlockstatus)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("doorlockstatus");
            entity.Property(e => e.Lastupdatetime)
                .HasColumnType("datetime")
                .HasColumnName("lastupdatetime");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<Devicetran>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("devicetrans");

            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Dfalarm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dfalarm");

            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uploadedyn");
        });

        modelBuilder.Entity<DistrictMaster>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("DistrictMaster");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Details)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Districtname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("districtname");
            entity.Property(e => e.Flag)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Stateid)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("stateid");
            entity.Property(e => e.Usedflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usedflag");
        });

        modelBuilder.Entity<DoorControl>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("doorControl");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Doorname)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("doorname");
            entity.Property(e => e.Flag)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Iid).HasColumnName("iid");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.V100id).HasColumnName("v100id");
        });

        modelBuilder.Entity<DriverDetail>(entity =>
        {
            entity.HasKey(e => e.Empid);

            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Accessgroups)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("accessgroups");
            entity.Property(e => e.Accesstype).HasColumnName("accesstype");
            entity.Property(e => e.Applyvalid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("applyvalid");
            entity.Property(e => e.Blacklisted)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("blacklisted");
            entity.Property(e => e.Caddress)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("CAddress");
            entity.Property(e => e.Cardno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cardno");
            entity.Property(e => e.Cert1DayPcvoDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cert1DayPcvoDate");
            entity.Property(e => e.Cert1DayPcvoNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cert1DayPcvoNo");
            entity.Property(e => e.Cert1DayPcvoValidity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cert1DayPcvoValidity");
            entity.Property(e => e.Cert3DayPcvoDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cert3DayPcvoDate");
            entity.Property(e => e.Cert3DayPcvoNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cert3DayPcvoNo");
            entity.Property(e => e.Cert3DayPcvoValidity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cert3DayPcvoValidity");
            entity.Property(e => e.Compid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.DeptName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Designation)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DhAutoUnreged)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Dlno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLNo");
            entity.Property(e => e.Dlvalidity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLValidity");
            entity.Property(e => e.Dob)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DOB");
            entity.Property(e => e.Doj)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DOJ");
            entity.Property(e => e.Email)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empcode");
            entity.Property(e => e.Endorsement)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("endorsement");
            entity.Property(e => e.Enrollno).HasColumnName("enrollno");
            entity.Property(e => e.Extendedyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("extendedyn");
            entity.Property(e => e.Facilitycode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("facilitycode");
            entity.Property(e => e.FatherName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Inschedelevator).HasColumnName("inschedelevator");
            entity.Property(e => e.Ldate)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("LDate");
            entity.Property(e => e.Locationid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Name)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Nofmt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nofmt");
            entity.Property(e => e.Otlno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OTLNo");
            entity.Property(e => e.Outschedelevator).HasColumnName("outschedelevator");
            entity.Property(e => e.Paddress)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("PAddress");
            entity.Property(e => e.Pbexemptyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("pbexemptyn");
            entity.Property(e => e.Pfno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pfno");
            entity.Property(e => e.Phno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Photo)
                .HasColumnType("image")
                .HasColumnName("photo");
            entity.Property(e => e.Pin)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("pin");
            entity.Property(e => e.Pinexemptyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("pinexemptyn");
            entity.Property(e => e.Policeverification)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("policeverification");
            entity.Property(e => e.Roleid).HasColumnName("roleid");
            entity.Property(e => e.Section)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("section");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Uniqueid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("uniqueid");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("uploadedyn");
            entity.Property(e => e.Validfrom)
                .HasColumnType("datetime")
                .HasColumnName("validfrom");
            entity.Property(e => e.Validto)
                .HasColumnType("datetime")
                .HasColumnName("validto");
        });

        modelBuilder.Entity<Emailalert>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("emailalerts");

            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Emailids)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("emailids");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Emailalertlog>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("emailalertlogs");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Datetime)
                .HasColumnType("datetime")
                .HasColumnName("datetime");
            entity.Property(e => e.Details)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Mailbody).HasColumnName("mailbody");
            entity.Property(e => e.Mailfrom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mailfrom");
            entity.Property(e => e.Mailto)
                .IsUnicode(false)
                .HasColumnName("mailto");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Subject)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("subject");
            entity.Property(e => e.Tiltle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tiltle");
        });

        modelBuilder.Entity<Emailid>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("emailids");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Details)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Emailid1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("emailid");
        });

        modelBuilder.Entity<Emailsetting>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("emailsetting");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Apply)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apply");
            entity.Property(e => e.Emailids)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("emailids");
            entity.Property(e => e.Emailtext)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("emailtext");
            entity.Property(e => e.Essl)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("essl");
            entity.Property(e => e.Pass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pass");
            entity.Property(e => e.Portno)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("portno");
            entity.Property(e => e.Server)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("server");
            entity.Property(e => e.Setalert)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("setalert");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<EmpCardUpload>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("EmpCardUpload");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uploadedyn");
        });

        modelBuilder.Entity<EmpCatMaster>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("EmpCatMaster");

            entity.Property(e => e.Srno)
                .ValueGeneratedNever()
                .HasColumnName("srno");
            entity.Property(e => e.Catname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("catname");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Months).HasColumnName("months");
            entity.Property(e => e.Years).HasColumnName("years");
        });

        modelBuilder.Entity<EmpClassification>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("empClassification");

            entity.Property(e => e.Assignedby)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("assignedby");
            entity.Property(e => e.Assignedon)
                .HasColumnType("datetime")
                .HasColumnName("assignedon");
            entity.Property(e => e.Compid).HasColumnName("compid");
            entity.Property(e => e.Deptid).HasColumnName("deptid");
            entity.Property(e => e.Desgid).HasColumnName("desgid");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Locationid).HasColumnName("locationid");
            entity.Property(e => e.Sectionid).HasColumnName("sectionid");
            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<EmpDeptMaster>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK_EmployeeDepartmentDetails");

            entity.ToTable("EmpDeptMaster");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Assignedby)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("assignedby");
            entity.Property(e => e.Assignedon)
                .HasColumnType("datetime")
                .HasColumnName("assignedon");
            entity.Property(e => e.Deptid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deptid");
            entity.Property(e => e.Details)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Empid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empid");
            entity.Property(e => e.Enddate)
                .HasColumnType("datetime")
                .HasColumnName("enddate");
            entity.Property(e => e.Startdate)
                .HasColumnType("datetime")
                .HasColumnName("startdate");
        });

        modelBuilder.Entity<EmpRoaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Emp_Roaster");

            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Patternname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("patternname");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<EmpShiftMaster>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("EmpShiftMaster");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Contflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contflag");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Months).HasColumnName("months");
            entity.Property(e => e.Shiftid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("shiftid");
            entity.Property(e => e.Todates)
                .HasColumnType("datetime")
                .HasColumnName("todates");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.Years).HasColumnName("years");
        });

        modelBuilder.Entity<EmpViolationStatus>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("EmpViolationStatus");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardholderstatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardholderstatus");
            entity.Property(e => e.Changestatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("changestatus");
            entity.Property(e => e.Currentarea)
                .HasMaxLength(50)
                .HasColumnName("currentarea");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Lastdate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lastdate");
            entity.Property(e => e.Lastreaderaddress).HasColumnName("lastreaderaddress");
            entity.Property(e => e.Lastreadercontroller).HasColumnName("lastreadercontroller");
            entity.Property(e => e.Lastreaderinterfaceaddress).HasColumnName("lastreaderinterfaceaddress");
            entity.Property(e => e.Lasttime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lasttime");
            entity.Property(e => e.Uniqueid).HasColumnName("uniqueid");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uploadedyn");
            entity.Property(e => e.Violationaction).HasColumnName("violationaction");
            entity.Property(e => e.Violationarea)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("violationarea");
            entity.Property(e => e.Violationtype).HasColumnName("violationtype");
        });

        modelBuilder.Entity<Empimage>(entity =>
        {
            entity.ToTable("empimages");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Employeeimg)
                .HasColumnType("image")
                .HasColumnName("employeeimg");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("employee");

            entity.HasIndex(e => e.Empid, "UQ__employee__AF4CE864187A949F").IsUnique();

            entity.HasIndex(e => e.Empid, "UQ__employee__AF4CE864822C7000").IsUnique();

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Accessgroups)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("accessgroups");
            entity.Property(e => e.Accesstype)
                .HasDefaultValue(0)
                .HasColumnName("accesstype");
            entity.Property(e => e.Acsoperator)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACSOperator");
            entity.Property(e => e.Applyvalid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("applyvalid");
            entity.Property(e => e.Autoshift)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("autoshift");
            entity.Property(e => e.Barcode)
                .HasColumnType("image")
                .HasColumnName("barcode");
            entity.Property(e => e.Barcodedata)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("barcodedata");
            entity.Property(e => e.Biostaruserid).HasColumnName("biostaruserid");
            entity.Property(e => e.Blacklistdatetime)
                .HasColumnType("datetime")
                .HasColumnName("blacklistdatetime");
            entity.Property(e => e.Blacklistreason)
                .HasColumnType("text")
                .HasColumnName("blacklistreason");
            entity.Property(e => e.BloodGroup)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Busid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("busid");
            entity.Property(e => e.Caddress)
                .IsUnicode(false)
                .HasColumnName("CAddress");
            entity.Property(e => e.CardActivatedOn).HasColumnType("datetime");
            entity.Property(e => e.Carddata)
                .IsUnicode(false)
                .HasColumnName("carddata");
            entity.Property(e => e.Cardno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cardno");
            entity.Property(e => e.Category)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Cefield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cefield1");
            entity.Property(e => e.Cefield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cefield2");
            entity.Property(e => e.Cefield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cefield3");
            entity.Property(e => e.Cefield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cefield4");
            entity.Property(e => e.Cefield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cefield5");
            entity.Property(e => e.City)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Clmscategory).HasColumnName("clmscategory");
            entity.Property(e => e.Clmsjobno)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("clmsjobno");
            entity.Property(e => e.Clmspassno).HasColumnName("clmspassno");
            entity.Property(e => e.Clmspasstype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("clmspasstype");
            entity.Property(e => e.Comment)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("comment");
            entity.Property(e => e.Compid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Controllergroupids)
                .IsUnicode(false)
                .HasColumnName("controllergroupids");
            entity.Property(e => e.Dependant)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.DeptName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Designation)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Districtid).HasColumnName("districtid");
            entity.Property(e => e.Dob)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DOB");
            entity.Property(e => e.Doj)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DOJ");
            entity.Property(e => e.Email)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.EmergencyPhno)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmergencyPhnoRelatn)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Empcatgory)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("empcatgory");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empcode");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.EmployeeRegisteredOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Empno).HasColumnName("empno");
            entity.Property(e => e.Empproject).HasColumnName("empproject");
            entity.Property(e => e.Emptype)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("emptype");
            entity.Property(e => e.Enrollno).HasColumnName("enrollno");
            entity.Property(e => e.Extendedyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("extendedyn");
            entity.Property(e => e.Faceauth).HasColumnName("faceauth");
            entity.Property(e => e.Facecount).HasColumnName("facecount");
            entity.Property(e => e.Facepath)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("facepath");
            entity.Property(e => e.Facilitycode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("facilitycode");
            entity.Property(e => e.FatherName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Fname)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("FName");
            entity.Property(e => e.Gender)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Idledayscomment)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("idledayscomment");
            entity.Property(e => e.Ieeflag).HasColumnName("ieeflag");
            entity.Property(e => e.Inschedelevator).HasColumnName("inschedelevator");
            entity.Property(e => e.Isblacklist)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("isblacklist");
            entity.Property(e => e.Ishmelemployee)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ishmelemployee");
            entity.Property(e => e.Language)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("language");
            entity.Property(e => e.Lapheadids)
                .IsUnicode(false)
                .HasColumnName("lapheadids");
            entity.Property(e => e.Laptopdetails)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("laptopdetails");
            entity.Property(e => e.Lastupdated)
                .HasColumnType("datetime")
                .HasColumnName("lastupdated");
            entity.Property(e => e.Ldate)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("LDate");
            entity.Property(e => e.Lname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("LName");
            entity.Property(e => e.Locationid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Mobheadids)
                .IsUnicode(false)
                .HasColumnName("mobheadids");
            entity.Property(e => e.Mobiledetails)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("mobiledetails");
            entity.Property(e => e.Mobno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mobno");
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nofmt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nofmt");
            entity.Property(e => e.Onlyattdevices)
                .IsUnicode(false)
                .HasColumnName("onlyattdevices");
            entity.Property(e => e.Ontrace)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("False")
                .HasColumnName("ontrace");
            entity.Property(e => e.Outschedelevator).HasColumnName("outschedelevator");
            entity.Property(e => e.Paddress)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("PAddress");
            entity.Property(e => e.Passtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("passtype");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pbexemptyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("pbexemptyn");
            entity.Property(e => e.Pfno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pfno");
            entity.Property(e => e.Phno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Photo)
                .HasColumnType("image")
                .HasColumnName("photo");
            entity.Property(e => e.Picture).HasColumnType("image");
            entity.Property(e => e.Pin)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("pin");
            entity.Property(e => e.Pincmdsyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("pincmdsyn");
            entity.Property(e => e.Pincode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Pinexemptyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("pinexemptyn");
            entity.Property(e => e.Qualification)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Readerids)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("readerids");
            entity.Property(e => e.ReasonL)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Registeredcontroller)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("registeredcontroller");
            entity.Property(e => e.Remarks)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Rids)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("rids");
            entity.Property(e => e.Roasterpattern)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("roasterpattern");
            entity.Property(e => e.Roleid)
                .HasDefaultValue(0)
                .HasColumnName("roleid");
            entity.Property(e => e.Sapcode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sapcode");
            entity.Property(e => e.Section)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("section");
            entity.Property(e => e.Sign)
                .HasColumnType("image")
                .HasColumnName("sign");
            entity.Property(e => e.State)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Stateid).HasColumnName("stateid");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Subcontractor)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("subcontractor");
            entity.Property(e => e.Taluka)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("taluka");
            entity.Property(e => e.Tokenno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tokenno");
            entity.Property(e => e.Traceremark)
                .IsUnicode(false)
                .HasColumnName("traceremark");
            entity.Property(e => e.Tzids)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("tzids");
            entity.Property(e => e.Uniqueid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("uniqueid");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("uploadedyn");
            entity.Property(e => e.Validfrom)
                .HasColumnType("datetime")
                .HasColumnName("validfrom");
            entity.Property(e => e.Validto)
                .HasColumnType("datetime")
                .HasColumnName("validto");
            entity.Property(e => e.Veeflag).HasColumnName("veeflag");
            entity.Property(e => e.Villageid).HasColumnName("villageid");
            entity.Property(e => e.Wkoff)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("wkoff");
            entity.Property(e => e.Woff)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Workarea).HasColumnName("workarea");
        });

        modelBuilder.Entity<Employee2>(entity =>
        {
            entity.HasKey(e => e.Empid);

            entity.ToTable("employee2");

            entity.HasIndex(e => e.Empid, "UQ__employee__AF4CE864B987B98E").IsUnique();

            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Addpath)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("addpath");
            entity.Property(e => e.Addressproofid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("addressproofid");
            entity.Property(e => e.Addressprooftype).HasColumnName("addressprooftype");
            entity.Property(e => e.Advsafetrai).HasColumnName("advsafetrai");
            entity.Property(e => e.Ateflag).HasColumnName("ateflag");
            entity.Property(e => e.Bp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bp");
            entity.Property(e => e.Caddress)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CAddress");
            entity.Property(e => e.Cat2eflag).HasColumnName("cat2eflag");
            entity.Property(e => e.Category)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("category");
            entity.Property(e => e.City)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Clmspasstype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("clmspasstype");
            entity.Property(e => e.Complocid).HasColumnName("complocid");
            entity.Property(e => e.Countryid).HasColumnName("countryid");
            entity.Property(e => e.Deptid).HasColumnName("deptid");
            entity.Property(e => e.Desgid).HasColumnName("desgid");
            entity.Property(e => e.Distid).HasColumnName("distid");
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.Dopetest)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dopetest");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Empcode).HasColumnName("empcode");
            entity.Property(e => e.Empimage)
                .HasColumnType("image")
                .HasColumnName("empimage");
            entity.Property(e => e.Enrollno).HasColumnName("enrollno");
            entity.Property(e => e.Eweflag).HasColumnName("eweflag");
            entity.Property(e => e.Exitgate).HasColumnName("exitgate");
            entity.Property(e => e.Exitgatereason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("exitgatereason");
            entity.Property(e => e.Eyetest)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("eyetest");
            entity.Property(e => e.FatherName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Fname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("FName");
            entity.Property(e => e.Gender)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Hlchecked).HasColumnName("hlchecked");
            entity.Property(e => e.Hldocuments)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("hldocuments");
            entity.Property(e => e.Hlreason)
                .HasColumnType("text")
                .HasColumnName("hlreason");
            entity.Property(e => e.Idpath)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("idpath");
            entity.Property(e => e.Idproofid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("idproofid");
            entity.Property(e => e.Idprooftype).HasColumnName("idprooftype");
            entity.Property(e => e.Ifforientation).HasColumnName("ifforientation");
            entity.Property(e => e.Iifexpwork).HasColumnName("iifexpwork");
            entity.Property(e => e.Iifmskm1).HasColumnName("iifmskm1");
            entity.Property(e => e.Iifmskm2).HasColumnName("iifmskm2");
            entity.Property(e => e.Language)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("language");
            entity.Property(e => e.Lname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LName");
            entity.Property(e => e.Medicalcheked).HasColumnName("medicalcheked");
            entity.Property(e => e.Medicalreason)
                .HasColumnType("text")
                .HasColumnName("medicalreason");
            entity.Property(e => e.Mobno).HasColumnName("mobno");
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Otherdocs)
                .HasColumnType("text")
                .HasColumnName("otherdocs");
            entity.Property(e => e.Otherdocspath)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("otherdocspath");
            entity.Property(e => e.Paddress)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PAddress");
            entity.Property(e => e.Passtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("passtype");
            entity.Property(e => e.Photo)
                .HasColumnType("image")
                .HasColumnName("photo");
            entity.Property(e => e.Pic)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("pic");
            entity.Property(e => e.Policeverify).HasColumnName("policeverify");
            entity.Property(e => e.Policevpath)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("policevpath");
            entity.Property(e => e.Qualification)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RenewSafetyrejectreason)
                .IsUnicode(false)
                .HasColumnName("renew_safetyrejectreason");
            entity.Property(e => e.Renewadv).HasColumnName("renewadv");
            entity.Property(e => e.Rensafetyinduction).HasColumnName("rensafetyinduction");
            entity.Property(e => e.Resafetyremark)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("resafetyremark");
            entity.Property(e => e.Resafetyremarkcat1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("resafetyremarkcat1");
            entity.Property(e => e.Resafetyremarkcat2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("resafetyremarkcat2");
            entity.Property(e => e.Resafetyremarkcat3)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("resafetyremarkcat3");
            entity.Property(e => e.Safetychecked).HasColumnName("safetychecked");
            entity.Property(e => e.Safetyinduction).HasColumnName("safetyinduction");
            entity.Property(e => e.Safetyreason)
                .HasColumnType("text")
                .HasColumnName("safetyreason");
            entity.Property(e => e.Safetyremark)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("safetyremark");
            entity.Property(e => e.Securityapproveddate).HasColumnName("securityapproveddate");
            entity.Property(e => e.Securitychecked)
                .HasDefaultValue((byte)0)
                .HasColumnName("securitychecked");
            entity.Property(e => e.Securitycheckeddate).HasColumnName("securitycheckeddate");
            entity.Property(e => e.Securityrejecteddate).HasColumnName("securityrejecteddate");
            entity.Property(e => e.Securityrejectflag).HasColumnName("securityrejectflag");
            entity.Property(e => e.Securityrejectreason)
                .IsUnicode(false)
                .HasColumnName("securityrejectreason");
            entity.Property(e => e.State)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Stateid).HasColumnName("stateid");
            entity.Property(e => e.Subcon)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("subcon");
            entity.Property(e => e.Subcontractor)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("subcontractor");
            entity.Property(e => e.Talukaid).HasColumnName("talukaid");
            entity.Property(e => e.Tokenno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tokenno");
            entity.Property(e => e.Totalchecked).HasColumnName("totalchecked");
            entity.Property(e => e.Usertype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usertype");
            entity.Property(e => e.Villageid).HasColumnName("villageid");
            entity.Property(e => e.Workorderno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("workorderno");
        });

        modelBuilder.Entity<EmployeeLeave>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("employee_leave$PrimaryKey");

            entity.ToTable("employee_leave");

            entity.Property(e => e.Srno).ValueGeneratedNever();
            entity.Property(e => e.Applydate)
                .HasColumnType("datetime")
                .HasColumnName("applydate");
            entity.Property(e => e.Empid).HasDefaultValue(0);
            entity.Property(e => e.Financeyear)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("financeyear");
            entity.Property(e => e.Fromdate).HasColumnType("datetime");
            entity.Property(e => e.LeaveCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Noofdays)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("noofdays");
            entity.Property(e => e.Notes)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Todate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Employeeawayentry>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("employeeawayentries");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Addeddatetime)
                .HasColumnType("datetime")
                .HasColumnName("addeddatetime");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Fromdatetime)
                .HasColumnType("datetime")
                .HasColumnName("fromdatetime");
            entity.Property(e => e.Fromprocessed)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fromprocessed");
            entity.Property(e => e.Todatetime)
                .HasColumnType("datetime")
                .HasColumnName("todatetime");
            entity.Property(e => e.Toprocessed)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("toprocessed");
        });

        modelBuilder.Entity<Employeepassentry>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__employeepassentry__6477ECF3");

            entity.ToTable("employeepassentry");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empcode");
            entity.Property(e => e.Empid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("empid");
            entity.Property(e => e.EntryDate)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("entryDate");
            entity.Property(e => e.Entrytime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("entrytime");
        });

        modelBuilder.Entity<Employeerenewcancel>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK_employeerenewcancel_1");

            entity.ToTable("employeerenewcancel");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Advsafetrai).HasColumnName("advsafetrai");
            entity.Property(e => e.Bp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bp");
            entity.Property(e => e.Category)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("category");
            entity.Property(e => e.Clmspasstype)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("clmspasstype");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Dopetest)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dopetest");
            entity.Property(e => e.Eicchecked).HasColumnName("eicchecked");
            entity.Property(e => e.Eicid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("eicid");
            entity.Property(e => e.Empcode).HasColumnName("empcode");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Enrollno).HasColumnName("enrollno");
            entity.Property(e => e.Eyetest)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("eyetest");
            entity.Property(e => e.Hlchecked).HasColumnName("hlchecked");
            entity.Property(e => e.Hlreason)
                .HasColumnType("text")
                .HasColumnName("hlreason");
            entity.Property(e => e.Iifexpwork).HasColumnName("iifexpwork");
            entity.Property(e => e.Iifmskm1).HasColumnName("iifmskm1");
            entity.Property(e => e.Iifmskm2).HasColumnName("iifmskm2");
            entity.Property(e => e.Medicalcheked).HasColumnName("medicalcheked");
            entity.Property(e => e.Medicalreason)
                .HasColumnType("text")
                .HasColumnName("medicalreason");
            entity.Property(e => e.Passtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("passtype");
            entity.Property(e => e.Safetychecked).HasColumnName("safetychecked");
            entity.Property(e => e.Safetyreason)
                .HasColumnType("text")
                .HasColumnName("safetyreason");
            entity.Property(e => e.Securitychecked)
                .HasDefaultValue((byte)0)
                .HasColumnName("securitychecked");
            entity.Property(e => e.Securitycheckeddate).HasColumnName("securitycheckeddate");
            entity.Property(e => e.Securityrejecteddate).HasColumnName("securityrejecteddate");
            entity.Property(e => e.Securityrejectflag).HasColumnName("securityrejectflag");
            entity.Property(e => e.Securityrejectreason)
                .IsUnicode(false)
                .HasColumnName("securityrejectreason");
            entity.Property(e => e.Tokenno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tokenno");
            entity.Property(e => e.Totalchecked).HasColumnName("totalchecked");
            entity.Property(e => e.Usertype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usertype");
            entity.Property(e => e.Workorderno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("workorderno");
        });

        modelBuilder.Entity<Empviewreport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("empviewreport");

            entity.Property(e => e.Checked)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("checked");
            entity.Property(e => e.Displayname)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("displayname");
            entity.Property(e => e.Formname)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("formname");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<Engineer>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.Property(e => e.Address)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Contact)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Details)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Ecode)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.EngineerName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Erpreportsetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("erpreportsettings");

            entity.Property(e => e.Columnstring)
                .IsUnicode(false)
                .HasColumnName("columnstring");
            entity.Property(e => e.Dateformat)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("dateformat");
            entity.Property(e => e.Dateseparator)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("dateseparator");
            entity.Property(e => e.Extension)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("extension");
            entity.Property(e => e.Fieldcount).HasColumnName("fieldcount");
            entity.Property(e => e.Fieldseparator)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("fieldseparator");
            entity.Property(e => e.Flag)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Formatstring)
                .IsUnicode(false)
                .HasColumnName("formatstring");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Notes1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes1");
            entity.Property(e => e.Reportname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("reportname");
            entity.Property(e => e.Reporttype)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("reporttype");
            entity.Property(e => e.Rowcount).HasColumnName("rowcount");
            entity.Property(e => e.Rowterminator)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("rowterminator");
            entity.Property(e => e.Showheader)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("showheader");
            entity.Property(e => e.Srno).HasColumnName("srno");
        });

        modelBuilder.Entity<Errorlog>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("errorlog");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Error)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("error");
        });

        modelBuilder.Entity<EventMaster>(entity =>
        {
            entity.HasKey(e => e.EventId);

            entity.ToTable("Event_Master");

            entity.Property(e => e.EventId)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("eventId");
            entity.Property(e => e.Classcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("classcode");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Eventcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("eventcode");
            entity.Property(e => e.Taskcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("taskcode");
        });

        modelBuilder.Entity<Failedapihit>(entity =>
        {
            entity.ToTable("failedapihits");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Attempts).HasColumnName("attempts");
            entity.Property(e => e.Data)
                .HasColumnType("text")
                .HasColumnName("data");
            entity.Property(e => e.Lastattempttime)
                .HasColumnType("datetime")
                .HasColumnName("lastattempttime");
            entity.Property(e => e.Lastresponse)
                .HasColumnType("text")
                .HasColumnName("lastresponse");
            entity.Property(e => e.Laststatuscode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("laststatuscode");
            entity.Property(e => e.Url)
                .HasColumnType("text")
                .HasColumnName("url");
        });

        modelBuilder.Entity<Failnotify>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("failnotify");

            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Cip)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("cip");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Emailids)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("emailids");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<FloorMaster>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("FloorMaster");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Details)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Floorno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("floorno");
        });

        modelBuilder.Entity<FormDetail>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Displayname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("displayname");
            entity.Property(e => e.Flag)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Formname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("formname");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Userlevel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("userlevel");
        });

        modelBuilder.Entity<FormatsUpload>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("FormatsUpload");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Facilitycode).HasColumnName("facilitycode");
            entity.Property(e => e.Filepath)
                .IsUnicode(false)
                .HasColumnName("filepath");
            entity.Property(e => e.Formatname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("formatname");
            entity.Property(e => e.Uploadeddate)
                .HasColumnType("datetime")
                .HasColumnName("uploadeddate");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("false")
                .HasColumnName("uploadedyn");
        });

        modelBuilder.Entity<Fpmaster>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__fpmaster__4A8310C6");

            entity.ToTable("fpmaster");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Fp).HasColumnName("fp");
            entity.Property(e => e.Fpimg)
                .HasColumnType("image")
                .HasColumnName("fpimg");
            entity.Property(e => e.Tmpsize)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("tmpsize");
            entity.Property(e => e.Visitorid).HasColumnName("visitorid");
        });

        modelBuilder.Entity<Fptemplate>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("fptemplates");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cardno");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Downloaddate)
                .HasColumnType("datetime")
                .HasColumnName("downloaddate");
            entity.Property(e => e.Findata)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("findata");
            entity.Property(e => e.Finid).HasColumnName("finid");
            entity.Property(e => e.Finlen).HasColumnName("finlen");
            entity.Property(e => e.Finno).HasColumnName("finno");
            entity.Property(e => e.Fintype).HasColumnName("fintype");
            entity.Property(e => e.Rno).HasColumnName("rno");
        });

        modelBuilder.Entity<FptemplatesDriver>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("fptemplatesDriver");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cardno");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Downloaddate)
                .HasColumnType("datetime")
                .HasColumnName("downloaddate");
            entity.Property(e => e.Findata)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("findata");
            entity.Property(e => e.Finid).HasColumnName("finid");
            entity.Property(e => e.Finlen).HasColumnName("finlen");
            entity.Property(e => e.Finno).HasColumnName("finno");
            entity.Property(e => e.Fintype).HasColumnName("fintype");
            entity.Property(e => e.Rno).HasColumnName("rno");
        });

        modelBuilder.Entity<FptemplatesHelper>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("fptemplatesHelper");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cardno");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Downloaddate)
                .HasColumnType("datetime")
                .HasColumnName("downloaddate");
            entity.Property(e => e.Findata)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("findata");
            entity.Property(e => e.Finid).HasColumnName("finid");
            entity.Property(e => e.Finlen).HasColumnName("finlen");
            entity.Property(e => e.Finno).HasColumnName("finno");
            entity.Property(e => e.Fintype).HasColumnName("fintype");
            entity.Property(e => e.Rno).HasColumnName("rno");
        });

        modelBuilder.Entity<Fptemplatescontractvisitor>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("fptemplatescontractvisitor");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cardno");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Downloaddate)
                .HasColumnType("datetime")
                .HasColumnName("downloaddate");
            entity.Property(e => e.Findata)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("findata");
            entity.Property(e => e.Finid).HasColumnName("finid");
            entity.Property(e => e.Finlen).HasColumnName("finlen");
            entity.Property(e => e.Finno).HasColumnName("finno");
            entity.Property(e => e.Fintype).HasColumnName("fintype");
            entity.Property(e => e.Rno).HasColumnName("rno");
        });

        modelBuilder.Entity<Fptemplatesvisitor>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("fptemplatesvisitor");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cardno");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Downloaddate)
                .HasColumnType("datetime")
                .HasColumnName("downloaddate");
            entity.Property(e => e.Findata)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("findata");
            entity.Property(e => e.Finid).HasColumnName("finid");
            entity.Property(e => e.Finlen).HasColumnName("finlen");
            entity.Property(e => e.Finno).HasColumnName("finno");
            entity.Property(e => e.Fintype).HasColumnName("fintype");
            entity.Property(e => e.Rno).HasColumnName("rno");
        });

        modelBuilder.Entity<GadgetAllowed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GadgetAllowed");

            entity.Property(e => e.Empid)
                .IsUnicode(false)
                .HasColumnName("empid");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Status)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Gatedetail>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("gatedetails");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Details)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("details");
            entity.Property(e => e.Gateno).HasColumnName("gateno");
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id");
        });

        modelBuilder.Entity<GatepassProfile>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__GatepassProfiles__45BE5BA9");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Compid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Floor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("floor");
            entity.Property(e => e.Floorwise)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("floorwise");
            entity.Property(e => e.Hostid).HasColumnName("hostid");
            entity.Property(e => e.Locationid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Profile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("profile");
            entity.Property(e => e.Profilefor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("profilefor");
        });

        modelBuilder.Entity<Gatepassdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("gatepassdetails");

            entity.Property(e => e.Accessgroup)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("accessgroup");
            entity.Property(e => e.Acscardno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("acscardno");
            entity.Property(e => e.Addedby)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("addedby");
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.Automailerflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("automailerflag");
            entity.Property(e => e.Barcode)
                .HasColumnType("image")
                .HasColumnName("barcode");
            entity.Property(e => e.Barcodedata)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("barcodedata");
            entity.Property(e => e.BuildingName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BuildingNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cardno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardno");
            entity.Property(e => e.Cardstatus).HasColumnName("cardstatus");
            entity.Property(e => e.Carrylaptop)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("carrylaptop");
            entity.Property(e => e.Carrymobile)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("carrymobile");
            entity.Property(e => e.Carrymobilewithcamera)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("carrymobilewithcamera");
            entity.Property(e => e.Carryother)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("carryother");
            entity.Property(e => e.Carryotherdetails)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("carryotherdetails");
            entity.Property(e => e.Carrytoolkit)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("carrytoolkit");
            entity.Property(e => e.CheckReturnable)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("checkReturnable");
            entity.Property(e => e.Company)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("company");
            entity.Property(e => e.ContractNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Controllerids)
                .IsUnicode(false)
                .HasColumnName("controllerids");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Depolaptop)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("depolaptop");
            entity.Property(e => e.Depomobile)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("depomobile");
            entity.Property(e => e.Depoother)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("depoother");
            entity.Property(e => e.Depootherdetails)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("depootherdetails");
            entity.Property(e => e.Emailid)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Empid)
                .HasDefaultValueSql("('0')")
                .HasColumnName("empid");
            entity.Property(e => e.Expectedouttime)
                .HasColumnType("datetime")
                .HasColumnName("expectedouttime");
            entity.Property(e => e.Flag)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.FloorNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("floorNo");
            entity.Property(e => e.Gateno).HasColumnName("gateno");
            entity.Property(e => e.Gatepassaddeddate)
                .HasColumnType("datetime")
                .HasColumnName("gatepassaddeddate");
            entity.Property(e => e.Gatepassno).HasColumnName("gatepassno");
            entity.Property(e => e.HostDept)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hostcomments)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("hostcomments");
            entity.Property(e => e.Hostcompany)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("hostcompany");
            entity.Property(e => e.Hostmailresponse)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("hostmailresponse");
            entity.Property(e => e.Hostresponse)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("NA")
                .HasColumnName("hostresponse");
            entity.Property(e => e.Hostsmsresponse)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("hostsmsresponse");
            entity.Property(e => e.Hostsmstext)
                .IsUnicode(false)
                .HasColumnName("hostsmstext");
            entity.Property(e => e.Id)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Idno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IDNo");
            entity.Property(e => e.Idprooftype)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("idprooftype");
            entity.Property(e => e.Intime)
                .HasDefaultValue(new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime")
                .HasColumnName("intime");
            entity.Property(e => e.Laptopserialno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("laptopserialno");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Mailsentflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("mailsentflag");
            entity.Property(e => e.MaterialInside)
                .HasMaxLength(1500)
                .IsUnicode(false);
            entity.Property(e => e.MaterialOutside)
                .HasMaxLength(1500)
                .IsUnicode(false);
            entity.Property(e => e.Mobileno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("mobileno");
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Notes)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Outtime)
                .HasDefaultValue(new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime")
                .HasColumnName("outtime");
            entity.Property(e => e.Phno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phno");
            entity.Property(e => e.Photopath)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("photopath");
            entity.Property(e => e.Praposedouttime)
                .HasColumnType("datetime")
                .HasColumnName("praposedouttime");
            entity.Property(e => e.Processedautosignout)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("processedautosignout");
            entity.Property(e => e.Processedautovaliditysignout)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("processedautovaliditysignout");
            entity.Property(e => e.Profilefor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("profilefor");
            entity.Property(e => e.Purpose)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("purpose");
            entity.Property(e => e.SignVerifynew)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("signVerifynew");
            entity.Property(e => e.Tokenno)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("tokenno");
            entity.Property(e => e.Tomeet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tomeet");
            entity.Property(e => e.TransportMode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ValidFrom)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("validFrom");
            entity.Property(e => e.ValidThru)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("validThru");
            entity.Property(e => e.Validfromdate)
                .HasColumnType("datetime")
                .HasColumnName("validfromdate");
            entity.Property(e => e.Validfromtime)
                .HasColumnType("datetime")
                .HasColumnName("validfromtime");
            entity.Property(e => e.Validtodate)
                .HasColumnType("datetime")
                .HasColumnName("validtodate");
            entity.Property(e => e.Validtotime)
                .HasColumnType("datetime")
                .HasColumnName("validtotime");
            entity.Property(e => e.Vehicle)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("vehicle");
            entity.Property(e => e.Vehicleno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vehicleno");
            entity.Property(e => e.Vehicletype)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vehicletype");
            entity.Property(e => e.Viscount).HasColumnName("viscount");
            entity.Property(e => e.Visitarea)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("visitarea");
            entity.Property(e => e.VisitorIdproofNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VisitorIDproofNo");
            entity.Property(e => e.Visitorid)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("visitorid");
            entity.Property(e => e.Visitorname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("visitorname");
            entity.Property(e => e.Visitortype)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("visitortype");
            entity.Property(e => e.Vpassno)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("vpassno");
            entity.Property(e => e.Wivisitarea)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("wivisitarea");
            entity.Property(e => e.Wiworkarea)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("wiworkarea");
            entity.Property(e => e.Zoneno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("zoneno");
        });

        modelBuilder.Entity<Gatepassentry>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("gatepassentry");

            entity.Property(e => e.ApproveDate).HasColumnType("datetime");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Approvers)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Details)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Empid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empid");
            entity.Property(e => e.Fromtime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fromtime");
            entity.Property(e => e.IsNotify)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("isNotify");
            entity.Property(e => e.Notes)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Requestdate)
                .HasColumnType("datetime")
                .HasColumnName("requestdate");
            entity.Property(e => e.Requestid).HasColumnName("requestid");
            entity.Property(e => e.Smstext)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("smstext");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.ToApprove)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Totime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("totime");
        });

        modelBuilder.Entity<HEvent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("h_events");

            entity.Property(e => e.Eventcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("eventcode");
            entity.Property(e => e.Eventdesc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("eventdesc");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<HelperDetail>(entity =>
        {
            entity.HasKey(e => e.Empid);

            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Accessgroups)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("accessgroups");
            entity.Property(e => e.Accesstype).HasColumnName("accesstype");
            entity.Property(e => e.Applyvalid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("applyvalid");
            entity.Property(e => e.Blacklisted)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("blacklisted");
            entity.Property(e => e.Caddress)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("CAddress");
            entity.Property(e => e.Cardno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cardno");
            entity.Property(e => e.Compid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.DeptName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Designation)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DhAutoUnreged)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Dob)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DOB");
            entity.Property(e => e.Doj)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DOJ");
            entity.Property(e => e.Email)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empcode");
            entity.Property(e => e.Enrollno).HasColumnName("enrollno");
            entity.Property(e => e.Extendedyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("extendedyn");
            entity.Property(e => e.Facilitycode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("facilitycode");
            entity.Property(e => e.FatherName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Inschedelevator).HasColumnName("inschedelevator");
            entity.Property(e => e.Ldate)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("LDate");
            entity.Property(e => e.Locationid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Name)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Nofmt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nofmt");
            entity.Property(e => e.Otlno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OTLNo");
            entity.Property(e => e.Outschedelevator).HasColumnName("outschedelevator");
            entity.Property(e => e.Paddress)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("PAddress");
            entity.Property(e => e.Pbexemptyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("pbexemptyn");
            entity.Property(e => e.Pfno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pfno");
            entity.Property(e => e.Phno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Photo)
                .HasColumnType("image")
                .HasColumnName("photo");
            entity.Property(e => e.Pin)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("pin");
            entity.Property(e => e.Pinexemptyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("pinexemptyn");
            entity.Property(e => e.Policeverification)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("policeverification");
            entity.Property(e => e.Roleid).HasColumnName("roleid");
            entity.Property(e => e.Section)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("section");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Uniqueid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("uniqueid");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("uploadedyn");
            entity.Property(e => e.Validfrom)
                .HasColumnType("datetime")
                .HasColumnName("validfrom");
            entity.Property(e => e.Validto)
                .HasColumnType("datetime")
                .HasColumnName("validto");
        });

        modelBuilder.Entity<HiMajorevent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("hi_majorevents");

            entity.Property(e => e.Eventid).HasColumnName("eventid");
            entity.Property(e => e.Eventname)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("eventname");
        });

        modelBuilder.Entity<HiMasterapb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("hi_masterapb");

            entity.Property(e => e.Apbid)
                .ValueGeneratedOnAdd()
                .HasColumnName("apbid");
            entity.Property(e => e.Apbname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apbname");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Initrno).HasColumnName("initrno");
        });

        modelBuilder.Entity<HiMinorevent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("hi_minorevents");

            entity.Property(e => e.Eventid).HasColumnName("eventid");
            entity.Property(e => e.Eventname)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("eventname");
            entity.Property(e => e.Majoreventid).HasColumnName("majoreventid");
        });

        modelBuilder.Entity<HikIorule>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("hik_iorule");

            entity.Property(e => e.Alarmout)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("alarmout");
            entity.Property(e => e.Cardno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cardno");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Closedoor)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("closedoor");
            entity.Property(e => e.Eventorcard).HasColumnName("eventorcard");
            entity.Property(e => e.Inputsource).HasColumnName("inputsource");
            entity.Property(e => e.Mainbuzzer).HasColumnName("mainbuzzer");
            entity.Property(e => e.Majoreventid).HasColumnName("majoreventid");
            entity.Property(e => e.Minoreventid).HasColumnName("minoreventid");
            entity.Property(e => e.Normalclose)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("normalclose");
            entity.Property(e => e.Normalopen)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("normalopen");
            entity.Property(e => e.Opendoor)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("opendoor");
            entity.Property(e => e.Readerbuzzer)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("readerbuzzer");
            entity.Property(e => e.Ruleid)
                .ValueGeneratedOnAdd()
                .HasColumnName("ruleid");
            entity.Property(e => e.Rulename)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("rulename");
            entity.Property(e => e.Snapshot)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("snapshot");
        });

        modelBuilder.Entity<Htmplogtbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("htmplogtbl");

            entity.Property(e => e.Category)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("category");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Empid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empid");
            entity.Property(e => e.Employeename)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("employeename");
            entity.Property(e => e.Passtype)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("passtype");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Stat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("stat");
            entity.Property(e => e.Tokengenerated)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tokengenerated");
            entity.Property(e => e.Usertype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usertype");
            entity.Property(e => e.Vendername)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendername");
            entity.Property(e => e.Vendorid).HasColumnName("vendorid");
            entity.Property(e => e.Workarea).HasColumnName("workarea");
            entity.Property(e => e.Workorderid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("workorderid");
        });

        modelBuilder.Entity<Htmplogtbl2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("htmplogtbl2");

            entity.Property(e => e.Category)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("category");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Empid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empid");
            entity.Property(e => e.Employeename)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("employeename");
            entity.Property(e => e.Passtype)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("passtype");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Stat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("stat");
            entity.Property(e => e.Tokengenerated)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tokengenerated");
            entity.Property(e => e.Usertype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usertype");
            entity.Property(e => e.Vendername)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendername");
            entity.Property(e => e.Vendorid).HasColumnName("vendorid");
            entity.Property(e => e.Workarea).HasColumnName("workarea");
            entity.Property(e => e.Workorderid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("workorderid");
        });

        modelBuilder.Entity<IdproofType>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK_idprooftype");

            entity.ToTable("IDProofType");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Idprooftype1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("idprooftype");
        });

        modelBuilder.Entity<Imagemaster>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__imagemaster__43D61337");

            entity.ToTable("imagemaster");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Image)
                .HasColumnType("image")
                .HasColumnName("image");
            entity.Property(e => e.Visitorid).HasColumnName("visitorid");
        });

        modelBuilder.Entity<Imgpath>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("imgpath");

            entity.Property(e => e.Imgpath1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("imgpath");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<Input>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("inputs");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Bit1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("bit1");
            entity.Property(e => e.Bit2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("bit2");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Flipmode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flipmode");
            entity.Property(e => e.Funccode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("funccode");
            entity.Property(e => e.Iid).HasColumnName("iid");
            entity.Property(e => e.Iname)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("iname");
            entity.Property(e => e.Input1).HasColumnName("input");
            entity.Property(e => e.Ivalue)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ivalue");
            entity.Property(e => e.Resetmode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("resetmode");
        });

        modelBuilder.Entity<Iofunction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("iofunctions");

            entity.Property(e => e.Ctype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ctype");
            entity.Property(e => e.Details)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Fc).HasColumnName("fc");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<IolinkerRule>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("IOLinkerRule");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Feature)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("feature");
            entity.Property(e => e.Flag)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Linkerrule)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("linkerrule");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uploadedyn");
        });

        modelBuilder.Entity<IolinkerUpload>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IOLinkerUpload");

            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uploadedyn");
        });

        modelBuilder.Entity<Iorule>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("iorules");

            entity.Property(e => e.Bit1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("bit1");
            entity.Property(e => e.Bit2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("bit2");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Details)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Eventmsgno).HasColumnName("eventmsgno");
            entity.Property(e => e.Flipmode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flipmode");
            entity.Property(e => e.Funccode).HasColumnName("funccode");
            entity.Property(e => e.Inputs)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("inputs");
            entity.Property(e => e.Inverseinput)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("inverseinput");
            entity.Property(e => e.Ionote1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ionote1");
            entity.Property(e => e.Ionote2)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ionote2");
            entity.Property(e => e.Ionote3)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ionote3");
            entity.Property(e => e.Openclose)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("openclose");
            entity.Property(e => e.Outputs)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("outputs");
            entity.Property(e => e.Popup)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("popup");
            entity.Property(e => e.Resetfunc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("resetfunc");
            entity.Property(e => e.Resetmode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("resetmode");
            entity.Property(e => e.Rulename)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("rulename");
            entity.Property(e => e.Ruleval)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ruleval");
            entity.Property(e => e.Ruleval2)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ruleval2");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<Iostatus>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("iostatus");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Bit1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("bit1");
            entity.Property(e => e.Bit2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("bit2");
            entity.Property(e => e.Ctype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ctype");
            entity.Property(e => e.Details)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Flipmode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flipmode");
            entity.Property(e => e.Resetfunc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("resetfunc");
            entity.Property(e => e.Resetmode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("resetmode");
            entity.Property(e => e.Statusbit).HasColumnName("statusbit");
        });

        modelBuilder.Entity<IsecureEmailLog>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Details)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.From)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("from");
            entity.Property(e => e.Status)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.To)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("to");
            entity.Property(e => e.Type)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.ToTable("Language");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Laptopassignmentsetting>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("laptopassignmentsettings");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Ignoredurationsec).HasColumnName("ignoredurationsec");
            entity.Property(e => e.Inreaderid).HasColumnName("inreaderid");
            entity.Property(e => e.Outreaderid).HasColumnName("outreaderid");
        });

        modelBuilder.Entity<Lateearlypenalty>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("lateearlypenalty");

            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Daystatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("daystatus");
            entity.Property(e => e.Dedcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dedcode");
            entity.Property(e => e.Dedcount).HasColumnName("dedcount");
            entity.Property(e => e.Dedtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dedtype");
            entity.Property(e => e.Empid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Years).HasColumnName("years");
        });

        modelBuilder.Entity<LeaveAccumulation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("leave_accumulation");

            entity.Property(e => e.AccAllowed).HasColumnName("acc_allowed");
            entity.Property(e => e.Catname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("catname");
            entity.Property(e => e.Empid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empid");
            entity.Property(e => e.Financeyear)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("financeyear");
            entity.Property(e => e.LeaveTransferred).HasColumnName("leave_transferred");
            entity.Property(e => e.Leavecode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("leavecode");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<LeaveAllocation>(entity =>
        {
            entity.HasKey(e => e.SrNo).HasName("leave_allocation$PrimaryKey");

            entity.ToTable("leave_allocation");

            entity.Property(e => e.Actions)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Balance).HasDefaultValue(0);
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Empid).HasDefaultValue(0);
            entity.Property(e => e.LeaveCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NoOfdays)
                .HasDefaultValue(0)
                .HasColumnName("NoOFdays");
            entity.Property(e => e.Notes)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Periods)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LeaveDetail>(entity =>
        {
            entity.HasKey(e => e.SrNo).HasName("leave_details$PrimaryKey");

            entity.ToTable("leave_details");

            entity.Property(e => e.Applydate)
                .HasColumnType("datetime")
                .HasColumnName("applydate");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId).HasDefaultValue(0);
            entity.Property(e => e.Halfday)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("halfday");
            entity.Property(e => e.LeaveCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mons)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Section)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("section");
            entity.Property(e => e.Years)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LeaveMaster>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("leaveMaster$PrimaryKey");

            entity.ToTable("leaveMaster");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Accudays)
                .HasDefaultValue(0.0)
                .HasColumnName("accudays");
            entity.Property(e => e.Allocated).HasColumnName("allocated");
            entity.Property(e => e.Balance).HasColumnName("balance");
            entity.Property(e => e.Catname)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("catname");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Financeyear)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("financeyear");
            entity.Property(e => e.Flag)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Leavecode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("leavecode");
            entity.Property(e => e.Locationid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Opbal).HasColumnName("opbal");
            entity.Property(e => e.Opflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opflag");
            entity.Property(e => e.Used).HasColumnName("used");
        });

        modelBuilder.Entity<LeaveRule>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("LeaveRules$PrimaryKey");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Accumulation)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("accumulation");
            entity.Property(e => e.Accumulationdays)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("accumulationdays");
            entity.Property(e => e.Applyminpresent)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("applyminpresent");
            entity.Property(e => e.Catname)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("catname");
            entity.Property(e => e.Compid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Encashment)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("encashment");
            entity.Property(e => e.Flag)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Halfday)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("halfday");
            entity.Property(e => e.Holidayleave)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("holidayleave");
            entity.Property(e => e.Leavecode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("leavecode");
            entity.Property(e => e.Locationid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Maxdays)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("maxdays");
            entity.Property(e => e.Mindays)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("mindays");
            entity.Property(e => e.Minpresent)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("minpresent");
            entity.Property(e => e.Negativebal)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("negativebal");
            entity.Property(e => e.Negativebalance)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("negativebalance");
            entity.Property(e => e.Notes)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Perdayflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("perdayflag");
            entity.Property(e => e.Perdayleave).HasColumnName("perdayleave");
            entity.Property(e => e.Perdaylimit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("perdaylimit");
            entity.Property(e => e.Seriesleavecode)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("seriesleavecode");
            entity.Property(e => e.Totaldays)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("totaldays");
            entity.Property(e => e.Totaltime)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("totaltime");
            entity.Property(e => e.Usedflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usedflag");
            entity.Property(e => e.Wkoffleave)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("wkoffleave");
        });

        modelBuilder.Entity<LeaveYear>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("LeaveYear");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Finendyear)
                .HasColumnType("datetime")
                .HasColumnName("finendyear");
            entity.Property(e => e.Finstartyear)
                .HasColumnType("datetime")
                .HasColumnName("finstartyear");
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes");
        });

        modelBuilder.Entity<Leavelock>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("leavelock");

            entity.Property(e => e.Compid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.HDate)
                .HasColumnType("datetime")
                .HasColumnName("H_Date");
            entity.Property(e => e.HToDate)
                .HasColumnType("datetime")
                .HasColumnName("H_ToDate");
            entity.Property(e => e.Holidayname)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Locationid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Usedflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usedflag");
            entity.Property(e => e.Years).HasColumnName("years");
        });

        modelBuilder.Entity<Leaverequest>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("leaverequest");

            entity.Property(e => e.Srno)
                .ValueGeneratedNever()
                .HasColumnName("srno");
            entity.Property(e => e.Approvers)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Flags)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("flags");
            entity.Property(e => e.IsNotify)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("isNotify");
            entity.Property(e => e.Leavecode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("leavecode");
            entity.Property(e => e.Leavereason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("leavereason");
            entity.Property(e => e.Months).HasColumnName("months");
            entity.Property(e => e.Noofdays)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("noofdays");
            entity.Property(e => e.Requestid).HasColumnName("requestid");
            entity.Property(e => e.Sections)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sections");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.ToApprove)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.Years).HasColumnName("years");
        });

        modelBuilder.Entity<Leavesanctioned>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("leavesanctioned");

            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Leavecode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("leavecode");
            entity.Property(e => e.Months).HasColumnName("months");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.Years).HasColumnName("years");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.SrNo).HasName("PK__location__2BFE89A6");

            entity.ToTable("location");

            entity.Property(e => e.Details)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Flag)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Location1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("location");
        });

        modelBuilder.Entity<LocationMaster>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("LocationMaster");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Compid)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Details)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Flag)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("false")
                .HasColumnName("flag");
            entity.Property(e => e.LocStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Locationid)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Usedflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usedflag");
        });

        modelBuilder.Entity<Locationlinkvm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("locationlinkvms");

            entity.Property(e => e.Locationid)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Vmslink)
                .IsUnicode(false)
                .HasColumnName("vmslink");
        });

        modelBuilder.Entity<Logtbl>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("logtbl");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Category)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("category");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Empid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empid");
            entity.Property(e => e.Employeename)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("employeename");
            entity.Property(e => e.Passtype)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("passtype");
            entity.Property(e => e.Stat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("stat");
            entity.Property(e => e.Tokengenerated)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tokengenerated");
            entity.Property(e => e.Usertype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usertype");
            entity.Property(e => e.Vendername)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendername");
            entity.Property(e => e.Vendorid).HasColumnName("vendorid");
            entity.Property(e => e.Workarea).HasColumnName("workarea");
            entity.Property(e => e.Workorderid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("workorderid");
        });

        modelBuilder.Entity<Lookupmaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("lookupmaster");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Lookupdata)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("lookupdata");
            entity.Property(e => e.Response)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("U")
                .HasColumnName("response");
        });

        modelBuilder.Entity<Lwp>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("LWP$PrimaryKey");

            entity.ToTable("LWP");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.ApproveDate).HasColumnType("datetime");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Approvers)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Fromdate)
                .HasColumnType("datetime")
                .HasColumnName("fromdate");
            entity.Property(e => e.IsNotify)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("isNotify");
            entity.Property(e => e.Notes)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Remark)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.Requestdate)
                .HasColumnType("datetime")
                .HasColumnName("requestdate");
            entity.Property(e => e.Smstext)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("smstext");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.ToApprove)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Todate)
                .HasColumnType("datetime")
                .HasColumnName("todate");
            entity.Property(e => e.Type)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        modelBuilder.Entity<MHoliday>(entity =>
        {
            entity.HasKey(e => e.SrNo).HasName("m_holiday$PrimaryKey");

            entity.ToTable("m_holiday");

            entity.Property(e => e.Compid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Days)
                .HasDefaultValue(0)
                .HasColumnName("days");
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.HDate)
                .HasColumnType("datetime")
                .HasColumnName("H_Date");
            entity.Property(e => e.HToDate)
                .HasColumnType("datetime")
                .HasColumnName("H_ToDate");
            entity.Property(e => e.Holidayname)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Locationid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Mons)
                .HasDefaultValue(0)
                .HasColumnName("mons");
            entity.Property(e => e.Usedflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usedflag");
            entity.Property(e => e.Years)
                .HasDefaultValue(0)
                .HasColumnName("years");
        });

        modelBuilder.Entity<MLeaf>(entity =>
        {
            entity.HasKey(e => e.SrNo).HasName("m_leaves$PrimaryKey");

            entity.ToTable("m_leaves");

            entity.Property(e => e.Abbrevation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CarryFoward)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Compid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LeaveCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Locationid)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.PaidUnpaid)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Usedflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usedflag");
        });

        modelBuilder.Entity<ManualPunchRequest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ManualPunchRequest");

            entity.Property(e => e.ApproveDate).HasColumnType("datetime");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Approvers)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dates).HasColumnType("datetime");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Details)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs).HasColumnName("hrs");
            entity.Property(e => e.IsNotify)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("isNotify");
            entity.Property(e => e.Mins).HasColumnName("mins");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Remark)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.Requestid).HasColumnName("requestid");
            entity.Property(e => e.Smstext)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("smstext");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.ToApprove)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<MasterControllerType>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK_ControllerTypes");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Ctype)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ctype");
            entity.Property(e => e.Translimit).HasColumnName("translimit");
        });

        modelBuilder.Entity<Masterag>(entity =>
        {
            entity.HasKey(e => e.Agid);

            entity.ToTable("masterag");

            entity.Property(e => e.Agid)
                .ValueGeneratedNever()
                .HasColumnName("agid");
            entity.Property(e => e.Agname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("agname");
            entity.Property(e => e.Compid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Defaultflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("defaultflag");
            entity.Property(e => e.Details)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Locationid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("uploadedyn");
        });

        modelBuilder.Entity<Masteragdetail>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("masteragdetails");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Agid).HasColumnName("agid");
            entity.Property(e => e.Dgid).HasColumnName("dgid");
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Sgid).HasColumnName("sgid");
        });

        modelBuilder.Entity<Masteragupload>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("masteragupload");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Agid).HasColumnName("agid");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uploadedyn");
        });

        modelBuilder.Entity<Masterapbzone>(entity =>
        {
            entity.HasKey(e => e.Zoneid);

            entity.ToTable("masterapbzone");

            entity.Property(e => e.Zoneid).HasColumnName("zoneid");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Notes1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes1");
            entity.Property(e => e.Notes2)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes2");
            entity.Property(e => e.Zonename)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("zonename");
        });

        modelBuilder.Entity<Masterassetassignment>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("masterassetassignments");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Fromdatetime)
                .HasColumnType("datetime")
                .HasColumnName("fromdatetime");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Latestdatetime)
                .HasColumnType("datetime")
                .HasColumnName("latestdatetime");
            entity.Property(e => e.Todatetime)
                .HasColumnType("datetime")
                .HasColumnName("todatetime");
        });

        modelBuilder.Entity<Masterassetsetting>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("masterassetsettings");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Controllerids)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("controllerids");
            entity.Property(e => e.Ignorepuncheswithinminutes).HasColumnName("ignorepuncheswithinminutes");
            entity.Property(e => e.Inoutreaderids)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("inoutreaderids");
            entity.Property(e => e.Inreaderids)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("inreaderids");
            entity.Property(e => e.Outreaderids)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("outreaderids");
        });

        modelBuilder.Entity<Masterassettype>(entity =>
        {
            entity.HasKey(e => e.Assettypeid);

            entity.ToTable("masterassettypes");

            entity.Property(e => e.Assettypeid).HasColumnName("assettypeid");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Details)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("details");
        });

        modelBuilder.Entity<Masterat>(entity =>
        {
            entity.HasKey(e => e.Atid);

            entity.ToTable("masterat");

            entity.Property(e => e.Atid)
                .ValueGeneratedNever()
                .HasColumnName("atid");
            entity.Property(e => e.Atname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("atname");
            entity.Property(e => e.Compid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Details)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Locationid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("uploadedyn");
        });

        modelBuilder.Entity<Masteratdetail>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("masteratdetails");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Atid).HasColumnName("atid");
            entity.Property(e => e.Day)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("day");
            entity.Property(e => e.Tzhgid)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("tzhgid");
        });

        modelBuilder.Entity<Mastercardassignment>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("mastercardassignments");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Assigneeid).HasColumnName("assigneeid");
            entity.Property(e => e.Assigneetype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("assigneetype");
            entity.Property(e => e.Cardid).HasColumnName("cardid");
            entity.Property(e => e.Fromdatetime)
                .HasColumnType("datetime")
                .HasColumnName("fromdatetime");
            entity.Property(e => e.Latestdatetime)
                .HasColumnType("datetime")
                .HasColumnName("latestdatetime");
            entity.Property(e => e.Todatetime)
                .HasColumnType("datetime")
                .HasColumnName("todatetime");
        });

        modelBuilder.Entity<Mastercardinventory>(entity =>
        {
            entity.HasKey(e => e.Cardid);

            entity.ToTable("mastercardinventory");

            entity.Property(e => e.Cardid).HasColumnName("cardid");
            entity.Property(e => e.CardAssignedOn).HasColumnType("datetime");
            entity.Property(e => e.Cardformat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardformat");
            entity.Property(e => e.Cardno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardno");
            entity.Property(e => e.Forvisitor)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("forvisitor");
            entity.Property(e => e.Noformat)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("noformat");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Uniqueid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("uniqueid");
        });

        modelBuilder.Entity<Mastercontroller>(entity =>
        {
            entity.HasKey(e => e.Cid);

            entity.ToTable("mastercontroller");

            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Authmode).HasColumnName("authmode");
            entity.Property(e => e.Capsnapshot)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("capsnapshot");
            entity.Property(e => e.Cardreadformat).HasColumnName("cardreadformat");
            entity.Property(e => e.Ciid).HasColumnName("ciid");
            entity.Property(e => e.Cname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("cname");
            entity.Property(e => e.Cntuploadedyn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cntuploadedyn");
            entity.Property(e => e.Compid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Cpass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cpass");
            entity.Property(e => e.Ctype)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ctype");
            entity.Property(e => e.Cusername)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cusername");
            entity.Property(e => e.Doorheld).HasColumnName("doorheld");
            entity.Property(e => e.Doorheldyn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("doorheldyn");
            entity.Property(e => e.Extendedaccess).HasColumnName("extendedaccess");
            entity.Property(e => e.Firmwareversion)
                .IsUnicode(false)
                .HasColumnName("firmwareversion");
            entity.Property(e => e.Flag)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValue("Active")
                .HasColumnName("flag");
            entity.Property(e => e.Fversion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fversion");
            entity.Property(e => e.Globalpassback).HasColumnName("globalpassback");
            entity.Property(e => e.Ip)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ip");
            entity.Property(e => e.Ipchange)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ipchange");
            entity.Property(e => e.Isenroller).HasColumnName("isenroller");
            entity.Property(e => e.Lastconnected)
                .HasColumnType("datetime")
                .HasColumnName("lastconnected");
            entity.Property(e => e.Lastconnecttime)
                .HasColumnType("datetime")
                .HasColumnName("lastconnecttime");
            entity.Property(e => e.Locationid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Macaddress)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("macaddress");
            entity.Property(e => e.Minopen).HasColumnName("minopen");
            entity.Property(e => e.Mode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("mode");
            entity.Property(e => e.Normalaccess).HasColumnName("normalaccess");
            entity.Property(e => e.Onlyattendance)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("onlyattendance");
            entity.Property(e => e.Port).HasColumnName("port");
            entity.Property(e => e.Pushmode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("pushmode");
            entity.Property(e => e.Readercnt).HasColumnName("readercnt");
            entity.Property(e => e.Serialformat).HasColumnName("serialformat");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Terminalid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("terminalid");
            entity.Property(e => e.Timesync).HasColumnName("timesync");
            entity.Property(e => e.Timezone)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("timezone");
            entity.Property(e => e.V100cnt).HasColumnName("v100cnt");
            entity.Property(e => e.V100rcnt)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("v100rcnt");
            entity.Property(e => e.V200cnt).HasColumnName("v200cnt");
            entity.Property(e => e.V300cnt).HasColumnName("v300cnt");
        });

        modelBuilder.Entity<Masterdg>(entity =>
        {
            entity.HasKey(e => e.Dgid);

            entity.ToTable("masterdg");

            entity.Property(e => e.Dgid)
                .ValueGeneratedNever()
                .HasColumnName("dgid");
            entity.Property(e => e.Compid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Details)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Dgname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("dgname");
            entity.Property(e => e.Firecid).HasColumnName("firecid");
            entity.Property(e => e.Fireevent)
                .HasDefaultValue((byte)0)
                .HasColumnName("fireevent");
            entity.Property(e => e.Locationid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("uploadedyn");
        });

        modelBuilder.Entity<Masterdgdetail>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("masterdgdetails");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Dgid).HasColumnName("dgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
        });

        modelBuilder.Entity<Masterdgupload>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("masterdgupload");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Dgid).HasColumnName("dgid");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uploadedyn");
        });

        modelBuilder.Entity<Masterdsg>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("masterdsg");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Doorname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("doorname");
            entity.Property(e => e.Doorno).HasColumnName("doorno");
            entity.Property(e => e.Doorstatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("doorstatus");
            entity.Property(e => e.Holidaygroup).HasColumnName("holidaygroup");
            entity.Property(e => e.Macaddr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("macaddr");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Timezone).HasColumnName("timezone");
        });

        modelBuilder.Entity<Masterdtz>(entity =>
        {
            entity.HasKey(e => e.Tzid);

            entity.ToTable("masterdtz");

            entity.Property(e => e.Tzid)
                .ValueGeneratedNever()
                .HasColumnName("tzid");
            entity.Property(e => e.Compid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Details)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Locationid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Tzname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("tzname");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("uploadedyn");
        });

        modelBuilder.Entity<Masterdtzdetail>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("masterdtzdetails");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Day).HasColumnName("day");
            entity.Property(e => e.Doorstatus).HasColumnName("doorstatus");
            entity.Property(e => e.Endtime)
                .HasColumnType("datetime")
                .HasColumnName("endtime");
            entity.Property(e => e.Starttime)
                .HasColumnType("datetime")
                .HasColumnName("starttime");
            entity.Property(e => e.Tzid).HasColumnName("tzid");
        });

        modelBuilder.Entity<Mastereg>(entity =>
        {
            entity.HasKey(e => e.Egid);

            entity.ToTable("mastereg");

            entity.Property(e => e.Egid).HasColumnName("egid");
            entity.Property(e => e.Details)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Egname)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("egname");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("uploadedyn");
        });

        modelBuilder.Entity<Masteregdetail>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("masteregdetails");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Details)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Egid).HasColumnName("egid");
            entity.Property(e => e.Floorid).HasColumnName("floorid");
            entity.Property(e => e.Liftid).HasColumnName("liftid");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes");
        });

        modelBuilder.Entity<Mastereventsv>(entity =>
        {
            entity.ToTable("mastereventsv");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Details)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        modelBuilder.Entity<Masterfc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("masterfc");

            entity.Property(e => e.Compid)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Fc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fc");
            entity.Property(e => e.Locationid)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<Masterhg>(entity =>
        {
            entity.HasKey(e => e.Hgid);

            entity.ToTable("masterhg");

            entity.Property(e => e.Hgid)
                .ValueGeneratedNever()
                .HasColumnName("hgid");
            entity.Property(e => e.Compid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Details)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Hgname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("hgname");
            entity.Property(e => e.Locationid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("uploadedyn");
        });

        modelBuilder.Entity<Masterhgdetail>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("masterhgdetails");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Hgid).HasColumnName("hgid");
            entity.Property(e => e.Hid).HasColumnName("hid");
        });

        modelBuilder.Entity<Masterhgupload>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("masterhgupload");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Hgid).HasColumnName("hgid");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uploadedyn");
        });

        modelBuilder.Entity<Masterig>(entity =>
        {
            entity.HasKey(e => e.Dgid);

            entity.ToTable("masterig");

            entity.Property(e => e.Dgid).HasColumnName("dgid");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Compid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Details)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Dgname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("dgname");
            entity.Property(e => e.Locationid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("uploadedyn");
        });

        modelBuilder.Entity<Masterigdetail>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("masterigdetails");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Dgid).HasColumnName("dgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
        });

        modelBuilder.Entity<Masterinput>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("masterinput");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Param1).HasColumnName("param1");
            entity.Property(e => e.Time).HasColumnName("time");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<Masterlaptop>(entity =>
        {
            entity.HasKey(e => e.Laptopid);

            entity.ToTable("masterlaptops");

            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Accessgroups)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("accessgroups");
            entity.Property(e => e.Applyvalid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("applyvalid");
            entity.Property(e => e.Assetno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("assetno");
            entity.Property(e => e.Assettypeid).HasColumnName("assettypeid");
            entity.Property(e => e.Brandname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("brandname");
            entity.Property(e => e.Cardformat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardformat");
            entity.Property(e => e.Details)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Empid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empid");
            entity.Property(e => e.Lastdatetime)
                .HasColumnType("datetime")
                .HasColumnName("lastdatetime");
            entity.Property(e => e.Lastinoutmode).HasColumnName("lastinoutmode");
            entity.Property(e => e.Lastread)
                .HasColumnType("datetime")
                .HasColumnName("lastread");
            entity.Property(e => e.Make)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("make");
            entity.Property(e => e.Manufacturer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("manufacturer");
            entity.Property(e => e.Modelno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modelno");
            entity.Property(e => e.Noformat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("noformat");
            entity.Property(e => e.Serialno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("serialno");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Stockdate)
                .HasColumnType("datetime")
                .HasColumnName("stockdate");
            entity.Property(e => e.Tagno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tagno");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.Uniqueid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("uniqueid");
            entity.Property(e => e.Validfrom)
                .HasColumnType("datetime")
                .HasColumnName("validfrom");
            entity.Property(e => e.Validto)
                .HasColumnType("datetime")
                .HasColumnName("validto");
        });

        modelBuilder.Entity<Masterlaptopassignment>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("masterlaptopassignments");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Fromdatetime)
                .HasColumnType("datetime")
                .HasColumnName("fromdatetime");
            entity.Property(e => e.Fromtrmonth).HasColumnName("fromtrmonth");
            entity.Property(e => e.Fromtrsrno).HasColumnName("fromtrsrno");
            entity.Property(e => e.Fromtryear).HasColumnName("fromtryear");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Latestdatetime)
                .HasColumnType("datetime")
                .HasColumnName("latestdatetime");
            entity.Property(e => e.Todatetime)
                .HasColumnType("datetime")
                .HasColumnName("todatetime");
            entity.Property(e => e.Totrmonth).HasColumnName("totrmonth");
            entity.Property(e => e.Totrsrno).HasColumnName("totrsrno");
            entity.Property(e => e.Totryear).HasColumnName("totryear");
        });

        modelBuilder.Entity<Masterlift>(entity =>
        {
            entity.HasKey(e => e.Liftid);

            entity.ToTable("masterlift");

            entity.Property(e => e.Liftid).HasColumnName("liftid");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Liftname)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("liftname");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Notes1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes1");
            entity.Property(e => e.Notes2)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes2");
            entity.Property(e => e.Rid).HasColumnName("rid");
        });

        modelBuilder.Entity<Masterliftdetail>(entity =>
        {
            entity.HasKey(e => e.Floorid);

            entity.ToTable("masterliftdetails");

            entity.Property(e => e.Floorid).HasColumnName("floorid");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Floorname)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("floorname");
            entity.Property(e => e.Ifid).HasColumnName("ifid");
            entity.Property(e => e.Liftid).HasColumnName("liftid");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Notes1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes1");
            entity.Property(e => e.Notes2)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes2");
            entity.Property(e => e.Relay).HasColumnName("relay");
        });

        modelBuilder.Entity<Masterlocksetting>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("masterlocksetting");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Forcedenable).HasColumnName("forcedenable");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Time).HasColumnName("time");
            entity.Property(e => e.Zoneid).HasColumnName("zoneid");
        });

        modelBuilder.Entity<Mastermsgdetail>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("mastermsgdetails");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Adcount).HasColumnName("adcount");
            entity.Property(e => e.Adfields)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("adfields");
            entity.Property(e => e.Descr)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("descr");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
        });

        modelBuilder.Entity<Masteroutput>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("masteroutput");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Param1).HasColumnName("param1");
            entity.Property(e => e.Time).HasColumnName("time");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<Masterpartition>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("masterpartition");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Account)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("account");
            entity.Property(e => e.Alarmcount).HasColumnName("alarmcount");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Enable).HasColumnName("enable");
            entity.Property(e => e.Entrydelay1).HasColumnName("entrydelay1");
            entity.Property(e => e.Entrydelay2).HasColumnName("entrydelay2");
            entity.Property(e => e.Exitdelay1).HasColumnName("exitdelay1");
            entity.Property(e => e.Exitdelay2).HasColumnName("exitdelay2");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Partoption).HasColumnName("partoption");
            entity.Property(e => e.Sirentime).HasColumnName("sirentime");
        });

        modelBuilder.Entity<Masterpass>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("masterpass");

            entity.Property(e => e.Pass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pass");
        });

        modelBuilder.Entity<Masterreader>(entity =>
        {
            entity.HasKey(e => e.Rid);

            entity.ToTable("masterreader");

            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Accesstype).HasColumnName("accesstype");
            entity.Property(e => e.Apbaction).HasColumnName("apbaction");
            entity.Property(e => e.Apbrnos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apbrnos");
            entity.Property(e => e.Apbtimeout)
                .HasColumnType("datetime")
                .HasColumnName("apbtimeout");
            entity.Property(e => e.Apbtype).HasColumnName("apbtype");
            entity.Property(e => e.Attyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("attyn");
            entity.Property(e => e.Camid).HasColumnName("camid");
            entity.Property(e => e.Camname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("camname");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Ciid).HasColumnName("ciid");
            entity.Property(e => e.Compid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Doorheld).HasColumnName("doorheld");
            entity.Property(e => e.Doorname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("doorname");
            entity.Property(e => e.Doorno).HasColumnName("doorno");
            entity.Property(e => e.Dtype)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("dtype");
            entity.Property(e => e.Elev)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("elev");
            entity.Property(e => e.Entryid)
                .HasDefaultValue(0)
                .HasColumnName("entryid");
            entity.Property(e => e.Exitid)
                .HasDefaultValue(0)
                .HasColumnName("exitid");
            entity.Property(e => e.Extended).HasColumnName("extended");
            entity.Property(e => e.Ifaddress)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ifaddress");
            entity.Property(e => e.Iid).HasColumnName("iid");
            entity.Property(e => e.Iostatus)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("iostatus");
            entity.Property(e => e.Locationid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Locks)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("locks");
            entity.Property(e => e.Mainentryorexit)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("mainentryorexit");
            entity.Property(e => e.Minimum).HasColumnName("minimum");
            entity.Property(e => e.Multiruleid).HasColumnName("multiruleid");
            entity.Property(e => e.Normal).HasColumnName("normal");
            entity.Property(e => e.Rname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("rname");
            entity.Property(e => e.Rno).HasColumnName("rno");
            entity.Property(e => e.Rnotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("rnotes");
            entity.Property(e => e.Rnotes1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("rnotes1");
            entity.Property(e => e.Rnotes2)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("rnotes2");
            entity.Property(e => e.Rtype)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("rtype");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("uploadedyn");
        });

        modelBuilder.Entity<Masterrole>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("masterrole");

            entity.Property(e => e.Details)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Fromdate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fromdate");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Roleid)
                .ValueGeneratedOnAdd()
                .HasColumnName("roleid");
            entity.Property(e => e.Rolename)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("rolename");
            entity.Property(e => e.Todate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("todate");
        });

        modelBuilder.Entity<Mastersg>(entity =>
        {
            entity.HasKey(e => e.Sgid);

            entity.ToTable("mastersg");

            entity.Property(e => e.Sgid)
                .ValueGeneratedNever()
                .HasColumnName("sgid");
            entity.Property(e => e.Compid)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Details)
                .HasMaxLength(800)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Locationid)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Sgname)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("sgname");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uploadedyn");
        });

        modelBuilder.Entity<Mastersgdetail>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("mastersgdetails");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Endtime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("endtime");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Htid).HasColumnName("htid");
            entity.Property(e => e.Sgid).HasColumnName("sgid");
            entity.Property(e => e.Starttime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("starttime");
        });

        modelBuilder.Entity<Mastersgupload>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("mastersgupload");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Sgid).HasColumnName("sgid");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uploadedyn");
        });

        modelBuilder.Entity<Mastertz>(entity =>
        {
            entity.HasKey(e => e.Tzid);

            entity.ToTable("mastertz");

            entity.Property(e => e.Tzid)
                .ValueGeneratedNever()
                .HasColumnName("tzid");
            entity.Property(e => e.Compid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Details)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Locationid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Tzname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("tzname");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("uploadedyn");
        });

        modelBuilder.Entity<Mastertzdetail>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("mastertzdetails");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Day).HasColumnName("day");
            entity.Property(e => e.Endtime)
                .HasColumnType("datetime")
                .HasColumnName("endtime");
            entity.Property(e => e.Starttime)
                .HasColumnType("datetime")
                .HasColumnName("starttime");
            entity.Property(e => e.Tzid).HasColumnName("tzid");
        });

        modelBuilder.Entity<Mastervagdetail>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("mastervagdetails");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Agid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("agid");
            entity.Property(e => e.Atid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("atid");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Cname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("cname");
            entity.Property(e => e.Doorname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("doorname");
            entity.Property(e => e.Doorno).HasColumnName("doorno");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Rname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("rname");
        });

        modelBuilder.Entity<Mastervehicle>(entity =>
        {
            entity.HasKey(e => e.Vehicleid);

            entity.ToTable("mastervehicles");

            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
            entity.Property(e => e.Accessgroups)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("accessgroups");
            entity.Property(e => e.Applyvalid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("applyvalid");
            entity.Property(e => e.Cardformat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardformat");
            entity.Property(e => e.Controllergroupids)
                .IsUnicode(false)
                .HasColumnName("controllergroupids");
            entity.Property(e => e.Controllerids)
                .IsUnicode(false)
                .HasColumnName("controllerids");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Details)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Dlno)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("dlno");
            entity.Property(e => e.Drivername)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("drivername");
            entity.Property(e => e.Empid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empid");
            entity.Property(e => e.Enrollno).HasColumnName("enrollno");
            entity.Property(e => e.Modificationdate)
                .HasColumnType("datetime")
                .HasColumnName("modificationdate");
            entity.Property(e => e.Noformat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("noformat");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Tagno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tagno");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Uniqueid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("uniqueid");
            entity.Property(e => e.Validfrom)
                .HasColumnType("datetime")
                .HasColumnName("validfrom");
            entity.Property(e => e.Validto)
                .HasColumnType("datetime")
                .HasColumnName("validto");
            entity.Property(e => e.Vehicleno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vehicleno");
        });

        modelBuilder.Entity<Masterzone>(entity =>
        {
            entity.HasKey(e => e.Zoneid);

            entity.ToTable("masterzone");

            entity.Property(e => e.Zoneid).HasColumnName("zoneid");
            entity.Property(e => e.Zonename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("zonename");
        });

        modelBuilder.Entity<Masterzonedetail>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("masterzonedetails");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Rflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("rflag");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Zoneid).HasColumnName("zoneid");
        });

        modelBuilder.Entity<Masterzonev>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("masterzonev");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Isdouble).HasColumnName("isdouble");
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Partition).HasColumnName("partition");
            entity.Property(e => e.Response).HasColumnName("response");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<MaterialEmailMaster>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__MaterialEmailMaster__6B24EA82");

            entity.ToTable("MaterialEmailMaster");

            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Active")
                .HasColumnName("flag");
        });

        modelBuilder.Entity<MaterialMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MaterialMaster");

            entity.Property(e => e.Details)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Itemname)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("itemname");
            entity.Property(e => e.Note)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("note");
            entity.Property(e => e.Srno).HasColumnName("srno");
        });

        modelBuilder.Entity<Mcsetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mcsettings");

            entity.Property(e => e.Connectip)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("connectip");
            entity.Property(e => e.Flag)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Gateway)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("gateway");
            entity.Property(e => e.InOutFlag)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InOutmode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("InOUTMode");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Machineno)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("machineno");
            entity.Property(e => e.Machinetype)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("machinetype");
            entity.Property(e => e.Mcname)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("mcname");
            entity.Property(e => e.Pushdata)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("pushdata");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Subnet)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("subnet");
            entity.Property(e => e.Temp)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("temp");
        });

        modelBuilder.Entity<MenuMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MenuMaster");

            entity.Property(e => e.Details)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Type)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__messages__6FE99F9F");

            entity.ToTable("messages");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Banner)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("banner");
            entity.Property(e => e.Bannerflag)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("False")
                .HasColumnName("bannerflag");
            entity.Property(e => e.Popup)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("popup");
            entity.Property(e => e.Popupflag)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("False")
                .HasColumnName("popupflag");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        modelBuilder.Entity<Mobileno>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("mobilenos");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Mndetails)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("mndetails");
            entity.Property(e => e.Mnnotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("mnnotes");
            entity.Property(e => e.Mobileno1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("mobileno");
            entity.Property(e => e.Pass)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("pass");
        });

        modelBuilder.Entity<Monthpass>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("monthpass");

            entity.Property(e => e.AcsCardNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("acsCardNo");
            entity.Property(e => e.Address)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.Barcode)
                .HasColumnType("image")
                .HasColumnName("barcode");
            entity.Property(e => e.Barcodedata)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("barcodedata");
            entity.Property(e => e.Cardno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardno");
            entity.Property(e => e.Compnay)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("compnay");
            entity.Property(e => e.Createdby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Createdon)
                .HasColumnType("datetime")
                .HasColumnName("createdon");
            entity.Property(e => e.Dept)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("dept");
            entity.Property(e => e.Empid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Fromdate)
                .HasColumnType("datetime")
                .HasColumnName("fromdate");
            entity.Property(e => e.Gateno).HasColumnName("gateno");
            entity.Property(e => e.Idproof)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("idproof");
            entity.Property(e => e.Idtype)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("idtype");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Passno).HasColumnName("passno");
            entity.Property(e => e.Phno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phno");
            entity.Property(e => e.Powonumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Processedautovaliditysignout)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("processedautovaliditysignout");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Todate)
                .HasColumnType("datetime")
                .HasColumnName("todate");
            entity.Property(e => e.Tomeet)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("tomeet");
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.Visid).HasColumnName("visid");
            entity.Property(e => e.Visitorname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("visitorname");
            entity.Property(e => e.Zno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("zno");
        });

        modelBuilder.Entity<Mtmplogtbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mtmplogtbl");

            entity.Property(e => e.Category)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("category");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Empid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empid");
            entity.Property(e => e.Employeename)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("employeename");
            entity.Property(e => e.Passtype)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("passtype");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Stat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("stat");
            entity.Property(e => e.Tokengenerated)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tokengenerated");
            entity.Property(e => e.Usertype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usertype");
            entity.Property(e => e.Vendername)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendername");
            entity.Property(e => e.Vendorid).HasColumnName("vendorid");
            entity.Property(e => e.Workarea).HasColumnName("workarea");
            entity.Property(e => e.Workorderid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("workorderid");
        });

        modelBuilder.Entity<Mtmplogtbl2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mtmplogtbl2");

            entity.Property(e => e.Category)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("category");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Empid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empid");
            entity.Property(e => e.Employeename)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("employeename");
            entity.Property(e => e.Passtype)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("passtype");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Stat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("stat");
            entity.Property(e => e.Tokengenerated)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tokengenerated");
            entity.Property(e => e.Usertype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usertype");
            entity.Property(e => e.Vendername)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendername");
            entity.Property(e => e.Vendorid).HasColumnName("vendorid");
            entity.Property(e => e.Workarea).HasColumnName("workarea");
            entity.Property(e => e.Workorderid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("workorderid");
        });

        modelBuilder.Entity<Multimandetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("multimandetails");

            entity.Property(e => e.Agids)
                .IsUnicode(false)
                .HasColumnName("agids");
            entity.Property(e => e.Roleid).HasColumnName("roleid");
            entity.Property(e => e.Ruleid).HasColumnName("ruleid");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<Multimanmaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("multimanmaster");

            entity.Property(e => e.Ruleid)
                .ValueGeneratedOnAdd()
                .HasColumnName("ruleid");
            entity.Property(e => e.Rulename)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("rulename");
            entity.Property(e => e.Seqn)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("seqn");
            entity.Property(e => e.Timeout).HasColumnName("timeout");
        });

        modelBuilder.Entity<Muster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("muster");

            entity.Property(e => e.Active)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("active");
            entity.Property(e => e.Activefrom)
                .HasColumnType("datetime")
                .HasColumnName("activefrom");
            entity.Property(e => e.Activefromdate)
                .HasColumnType("datetime")
                .HasColumnName("activefromdate");
            entity.Property(e => e.Activeto)
                .HasColumnType("datetime")
                .HasColumnName("activeto");
            entity.Property(e => e.Activetodate)
                .HasColumnType("datetime")
                .HasColumnName("activetodate");
            entity.Property(e => e.Musternote1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("musternote1");
            entity.Property(e => e.Musternote2)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("musternote2");
            entity.Property(e => e.Musternotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("musternotes");
            entity.Property(e => e.Srno).HasColumnName("srno");
        });

        modelBuilder.Entity<NationalityMaster>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__NationalityMaste__6B24EA82");

            entity.ToTable("NationalityMaster");

            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Active")
                .HasColumnName("flag");
            entity.Property(e => e.Nationality)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nationality");
        });

        modelBuilder.Entity<NewCompOffRequest>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("NewCompOffRequest$PrimaryKey");

            entity.ToTable("NewCompOffRequest");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Approvers)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Availableot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("availableot");
            entity.Property(e => e.Cofftype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cofftype");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Empid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empid");
            entity.Property(e => e.Fdday).HasColumnName("fdday");
            entity.Property(e => e.Fdmonth).HasColumnName("fdmonth");
            entity.Property(e => e.Fdyear).HasColumnName("fdyear");
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Fromdate)
                .HasColumnType("datetime")
                .HasColumnName("fromdate");
            entity.Property(e => e.IsNotify)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("isNotify");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Punchtime)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("punchtime");
            entity.Property(e => e.Remark)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.Requestid).HasColumnName("requestid");
            entity.Property(e => e.Smstext)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("smstext");
            entity.Property(e => e.Tdday).HasColumnName("tdday");
            entity.Property(e => e.Tdmonth).HasColumnName("tdmonth");
            entity.Property(e => e.Tdyear).HasColumnName("tdyear");
            entity.Property(e => e.ToApprove)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Todate)
                .HasColumnType("datetime")
                .HasColumnName("todate");
        });

        modelBuilder.Entity<Newsection>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("newsection");

            entity.Property(e => e.Details)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Flag)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Section)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("section");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<Odentry>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("odentry");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Compoffdate)
                .HasColumnType("datetime")
                .HasColumnName("compoffdate");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Oddetails)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("oddetails");
            entity.Property(e => e.Odhrs)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("odhrs");
            entity.Property(e => e.Odnotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("odnotes");
            entity.Property(e => e.Odnotes1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("odnotes1");
            entity.Property(e => e.Place)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("place");
        });

        modelBuilder.Entity<OdentryRequest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ODEntryRequest");

            entity.Property(e => e.Dates).HasColumnType("datetime");
            entity.Property(e => e.Details)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Lastpunch)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("lastpunch");
            entity.Property(e => e.Punchtime).HasColumnType("datetime");
            entity.Property(e => e.Punchtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("punchtype");
            entity.Property(e => e.Requestid).HasColumnName("requestid");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Typeflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("typeflag");
        });

        modelBuilder.Entity<Odrequest>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("odrequest");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Approvedfrom)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("approvedfrom");
            entity.Property(e => e.Approvedto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("approvedto");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Fromtime)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fromtime");
            entity.Property(e => e.Oddetails)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("oddetails");
            entity.Property(e => e.Odflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("odflag");
            entity.Property(e => e.Odnotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("odnotes");
            entity.Property(e => e.Odnotes1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("odnotes1");
            entity.Property(e => e.Requestdate)
                .HasColumnType("datetime")
                .HasColumnName("requestdate");
            entity.Property(e => e.Requestid).HasColumnName("requestid");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Totime)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("totime");
        });

        modelBuilder.Entity<Odrequestnew>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("odrequestnew");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.ApproveDate).HasColumnType("datetime");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Approvers)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.IsNotify)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("isNotify");
            entity.Property(e => e.Oddetails)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("oddetails");
            entity.Property(e => e.Odhrs)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("odhrs");
            entity.Property(e => e.Odnotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("odnotes");
            entity.Property(e => e.Odnotes1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("odnotes1");
            entity.Property(e => e.Place)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("place");
            entity.Property(e => e.Remark)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.Requestdate)
                .HasColumnType("datetime")
                .HasColumnName("requestdate");
            entity.Property(e => e.Requestid).HasColumnName("requestid");
            entity.Property(e => e.Smstext)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("smstext");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.ToApprove)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Organizational>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Organizational");

            entity.Property(e => e.Address)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Logo)
                .HasColumnType("image")
                .HasColumnName("logo");
            entity.Property(e => e.Orgname)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Phno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("phno");
        });

        modelBuilder.Entity<Orglogo>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("orglogo");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Details)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Logo)
                .HasColumnType("image")
                .HasColumnName("logo");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes");
        });

        modelBuilder.Entity<Otptransaction>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("OTPTransactions");

            entity.Property(e => e.Dates).HasColumnType("datetime");
            entity.Property(e => e.IsActive)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsUpload)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Otp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OTP");
            entity.Property(e => e.Panelid)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Times).HasColumnType("datetime");
        });

        modelBuilder.Entity<Output>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("outputs");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Iid).HasColumnName("iid");
            entity.Property(e => e.Oname)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("oname");
            entity.Property(e => e.Output1).HasColumnName("output");
            entity.Property(e => e.Ovalue)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ovalue");
        });

        modelBuilder.Entity<PeerGroup>(entity =>
        {
            entity.HasKey(e => e.Pgrpid);

            entity.Property(e => e.Pgrpid).HasColumnName("pgrpid");
            entity.Property(e => e.Compid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Locationid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Pgrpname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("pgrpname");
            entity.Property(e => e.Ridstring)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ridstring");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uploadedyn");
        });

        modelBuilder.Entity<PendingAppointment>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("PendingAppointment");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Address)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.Carrlaptop)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("carrlaptop");
            entity.Property(e => e.Carrmob)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("carrmob");
            entity.Property(e => e.Carrmobwithcamera)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("carrmobwithcamera");
            entity.Property(e => e.Carrother)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("carrother");
            entity.Property(e => e.Carrotherdetails)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("carrotherdetails");
            entity.Property(e => e.Carrtoolkit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("carrtoolkit");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Compname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("compname");
            entity.Property(e => e.Contactno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contactno");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Gateno).HasColumnName("gateno");
            entity.Property(e => e.Gatepassno).HasColumnName("gatepassno");
            entity.Property(e => e.Host)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("host");
            entity.Property(e => e.Note)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("note");
            entity.Property(e => e.Purpose)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("purpose");
            entity.Property(e => e.Smstext)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("smstext");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Updated)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("updated");
            entity.Property(e => e.Visitorname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("visitorname");
        });

        modelBuilder.Entity<Pendingactivity>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__pendinga__36B150C6C6620F8A");

            entity.ToTable("pendingactivity");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Activitytype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("activitytype");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Details)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Details1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("details1");
            entity.Property(e => e.Failedflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("failedflag");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.Username)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Preapprovelist>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__preapprovelist__5AEE82B9");

            entity.ToTable("preapprovelist");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Addedby)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("addedby");
            entity.Property(e => e.Empid)
                .HasDefaultValueSql("('0')")
                .HasColumnName("empid");
            entity.Property(e => e.Note)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("note");
            entity.Property(e => e.Visitorid).HasColumnName("visitorid");
            entity.Property(e => e.Visname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("visname");
        });

        modelBuilder.Entity<ProcessData012022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("process_data_012022");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Type }, "IX_process_data_012022")
                .IsUnique()
                .IsDescending(false, true, true, false);

            entity.Property(e => e.Coordinates)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("coordinates");
            entity.Property(e => e.Cpfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield1");
            entity.Property(e => e.Cpfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield2");
            entity.Property(e => e.Cpfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield3");
            entity.Property(e => e.Cpfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield4");
            entity.Property(e => e.Cpfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield5");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs).HasColumnName("hrs");
            entity.Property(e => e.Imei)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("imei");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Logonid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("logonid");
            entity.Property(e => e.Mcid).HasColumnName("mcid");
            entity.Property(e => e.Mins).HasColumnName("mins");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Oldflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("oldflag");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Verifymode).HasColumnName("verifymode");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<ProcessData012023>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("process_data_012023");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Type }, "IX_process_data_012023")
                .IsUnique()
                .IsDescending(false, true, true, false);

            entity.Property(e => e.Coordinates)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("coordinates");
            entity.Property(e => e.Cpfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield1");
            entity.Property(e => e.Cpfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield2");
            entity.Property(e => e.Cpfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield3");
            entity.Property(e => e.Cpfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield4");
            entity.Property(e => e.Cpfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield5");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs).HasColumnName("hrs");
            entity.Property(e => e.Imei)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("imei");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Logonid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("logonid");
            entity.Property(e => e.Mcid).HasColumnName("mcid");
            entity.Property(e => e.Mins).HasColumnName("mins");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Oldflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("oldflag");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Verifymode).HasColumnName("verifymode");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<ProcessData012024>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("process_data_012024");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Type }, "IX_process_data_012024")
                .IsUnique()
                .IsDescending(false, true, true, false);

            entity.Property(e => e.Coordinates)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("coordinates");
            entity.Property(e => e.Cpfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield1");
            entity.Property(e => e.Cpfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield2");
            entity.Property(e => e.Cpfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield3");
            entity.Property(e => e.Cpfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield4");
            entity.Property(e => e.Cpfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield5");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs).HasColumnName("hrs");
            entity.Property(e => e.Imei)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("imei");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Logonid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("logonid");
            entity.Property(e => e.Mcid).HasColumnName("mcid");
            entity.Property(e => e.Mins).HasColumnName("mins");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Oldflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("oldflag");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Verifymode).HasColumnName("verifymode");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<ProcessData022022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("process_data_022022");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Type }, "IX_process_data_022022")
                .IsUnique()
                .IsDescending(false, true, true, false);

            entity.Property(e => e.Coordinates)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("coordinates");
            entity.Property(e => e.Cpfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield1");
            entity.Property(e => e.Cpfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield2");
            entity.Property(e => e.Cpfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield3");
            entity.Property(e => e.Cpfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield4");
            entity.Property(e => e.Cpfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield5");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs).HasColumnName("hrs");
            entity.Property(e => e.Imei)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("imei");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Logonid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("logonid");
            entity.Property(e => e.Mcid).HasColumnName("mcid");
            entity.Property(e => e.Mins).HasColumnName("mins");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Oldflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("oldflag");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Verifymode).HasColumnName("verifymode");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<ProcessData022023>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("process_data_022023");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Type }, "IX_process_data_022023")
                .IsUnique()
                .IsDescending(false, true, true, false);

            entity.Property(e => e.Coordinates)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("coordinates");
            entity.Property(e => e.Cpfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield1");
            entity.Property(e => e.Cpfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield2");
            entity.Property(e => e.Cpfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield3");
            entity.Property(e => e.Cpfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield4");
            entity.Property(e => e.Cpfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield5");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs).HasColumnName("hrs");
            entity.Property(e => e.Imei)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("imei");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Logonid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("logonid");
            entity.Property(e => e.Mcid).HasColumnName("mcid");
            entity.Property(e => e.Mins).HasColumnName("mins");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Oldflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("oldflag");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Verifymode).HasColumnName("verifymode");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<ProcessData022024>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("process_data_022024");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Type }, "IX_process_data_022024")
                .IsUnique()
                .IsDescending(false, true, true, false);

            entity.Property(e => e.Coordinates)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("coordinates");
            entity.Property(e => e.Cpfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield1");
            entity.Property(e => e.Cpfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield2");
            entity.Property(e => e.Cpfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield3");
            entity.Property(e => e.Cpfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield4");
            entity.Property(e => e.Cpfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield5");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs).HasColumnName("hrs");
            entity.Property(e => e.Imei)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("imei");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Logonid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("logonid");
            entity.Property(e => e.Mcid).HasColumnName("mcid");
            entity.Property(e => e.Mins).HasColumnName("mins");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Oldflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("oldflag");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Verifymode).HasColumnName("verifymode");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<ProcessData032022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("process_data_032022");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Type }, "IX_process_data_032022")
                .IsUnique()
                .IsDescending(false, true, true, false);

            entity.Property(e => e.Coordinates)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("coordinates");
            entity.Property(e => e.Cpfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield1");
            entity.Property(e => e.Cpfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield2");
            entity.Property(e => e.Cpfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield3");
            entity.Property(e => e.Cpfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield4");
            entity.Property(e => e.Cpfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield5");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs).HasColumnName("hrs");
            entity.Property(e => e.Imei)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("imei");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Logonid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("logonid");
            entity.Property(e => e.Mcid).HasColumnName("mcid");
            entity.Property(e => e.Mins).HasColumnName("mins");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Oldflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("oldflag");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Verifymode).HasColumnName("verifymode");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<ProcessData032023>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("process_data_032023");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Type }, "IX_process_data_032023")
                .IsUnique()
                .IsDescending(false, true, true, false);

            entity.Property(e => e.Coordinates)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("coordinates");
            entity.Property(e => e.Cpfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield1");
            entity.Property(e => e.Cpfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield2");
            entity.Property(e => e.Cpfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield3");
            entity.Property(e => e.Cpfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield4");
            entity.Property(e => e.Cpfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield5");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs).HasColumnName("hrs");
            entity.Property(e => e.Imei)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("imei");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Logonid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("logonid");
            entity.Property(e => e.Mcid).HasColumnName("mcid");
            entity.Property(e => e.Mins).HasColumnName("mins");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Oldflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("oldflag");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Verifymode).HasColumnName("verifymode");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<ProcessData042022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("process_data_042022");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Type }, "IX_process_data_042022")
                .IsUnique()
                .IsDescending(false, true, true, false);

            entity.Property(e => e.Coordinates)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("coordinates");
            entity.Property(e => e.Cpfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield1");
            entity.Property(e => e.Cpfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield2");
            entity.Property(e => e.Cpfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield3");
            entity.Property(e => e.Cpfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield4");
            entity.Property(e => e.Cpfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield5");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs).HasColumnName("hrs");
            entity.Property(e => e.Imei)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("imei");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Logonid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("logonid");
            entity.Property(e => e.Mcid).HasColumnName("mcid");
            entity.Property(e => e.Mins).HasColumnName("mins");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Oldflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("oldflag");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Verifymode).HasColumnName("verifymode");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<ProcessData042023>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("process_data_042023");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Type }, "IX_process_data_042023")
                .IsUnique()
                .IsDescending(false, true, true, false);

            entity.Property(e => e.Coordinates)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("coordinates");
            entity.Property(e => e.Cpfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield1");
            entity.Property(e => e.Cpfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield2");
            entity.Property(e => e.Cpfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield3");
            entity.Property(e => e.Cpfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield4");
            entity.Property(e => e.Cpfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield5");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs).HasColumnName("hrs");
            entity.Property(e => e.Imei)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("imei");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Logonid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("logonid");
            entity.Property(e => e.Mcid).HasColumnName("mcid");
            entity.Property(e => e.Mins).HasColumnName("mins");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Oldflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("oldflag");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Verifymode).HasColumnName("verifymode");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<ProcessData052022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("process_data_052022");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Type }, "IX_process_data_052022")
                .IsUnique()
                .IsDescending(false, true, true, false);

            entity.Property(e => e.Coordinates)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("coordinates");
            entity.Property(e => e.Cpfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield1");
            entity.Property(e => e.Cpfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield2");
            entity.Property(e => e.Cpfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield3");
            entity.Property(e => e.Cpfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield4");
            entity.Property(e => e.Cpfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield5");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs).HasColumnName("hrs");
            entity.Property(e => e.Imei)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("imei");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Logonid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("logonid");
            entity.Property(e => e.Mcid).HasColumnName("mcid");
            entity.Property(e => e.Mins).HasColumnName("mins");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Oldflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("oldflag");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Verifymode).HasColumnName("verifymode");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<ProcessData052023>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("process_data_052023");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Type }, "IX_process_data_052023")
                .IsUnique()
                .IsDescending(false, true, true, false);

            entity.Property(e => e.Coordinates)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("coordinates");
            entity.Property(e => e.Cpfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield1");
            entity.Property(e => e.Cpfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield2");
            entity.Property(e => e.Cpfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield3");
            entity.Property(e => e.Cpfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield4");
            entity.Property(e => e.Cpfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield5");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs).HasColumnName("hrs");
            entity.Property(e => e.Imei)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("imei");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Logonid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("logonid");
            entity.Property(e => e.Mcid).HasColumnName("mcid");
            entity.Property(e => e.Mins).HasColumnName("mins");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Oldflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("oldflag");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Verifymode).HasColumnName("verifymode");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<ProcessData062022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("process_data_062022");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Type }, "IX_process_data_062022")
                .IsUnique()
                .IsDescending(false, true, true, false);

            entity.Property(e => e.Coordinates)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("coordinates");
            entity.Property(e => e.Cpfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield1");
            entity.Property(e => e.Cpfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield2");
            entity.Property(e => e.Cpfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield3");
            entity.Property(e => e.Cpfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield4");
            entity.Property(e => e.Cpfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield5");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs).HasColumnName("hrs");
            entity.Property(e => e.Imei)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("imei");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Logonid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("logonid");
            entity.Property(e => e.Mcid).HasColumnName("mcid");
            entity.Property(e => e.Mins).HasColumnName("mins");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Oldflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("oldflag");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Verifymode).HasColumnName("verifymode");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<ProcessData062023>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("process_data_062023");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Type }, "IX_process_data_062023")
                .IsUnique()
                .IsDescending(false, true, true, false);

            entity.Property(e => e.Coordinates)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("coordinates");
            entity.Property(e => e.Cpfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield1");
            entity.Property(e => e.Cpfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield2");
            entity.Property(e => e.Cpfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield3");
            entity.Property(e => e.Cpfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield4");
            entity.Property(e => e.Cpfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield5");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs).HasColumnName("hrs");
            entity.Property(e => e.Imei)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("imei");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Logonid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("logonid");
            entity.Property(e => e.Mcid).HasColumnName("mcid");
            entity.Property(e => e.Mins).HasColumnName("mins");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Oldflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("oldflag");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Verifymode).HasColumnName("verifymode");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<ProcessData072022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("process_data_072022");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Type }, "IX_process_data_072022")
                .IsUnique()
                .IsDescending(false, true, true, false);

            entity.Property(e => e.Coordinates)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("coordinates");
            entity.Property(e => e.Cpfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield1");
            entity.Property(e => e.Cpfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield2");
            entity.Property(e => e.Cpfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield3");
            entity.Property(e => e.Cpfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield4");
            entity.Property(e => e.Cpfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield5");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs).HasColumnName("hrs");
            entity.Property(e => e.Imei)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("imei");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Logonid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("logonid");
            entity.Property(e => e.Mcid).HasColumnName("mcid");
            entity.Property(e => e.Mins).HasColumnName("mins");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Oldflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("oldflag");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Verifymode).HasColumnName("verifymode");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<ProcessData072023>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("process_data_072023");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Type }, "IX_process_data_072023")
                .IsUnique()
                .IsDescending(false, true, true, false);

            entity.Property(e => e.Coordinates)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("coordinates");
            entity.Property(e => e.Cpfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield1");
            entity.Property(e => e.Cpfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield2");
            entity.Property(e => e.Cpfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield3");
            entity.Property(e => e.Cpfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield4");
            entity.Property(e => e.Cpfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield5");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs).HasColumnName("hrs");
            entity.Property(e => e.Imei)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("imei");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Logonid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("logonid");
            entity.Property(e => e.Mcid).HasColumnName("mcid");
            entity.Property(e => e.Mins).HasColumnName("mins");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Oldflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("oldflag");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Verifymode).HasColumnName("verifymode");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<ProcessData082022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("process_data_082022");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Type }, "IX_process_data_082022")
                .IsUnique()
                .IsDescending(false, true, true, false);

            entity.Property(e => e.Coordinates)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("coordinates");
            entity.Property(e => e.Cpfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield1");
            entity.Property(e => e.Cpfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield2");
            entity.Property(e => e.Cpfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield3");
            entity.Property(e => e.Cpfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield4");
            entity.Property(e => e.Cpfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield5");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs).HasColumnName("hrs");
            entity.Property(e => e.Imei)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("imei");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Logonid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("logonid");
            entity.Property(e => e.Mcid).HasColumnName("mcid");
            entity.Property(e => e.Mins).HasColumnName("mins");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Oldflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("oldflag");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Verifymode).HasColumnName("verifymode");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<ProcessData082023>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("process_data_082023");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Type }, "IX_process_data_082023")
                .IsUnique()
                .IsDescending(false, true, true, false);

            entity.Property(e => e.Coordinates)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("coordinates");
            entity.Property(e => e.Cpfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield1");
            entity.Property(e => e.Cpfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield2");
            entity.Property(e => e.Cpfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield3");
            entity.Property(e => e.Cpfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield4");
            entity.Property(e => e.Cpfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield5");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs).HasColumnName("hrs");
            entity.Property(e => e.Imei)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("imei");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Logonid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("logonid");
            entity.Property(e => e.Mcid).HasColumnName("mcid");
            entity.Property(e => e.Mins).HasColumnName("mins");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Oldflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("oldflag");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Verifymode).HasColumnName("verifymode");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<ProcessData092022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("process_data_092022");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Type }, "IX_process_data_092022")
                .IsUnique()
                .IsDescending(false, true, true, false);

            entity.Property(e => e.Coordinates)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("coordinates");
            entity.Property(e => e.Cpfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield1");
            entity.Property(e => e.Cpfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield2");
            entity.Property(e => e.Cpfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield3");
            entity.Property(e => e.Cpfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield4");
            entity.Property(e => e.Cpfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield5");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs).HasColumnName("hrs");
            entity.Property(e => e.Imei)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("imei");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Logonid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("logonid");
            entity.Property(e => e.Mcid).HasColumnName("mcid");
            entity.Property(e => e.Mins).HasColumnName("mins");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Oldflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("oldflag");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Verifymode).HasColumnName("verifymode");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<ProcessData092023>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("process_data_092023");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Type }, "IX_process_data_092023")
                .IsUnique()
                .IsDescending(false, true, true, false);

            entity.Property(e => e.Coordinates)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("coordinates");
            entity.Property(e => e.Cpfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield1");
            entity.Property(e => e.Cpfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield2");
            entity.Property(e => e.Cpfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield3");
            entity.Property(e => e.Cpfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield4");
            entity.Property(e => e.Cpfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield5");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs).HasColumnName("hrs");
            entity.Property(e => e.Imei)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("imei");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Logonid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("logonid");
            entity.Property(e => e.Mcid).HasColumnName("mcid");
            entity.Property(e => e.Mins).HasColumnName("mins");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Oldflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("oldflag");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Verifymode).HasColumnName("verifymode");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<ProcessData102021>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("process_data_102021");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Type }, "IX_process_data_102021")
                .IsUnique()
                .IsDescending(false, true, true, false);

            entity.Property(e => e.Coordinates)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("coordinates");
            entity.Property(e => e.Cpfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield1");
            entity.Property(e => e.Cpfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield2");
            entity.Property(e => e.Cpfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield3");
            entity.Property(e => e.Cpfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield4");
            entity.Property(e => e.Cpfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield5");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs).HasColumnName("hrs");
            entity.Property(e => e.Imei)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("imei");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Logonid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("logonid");
            entity.Property(e => e.Mcid).HasColumnName("mcid");
            entity.Property(e => e.Mins).HasColumnName("mins");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Oldflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("oldflag");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Verifymode).HasColumnName("verifymode");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<ProcessData102022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("process_data_102022");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Type }, "IX_process_data_102022")
                .IsUnique()
                .IsDescending(false, true, true, false);

            entity.Property(e => e.Coordinates)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("coordinates");
            entity.Property(e => e.Cpfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield1");
            entity.Property(e => e.Cpfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield2");
            entity.Property(e => e.Cpfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield3");
            entity.Property(e => e.Cpfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield4");
            entity.Property(e => e.Cpfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield5");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs).HasColumnName("hrs");
            entity.Property(e => e.Imei)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("imei");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Logonid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("logonid");
            entity.Property(e => e.Mcid).HasColumnName("mcid");
            entity.Property(e => e.Mins).HasColumnName("mins");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Oldflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("oldflag");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Verifymode).HasColumnName("verifymode");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<ProcessData102023>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("process_data_102023");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Type }, "IX_process_data_102023")
                .IsUnique()
                .IsDescending(false, true, true, false);

            entity.Property(e => e.Coordinates)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("coordinates");
            entity.Property(e => e.Cpfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield1");
            entity.Property(e => e.Cpfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield2");
            entity.Property(e => e.Cpfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield3");
            entity.Property(e => e.Cpfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield4");
            entity.Property(e => e.Cpfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield5");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs).HasColumnName("hrs");
            entity.Property(e => e.Imei)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("imei");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Logonid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("logonid");
            entity.Property(e => e.Mcid).HasColumnName("mcid");
            entity.Property(e => e.Mins).HasColumnName("mins");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Oldflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("oldflag");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Verifymode).HasColumnName("verifymode");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<ProcessData112021>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("process_data_112021");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Type }, "IX_process_data_112021")
                .IsUnique()
                .IsDescending(false, true, true, false);

            entity.Property(e => e.Coordinates)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("coordinates");
            entity.Property(e => e.Cpfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield1");
            entity.Property(e => e.Cpfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield2");
            entity.Property(e => e.Cpfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield3");
            entity.Property(e => e.Cpfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield4");
            entity.Property(e => e.Cpfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield5");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs).HasColumnName("hrs");
            entity.Property(e => e.Imei)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("imei");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Logonid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("logonid");
            entity.Property(e => e.Mcid).HasColumnName("mcid");
            entity.Property(e => e.Mins).HasColumnName("mins");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Oldflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("oldflag");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Verifymode).HasColumnName("verifymode");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<ProcessData112022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("process_data_112022");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Type }, "IX_process_data_112022")
                .IsUnique()
                .IsDescending(false, true, true, false);

            entity.Property(e => e.Coordinates)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("coordinates");
            entity.Property(e => e.Cpfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield1");
            entity.Property(e => e.Cpfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield2");
            entity.Property(e => e.Cpfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield3");
            entity.Property(e => e.Cpfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield4");
            entity.Property(e => e.Cpfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield5");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs).HasColumnName("hrs");
            entity.Property(e => e.Imei)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("imei");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Logonid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("logonid");
            entity.Property(e => e.Mcid).HasColumnName("mcid");
            entity.Property(e => e.Mins).HasColumnName("mins");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Oldflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("oldflag");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Verifymode).HasColumnName("verifymode");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<ProcessData112023>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("process_data_112023");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Type }, "IX_process_data_112023")
                .IsUnique()
                .IsDescending(false, true, true, false);

            entity.Property(e => e.Coordinates)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("coordinates");
            entity.Property(e => e.Cpfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield1");
            entity.Property(e => e.Cpfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield2");
            entity.Property(e => e.Cpfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield3");
            entity.Property(e => e.Cpfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield4");
            entity.Property(e => e.Cpfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield5");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs).HasColumnName("hrs");
            entity.Property(e => e.Imei)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("imei");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Logonid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("logonid");
            entity.Property(e => e.Mcid).HasColumnName("mcid");
            entity.Property(e => e.Mins).HasColumnName("mins");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Oldflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("oldflag");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Verifymode).HasColumnName("verifymode");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<ProcessData122021>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("process_data_122021");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Type }, "IX_process_data_122021")
                .IsUnique()
                .IsDescending(false, true, true, false);

            entity.Property(e => e.Coordinates)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("coordinates");
            entity.Property(e => e.Cpfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield1");
            entity.Property(e => e.Cpfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield2");
            entity.Property(e => e.Cpfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield3");
            entity.Property(e => e.Cpfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield4");
            entity.Property(e => e.Cpfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield5");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs).HasColumnName("hrs");
            entity.Property(e => e.Imei)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("imei");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Logonid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("logonid");
            entity.Property(e => e.Mcid).HasColumnName("mcid");
            entity.Property(e => e.Mins).HasColumnName("mins");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Oldflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("oldflag");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Verifymode).HasColumnName("verifymode");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<ProcessData122022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("process_data_122022");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Type }, "IX_process_data_122022")
                .IsUnique()
                .IsDescending(false, true, true, false);

            entity.Property(e => e.Coordinates)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("coordinates");
            entity.Property(e => e.Cpfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield1");
            entity.Property(e => e.Cpfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield2");
            entity.Property(e => e.Cpfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield3");
            entity.Property(e => e.Cpfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield4");
            entity.Property(e => e.Cpfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield5");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs).HasColumnName("hrs");
            entity.Property(e => e.Imei)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("imei");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Logonid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("logonid");
            entity.Property(e => e.Mcid).HasColumnName("mcid");
            entity.Property(e => e.Mins).HasColumnName("mins");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Oldflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("oldflag");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Verifymode).HasColumnName("verifymode");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<ProcessData122023>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("process_data_122023");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Type }, "IX_process_data_122023")
                .IsUnique()
                .IsDescending(false, true, true, false);

            entity.Property(e => e.Coordinates)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("coordinates");
            entity.Property(e => e.Cpfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield1");
            entity.Property(e => e.Cpfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield2");
            entity.Property(e => e.Cpfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield3");
            entity.Property(e => e.Cpfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield4");
            entity.Property(e => e.Cpfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield5");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs).HasColumnName("hrs");
            entity.Property(e => e.Imei)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("imei");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Logonid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("logonid");
            entity.Property(e => e.Mcid).HasColumnName("mcid");
            entity.Property(e => e.Mins).HasColumnName("mins");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Oldflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("oldflag");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Verifymode).HasColumnName("verifymode");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<ProcessDatum>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("process_data$PrimaryKey");

            entity.ToTable("process_data");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Coordinates)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("coordinates");
            entity.Property(e => e.Cpfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield1");
            entity.Property(e => e.Cpfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield2");
            entity.Property(e => e.Cpfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield3");
            entity.Property(e => e.Cpfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield4");
            entity.Property(e => e.Cpfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cpfield5");
            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("date1");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days)
                .HasDefaultValue(0)
                .HasColumnName("days");
            entity.Property(e => e.Empid)
                .HasDefaultValue(0)
                .HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs)
                .HasDefaultValue(0)
                .HasColumnName("hrs");
            entity.Property(e => e.Imei)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("imei");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ipaddress");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Logonid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("logonid");
            entity.Property(e => e.Mcid).HasColumnName("mcid");
            entity.Property(e => e.Mins)
                .HasDefaultValue(0)
                .HasColumnName("mins");
            entity.Property(e => e.Mons)
                .HasDefaultValue(0)
                .HasColumnName("mons");
            entity.Property(e => e.Oldflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("oldflag");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Type)
                .HasDefaultValue(0)
                .HasColumnName("type");
            entity.Property(e => e.Verifymode)
                .HasDefaultValue(0)
                .HasColumnName("verifymode");
            entity.Property(e => e.Yrs)
                .HasDefaultValue(0)
                .HasColumnName("yrs");
        });

        modelBuilder.Entity<Profile>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__Profiles__5165187F");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Profilename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("profilename");
        });

        modelBuilder.Entity<ProfileFormDetail>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__Profile_FormDeta__571DF1D5");

            entity.ToTable("Profile_FormDetails");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Backcolor)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("backcolor");
            entity.Property(e => e.Formheight).HasColumnName("formheight");
            entity.Property(e => e.Formwidth).HasColumnName("formwidth");
            entity.Property(e => e.Profilename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("profilename");
        });

        modelBuilder.Entity<ProfileImage>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__Profile_Images__5535A963");

            entity.ToTable("Profile_Images");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Image)
                .HasColumnType("image")
                .HasColumnName("image");
            entity.Property(e => e.Imageheight).HasColumnName("imageheight");
            entity.Property(e => e.Imageleft)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("imageleft");
            entity.Property(e => e.Imagename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("imagename");
            entity.Property(e => e.Imagetop)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("imagetop");
            entity.Property(e => e.Imagewidth).HasColumnName("imagewidth");
            entity.Property(e => e.Profilename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("profilename");
        });

        modelBuilder.Entity<ProfileLine>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("Profile_Lines");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Color)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("color");
            entity.Property(e => e.Details)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Profilename)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("profilename");
            entity.Property(e => e.Thickness)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("thickness");
            entity.Property(e => e.X1).HasColumnName("x1");
            entity.Property(e => e.X2).HasColumnName("x2");
            entity.Property(e => e.Y1).HasColumnName("y1");
            entity.Property(e => e.Y2).HasColumnName("y2");
        });

        modelBuilder.Entity<ProfileMaster>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__Profile_Master__534D60F1");

            entity.ToTable("Profile_Master");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Bold)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("bold");
            entity.Property(e => e.Displaytext)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("displaytext");
            entity.Property(e => e.Fieldname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("fieldname");
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Fontname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fontname");
            entity.Property(e => e.Fontsize)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fontsize");
            entity.Property(e => e.Forecolour)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("forecolour");
            entity.Property(e => e.Italic)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("italic");
            entity.Property(e => e.Leftposition)
                .HasDefaultValue(0)
                .HasColumnName("leftposition");
            entity.Property(e => e.Profilename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("profilename");
            entity.Property(e => e.Topposition)
                .HasDefaultValue(0)
                .HasColumnName("topposition");
            entity.Property(e => e.Underline)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("underline");
        });

        modelBuilder.Entity<Projectmaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("projectmaster");

            entity.Property(e => e.Details)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Idcno)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("idcno");
            entity.Property(e => e.Pmnotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("pmnotes");
            entity.Property(e => e.Pmnotes1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("pmnotes1");
            entity.Property(e => e.Pmnotes2)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("pmnotes2");
            entity.Property(e => e.Projectmgr).HasColumnName("projectmgr");
            entity.Property(e => e.Projectno)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("projectno");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<Projectnamemaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("projectnamemaster");

            entity.Property(e => e.Details)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Pnotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("pnotes");
            entity.Property(e => e.Pnotes1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("pnotes1");
            entity.Property(e => e.Pnotes2)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("pnotes2");
            entity.Property(e => e.Projectid).HasColumnName("projectid");
            entity.Property(e => e.Projectname)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("projectname");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<Purpose>(entity =>
        {
            entity.HasKey(e => e.SrNo).HasName("PK__purpose__4D94879B");

            entity.ToTable("purpose");

            entity.Property(e => e.Details)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Purpose1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("purpose");
        });

        modelBuilder.Entity<Recharge>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Recharge");

            entity.Property(e => e.Addedon)
                .HasColumnType("datetime")
                .HasColumnName("addedon");
            entity.Property(e => e.Balance).HasColumnName("balance");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Menuid).HasColumnName("menuid");
            entity.Property(e => e.Recharge1).HasColumnName("Recharge");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Used).HasColumnName("used");
            entity.Property(e => e.Validfrom)
                .HasColumnType("datetime")
                .HasColumnName("validfrom");
            entity.Property(e => e.Validto)
                .HasColumnType("datetime")
                .HasColumnName("validto");
        });

        modelBuilder.Entity<Registerkey>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("registerkeys");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.Key1)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("key1");
            entity.Property(e => e.Key2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("key2");
            entity.Property(e => e.Srno).HasColumnName("srno");
        });

        modelBuilder.Entity<Removedwatchlist>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__removedwatchlist__4AB81AF0");

            entity.ToTable("removedwatchlist");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Addedby)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("addedby");
            entity.Property(e => e.Empid)
                .HasDefaultValueSql("('0')")
                .HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Note)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("note");
            entity.Property(e => e.Visitorid).HasColumnName("visitorid");
            entity.Property(e => e.Visname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("visname");
        });

        modelBuilder.Entity<Reportsetting>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("reportsettings");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Columnstring)
                .IsUnicode(false)
                .HasColumnName("columnstring");
            entity.Property(e => e.Dateformat)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("dateformat");
            entity.Property(e => e.Dateseparator)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("dateseparator");
            entity.Property(e => e.Extension)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("extension");
            entity.Property(e => e.Fieldcount).HasColumnName("fieldcount");
            entity.Property(e => e.Fieldseparator)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("fieldseparator");
            entity.Property(e => e.Flag)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Formatstring)
                .IsUnicode(false)
                .HasColumnName("formatstring");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Notes1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes1");
            entity.Property(e => e.Reportname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("reportname");
            entity.Property(e => e.Reporttype)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("reporttype");
            entity.Property(e => e.Rowcount).HasColumnName("rowcount");
            entity.Property(e => e.Rowterminator)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("rowterminator");
            entity.Property(e => e.Showheader)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("showheader");
            entity.Property(e => e.Usertype).HasColumnName("usertype");
        });

        modelBuilder.Entity<RequestAppointment>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("RequestAppointment");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Address)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.Approvevisitor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("approvevisitor");
            entity.Property(e => e.Buildingno)
                .IsUnicode(false)
                .HasColumnName("buildingno");
            entity.Property(e => e.Carrlaptop)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("carrlaptop");
            entity.Property(e => e.Carrmob)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("carrmob");
            entity.Property(e => e.Carrmobwithcamera)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("carrmobwithcamera");
            entity.Property(e => e.Carrother)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("carrother");
            entity.Property(e => e.Carrotherdetails)
                .IsUnicode(false)
                .HasColumnName("carrotherdetails");
            entity.Property(e => e.Carrtoolkit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("carrtoolkit");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Compname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("compname");
            entity.Property(e => e.Contactno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contactno");
            entity.Property(e => e.Dist).HasColumnName("dist");
            entity.Property(e => e.Email)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Floorno)
                .IsUnicode(false)
                .HasColumnName("floorno");
            entity.Property(e => e.Fromdate)
                .HasColumnType("datetime")
                .HasColumnName("fromdate");
            entity.Property(e => e.Gateno).HasColumnName("gateno");
            entity.Property(e => e.Gatepassno).HasColumnName("gatepassno");
            entity.Property(e => e.Host)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("host");
            entity.Property(e => e.Idproof)
                .IsUnicode(false)
                .HasColumnName("idproof");
            entity.Property(e => e.Idtype)
                .IsUnicode(false)
                .HasColumnName("idtype");
            entity.Property(e => e.Lapproveflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lapproveflag");
            entity.Property(e => e.Mapproveflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mapproveflag");
            entity.Property(e => e.Nationality)
                .IsUnicode(false)
                .HasColumnName("nationality");
            entity.Property(e => e.Note)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("note");
            entity.Property(e => e.Purpose)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("purpose");
            entity.Property(e => e.Requeststatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("requeststatus");
            entity.Property(e => e.Smstext)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("smstext");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Todate)
                .HasColumnType("datetime")
                .HasColumnName("todate");
            entity.Property(e => e.Updated)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("updated");
            entity.Property(e => e.Village).HasColumnName("village");
            entity.Property(e => e.Visitarea)
                .IsUnicode(false)
                .HasColumnName("visitarea");
            entity.Property(e => e.Visitorname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("visitorname");
            entity.Property(e => e.Workarea)
                .IsUnicode(false)
                .HasColumnName("workarea");
        });

        modelBuilder.Entity<RequestMail>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Emailid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("emailid");
            entity.Property(e => e.Entryon)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("entryon");
            entity.Property(e => e.Flag)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Loginid)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("loginid");
            entity.Property(e => e.Notes)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Reqid).HasColumnName("reqid");
            entity.Property(e => e.Reqtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("reqtype");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<RewardSafetyvoilation>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("reward_safetyvoilation");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Rewards)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("rewards");
            entity.Property(e => e.Safetyvoilation)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("safetyvoilation");
        });

        modelBuilder.Entity<RoasterDaily>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__Roaster_Daily__45F365D3");

            entity.ToTable("Roaster_Daily");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Compid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Locationid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Patternname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("patternname");
            entity.Property(e => e.Shiftname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("shiftname");
        });

        modelBuilder.Entity<RoasterMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Roaster_Master");

            entity.Property(e => e.Changeon)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("changeon");
            entity.Property(e => e.Compid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Locationid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Monthlychangedate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("monthlychangedate");
            entity.Property(e => e.Patterncode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("patterncode");
            entity.Property(e => e.Patternname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("patternname");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.Usedflag)
                .HasDefaultValue(0)
                .HasColumnName("usedflag");
            entity.Property(e => e.Wkoff1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("wkoff1");
            entity.Property(e => e.Wkoff2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("wkoff2");
            entity.Property(e => e.Wkoffon1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("wkoffon1");
            entity.Property(e => e.Wkoffon2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("wkoffon2");
        });

        modelBuilder.Entity<RoasterMonthly>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__Roaster_Monthly__4316F928");

            entity.ToTable("Roaster_Monthly");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Compid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Locationid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Patternname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("patternname");
            entity.Property(e => e.Shiftname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("shiftname");
        });

        modelBuilder.Entity<RoasterWeekly>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__Roaster_Weekly__412EB0B6");

            entity.ToTable("Roaster_Weekly");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Compid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Fri)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fri");
            entity.Property(e => e.Locationid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Mon)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mon");
            entity.Property(e => e.Patternname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("patternname");
            entity.Property(e => e.Sat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sat");
            entity.Property(e => e.Sun)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sun");
            entity.Property(e => e.Thu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("thu");
            entity.Property(e => e.Tue)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tue");
            entity.Property(e => e.Wed)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("wed");
            entity.Property(e => e.Weekcount).HasColumnName("weekcount");
            entity.Property(e => e.Weekno).HasColumnName("weekno");
        });

        modelBuilder.Entity<Rosterdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("rosterdetails");

            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Details)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Note1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("note1");
            entity.Property(e => e.Note2)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("note2");
            entity.Property(e => e.Rosterid).HasColumnName("rosterid");
            entity.Property(e => e.Shift)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("shift");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<Safetylog>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("safetylog");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("category");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Tokenno)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("tokenno");
            entity.Property(e => e.Training)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("training");
            entity.Property(e => e.Vendor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor");
            entity.Property(e => e.Workarea)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("workarea");
            entity.Property(e => e.Workorderno)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("workorderno");
        });

        modelBuilder.Entity<Scandoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("scandoc");

            entity.Property(e => e.Docimage)
                .HasColumnType("image")
                .HasColumnName("docimage");
            entity.Property(e => e.Docname)
                .HasMaxLength(50)
                .HasColumnName("docname");
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .HasColumnName("flag");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Visitorid).HasColumnName("visitorid");
        });

        modelBuilder.Entity<Sectionmaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sectionmaster");

            entity.Property(e => e.Compid)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Contactno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("contactno");
            entity.Property(e => e.Details)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Locationid)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Sectionhead)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("sectionhead");
            entity.Property(e => e.Sectionname)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("sectionname");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<Securitymessage>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__securitymessage__3C69FB99");

            entity.ToTable("securitymessage");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Message)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("message");
        });

        modelBuilder.Entity<Serverauth>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("serverauth");

            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Notes1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes1");
            entity.Property(e => e.Serverauthflag)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("serverauthflag");
        });

        modelBuilder.Entity<Servicestatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("servicestatus");

            entity.Property(e => e.Lastupdatetime)
                .HasColumnType("datetime")
                .HasColumnName("lastupdatetime");
        });

        modelBuilder.Entity<SetAccesstime>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("SET_accesstimes");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Doorheldtime).HasColumnName("doorheldtime");
            entity.Property(e => e.Egatime).HasColumnName("egatime");
            entity.Property(e => e.Minopentime).HasColumnName("minopentime");
            entity.Property(e => e.Ngatime).HasColumnName("ngatime");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uploadedyn");
        });

        modelBuilder.Entity<SetDoorMonitor>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("SET_DoorMonitor");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cleardfalarm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CLEARDFALARM");
            entity.Property(e => e.EnableDoorForced)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("enableDoorForced");
            entity.Property(e => e.EnableDoorHeld)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("enableDoorHeld");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uploadedyn");
        });

        modelBuilder.Entity<SetMemoryAddress>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("SET_MemoryAddress");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cnttype)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cnttype");
            entity.Property(e => e.Datastored)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("datastored");
            entity.Property(e => e.Memadd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("memadd");
        });

        modelBuilder.Entity<SetMonitor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SET_Monitor");

            entity.Property(e => e.Savedatatocnt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("savedatatocnt");
            entity.Property(e => e.Startflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("false")
                .HasColumnName("startflag");
        });

        modelBuilder.Entity<SetPortNo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SET_PortNo");

            entity.Property(e => e.Portno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("4070")
                .HasColumnName("portno");
        });

        modelBuilder.Entity<Setcolour>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("setcolour");

            entity.Property(e => e.Colour)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("colour");
            entity.Property(e => e.Names)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("names");
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Verification)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("verification");
        });

        modelBuilder.Entity<ShiftCalendar>(entity =>
        {
            entity.HasKey(e => e.SrNo).HasName("shift_calendar$PrimaryKey");

            entity.ToTable("shift_calendar");

            entity.Property(e => e.Caltype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("caltype");
            entity.Property(e => e.Compid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Fromdate)
                .HasColumnType("datetime")
                .HasColumnName("fromdate");
            entity.Property(e => e.Locationid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Months)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mpname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("mpname");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pname");
            entity.Property(e => e.Todate)
                .HasColumnType("datetime")
                .HasColumnName("todate");
            entity.Property(e => e.Usedflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usedflag");
            entity.Property(e => e.Years)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e._1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("1");
            entity.Property(e => e._10)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("10");
            entity.Property(e => e._11)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("11");
            entity.Property(e => e._12)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("12");
            entity.Property(e => e._13)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("13");
            entity.Property(e => e._14)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("14");
            entity.Property(e => e._15)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("15");
            entity.Property(e => e._16)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("16");
            entity.Property(e => e._17)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("17");
            entity.Property(e => e._18)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("18");
            entity.Property(e => e._19)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("19");
            entity.Property(e => e._2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("2");
            entity.Property(e => e._20)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("20");
            entity.Property(e => e._21)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("21");
            entity.Property(e => e._22)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("22");
            entity.Property(e => e._23)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("23");
            entity.Property(e => e._24)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("24");
            entity.Property(e => e._25)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("25");
            entity.Property(e => e._26)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("26");
            entity.Property(e => e._27)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("27");
            entity.Property(e => e._28)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("28");
            entity.Property(e => e._29)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("29");
            entity.Property(e => e._3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("3");
            entity.Property(e => e._30)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("30");
            entity.Property(e => e._31)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("31");
            entity.Property(e => e._4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("4");
            entity.Property(e => e._5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("5");
            entity.Property(e => e._6)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("6");
            entity.Property(e => e._7)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("7");
            entity.Property(e => e._8)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("8");
            entity.Property(e => e._9)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("9");
        });

        modelBuilder.Entity<ShiftGroup>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Addedby)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("addedby");
            entity.Property(e => e.Addedtime)
                .HasColumnType("datetime")
                .HasColumnName("addedtime");
            entity.Property(e => e.Compid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Flag)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Groupname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("groupname");
            entity.Property(e => e.Locationid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Shiftid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("shiftid");
        });

        modelBuilder.Entity<ShiftRoster>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("shift_roster");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Compid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Flag)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Fri1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fri1");
            entity.Property(e => e.Fri2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fri2");
            entity.Property(e => e.Fri3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fri3");
            entity.Property(e => e.Fri4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fri4");
            entity.Property(e => e.Fri5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fri5");
            entity.Property(e => e.Locationid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Mon1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("mon1");
            entity.Property(e => e.Mon2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("mon2");
            entity.Property(e => e.Mon3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("mon3");
            entity.Property(e => e.Mon4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("mon4");
            entity.Property(e => e.Mon5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("mon5");
            entity.Property(e => e.Rostername)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("rostername");
            entity.Property(e => e.Sat1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sat1");
            entity.Property(e => e.Sat2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sat2");
            entity.Property(e => e.Sat3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sat3");
            entity.Property(e => e.Sat4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sat4");
            entity.Property(e => e.Sat5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sat5");
            entity.Property(e => e.Section)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("section");
            entity.Property(e => e.Setflag)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("setflag");
            entity.Property(e => e.Sun1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sun1");
            entity.Property(e => e.Sun2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sun2");
            entity.Property(e => e.Sun3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sun3");
            entity.Property(e => e.Sun4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sun4");
            entity.Property(e => e.Sun5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sun5");
            entity.Property(e => e.Thu1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("thu1");
            entity.Property(e => e.Thu2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("thu2");
            entity.Property(e => e.Thu3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("thu3");
            entity.Property(e => e.Thu4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("thu4");
            entity.Property(e => e.Thu5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("thu5");
            entity.Property(e => e.Totaldays)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("totaldays");
            entity.Property(e => e.Tue1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tue1");
            entity.Property(e => e.Tue2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tue2");
            entity.Property(e => e.Tue3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tue3");
            entity.Property(e => e.Tue4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tue4");
            entity.Property(e => e.Tue5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tue5");
            entity.Property(e => e.Wed1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("wed1");
            entity.Property(e => e.Wed2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("wed2");
            entity.Property(e => e.Wed3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("wed3");
            entity.Property(e => e.Wed4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("wed4");
            entity.Property(e => e.Wed5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("wed5");
        });

        modelBuilder.Entity<Shiftmaster>(entity =>
        {
            entity.HasKey(e => e.SrNo).HasName("shiftmaster$PrimaryKey");

            entity.ToTable("shiftmaster");

            entity.Property(e => e.BreakEnd)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BreakStart)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChkShfAftTolerance)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChkShfBfrTolerance)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Compid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Dayendtime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dayendtime");
            entity.Property(e => e.Dayflag).HasColumnName("dayflag");
            entity.Property(e => e.Daystarttime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("daystarttime");
            entity.Property(e => e.Defaultflag)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.EndTime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Firstdaypunchescnt)
                .HasDefaultValue(0)
                .HasColumnName("firstdaypunchescnt");
            entity.Property(e => e.Flag1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("flag1");
            entity.Property(e => e.Flag2)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("flag2");
            entity.Property(e => e.LateTolerance)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Locationid)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.NightShift)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtTolerance)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Seconddaypunchcnt)
                .HasDefaultValue(0)
                .HasColumnName("seconddaypunchcnt");
            entity.Property(e => e.Section)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("section");
            entity.Property(e => e.ShiftCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShiftName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Shiftflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("shiftflag");
            entity.Property(e => e.Shifthalfdayhrs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("shifthalfdayhrs");
            entity.Property(e => e.Shiftwrkhrs)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("shiftwrkhrs");
            entity.Property(e => e.ShortTolerance)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StartTime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Usedflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usedflag");
        });

        modelBuilder.Entity<SignatureMaster>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("signatureMaster");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Image)
                .HasColumnType("image")
                .HasColumnName("image");
            entity.Property(e => e.Visitorid).HasColumnName("visitorid");
        });

        modelBuilder.Entity<Sm>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("sms");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Entrydate)
                .HasColumnType("datetime")
                .HasColumnName("entrydate");
            entity.Property(e => e.Entrytime)
                .HasColumnType("datetime")
                .HasColumnName("entrytime");
            entity.Property(e => e.Kyword)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("kyword");
            entity.Property(e => e.Message)
                .HasColumnType("text")
                .HasColumnName("message");
            entity.Property(e => e.Msgdetails)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("msgdetails");
            entity.Property(e => e.Msgnotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("msgnotes");
            entity.Property(e => e.Num)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("num");
            entity.Property(e => e.Replystatus)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("replystatus");
            entity.Property(e => e.Sender)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("sender");
            entity.Property(e => e.Sent)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("sent");
            entity.Property(e => e.Status)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Smsgatewaysetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("smsgatewaysettings");

            entity.Property(e => e.Pass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pass");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Smssetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("smssetting");

            entity.Property(e => e.Balance)
                .HasDefaultValueSql("('0')")
                .HasColumnName("balance");
            entity.Property(e => e.Empsms)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("empsms");
            entity.Property(e => e.Pass)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("pass");
            entity.Property(e => e.SettingType)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Smsonappointment)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("smsonappointment");
            entity.Property(e => e.Smstext)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("smstext");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Smssetting1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("smssettings");

            entity.Property(e => e.Apply)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("apply");
            entity.Property(e => e.Baudrate)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("baudrate");
            entity.Property(e => e.Databits)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("databits");
            entity.Property(e => e.Paritybits)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("paritybits");
            entity.Property(e => e.Port)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("port");
            entity.Property(e => e.Simnum)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("simnum");
            entity.Property(e => e.Smsnotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("smsnotes");
            entity.Property(e => e.Smsnotes1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("smsnotes1");
            entity.Property(e => e.Smsnotes2)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("smsnotes2");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Stopbits)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("stopbits");
        });

        modelBuilder.Entity<StateMaster>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("StateMaster$PrimaryKey");

            entity.ToTable("StateMaster");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Details)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Emailid)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("emailid");
            entity.Property(e => e.Finendyear)
                .HasColumnType("datetime")
                .HasColumnName("finendyear");
            entity.Property(e => e.Finstartyear)
                .HasColumnType("datetime")
                .HasColumnName("finstartyear");
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Logo)
                .HasColumnType("image")
                .HasColumnName("logo");
            entity.Property(e => e.Phno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phno");
            entity.Property(e => e.Statename)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("statename");
            entity.Property(e => e.Usedflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usedflag");
        });

        modelBuilder.Entity<Stmplogtbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("stmplogtbl");

            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("category");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Tokenno)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("tokenno");
            entity.Property(e => e.Training)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("training");
            entity.Property(e => e.Vendor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendor");
            entity.Property(e => e.Workarea)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("workarea");
            entity.Property(e => e.Workorderno)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("workorderno");
        });

        modelBuilder.Entity<Stmplogtbl2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("stmplogtbl2");

            entity.Property(e => e.Category)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("category");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Empid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empid");
            entity.Property(e => e.Employeename)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("employeename");
            entity.Property(e => e.Passtype)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("passtype");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Stat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("stat");
            entity.Property(e => e.Tokengenerated)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tokengenerated");
            entity.Property(e => e.Usertype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usertype");
            entity.Property(e => e.Vendername)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendername");
            entity.Property(e => e.Vendorid).HasColumnName("vendorid");
            entity.Property(e => e.Workarea).HasColumnName("workarea");
            entity.Property(e => e.Workorderid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("workorderid");
        });

        modelBuilder.Entity<Supremafptemplate>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("supremafptemplates");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cardno");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Downloaddate)
                .HasColumnType("datetime")
                .HasColumnName("downloaddate");
            entity.Property(e => e.Findata)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("findata");
            entity.Property(e => e.Finid).HasColumnName("finid");
            entity.Property(e => e.Finlen).HasColumnName("finlen");
            entity.Property(e => e.Finno).HasColumnName("finno");
            entity.Property(e => e.Fintype).HasColumnName("fintype");
            entity.Property(e => e.Rno).HasColumnName("rno");
        });

        modelBuilder.Entity<TalukaMaster>(entity =>
        {
            entity.HasKey(e => e.TalId);

            entity.ToTable("TalukaMaster");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblVendor>(entity =>
        {
            entity.ToTable("tbl_vendor");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Addedby)
                .HasMaxLength(50)
                .HasColumnName("addedby");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
        });

        modelBuilder.Entity<TblWorkorder>(entity =>
        {
            entity.ToTable("tbl_workorder");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Addedby).HasColumnName("addedby");
            entity.Property(e => e.Closepodate)
                .HasColumnType("datetime")
                .HasColumnName("closepodate");
            entity.Property(e => e.Closepoflag).HasColumnName("closepoflag");
            entity.Property(e => e.Eicid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("eicid");
            entity.Property(e => e.Empid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("empid");
            entity.Property(e => e.Filepath)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("filepath");
            entity.Property(e => e.FromDate).HasColumnName("from_date");
            entity.Property(e => e.Maxmanpower).HasColumnName("maxmanpower");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.ToDate).HasColumnName("to_date");
            entity.Property(e => e.Validityofll).HasColumnName("validityofll");
            entity.Property(e => e.Validityofwcp).HasColumnName("validityofwcp");
            entity.Property(e => e.Vendorid).HasColumnName("vendorid");
            entity.Property(e => e.Workorderno)
                .HasMaxLength(50)
                .HasColumnName("workorderno");
        });

        modelBuilder.Entity<Teammaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("teammaster");

            entity.Property(e => e.Details)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Teamname)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("teamname");
            entity.Property(e => e.Tnotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("tnotes");
            entity.Property(e => e.Tnotes1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("tnotes1");
            entity.Property(e => e.Tnotes2)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("tnotes2");
        });

        modelBuilder.Entity<TempapprovedOt>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("tempapprovedOT$PrimaryKey");

            entity.ToTable("tempapprovedOT");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Approveflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("approveflag");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Lineid).HasColumnName("lineid");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Othrs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("othrs");
            entity.Property(e => e.Punchtimes)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("punchtimes");
            entity.Property(e => e.Teamid).HasColumnName("teamid");
            entity.Property(e => e.Yrs).HasColumnName("yrs");
        });

        modelBuilder.Entity<Tempemployee>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tempemployee");

            entity.Property(e => e.Accessgroups)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("accessgroups");
            entity.Property(e => e.Accesstype)
                .HasDefaultValue(0)
                .HasColumnName("accesstype");
            entity.Property(e => e.Autoshift)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("autoshift");
            entity.Property(e => e.Busid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("busid");
            entity.Property(e => e.Caddress)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CAddress");
            entity.Property(e => e.Cardno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cardno");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Compid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.DeptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dob)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DOB");
            entity.Property(e => e.Doj)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DOJ");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Empno).HasColumnName("empno");
            entity.Property(e => e.Emptype)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("emptype");
            entity.Property(e => e.Extendedyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("extendedyn");
            entity.Property(e => e.Facilitycode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("facilitycode");
            entity.Property(e => e.FatherName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FName");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Ldate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LDate");
            entity.Property(e => e.Lname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LName");
            entity.Property(e => e.Locationid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Paddress)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PAddress");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pbexemptyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("pbexemptyn");
            entity.Property(e => e.Phno)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Photo)
                .HasColumnType("image")
                .HasColumnName("photo");
            entity.Property(e => e.Picture)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Pin)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("pin");
            entity.Property(e => e.Pincmdsyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("pincmdsyn");
            entity.Property(e => e.Pincode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Pinexemptyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("pinexemptyn");
            entity.Property(e => e.Qualification)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReasonL)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Roasterpattern)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("roasterpattern");
            entity.Property(e => e.Section)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("section");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Active")
                .HasColumnName("status");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("uploadedyn");
            entity.Property(e => e.Wkoff)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("wkoff");
            entity.Property(e => e.Woff)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Tempimage>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__tempimages__20C1E124");

            entity.ToTable("tempimages");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Image)
                .HasColumnType("image")
                .HasColumnName("image");
            entity.Property(e => e.Names)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("names");
            entity.Property(e => e.Tmpsize)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("0")
                .HasColumnName("tmpsize");
        });

        modelBuilder.Entity<Tempscandoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tempscandoc");

            entity.Property(e => e.Docimage)
                .HasColumnType("image")
                .HasColumnName("docimage");
            entity.Property(e => e.Docname)
                .HasMaxLength(50)
                .HasColumnName("docname");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<Timesheet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("timesheet");

            entity.Property(e => e.Activityid).HasColumnName("activityid");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Day).HasColumnName("day");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Hrs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("hrs");
            entity.Property(e => e.Projectnameid).HasColumnName("projectnameid");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Tsdetails)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("tsdetails");
            entity.Property(e => e.Tsnotes1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("tsnotes1");
            entity.Property(e => e.Tsnotes2)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("tsnotes2");
            entity.Property(e => e.Tsnotes3)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("tsnotes3");
            entity.Property(e => e.Weekno).HasColumnName("weekno");
        });

        modelBuilder.Entity<Tmplogtbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmplogtbl");

            entity.Property(e => e.Category)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("category");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Empid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empid");
            entity.Property(e => e.Employeename)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("employeename");
            entity.Property(e => e.Passtype)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("passtype");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Stat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("stat");
            entity.Property(e => e.Tokengenerated)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tokengenerated");
            entity.Property(e => e.Usertype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usertype");
            entity.Property(e => e.Vendername)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendername");
            entity.Property(e => e.Vendorid).HasColumnName("vendorid");
            entity.Property(e => e.Workarea).HasColumnName("workarea");
            entity.Property(e => e.Workorderid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("workorderid");
        });

        modelBuilder.Entity<Tmplogtbl2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmplogtbl2");

            entity.Property(e => e.Category)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("category");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Empid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empid");
            entity.Property(e => e.Employeename)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("employeename");
            entity.Property(e => e.Passtype)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("passtype");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Stat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("stat");
            entity.Property(e => e.Tokengenerated)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tokengenerated");
            entity.Property(e => e.Usertype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usertype");
            entity.Property(e => e.Vendername)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vendername");
            entity.Property(e => e.Vendorid).HasColumnName("vendorid");
            entity.Property(e => e.Workarea).HasColumnName("workarea");
            entity.Property(e => e.Workorderid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("workorderid");
        });

        modelBuilder.Entity<Tokendetail>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__tokendet__36B150C685FC22AA");

            entity.ToTable("tokendetails");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Clientid)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("clientid");
            entity.Property(e => e.Flag)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<TourEntry>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("TourEntry$PrimaryKey");

            entity.ToTable("TourEntry");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.ApproveDate).HasColumnType("datetime");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Approvers)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Compoffdate)
                .HasColumnType("datetime")
                .HasColumnName("compoffdate");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.IsNotify)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("isNotify");
            entity.Property(e => e.Modes)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("modes");
            entity.Property(e => e.Mons).HasColumnName("mons");
            entity.Property(e => e.Notes)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Place)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("place");
            entity.Property(e => e.Remark)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.Requestid).HasColumnName("requestid");
            entity.Property(e => e.Smstext)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("smstext");
            entity.Property(e => e.ToApprove)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Workhrs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("workhrs");
            entity.Property(e => e.Years).HasColumnName("years");
        });

        modelBuilder.Entity<TourEntryRequest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TourEntryRequest");

            entity.Property(e => e.Dates)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dates");
            entity.Property(e => e.Details)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Mode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mode");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("transactions");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<TransactionConfiguration>(entity =>
        {
            entity.ToTable("TransactionConfiguration");

            entity.Property(e => e.Param)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Value)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Transactions012022>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C60064FC88");

            entity.ToTable("transactions_012022");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_012022")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions012023>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C6B8BD5EE2");

            entity.ToTable("transactions_012023");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_012023")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions012024>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C63E12328B");

            entity.ToTable("transactions_012024");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_012024")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions022022>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C635BAEB81");

            entity.ToTable("transactions_022022");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_022022")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions022023>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C6AA20AF58");

            entity.ToTable("transactions_022023");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_022023")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions022024>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C614B57529");

            entity.ToTable("transactions_022024");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_022024")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions032022>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C6DF1AACF8");

            entity.ToTable("transactions_032022");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_032022")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions032023>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C6AA5F7EC4");

            entity.ToTable("transactions_032023");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_032023")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions042022>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C6FF33B140");

            entity.ToTable("transactions_042022");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_042022")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions042023>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C6B91DFBC7");

            entity.ToTable("transactions_042023");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_042023")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions052022>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C6FC9C7D44");

            entity.ToTable("transactions_052022");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_052022")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions052023>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C6E9CA5C27");

            entity.ToTable("transactions_052023");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_052023")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions062021>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C67B3923E0");

            entity.ToTable("transactions_062021");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_062021")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions062022>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C673567311");

            entity.ToTable("transactions_062022");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_062022")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions062023>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C659CB52BF");

            entity.ToTable("transactions_062023");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_062023")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions072021>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C67642CAA6");

            entity.ToTable("transactions_072021");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_072021")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions072022>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C601625F90");

            entity.ToTable("transactions_072022");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_072022")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions072023>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C6B37A31EF");

            entity.ToTable("transactions_072023");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_072023")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions082021>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C60BE68F8A");

            entity.ToTable("transactions_082021");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_082021")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions082022>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C608334EF8");

            entity.ToTable("transactions_082022");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_082022")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions082023>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C6278867D8");

            entity.ToTable("transactions_082023");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_082023")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions092021>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C61F0BCE24");

            entity.ToTable("transactions_092021");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_092021")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions092022>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C64A3D9971");

            entity.ToTable("transactions_092022");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_092022")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions092023>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C67494D14A");

            entity.ToTable("transactions_092023");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_092023")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions102021>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C6B80D3A56");

            entity.ToTable("transactions_102021");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_102021")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions102022>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C6F370761D");

            entity.ToTable("transactions_102022");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_102022")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions102023>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C6B4B9FBE1");

            entity.ToTable("transactions_102023");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_102023")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions112021>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C6FAF21AE9");

            entity.ToTable("transactions_112021");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_112021")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions112022>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C6AFD83312");

            entity.ToTable("transactions_112022");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_112022")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions112023>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C611BFC155");

            entity.ToTable("transactions_112023");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_112023")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions122021>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C6554A0371");

            entity.ToTable("transactions_122021");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_122021")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions122022>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C6F5CD3D45");

            entity.ToTable("transactions_122022");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_122022")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<Transactions122023>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__transact__36B150C68E2DB56D");

            entity.ToTable("transactions_122023");

            entity.HasIndex(e => new { e.Empid, e.Dates, e.Times, e.Rid, e.Eventcode }, "IX_transactions_122023")
                .IsUnique()
                .IsDescending(false, true, true, false, false);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardorunique)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardorunique");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Copyflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("copyflag");
            entity.Property(e => e.Ctfield1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield1");
            entity.Property(e => e.Ctfield2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield2");
            entity.Property(e => e.Ctfield3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield3");
            entity.Property(e => e.Ctfield4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield4");
            entity.Property(e => e.Ctfield5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ctfield5");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Downloaded)
                .HasColumnType("datetime")
                .HasColumnName("downloaded");
            entity.Property(e => e.Empid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("empid");
            entity.Property(e => e.Eventcode).HasColumnName("eventcode");
            entity.Property(e => e.Ignoreflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignoreflag");
            entity.Property(e => e.Inout).HasColumnName("inout");
            entity.Property(e => e.Laptopid).HasColumnName("laptopid");
            entity.Property(e => e.Msgflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("msgflag");
            entity.Property(e => e.Msgid).HasColumnName("msgid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasColumnName("snapshot");
            entity.Property(e => e.Taskcode).HasColumnName("taskcode");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Tphotopath)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tphotopath");
            entity.Property(e => e.TrFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tr_flag");
            entity.Property(e => e.Transferflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transferflag");
            entity.Property(e => e.Transmsg)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("transmsg");
            entity.Property(e => e.Transtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("transtype");
            entity.Property(e => e.Uniqs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uniqs");
            entity.Property(e => e.Updated).HasColumnName("updated");
            entity.Property(e => e.Vehicleid).HasColumnName("vehicleid");
        });

        modelBuilder.Entity<TransportModeMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TransportModeMaster");

            entity.Property(e => e.Details)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Mode)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Note)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Srno).HasColumnName("srno");
        });

        modelBuilder.Entity<UserRight>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Formid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("formid");
            entity.Property(e => e.Formvalue)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("formvalue");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Userid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("userid");
        });

        modelBuilder.Entity<UserShiftmaster>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("user_shiftmaster$PrimaryKey");

            entity.ToTable("user_shiftmaster");

            entity.Property(e => e.Srno)
                .ValueGeneratedNever()
                .HasColumnName("srno");
            entity.Property(e => e.Months)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("months");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Years)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("years");
            entity.Property(e => e._1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("1");
            entity.Property(e => e._10)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("10");
            entity.Property(e => e._11)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("11");
            entity.Property(e => e._12)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("12");
            entity.Property(e => e._13)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("13");
            entity.Property(e => e._14)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("14");
            entity.Property(e => e._15)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("15");
            entity.Property(e => e._16)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("16");
            entity.Property(e => e._17)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("17");
            entity.Property(e => e._18)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("18");
            entity.Property(e => e._19)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("19");
            entity.Property(e => e._2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("2");
            entity.Property(e => e._20)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("20");
            entity.Property(e => e._21)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("21");
            entity.Property(e => e._22)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("22");
            entity.Property(e => e._23)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("23");
            entity.Property(e => e._24)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("24");
            entity.Property(e => e._25)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("25");
            entity.Property(e => e._26)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("26");
            entity.Property(e => e._27)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("27");
            entity.Property(e => e._28)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("28");
            entity.Property(e => e._29)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("29");
            entity.Property(e => e._3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("3");
            entity.Property(e => e._30)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("30");
            entity.Property(e => e._31)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("31");
            entity.Property(e => e._4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("4");
            entity.Property(e => e._5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("5");
            entity.Property(e => e._6)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("6");
            entity.Property(e => e._7)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("7");
            entity.Property(e => e._8)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("8");
            entity.Property(e => e._9)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("9");
        });

        modelBuilder.Entity<UserTimelog>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("user_timelog$PrimaryKey");

            entity.ToTable("user_timelog");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Days)
                .HasDefaultValue(0)
                .HasColumnName("days");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Hrs)
                .HasDefaultValue(0)
                .HasColumnName("hrs");
            entity.Property(e => e.Mins)
                .HasDefaultValue(0)
                .HasColumnName("mins");
            entity.Property(e => e.Mons)
                .HasDefaultValue(0)
                .HasColumnName("mons");
            entity.Property(e => e.Times)
                .HasColumnType("datetime")
                .HasColumnName("times");
            entity.Property(e => e.Type)
                .HasDefaultValue(0)
                .HasColumnName("type");
            entity.Property(e => e.Userid)
                .HasDefaultValue(0)
                .HasColumnName("userid");
            entity.Property(e => e.Verifymode)
                .HasDefaultValue(0)
                .HasColumnName("verifymode");
            entity.Property(e => e.Yrs)
                .HasDefaultValue(0)
                .HasColumnName("yrs");
        });

        modelBuilder.Entity<Useraccess>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("useraccess");

            entity.Property(e => e.Istrue)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("istrue");
        });

        modelBuilder.Entity<Vehicletype>(entity =>
        {
            entity.HasKey(e => e.SrNo).HasName("PK__vehicletype__108B795B");

            entity.ToTable("vehicletype");

            entity.Property(e => e.Details)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Vehicletype1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("vehicletype");
        });

        modelBuilder.Entity<VendorMenuMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VendorMenuMaster");

            entity.Property(e => e.Deleteflag)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("deleteflag");
            entity.Property(e => e.Fromtime)
                .HasColumnType("datetime")
                .HasColumnName("fromtime");
            entity.Property(e => e.Image)
                .HasColumnType("image")
                .HasColumnName("image");
            entity.Property(e => e.Menuid).HasColumnName("menuid");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Rate).HasColumnName("rate");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Timeflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("timeflag");
            entity.Property(e => e.Totime)
                .HasColumnType("datetime")
                .HasColumnName("totime");
            entity.Property(e => e.Type)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.Venderid).HasColumnName("venderid");
        });

        modelBuilder.Entity<Versionmaster>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("versionmaster$PrimaryKey");

            entity.ToTable("versionmaster");

            entity.Property(e => e.DbVersion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Footertext)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("footertext");
            entity.Property(e => e.Releasedate)
                .HasColumnType("datetime")
                .HasColumnName("releasedate");
            entity.Property(e => e.Swversion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SWversion");
        });

        modelBuilder.Entity<VillageMaster>(entity =>
        {
            entity.HasKey(e => e.SrNo).HasName("VillageMaster$PrimaryKey");

            entity.ToTable("VillageMaster");

            entity.Property(e => e.Details)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Districtid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("districtid");
            entity.Property(e => e.Flag)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Section)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("section");
            entity.Property(e => e.Stateid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("stateid");
            entity.Property(e => e.Usedflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usedflag");
            entity.Property(e => e.Villagename)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("villagename");
        });

        modelBuilder.Entity<Visitarea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("visitarea");

            entity.Property(e => e.Details)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<Visitor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("visitor");

            entity.Property(e => e.Caddress)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CAddress");
            entity.Property(e => e.Cardno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cardno");
            entity.Property(e => e.Compid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Host)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("host");
            entity.Property(e => e.Intime)
                .HasColumnType("datetime")
                .HasColumnName("intime");
            entity.Property(e => e.Locationid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Outtime)
                .HasColumnType("datetime")
                .HasColumnName("outtime");
            entity.Property(e => e.Phno)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Vid)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("vid");
            entity.Property(e => e.VisitorCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("visitorCode");
            entity.Property(e => e.Visitorname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("visitorname");
        });

        modelBuilder.Entity<VisitorCard>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Accessgroups)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("accessgroups");
            entity.Property(e => e.Accesstype)
                .HasDefaultValue(0)
                .HasColumnName("accesstype");
            entity.Property(e => e.Cardno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cardno");
            entity.Property(e => e.Compid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("compid");
            entity.Property(e => e.Extendedyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("extendedyn");
            entity.Property(e => e.Facilitycode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("facilitycode");
            entity.Property(e => e.Locationid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("locationid");
            entity.Property(e => e.Pbexemptyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("pbexemptyn");
            entity.Property(e => e.Pin)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("pin");
            entity.Property(e => e.Pincmdsyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("pincmdsyn");
            entity.Property(e => e.Pinexemptyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("pinexemptyn");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("uploadedyn");
        });

        modelBuilder.Entity<VisitorCardUpload>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("VisitorCardUpload");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardno).HasColumnName("cardno");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Uploadedyn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uploadedyn");
        });

        modelBuilder.Entity<VisitorCardnoEnrollno>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("VisitorCardnoEnrollno");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Cardno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardno");
            entity.Property(e => e.Enrollno).HasColumnName("enrollno");
        });

        modelBuilder.Entity<Visitorentry>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("visitorentry");

            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.Carrylaptop)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("carrylaptop");
            entity.Property(e => e.Carryother)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("carryother");
            entity.Property(e => e.Carryotherdetails)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("carryotherdetails");
            entity.Property(e => e.Carrytoolkit)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("carrytoolkit");
            entity.Property(e => e.Company)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("company");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Depolaptop)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("depolaptop");
            entity.Property(e => e.Depomobile)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("depomobile");
            entity.Property(e => e.Depoother)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("depoother");
            entity.Property(e => e.Depootherdetails)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("depootherdetails");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Intime)
                .HasDefaultValue(new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime")
                .HasColumnName("intime");
            entity.Property(e => e.Mobileno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("mobileno");
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nationality");
            entity.Property(e => e.Notes)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Phno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phno");
            entity.Property(e => e.Purpose)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("purpose");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Vehicle)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("vehicle");
            entity.Property(e => e.Vehicleno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vehicleno");
            entity.Property(e => e.Vehicletype)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vehicletype");
            entity.Property(e => e.Viscount).HasColumnName("viscount");
            entity.Property(e => e.Visitorid)
                .ValueGeneratedOnAdd()
                .HasColumnName("visitorid");
            entity.Property(e => e.Visitorname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("visitorname");
            entity.Property(e => e.Visitortype)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("visitortype");
        });

        modelBuilder.Entity<Visitormaster>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__visitormaster__07020F21");

            entity.ToTable("visitormaster");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Addedby)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("addedby");
            entity.Property(e => e.Addr)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("addr");
            entity.Property(e => e.Buildingno)
                .IsUnicode(false)
                .HasColumnName("buildingno");
            entity.Property(e => e.Cardformat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardformat");
            entity.Property(e => e.Cardno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardno");
            entity.Property(e => e.Compname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("compname");
            entity.Property(e => e.Districtid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("districtid");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Enrollno).HasColumnName("enrollno");
            entity.Property(e => e.Flag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Floorno)
                .IsUnicode(false)
                .HasColumnName("floorno");
            entity.Property(e => e.Idprooftype)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("idprooftype");
            entity.Property(e => e.Mobno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("mobno");
            entity.Property(e => e.Nationality)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nationality");
            entity.Property(e => e.Noformat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("noformat");
            entity.Property(e => e.Note)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("note");
            entity.Property(e => e.Phno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phno");
            entity.Property(e => e.Photopath)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("photopath");
            entity.Property(e => e.Stateid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("stateid");
            entity.Property(e => e.Svalidfrom).HasColumnName("svalidfrom");
            entity.Property(e => e.Svalidto).HasColumnName("svalidto");
            entity.Property(e => e.Villageid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("villageid");
            entity.Property(e => e.Visitarea)
                .IsUnicode(false)
                .HasColumnName("visitarea");
            entity.Property(e => e.VisitorIdproofNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("VisitorIDproofNo");
            entity.Property(e => e.Visitorname)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("visitorname");
            entity.Property(e => e.Workarea)
                .IsUnicode(false)
                .HasColumnName("workarea");
        });

        modelBuilder.Entity<Visitortype>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("visitortype");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Visitortype1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("visitortype");
        });

        modelBuilder.Entity<Vmscompany>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("VMSCompanies");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Compids)
                .IsUnicode(false)
                .HasColumnName("compids");
        });

        modelBuilder.Entity<Watchlist>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("PK__watchlist__03317E3D");

            entity.ToTable("watchlist");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Addedby)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("addedby");
            entity.Property(e => e.Empid)
                .HasDefaultValueSql("('0')")
                .HasColumnName("empid");
            entity.Property(e => e.Note)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("note");
            entity.Property(e => e.Visitorid).HasColumnName("visitorid");
            entity.Property(e => e.Visname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("visname");
        });

        modelBuilder.Entity<Weeklyoff>(entity =>
        {
            entity.HasKey(e => e.SrNo).HasName("weeklyoff$PrimaryKey");

            entity.ToTable("weeklyoff");

            entity.Property(e => e.Contflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contflag");
            entity.Property(e => e.Dates)
                .HasColumnType("datetime")
                .HasColumnName("dates");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Empid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empid");
            entity.Property(e => e.Flag)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("flag");
            entity.Property(e => e.Todates)
                .HasColumnType("datetime")
                .HasColumnName("todates");
            entity.Property(e => e.W1fh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("w1fh");
            entity.Property(e => e.W1sh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("w1sh");
            entity.Property(e => e.W2fh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("w2fh");
            entity.Property(e => e.W2sh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("w2sh");
            entity.Property(e => e.W3fh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("w3fh");
            entity.Property(e => e.W3sh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("w3sh");
            entity.Property(e => e.W4fh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("w4fh");
            entity.Property(e => e.W4sh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("w4sh");
            entity.Property(e => e.W5fh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("w5fh");
            entity.Property(e => e.W5sh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("w5sh");
            entity.Property(e => e.Wkoffid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("wkoffid");
        });

        modelBuilder.Entity<Weeklypattern>(entity =>
        {
            entity.HasKey(e => e.Srno).HasName("weeklypattern$PrimaryKey");

            entity.ToTable("weeklypattern");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Friday)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("friday");
            entity.Property(e => e.Monday)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("monday");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pname");
            entity.Property(e => e.Saturday)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("saturday");
            entity.Property(e => e.Sunday)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sunday");
            entity.Property(e => e.Thursday)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("thursday");
            entity.Property(e => e.Tuesday)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tuesday");
            entity.Property(e => e.Wednesday)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("wednesday");
        });

        modelBuilder.Entity<Weekmaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("weekmaster");

            entity.Property(e => e.Details)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Fromdate)
                .HasColumnType("datetime")
                .HasColumnName("fromdate");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
            entity.Property(e => e.Weekno).HasColumnName("weekno");
            entity.Property(e => e.Wnotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("wnotes");
            entity.Property(e => e.Wnotes1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("wnotes1");
            entity.Property(e => e.Wnotes2)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("wnotes2");
        });

        modelBuilder.Entity<Workarea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("workarea");

            entity.Property(e => e.Details)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("srno");
        });

        modelBuilder.Entity<WorkareaProject>(entity =>
        {
            entity.HasKey(e => e.Srno);

            entity.ToTable("workarea_project");

            entity.Property(e => e.Srno).HasColumnName("srno");
            entity.Property(e => e.Details)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("details");
        });

        modelBuilder.Entity<Zone>(entity =>
        {
            entity.ToTable("zone");

            entity.Property(e => e.Zoneid).HasColumnName("zoneid");
            entity.Property(e => e.Zdetails)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("zdetails");
            entity.Property(e => e.Zno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("zno");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
