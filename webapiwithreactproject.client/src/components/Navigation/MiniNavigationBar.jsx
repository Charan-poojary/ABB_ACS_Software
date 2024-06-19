import React, { useState } from 'react';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faAngleDown } from '@fortawesome/free-solid-svg-icons';

const MiniNavigationBar = ({ onMasterDataClick, onDoorActionsClick, onRealTimeClick, onReportsClick, onSettingsClick }) => {

    const [activeLink, setActiveLink] = useState('masterData');

    const handleMasterDataClick = () => {
        setActiveLink('masterData');
        onMasterDataClick();
    };

    const handleDoorActionsClick = () => {
        setActiveLink('doorActions');
        onDoorActionsClick();
    };

    const handleRealTimeClick = () => {
        setActiveLink('realTime');
        onRealTimeClick();
    };

    const handleReportsClick = () => {
        setActiveLink('reports');
        onReportsClick();
    };

    const handleSettingsClick = () => {
        setActiveLink('settings');
        onSettingsClick();
    };
    return (
        <nav className="navbar navbar-expand-lg navbar-light bg-light">
            <FontAwesomeIcon icon={faAngleDown} className="navbar-toggler minNavIcon" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav1" aria-controls="navbarNav1" aria-expanded="false" aria-label="Toggle navigation" />
            <span className="icon-text">Home</span>
            <div className="collapse navbar-collapse justify-content-center" id="navbarNav1">
                <ul className="nav navbar-nav nav-tabs">
                    <li className="nav-item">
                        <a className={`nav-link ms-2 ${activeLink === 'masterData' ? 'active text-danger' : ''}`} onClick={handleMasterDataClick} href="#">Master Data</a>
                    </li>
                    <li className="nav-item">
                        <a className={`nav-link ms-2 ${activeLink === 'doorActions' ? 'active text-danger' : ''}`} onClick={handleDoorActionsClick} href="#">Door Actions</a>
                    </li>
                    <li className="nav-item">
                        <a className={`nav-link ms-2 ${activeLink === 'realTime' ? 'active text-danger' : ''}`} onClick={handleRealTimeClick} href="#">Real Time</a>
                    </li>
                    <li className="nav-item">
                        <a className={`nav-link ms-2 ${activeLink === 'reports' ? 'active text-danger' : ''}`} onClick={handleReportsClick} href="#">Reports</a>
                    </li>
                    <li className="nav-item">
                        <a className={`nav-link ms-2 ${activeLink === 'settings' ? 'active text-danger' : ''}`} onClick={handleSettingsClick} href="#">Settings</a>
                    </li>
                </ul>
            </div>
        </nav>
    );
};

export default MiniNavigationBar;
