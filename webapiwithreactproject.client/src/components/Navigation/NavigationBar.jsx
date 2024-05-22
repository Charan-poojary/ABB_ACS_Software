import React from 'react';
import { Link } from 'react-router-dom';
import logo from '../../assets/images/logo.png';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faHouse, faLock, faDesktop, faRightFromBracket } from '@fortawesome/free-solid-svg-icons';

const NavigationBar = ({ onLogout, onChangePassword }) => {

    return (
        <nav className="navbar navbar-expand-lg navbar-dark bg-dark">
            <div className="container-fluid">
                <Link className="navbar-brand" to="/home" >
                    <img src={logo} alt="Company Logo" width="50" height="30" className="d-inline-block align-left" />
                    <span className="lead ms-2">ACCESS CONTROL</span>
                </Link>
                <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
                    <span className="navbar-toggler-icon"></span>
                </button>
                <div className="collapse navbar-collapse justify-content-end" id="navbarNavAltMarkup">
                    <div className="navbar-nav">
                        <Link className="nav-link active ms-3 d-flex flex-column align-items-center" aria-current="page" to="/" >
                            <FontAwesomeIcon icon={faHouse}  />
                            <span className="icon-text">Home</span>
                        </Link>
                        <Link className="nav-link ms-3 d-flex flex-column align-items-center" onClick={onChangePassword}>
                            <FontAwesomeIcon icon={faLock} />
                            <span className="icon-text">Change Password</span>
                        </Link>

                        <li className="nav-item dropdown ms-3">
                            <Link className="nav-link dropdown-toggle d-flex flex-column align-items-center" to="#" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                                <FontAwesomeIcon icon={faDesktop}/>
                                <span className="icon-text">Systems</span>
                            </Link>
                            <ul className="dropdown-menu bg-dark" aria-labelledby="navbarDropdown">
                                <li><Link className="dropdown-item bg-light text-dark mt-2 mb-1" to="/home" >System 1</Link></li>
                                <li><Link className="dropdown-item bg-light text-dark mb-1" to="/home" >System 2</Link></li>
                                <li><Link className="dropdown-item bg-light text-dark" to="/home">System 3</Link></li>
                            </ul>
                        </li>
                        <Link className="nav-link ms-3 d-flex flex-column align-items-center" onClick={onLogout}>
                            <FontAwesomeIcon icon={faRightFromBracket} />
                            <span className="icon-text">Logout</span>
                        </Link>
                    </div>
                </div>
            </div>
        </nav>
    );
};

export default NavigationBar;
