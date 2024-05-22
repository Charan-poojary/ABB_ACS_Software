import React, { useState } from 'react';
import { Link } from 'react-router-dom';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faCaretRight } from '@fortawesome/free-solid-svg-icons';
import CompanyMaster from './CompanyMaster';
import LocationMaster from './LocationMaster';
import DepartmentMaster from './DepartmentMaster';
import SubDepartmentMaster from './SubDepartmentMaster';
import DesignationMaster from './DesignationMaster';
import SectionMaster from './SectionMaster';
import StateMaster from './StateMaster';
import DistrictMaster from './DistrictMaster';
import VillageMaster from './VillageMaster';
import EmployeeCatagoryMaster from './EmployeeCatagoryMaster';
import EmployeeMaster from './Employee/EmployeeMaster';


const MasterData = () => {
    const [selectedLink, setSelectedLink] = useState();
    const handleLinkClick = (link) => {
        setSelectedLink(link);
    };

    return (
        <>

        <div className="container-fluid bg-light py-4">
            <div className="row justify-content-center">
                <div className="col-lg-8">
                    <div className="card p-4 ">
                        <div className="row">
                            <div className="col-md-4 bg-light">
                                <h2 className="mb-4">Master Data</h2>
                                <div className="sidebar">
                                    <ul className="nav flex-column">
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link1')}>
                                                <FontAwesomeIcon icon={faCaretRight}/>
                                                &nbsp;
                                                Company
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link2')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Location
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link3')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Department
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link4')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Sub-Department
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link5')}>

                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Designation
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link6')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Section
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link7')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                State
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link8')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                District
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link9')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Village
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link10')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Employee Category
                                            </Link>
                                        </li>
                                        <li className="nav-item dropdown">
                                            <Link className="nav-link dropdown-toggle" to="#" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Card Contrller Data
                                            </Link>
                                            <ul className="dropdown-menu" aria-labelledby="navbarDropdown">
                                                <li><Link className="dropdown-item" to="/home" onClick={() => handleLinkClick('link11')}>
                                                    <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;Controller-Reader</Link></li>
                                                <li><Link className="dropdown-item" to="/home" onClick={() => handleLinkClick('link12')}><FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;Card Formats</Link></li>
                                                <li><Link className="dropdown-item" to="/home" onClick={() => handleLinkClick('link13')}><FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;Card Inventory</Link></li>
                                                <li><Link className="dropdown-item" to="/home" onClick={() => handleLinkClick('link14')}><FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;Import Cards</Link></li>
                                                <li><Link className="dropdown-item" to="/home" onClick={() => handleLinkClick('link15')}><FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;Time Zone</Link></li>
                                                <li><Link className="dropdown-item" to="/home" onClick={() => handleLinkClick('link16')}><FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;Access Time</Link></li>
                                                <li><Link className="dropdown-item" to="/home" onClick={() => handleLinkClick('link17')}><FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;Holiday Master</Link></li>
                                                <li><Link className="dropdown-item" to="/home" onClick={() => handleLinkClick('link18')}><FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;Holiday Group</Link></li>
                                                <li><Link className="dropdown-item" to="/home" onClick={() => handleLinkClick('link19')}><FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;Access Group</Link></li>
                                                <li><Link className="dropdown-item" to="/home" onClick={() => handleLinkClick('link20')}><FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;Controller Group</Link></li>
                                                <li><Link className="dropdown-item" to="/home" onClick={() => handleLinkClick('link21')}><FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;Template Transfer</Link></li>
                                                <li><Link className="dropdown-item" to="/home" onClick={() => handleLinkClick('link22')}><FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;Driver Template Transfer</Link></li>
                                                <li><Link className="dropdown-item" to="/home" onClick={() => handleLinkClick('link23')}><FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;Helper Template Transfer</Link></li>
                                            </ul>
                                        </li>
                                        <li className="nav-item dropdown">
                                            <Link className="nav-link dropdown-toggle" to="#" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Employee
                                            </Link>
                                            <ul className="dropdown-menu" aria-labelledby="navbarDropdown">
                                                <li><Link className="dropdown-item" to="/home" onClick={() => handleLinkClick('link24')}>
                                                    <FontAwesomeIcon icon={faCaretRight} />
                                                    &nbsp;Employee Master</Link></li>
                                                <li><Link className="dropdown-item" to="/home" onClick={() => handleLinkClick('link25')}><FontAwesomeIcon icon={faCaretRight} />
                                                    &nbsp;Employee Classification</Link></li>
                                                <li><Link className="dropdown-item" to="/home" onClick={() => handleLinkClick('link26')}><FontAwesomeIcon icon={faCaretRight} />
                                                    &nbsp;Import/Export Employees</Link></li>
                                                <li><Link className="dropdown-item" to="/home" onClick={() => handleLinkClick('link27')}><FontAwesomeIcon icon={faCaretRight} />
                                                    &nbsp;Employee Registeration</Link></li>
                                                <li><Link className="dropdown-item" to="/home" onClick={() => handleLinkClick('link28')}><FontAwesomeIcon icon={faCaretRight} />
                                                    &nbsp;Import Virdi Templates</Link></li>
                                                <li><Link className="dropdown-item" to="/home" onClick={() => handleLinkClick('link29')}><FontAwesomeIcon icon={faCaretRight} />
                                                    &nbsp;Helper Master</Link></li>
                                                <li><Link className="dropdown-item" to="/home" onClick={() => handleLinkClick('link30')}><FontAwesomeIcon icon={faCaretRight} />
                                                    &nbsp;Driver Master</Link></li>
                                            </ul>
                                        </li>
                                        <li className="nav-item dropdown">
                                            <Link className="nav-link dropdown-toggle" to="#" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Vehicle
                                            </Link>
                                            <ul className="dropdown-menu" aria-labelledby="navbarDropdown">
                                                <li><Link className="dropdown-item" to="/home" onClick={() => handleLinkClick('link31')}><FontAwesomeIcon icon={faCaretRight} />
                                                    &nbsp;Vehicles</Link></li>
                                                <li><Link className="dropdown-item" to="/home" onClick={() => handleLinkClick('link32')}><FontAwesomeIcon icon={faCaretRight} />
                                                    &nbsp;Register Vehicles</Link></li>
                                                <li><Link className="dropdown-item" to="/home" onClick={() => handleLinkClick('link33')}><FontAwesomeIcon icon={faCaretRight} />
                                                    &nbsp;Unregister Vehicles</Link></li>
                                            </ul>
                                        </li>
                                    </ul>
                                </div>
                            </div>

                            <div className="col-md-8">
                                <div className="main-content">
                                        {selectedLink === 'link1' && <CompanyMaster />}
                                    {selectedLink === 'link2' && <LocationMaster />}
                                    {selectedLink === 'link3' && <DepartmentMaster />}
                                    {selectedLink === 'link4' && <SubDepartmentMaster />}
                                    {selectedLink === 'link5' && <DesignationMaster />}
                                    {selectedLink === 'link6' && <SectionMaster />}
                                    {selectedLink === 'link7' && <StateMaster />}
                                    {selectedLink === 'link8' && <DistrictMaster />}
                                    {selectedLink === 'link9' && <VillageMaster />}
                                    {selectedLink === 'link10' && <EmployeeCatagoryMaster />}
                                    {selectedLink === 'link11' && <CompanyMaster />}
                                    {selectedLink === 'link12' && <LocationMaster />}
                                    {selectedLink === 'link13' && <DepartmentMaster />}
                                    {selectedLink === 'link14' && <SubDepartmentMaster />}
                                    {selectedLink === 'link15' && <DesignationMaster />}
                                    {selectedLink === 'link16' && <SectionMaster />}
                                    {selectedLink === 'link17' && <StateMaster />}
                                    {selectedLink === 'link18' && <DistrictMaster />}
                                    {selectedLink === 'link19' && <VillageMaster />}
                                    {selectedLink === 'link20' && <EmployeeCatagoryMaster />}
                                    {selectedLink === 'link21' && <DistrictMaster />}
                                    {selectedLink === 'link22' && <VillageMaster />}
                                    {selectedLink === 'link23' && <EmployeeCatagoryMaster />}
                                    {selectedLink === 'link24' && <EmployeeMaster />}
                                    {selectedLink === 'link25' && <DistrictMaster />}
                                    {selectedLink === 'link26' && <VillageMaster />}
                                    {selectedLink === 'link27' && <EmployeeCatagoryMaster />}
                                    {selectedLink === 'link28' && <DistrictMaster />}
                                    {selectedLink === 'link29' && <VillageMaster />}
                                    {selectedLink === 'link30' && <EmployeeCatagoryMaster />}
                                    {selectedLink === 'link31' && <DistrictMaster />}
                                    {selectedLink === 'link32' && <VillageMaster />}
                                    {selectedLink === 'link33' && <EmployeeCatagoryMaster />}

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            </div>
        </>
    );
};

export default MasterData;