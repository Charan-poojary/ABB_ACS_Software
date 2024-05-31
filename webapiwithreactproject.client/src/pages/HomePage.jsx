import React, { useState,useEffect } from 'react';
import NavigationBar from '../components/Navigation/NavigationBar';
import MiniNavigationBar from '../components/Navigation/MiniNavigationBar';
import MasterData from '../components/MasterDataComponents/MasterData';
import DoorActions from '../components/DoorActionsComponents/DoorActions';
import RealTime from '../components/RealTimeComponents/RealTime';
import Settings from '../components/SettingsComponents/Settings';
import Reports from '../components/ReportsComponents/Reports';
import IconGrid from '../components/Navigation/IconGrid';
import ForgotPasswordPage from './ForgotPasswordPage';
import companyLogo from '../assets/images/Bharat_Petroleum_logo_PNG.png';


const HomePage = ({ onLogout, onAddControllerClick, onCreateAccessGroupClick, onSendControllerSettingClick, onEmployeeMasterClick, onIEemployeeClick, onEmployeeRegisterationClick, onStatusMonitoringClick, onTemplateTransferClick, onFifoReportClick, onUpdateLicenceClick }) => {
    const [message, setMessage] = useState('');
    const [username, setUsername] = useState('');
    const [loginTime, setLoginTime] = useState('');
    const [lastAccessTime, setLastAccessTime] = useState('');
    const [activeComponent, setActiveComponent] = useState(null);
    const [showMasterData, setShowMasterData] = useState(true);
    const [showChangePassword, setShowChangePassword] = useState(false); 

    useEffect(() => {
        setUsername(localStorage.getItem('username') || '');
        setLoginTime(localStorage.getItem('loginTime') || '');
        setLastAccessTime(localStorage.getItem('lastAccessTime') || '');
    }, []);


    const handleMasterDataClick = () => {
        setShowMasterData(true);
        setShowChangePassword(false);
    };


    const handleDoorActionsClick = () => {
        setShowMasterData(false);
        setShowChangePassword(false);
        setActiveComponent('doorActions');
    };

    const handleRealTimeClick = () => {
        setShowMasterData(false);
        setShowChangePassword(false);
        setActiveComponent('realTime');

    };

    const handleReportsClick = () => {
        setShowMasterData(false);
        setShowChangePassword(false);
        setActiveComponent('reports');

    };

    const handSettingsClick = () => {
        setShowMasterData(false);
        setShowChangePassword(false);
        setActiveComponent('settings');
    };


    const handleOnAddControllerClick = () => {
        setShowMasterData(true);
        setShowChangePassword(false);
    };
    const handleOnCreateAccessGroupClick = () => {
        setShowMasterData(true);
        setShowChangePassword(false);
    };
    const handleOnSendControllerSettingClick = () => {
        setShowMasterData(true);
        setShowChangePassword(false);
    };
    const handleOnEmployeeMasterClick = () => {
        setShowMasterData(true);
        setShowChangePassword(false);
    };
    const handleOnIEemployeeClick = () => {
        setShowMasterData(true);
        setShowChangePassword(false);
    };
    const handleOnEmployeeRegisterationClick = () => {
        setShowMasterData(true);
        setShowChangePassword(false);
    };
    const handleOnStatusMonitoringClick = () => {
        setShowMasterData(false);
        setShowChangePassword(false);
        setActiveComponent('realTime');

    };
    const handleOnTemplateTransferClick = () => {
        setShowMasterData(true);
        setShowChangePassword(false);
    };
    const handleOnFifoReportClick = () => {
        setShowMasterData(false);
        setShowChangePassword(false);
        setActiveComponent('reports');

    };
    const handleOnUpdateLicenceClick = () => {
        setShowMasterData(true);
        setShowChangePassword(false);
    };
    const handleChangePassword = () => {
        setShowChangePassword(true); 
        setShowMasterData(false); 
        setActiveComponent(null);
    }

    return (
        <>
            <NavigationBar
                onLogout={onLogout}
                onChangePassword={handleChangePassword}
            />
            {!showChangePassword && (
            <MiniNavigationBar
                onMasterDataClick={handleMasterDataClick }
                onDoorActionsClick={handleDoorActionsClick}
                onRealTimeClick={handleRealTimeClick}
                onReportsClick={handleReportsClick}
                onSettingsClick={handSettingsClick}
            />
            )}
            {!showChangePassword && (
                <div className="container-fluid d-flex justify-content-between align-items-center">
                    <div>
                        <h2 className="display-6 ms-md-2">Welcome, <span className="text-danger">{username}</span></h2>
                        <p className="h6 ms-md-3">Last Login: <span className="text-primary">{loginTime}</span></p>
                        <p className="h6 ms-md-3">Access Service Status: <span className="text-danger">{lastAccessTime}</span></p>
                    </div>
                    <div>
                        <img src={companyLogo} alt="Company Logo" className="img-fluid" style={{ maxWidth: '250px' }} />
                    </div>
                </div>
            )}
            {!showChangePassword && (
                <IconGrid
                    onAddControllerClick={handleOnAddControllerClick}
                    onCreateAccessGroupClick={handleOnCreateAccessGroupClick}
                    onSendControllerSettingClick={handleOnSendControllerSettingClick}
                    onEmployeeMasterClick={handleOnEmployeeMasterClick}
                    onIEemployeeClick={handleOnIEemployeeClick}
                    onEmployeeRegisterationClick={handleOnEmployeeRegisterationClick}
                    onStatusMonitoringClick={handleOnStatusMonitoringClick}
                    onTemplateTransferClick={handleOnTemplateTransferClick}
                    onFifoReportClick={handleOnFifoReportClick}
                    onUpdateLicenceClick={handleOnUpdateLicenceClick}
                />
            )}
            {showChangePassword && <ForgotPasswordPage/>}
            {showMasterData && <MasterData />}
            {activeComponent === 'doorActions' && !showMasterData && <DoorActions />}
            {activeComponent === 'realTime' && !showMasterData && <RealTime />}
            {activeComponent === 'reports' && !showMasterData && <Reports />}
            {activeComponent === 'settings' && !showMasterData && <Settings />}
        </>
    );
};

export default HomePage;
