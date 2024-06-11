import React, { useState, useEffect } from 'react';
import '../../assets/styles/fetchEmployee.css';
import '../../assets/styles/form.css'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPlus, faTrash, faSync } from '@fortawesome/free-solid-svg-icons';

const RealTimeData = () => {

    return (
        <>
            <div className="container employeeContainer mt-2 justify-content-center align-items-start">
                <div className='card'>
                    <h1 className="mb-4 ms-2">Real Time</h1>
                    <div className='container-fluid mb-4'>
                        <div className="row mb-4">
                            <div className="col-md-4 col-sm-6 col-12 mb-2 d-flex align-items-center">
                                <label htmlFor="controllers" className="form-label2 me-2">Select Controllers:</label>
                                <select className="form-control form-select border border-dark" name="controllers">
                                    <option value="">All</option>
                                    <option value="1">ACS Controller</option>
                                    <option value="2">CONTROL ROOM IN</option>
                                    <option value="3">CONTROL ROOM OUT</option>
                                    <option value="4">MAIN GATE IN - Driver Side</option>
                                    <option value="5">MAIN GATE IN - Clener Side</option>
                                    <option value="6">MAIN GATE OUT - Driver Side</option>
                                    <option value="7">MAIN GATE OUT - Clener Side</option>
                                </select>
                            </div>
                            <div className="col-md-4 col-sm-6 col-12 mb-2 d-flex align-items-center">
                                <label className="form-label2 me-2">Empcode:</label>
                                <input type="text" className="form-control" name="empcode" />
                            </div>
                            <div className="col-md-2 col-sm-6 col-12 mb-2 mt-2">
                                <button className="custom-btn secondary float-end">
                                    <FontAwesomeIcon icon={faSync} />
                                </button>
                            </div>
                        </div>
                    </div>

                    <div className="container-fluid mb-4 border border-dark">
                        <div className="row">
                            <div className="col-12">
                                <div className="p-2" style={{ maxWidth: "1200px", margin: "0 auto", backgroundColor: "#f8f9fa" }}>
                                    <p>Activity Log</p>
                                </div>
                                <div className="table-responsive text-center border-bottom border-dark pb-4" style={{ maxWidth: "1200px", margin: "0 auto", backgroundColor: "#f8f9fa" }}>
                                    <table className="table table-striped mb-0">
                                        <thead>
                                            <tr>
                                                <th>Controller</th>
                                                <th>Activity Type</th>
                                                <th>Controller IP</th>
                                                <th>Date</th>
                                                <th>Time</th>
                                                <th>User</th>
                                                <th>Status</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td></td>
                                                <td></td>
                                                <td></td>
                                                <td></td>
                                                <td></td>
                                                <td></td>
                                                <td></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <div className="row">
                            <div className="col-12">
                                <div className="p-2" style={{ maxWidth: "1200px", margin: "0 auto", backgroundColor: "#f8f9fa" }}>
                                    <p>Transactions section</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </>
    );
};

export default RealTimeData;
