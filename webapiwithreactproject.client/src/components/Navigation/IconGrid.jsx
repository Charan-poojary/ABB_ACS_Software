import React, { useState } from 'react';
import '../../assets/styles/fetchEmployee.css';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPlus, faUserFriends, faCogs, faFileImport, faUsersCog, faUserPlus, faChartLine, faCopy, faFileAlt, faSyncAlt } from '@fortawesome/free-solid-svg-icons';

const IconGrid = ({ onAddControllerClick, onCreateAccessGroupClick, onSendControllerSettingClick, onEmployeeMasterClick, onIEemployeeClick, onEmployeeRegisterationClick, onStatusMonitoringClick, onTemplateTransferClick, onFifoReportClick, onUpdateLicenceClick }) => {
    const [activeDiv, setActiveDiv] = useState(null);

    const handleDivClick = (divId, onClick) => {
        setActiveDiv(divId);
        onClick();
    };

    return (
        <div className="container-fluid p-4">
            <div className="row g-4">
                <div className={`col text-center column p-2 ${activeDiv === 'addController' ? 'active' : ''}`} onClick={() => handleDivClick('addController', onAddControllerClick)}>
                    <FontAwesomeIcon icon={faPlus} size="lg" />
                    <p className="mt-2 mb-0 icons-text">ADD Controller</p>
                </div>

                <div className={`col text-center column p-2 ${activeDiv === 'createAccessGroup' ? 'active' : ''}`} onClick={() => handleDivClick('createAccessGroup', onCreateAccessGroupClick)}>
                    <FontAwesomeIcon icon={faUserFriends} size="lg" />
                    <p className="mt-2 mb-0 icons-text">Create Access Group</p>
                </div>

                <div className={`col text-center column p-2 ${activeDiv === 'sendControllerSetting' ? 'active' : ''}`} onClick={() => handleDivClick('sendControllerSetting', onSendControllerSettingClick)}>
                    <FontAwesomeIcon icon={faCogs} size="lg" />
                    <p className="mt-2 mb-0 icons-text">Send Controller Setting</p>
                </div>

                <div className={`col text-center column p-2 ${activeDiv === 'employeeMaster' ? 'active' : ''}`} onClick={() => handleDivClick('employeeMaster', onEmployeeMasterClick)}>
                    <FontAwesomeIcon icon={faUsersCog} size="lg" />
                    <p className="mt-2 mb-0 icons-text">Employee Master</p>
                </div>

                <div className={`col text-center column p-2 ${activeDiv === 'ieEmployee' ? 'active' : ''}`} onClick={() => handleDivClick('ieEmployee', onIEemployeeClick)}>
                    <FontAwesomeIcon icon={faFileImport} size="lg" />
                    <p className="mt-2 mb-0 icons-text">Import Export Employees</p>
                </div>

                <div className={`col text-center column p-2 ${activeDiv === 'employeeRegistration' ? 'active' : ''}`} onClick={() => handleDivClick('employeeRegistration', onEmployeeRegisterationClick)}>
                    <FontAwesomeIcon icon={faUserPlus} size="lg" />
                    <p className="mt-2 mb-0 icons-text">Employee Registration</p>
                </div>

                <div className={`col text-center column p-2 ${activeDiv === 'statusMonitoring' ? 'active' : ''}`} onClick={() => handleDivClick('statusMonitoring', onStatusMonitoringClick)}>
                    <FontAwesomeIcon icon={faChartLine} size="lg" />
                    <p className="mt-2 mb-0 icons-text">Status Monitoring</p>
                </div>

                <div className={`col text-center column p-2 ${activeDiv === 'templateTransfer' ? 'active' : ''}`} onClick={() => handleDivClick('templateTransfer', onTemplateTransferClick)}>
                    <FontAwesomeIcon icon={faCopy} size="lg" />
                    <p className="mt-2 mb-0 icons-text">Template Transfer</p>
                </div>

                <div className={`col text-center column p-2 ${activeDiv === 'fifoReport' ? 'active' : ''}`} onClick={() => handleDivClick('fifoReport', onFifoReportClick)}>
                    <FontAwesomeIcon icon={faFileAlt} size="lg" />
                    <p className="mt-2 mb-0 icons-text">FIFO Report</p>
                </div>

                <div className={`col text-center column p-2 ${activeDiv === 'updateLicence' ? 'active' : ''}`} onClick={() => handleDivClick('updateLicence', onUpdateLicenceClick)}>
                    <FontAwesomeIcon icon={faSyncAlt} size="lg" />
                    <p className="mt-2 mb-0 icons-text">Update Licence</p>
                </div>
            </div>
        </div>
    );
};

export default IconGrid;
