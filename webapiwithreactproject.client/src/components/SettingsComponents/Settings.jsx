import React, { useState, useEffect } from 'react';
import { Link } from 'react-router-dom';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faCaretRight } from '@fortawesome/free-solid-svg-icons';
import PendingActivities from './PendingActivities';
import RestoreDeviceLogs from './RestoreDeviceLogs';
import FingerQualitySetting from './FingerQualitySetting';
import SuperAdmin from './UserManagement/SuperAdmin';
import SectionAdmin from './UserManagement/SectionAdmin';
import Employee from './UserManagement/Employee';
import HierarchyAdmin from './UserManagement/HierarchyAdmin';
import ImportLicenseFile from './ImportLicenseFile';



const Settings = ({ defaultLink }) => {

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
                                <h2 className="mb-4">Settings</h2>
                                <div className="sidebar">
                                    <ul className="nav flex-column">
                                        <li className="nav-item dropdown">
                                            <Link className="nav-link side-navi dropdown-toggle" to="#" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                User Management
                                            </Link>
                                            <ul className="dropdown-menu" aria-labelledby="navbarDropdown">
                                                <li><Link className="dropdown-item side-navi" to="/home" onClick={() => handleLinkClick('link1')}><FontAwesomeIcon icon={faCaretRight} />&nbsp;Super Admin</Link></li>
                                                <li><Link className="dropdown-item side-navi" to="/home" onClick={() => handleLinkClick('link2')}><FontAwesomeIcon icon={faCaretRight} />&nbsp;Section Admin</Link></li>
                                                <li><Link className="dropdown-item side-navi" to="/home" onClick={() => handleLinkClick('link3')}><FontAwesomeIcon icon={faCaretRight} />&nbsp;Employee</Link></li>
                                                <li><Link className="dropdown-item side-navi" to="/home" onClick={() => handleLinkClick('link4')}><FontAwesomeIcon icon={faCaretRight} />&nbsp;Hierarchy Admin</Link></li>
                                            </ul>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link side-navi" to="#" onClick={() => handleLinkClick('link5')}>
                                                <FontAwesomeIcon icon={faCaretRight}/>
                                                &nbsp;
                                                Pending Activities
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link side-navi" to="#" onClick={() => handleLinkClick('link6')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Restore Device Logs
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link side-navi" to="#" onClick={() => handleLinkClick('link7')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Finger Quality Setting
                                            </Link>
                                        </li>
                                    </ul>
                                </div>
                            </div>

                            

                            <div className="col-md-8">
                                <div className="main-content">
                                    {selectedLink === 'link1' && <SuperAdmin />}
                                    {selectedLink === 'link2' && <SectionAdmin />}
                                    {selectedLink === 'link3' && <Employee />}
                                    {selectedLink === 'link4' && <HierarchyAdmin />}
                                    {selectedLink === 'link5' && <PendingActivities />}
                                    {selectedLink === 'link6' && <RestoreDeviceLogs />}
                                    {selectedLink === 'link7' && <FingerQualitySetting />}
                                    {selectedLink === 'link8' && <ImportLicenseFile />}
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    );
};

export default Settings;
