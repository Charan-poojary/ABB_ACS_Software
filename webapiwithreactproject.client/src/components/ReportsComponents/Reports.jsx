import React, { useState, useEffect } from 'react';
import { Link } from 'react-router-dom';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faCaretRight } from '@fortawesome/free-solid-svg-icons';
import EmployeeAccessMaster from './EmployeeAccessMaster';
import AccessGranted from './AccessGranted';
import AccessDenied from './AccessDenied';
import AccessTransactions from './AccessTransactions';
import ActiveExpiredInactiveCards from './ActiveExpiredInactiveCards';
import AuditLog from './AuditLog';
import CompanyWiseReport from './CompanyWiseReport';
import CategoryWiseReport from './CategoryWiseReport';
import ContractorWiseReport from './ContractorWiseReport';
import CurrentEmployeesInsidePlant from './CurrentEmployeesInsidePlant';
import DateFromToReport from './DateFromToReport';
import DepartmentWiseReport from './DepartmentWiseReport';
import DateOfBirthAgeReport from './DateOfBirthAgeReport';
import DailyManpowerFPLP from './DailyManpowerFPLP';
import EmployeeBlacklistReport from './EmployeeBlacklistReport';
import FirstInLastOutReport from './FirstInLastOutReport';
import GateWiseReport from './GateWiseReport';
import ManPowerReport from './ManPowerReport';
import MonthlyManpowerReport from './MonthlyManpowerReport';
import PinBypassReport from './PinBypassReport';



const Reports = ({ defaultLink }) => {

    useEffect(() => {
        setSelectedLink(defaultLink);
    }, [defaultLink]);

    const [selectedLink, setSelectedLink] = useState(null);

    const handleLinkClick = (link) => {

        setSelectedLink(link);
    };

    return (
        <div className="container-fluid bg-light py-4">
            <div className="row justify-content-center">
                <div className="col-lg-8">
                    <div className="card p-4 ">
                        <div className="row">
                            <div className="col-md-4 bg-light">
                                <h2 className="mb-4">Reports</h2>
                                <div className="sidebar">
                                    <ul className="nav flex-column">
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link1')}>
                                                <FontAwesomeIcon icon={faCaretRight}/>
                                                &nbsp;
                                                Employee Access Master
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link2')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Access Granted
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link3')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Access Denied
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link4')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Access Transactions
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link5')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Active/Expired/Inactive Cards in the system
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link6')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Audit Log
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link7')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Company wise Report
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link8')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Category wise Report
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link9')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Contractore manpower Report
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link10')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Current Employees Inside Plant
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link11')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Date From To Report
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link12')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Department wise Report
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link13')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Date of Birth/AGE Report
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link14')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Daily Manpower Report(First Punch and Last Punch)
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link15')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Employee Blacklist
                                            </Link>
                                        </li>
                                        <li className="nav-item dropdown">
                                            <Link className="nav-link dropdown-toggle" to="#" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                ERP Daily
                                            </Link>
                                            <ul className="dropdown-menu" aria-labelledby="navbarDropdown">
                                                <li><Link className="dropdown-item" to="/home">Settings</Link></li>
                                                <li><Link className="dropdown-item" to="/home" >Generate Reports</Link></li>
                                            </ul>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link16')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                First In Last Out
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link17')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Gate Wise Report
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link18')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                ManPower Report
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link19')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Monthly Manpower Report
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link20')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Pin Bypass
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link21')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Picture Transactions Report
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link22')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                State Report
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link23')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Vehicle Access Event
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link24')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Vehicle Master Report
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link25')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Valid Gate Pass Record Report 
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link26')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Door Access Report
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link27')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Driver Helper
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link28')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Driver Helper Unregisteration
                                            </Link>
                                        </li>
                                    </ul>
                                </div>
                            </div>

                            <div className="col-md-8">
                                <div className="main-content">
                                    {selectedLink === 'link1' && <EmployeeAccessMaster />}
                                    {selectedLink === 'link2' && <AccessGranted />}
                                    {selectedLink === 'link3' && < AccessDenied />}
                                    {selectedLink === 'link4' && <AccessTransactions />}
                                    {selectedLink === 'link5' && <ActiveExpiredInactiveCards />}
                                    {selectedLink === 'link6' && <AuditLog />}
                                    {selectedLink === 'link7' && <CompanyWiseReport />}
                                    {selectedLink === 'link8' && <CategoryWiseReport />}
                                    {selectedLink === 'link9' && <ContractorWiseReport />}
                                    {selectedLink === 'link10' && <CurrentEmployeesInsidePlant />}
                                    {selectedLink === 'link11' && <DateFromToReport />}
                                    {selectedLink === 'link12' && <DepartmentWiseReport />}
                                    {selectedLink === 'link13' && <DateOfBirthAgeReport />}
                                    {selectedLink === 'link14' && <DailyManpowerFPLP />}
                                    {selectedLink === 'link15' && <EmployeeBlacklistReport />}
                                    {selectedLink === 'link16' && <FirstInLastOutReport />}
                                    {selectedLink === 'link17' && <GateWiseReport />}
                                    {selectedLink === 'link18' && <ManPowerReport />}
                                    {selectedLink === 'link19' && <MonthlyManpowerReport />}
                                    {selectedLink === 'link20' && <PinBypassReport />}
                                    {selectedLink === 'link21' && <EmployeeAccessMaster />}
                                    {selectedLink === 'link22' && <CompanyWiseReport />}
                                    {selectedLink === 'link23' && <AccessGranted />}
                                    {selectedLink === 'link24' && <ContractorWiseReport />}
                                    {selectedLink === 'link25' && <AccessDenied />}
                                    {selectedLink === 'link26' && <AuditLog />}
                                    {selectedLink === 'link27' && <CategoryWiseReport />}
                                    {selectedLink === 'link28' && <AccessTransactions />}
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    );
};

export default Reports;
