import React, { useState, useEffect, useRef } from 'react';
import '../../assets/styles/fetchEmployee.css';
import 'bootstrap-datepicker/dist/css/bootstrap-datepicker.min.css';
import $ from 'jquery';
import 'bootstrap-datepicker';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faSync, faCalendar } from '@fortawesome/free-solid-svg-icons';

const DriverHelperUnregisterationReport = () => {

/*    const [EmployeeMasters, setEmployeeMasters] = useState([]);
    const [allEmployeeMasters, setAllEmployeeMasters] = useState([]);
    const [selectedRows, setSelectedRows] = useState([]);*/
    const [validFrom, setValidFrom] = useState('');
    const [validTo, setValidTo] = useState('');
/*    const [fromTime, setFromTime] = useState('10:00');
    const [toTime, setToTime] = useState('11:00');*/



    useEffect(() => {
        $('#validFrom').datepicker({
            format: 'mm/dd/yyyy',
            autoclose: true,
        }).on('changeDate', function (e) {
            setValidFrom(e.target.value);
        });

        $('#validTo').datepicker({
            format: 'mm/dd/yyyy',
            autoclose: true,
        }).on('changeDate', function (e) {
            setValidTo(e.target.value);
        });

    }, []);

    const showDatePicker = (inputId) => {
        $(`#${inputId}`).datepicker('show');
    };



    return (
        <>
            <div className="container employeeContainer  mt-2 justify-content-center align-items-start">
                <div className='card'>
                    <h1 className="mb-4 ms-2">Driver Helper Unregisteration Report</h1>
                    <div className='container-fluid mb-4'>
                        <div className="row mb-4">
                            <div className="col-md-3 mb-2">
                                <label htmlFor="type" className="form-label2">Type:</label>
                                <select
                                    className="form-control form-select border border-dark"
                                    name="type"
                                    disabled
                                >
                                    <option value="0">Both</option>
                                    <option value="1">Driver</option>
                                    <option value="2">Helper</option>

                                </select>
                            </div>
                            <div className="col-md-3 mb-2">
                                <label htmlFor="empcode" className="form-label2">Empcode:</label>
                                <input id="empcode"
                                    className="form-control border border-dark"
                                >
                                </input>
                            </div>
                            <div className="col-md-3 mb-2">
                                <label htmlFor="name" className="form-label2">Name:</label>
                                <input id="name"
                                    className="form-control border border-dark"
                                >
                                </input>
                            </div>
                        </div>
                        <div className="row mb-4">
                            <div className="col-md-3 mb-2">
                                <label>From:</label>
                                <div className="input-group">
                                    <input
                                        type="text"
                                        id="validFrom"
                                        className="form-control border border-dark"
                                        placeholder="Select date"
                                        value={validFrom}
                                        onChange={(e) => setValidFrom(e.target.value)}
                                    />
                                    <span className="input-group-text" onClick={() => showDatePicker('validFrom')}>
                                        <FontAwesomeIcon icon={faCalendar} style={{ cursor: 'pointer' }} />
                                    </span>
                                </div>
                            </div>
                            <div className="col-md-3 mb-2">
                                <label>To:</label>
                                <div className="input-group">
                                    <input
                                        type="text"
                                        id="validTo"
                                        className="form-control border border-dark"
                                        placeholder="Select date"
                                        value={validTo}
                                        onChange={(e) => setValidTo(e.target.value)}
                                    />
                                    <span className="input-group-text" onClick={() => showDatePicker('validTo')}>
                                        <FontAwesomeIcon icon={faCalendar} style={{ cursor: 'pointer' }} />
                                    </span>
                                </div>
                            </div>
                            <div className="col-md-3 mb-2">
                                <label htmlFor="format" className="form-label2">Format:</label>
                                <select
                                    className="form-control form-select border border-dark"
                                    name="format"
                                >
                                    <option value="1">PDF</option>
                                    <option value="2">Excel</option>
                                </select>
                            </div>
                        </div>
                       
                        <div className="row mb-4 justify-content-center">
                            <div className="col-md-3 mb-2">
                                <button className="btn btn-secondary w-80">View</button>
                            </div>
                            <div className="col-md-3 mb-2">
                                <button className="btn btn-secondary w-80">Export</button>
                            </div>
                        </div>
                       
                    </div>
                </div>
            </div>
        </>
    );
};

export default DriverHelperUnregisterationReport;
