import React, { useState, useEffect } from 'react';
import DatePicker from 'react-datepicker';
import 'react-datepicker/dist/react-datepicker.css';
import '../../assets/styles/fetchEmployee.css';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPlus, faTrash, faSync } from '@fortawesome/free-solid-svg-icons';

const RestoreDeviceLogs = () => {
    const [startDate, setStartDate] = useState(new Date());
    const [endDate, setEndDate] = useState(new Date());
    return (
        <>
            <div className="container employeeContainer mt-2 justify-content-center align-items-start">
                <div className='card'>
                    <h1 className="mb-4 ms-2">Restore Logs</h1>
                    <div className='container-fluid mb-4'>
                        <div className="row mb-4">
                            <div className="col ms-2 me-2">
                                <div className="table-responsive" style={{ height: '300px', overflowX: 'auto' }}>
                                    <table className="table table-bordered">
                                        <thead>
                                            <tr>
                                                <th>Select</th>
                                                <th>Controller</th>
                                                <th>IP address</th>
                                                <th>Send Activity</th>
                                                <th>Time</th>
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
                                                    ACS Controller
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <input
                                                        type="checkbox"
                                                    />
                                                </td>
                                                <td>
                                                    CONTROL ROOM IN
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <input
                                                        type="checkbox"
                                                    />
                                                </td>
                                                <td>
                                                    CONTROL ROOM OUT
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
                                            <td></td>
                                            <td></td>
                                            <td></td>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                       <div className="row mb-3 justify-content-center">
                        <div className="col-12 col-md-4">
                            <label htmlFor="logTypeSelect" className="form-label2">Log Type:</label>
                            <select id="logTypeSelect" className="form-select">
                                    <option value="New log">New log</option>
                                    <option value="Log already sent to the server">Log already sent to the server</option>
                                    <option value="All stored logs">All stored logs</option>
                                    <option value="Period log">Period log</option>

                                
                            </select>
                        </div>
                    </div>
                    <div className="row mb-3 justify-content-center">
                        <div className="col-12 col-md-4">
                            <label htmlFor="fromDate" className="form-label2">From:</label>
                            <DatePicker selected={startDate} onChange={date => setStartDate(date)} className="form-control" />
                        </div>
                    </div>
                    <div className="row mb-3 justify-content-center">
                        <div className="col-12 col-md-4">
                                <label htmlFor="toDate" className="form-label2">To:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</label>
                            <DatePicker selected={endDate} onChange={date => setEndDate(date)} className="form-control" />
                        </div>
                    </div>
                    <div className="row mb-3 justify-content-center">
                        <div className="col-12 col-md-4 text-center">
                            <button className="btn btn-secondary">Restore Data</button>
                        </div>
                    </div>
                    </div>
                    </div>
            </div>
        </>

    );
};

export default RestoreDeviceLogs;
