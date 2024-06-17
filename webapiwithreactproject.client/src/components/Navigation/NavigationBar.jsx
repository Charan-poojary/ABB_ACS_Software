import React from 'react';
import { Link } from 'react-router-dom';
import logo from '../../assets/images/logo.png';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faHouse, faLock, faDesktop, faRightFromBracket } from '@fortawesome/free-solid-svg-icons';

const NavigationBar = ({ onLogout, onChangePassword, onHomeIconclick, onACSIconclick }) => {
    return (
        <nav className="navbar navbar-expand-lg navbar-dark bg-dark">
            <div className="container-fluid">
                <Link className="navbar-brand" to="/dashboard">
                    <img src={logo} alt="Company Logo" width="50" height="30" className="d-inline-block align-left" />
                    <span className="lead ms-2">ACCESS CONTROL</span>
                </Link>
                <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
                    <span className="navbar-toggler-icon"></span>
                </button>
                <div className="collapse navbar-collapse justify-content-end" id="navbarNavAltMarkup">
                    <div className="navbar-nav">
                        <Link className="nav-link active ms-3 d-flex flex-column align-items-center" aria-current="page" onClick={onHomeIconclick} style={{ cursor: 'pointer' }}>
                            <FontAwesomeIcon icon={faHouse} />
                            <span className="icon-text">Home</span>
                        </Link>
                        <div className="nav-link ms-3 d-flex flex-column align-items-center" onClick={onChangePassword} style={{ cursor: 'pointer' }}>
                            <FontAwesomeIcon icon={faLock} />
                            <span className="icon-text">Change Password</span>
                        </div>
                        <li className="nav-item dropdown ms-3">
                            <Link className="nav-link dropdown-toggle d-flex flex-column align-items-center" to="#" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                                <FontAwesomeIcon icon={faDesktop} />
                                <span className="icon-text">Systems</span>
                            </Link>
                            <ul className="dropdown-menu bg-dark" aria-labelledby="navbarDropdown">
                                <li><Link className="dropdown-item bg-light text-dark mt-2 mb-1" onClick={onACSIconclick} style={{ cursor: 'pointer' }}>Access Control</Link></li>
                                <li><Link className="dropdown-item bg-light text-dark mb-1" to="#">Attendance System</Link></li>
                                <li><Link className="dropdown-item bg-light text-dark" to="#">VMS</Link></li>
                            </ul>
                        </li>
                        <div className="nav-link ms-3 d-flex flex-column align-items-center" onClick={onLogout} style={{ cursor: 'pointer' }}>
                            <FontAwesomeIcon icon={faRightFromBracket} />
                            <span className="icon-text">Logout</span>
                        </div>
                    </div>
                </div>
            </div>
        </nav>
    );
};

export default NavigationBar;
