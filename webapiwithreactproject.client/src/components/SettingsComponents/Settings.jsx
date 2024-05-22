import React, { useState } from 'react';
import { Link } from 'react-router-dom';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faCaretRight } from '@fortawesome/free-solid-svg-icons';
import CompanyMaster from './CompanyMaster';
import LocationMaster from './LocationMaster';
import DepartmentMaster from './DepartmentMaster';


const Settings = () => {
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
                                            <Link className="nav-link dropdown-toggle" to="#" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                User Management
                                            </Link>
                                            <ul className="dropdown-menu" aria-labelledby="navbarDropdown">
                                                <li><Link className="dropdown-item" to="/home">Super Admin</Link></li>
                                                <li><Link className="dropdown-item" to="/home" >Section Admin</Link></li>
                                                <li><Link className="dropdown-item" to="/home" >Employee</Link></li>
                                                <li><Link className="dropdown-item" to="/home" >Hierarchy Admin</Link></li>
                                            </ul>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link1')}>
                                                <FontAwesomeIcon icon={faCaretRight}/>
                                                &nbsp;
                                                Pending Activities
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link2')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Restore Device Logs
                                            </Link>
                                        </li>
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link3')}>
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
                                    {selectedLink === 'link1' && <CompanyMaster />}
                                    {selectedLink === 'link2' && <LocationMaster />}
                                    {selectedLink === 'link3' && <DepartmentMaster />}
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
