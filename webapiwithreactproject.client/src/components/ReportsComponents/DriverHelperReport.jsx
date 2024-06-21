import React, { useState, useEffect, useRef } from 'react';
import '../../assets/styles/fetchEmployee.css';
import 'bootstrap-datepicker/dist/css/bootstrap-datepicker.min.css';
import $ from 'jquery';
import 'bootstrap-datepicker';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faSync, faCalendar } from '@fortawesome/free-solid-svg-icons';

const DriverHelperReport = () => {

/*    const [EmployeeMasters, setEmployeeMasters] = useState([]);
    const [allEmployeeMasters, setAllEmployeeMasters] = useState([]);
    const [selectedRows, setSelectedRows] = useState([]);*/
    const [validFrom, setValidFrom] = useState('');
    const [validTo, setValidTo] = useState('');
    const [fromTime, setFromTime] = useState('10:00');
    const [toTime, setToTime] = useState('11:00');



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
                    <h1 className="mb-4 ms-2">Driver Helper Report</h1>
                    <div className='container-fluid mb-4'>
                        <div className="row mb-4">
                            <div className="col-md-3 mb-2">
                                <label htmlFor="compid" className="form-label2">Company:</label>
                                <select
                                    className="form-select form-control border border-dark"
                                    name="compid"

                                >
                                    <option value="">All</option>
                                    <option value="1">Bharat Petroleum Corporation Limited</option>
                                </select>
                            </div>
                            <div className="col-md-3 mb-2">
                                <label htmlFor="locationid" className="form-label2">Location:</label>
                                <select
                                    className="form-control form-select border border-dark"
                                    name="locationid"

                                >
                                    <option value="">All</option>
                                    <option value="1">WARANGAL DEPOT</option>
                                </select>
                            </div>
                            <div className="col-md-3 mb-2">
                                <label htmlFor="deptname" className="form-label2">Department:</label>
                                <select
                                    className="form-control form-select border border-dark"
                                    name="deptname"

                                >
                                    <option value="">All</option>
                                    <option value="1">Administrator</option>
                                    <option value="2">CLEANER</option>
                                    <option value="3">DRIVER</option>
                                    <option value="4">Electrical</option>
                                    <option value="5">Maintainance</option>
                                    <option value="6">Operation</option>
                                    <option value="7">Planning</option>
                                    <option value="8">Safety</option>
                                </select>
                            </div>
                            <div className="col-md-3 mb-2">
                                <label htmlFor="subdeptname" className="form-label2">Sub Dept:</label>
                                <select
                                    className="form-control form-select border border-dark"
                                    name="subdeptname"
                                    value=""
                                >
                                    <option value="">All</option>
                                </select>
                            </div>
                            <div className="col-md-3 mb-2">
                                <label htmlFor="type" className="form-label2">Type:</label>
                                <select
                                    className="form-control form-select border border-dark"
                                    name="type"
                                    disabled
                                >
                                    <option value="">Driver Helper Report</option>
                                </select>
                            </div>
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
                                <label htmlFor="status" className="form-label2">Status:</label>
                                <select
                                    className="form-control form-select border border-dark"
                                    name="status"

                                >
                                    <option value="">All</option>
                                    <option value="Active">Active</option>
                                    <option value="Deactive">Deactive</option>
                                </select>
                            </div>
                        </div>
                        <div className="row mb-4">
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
                            <div className="col-md-3 mb-2">
                                <label>From Time:</label>
                                <div className="input-group">
                                    <input
                                        type="time"
                                        id="fromTime"
                                        className="form-control border border-dark"
                                        value={fromTime}
                                        onChange={(e) => setFromTime(e.target.value)}
                                    />
                                </div>
                            </div>
                            <div className="col-md-3 mb-2">
                                <label>To Time:</label>
                                <div className="input-group">
                                    <input
                                        type="time"
                                        id="toTime"
                                        className="form-control border border-dark"
                                        value={toTime}
                                        onChange={(e) => setToTime(e.target.value)}
                                    />
                                </div>
                            </div>
                            <div className="col-md-3 mt-4">
                                <button className="custom-btn secondary float-end">
                                    <FontAwesomeIcon icon={faSync} />
                                </button>
                            </div>
                        </div>
                        <div className="row mb-4">
                            <div className="col-md-3 mb-2">
                                <input type="checkbox" />
                                <label className="form-label2">&nbsp;Check All</label>
                            </div>
                            <div className="table-responsive text-center" style={{ height: '200px', overflowX: 'auto' }}>
                                <table className="table table-bordered">
                                    <thead>
                                        <tr>
                                            <th>Select</th>
                                            <th>Reader</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td>
                                                <input
                                                    type="checkbox"
                                                />
                                            </td>
                                            <td>
                                                ACS Controller - Reader1
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <input
                                                    type="checkbox"
                                                />
                                            </td>
                                            <td>
                                                ACS Controller - Reader2
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <input
                                                    type="checkbox"
                                                />
                                            </td>
                                            <td>
                                                ACS Controller - Reader3
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <input
                                                    type="checkbox"
                                                />
                                            </td>
                                            <td>
                                                ACS Controller - Reader4
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <input
                                                    type="checkbox"
                                                />
                                            </td>
                                            <td>
                                                CONTROL ROOM IN - CONTROL ROOM IN
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <input
                                                    type="checkbox"
                                                />
                                            </td>
                                            <td>
                                                CONTROL ROOM OUT - CONTROL ROOM OUT
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <input
                                                    type="checkbox"
                                                />
                                            </td>
                                            <td>
                                                MAIN GATE IN - Driver Side
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <input
                                                    type="checkbox"
                                                />
                                            </td>
                                            <td>
                                                MAIN GATE IN - Clener Side
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <input
                                                    type="checkbox"
                                                />
                                            </td>
                                            <td>
                                                MAIN GATE OUT - Driver Side
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <input
                                                    type="checkbox"
                                                />
                                            </td>
                                            <td>
                                                MAIN GATE OUT - Clener Side
                                            </td>
                                        </tr>

                                    </tbody>
                                </table>
                            </div>
                        </div>
                        <div className="row mb-4 justify-content-center">
                            <div className="col-md-3 mb-2">
                                <button className="btn btn-secondary w-80">Get Data</button>
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

export default DriverHelperReport;
