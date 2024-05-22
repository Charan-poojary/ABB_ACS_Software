import React from 'react';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPlus, faUserFriends, faCogs, faFileImport, faUsersCog, faUserPlus, faChartLine, faCopy, faFileAlt, faSyncAlt } from '@fortawesome/free-solid-svg-icons';

const IconGrid = ({ onAddControllerClick, onCreateAccessGroupClick, onSendControllerSettingClick, onEmployeeMasterClick, onIEemployeeClick, onEmployeeRegisterationClick, onStatusMonitoringClick, onTemplateTransferClick, onFifoReportClick, onUpdateLicenceClick }) => {
    return (
        <div className="container-fluid p-4">
            <div className="row g-4 ">
                <div className="col text-center">
                    <FontAwesomeIcon icon={faPlus} size="lg" onClick={onAddControllerClick} />
                    <p className="mt-2 mb-0 icons-text">ADD Controller</p>
                </div>
                <div className="col text-center">
                    <FontAwesomeIcon icon={faUserFriends} size="lg" onClick={onCreateAccessGroupClick} />
                    <p className="mt-2 mb-0 icons-text">Create Access group</p>
                </div>



                <div className="col text-center">
                    <FontAwesomeIcon icon={faCogs} size="lg" onClick={onSendControllerSettingClick} />
                    <p className="mt-2 mb-0 icons-text">Send Controller Setting</p>
                </div>



                <div className="col text-center">
                    <FontAwesomeIcon icon={faUsersCog} size="lg" onClick={onEmployeeMasterClick} />
                    <p className="mt-2 mb-0 icons-text">Employee Master</p>
                </div>
                <div className="col text-center">
                    <FontAwesomeIcon icon={faFileImport} size="lg" onClick={onIEemployeeClick} />
                    <p className="mt-2 mb-0 icons-text">Import Export Employees</p>
                </div>
                <div className="col text-center">
                    <FontAwesomeIcon icon={faUserPlus} size="lg" onClick={onEmployeeRegisterationClick} />
                    <p className="mt-2 mb-0 icons-text">Employee Registration</p>
                </div>



                <div className="col text-center">
                    <FontAwesomeIcon icon={faChartLine} size="lg" onClick={onStatusMonitoringClick} />
                    <p className="mt-2 mb-0 icons-text">Status Monitoring</p>
                </div>



                <div className="col text-center">
                    <FontAwesomeIcon icon={faCopy} size="lg" onClick={onTemplateTransferClick} />
                    <p className="mt-2 mb-0 icons-text">Template Transfer</p>
                </div>


                <div className="col text-center">
                    <FontAwesomeIcon icon={faFileAlt} size="lg" onClick={onFifoReportClick} />
                    <p className="mt-2 mb-0 icons-text">FIFO Report</p>
                </div>


                <div className="col text-center">
                    <FontAwesomeIcon icon={faSyncAlt} size="lg" onClick={onUpdateLicenceClick} />
                    <p className="mt-2 mb-0 icons-text">Update Licence</p>
                </div>
            </div>
        </div>
    );
};

export default IconGrid;
