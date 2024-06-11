import React, { useState, useEffect } from 'react';
import '../../assets/styles/fetchEmployee.css';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPlus, faTrash, faSync } from '@fortawesome/free-solid-svg-icons';

const DoorOpenClose = () => {

    return (
        <>
            <div className="container employeeContainer mt-2 justify-content-center align-items-start">
                <div className='card'>
                    <h1 className="mb-4 ms-2">Door Open / Close</h1>
                    <div className='container-fluid mb-4'>
                        <div className="row mb-4">
                            <div className="col-md-2 col-sm-4 col-6 mb-2">
                                <button className="btn btn-primary w-80">Open</button>
                            </div>
                            <div className="col-md-2 col-sm-4 col-6 mb-2">
                                <button className="btn btn-secondary w-80">Start</button>
                            </div>
                            <div className="col-md-2 col-sm-4 col-6 mb-2">
                                <button className="btn btn-danger w-80">Close</button>
                            </div>
                            <div className="col-md-2 col-sm-4 col-6 mb-2">
                                <button className="btn btn-primary w-100">Lock</button>
                            </div>
                            <div className="col-md-2 col-sm-4 col-6 mb-2">
                                <button className="btn btn-secondary w-100">Unlock</button>
                            </div>
                            <div className="col-md-2 col-sm-4 col-6 mb-2 mt-2">
                            <button className="custom-btn secondary float-end">
                                <FontAwesomeIcon icon={faSync} />
                                </button>
                            </div>
                        </div>
                    </div>
                    <div className="row mb-4">
                        <div className="col ms-2 me-2">
                            <input
                                type="checkbox"
                            />
                            <label>&nbsp;Check All</label>
                            <div className="table-responsive" style={{ height: '200px', overflowX: 'auto' }}>
                                <table className="table table-bordered">
                                    <thead>
                                        <tr>
                                            <th>Select</th>
                                            <th>Door</th>
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
                                               Door1 - CONTROL ROOM IN 
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <input
                                                    type="checkbox"
                                                />
                                            </td>
                                            <td>
                                                Door1 - CONTROL ROOM OUT
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <input
                                                    type="checkbox"
                                                />
                                            </td>
                                            <td>
                                                Door1 - MAIN GATE IN - Driver Side
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <input
                                                    type="checkbox"
                                                />
                                            </td>
                                            <td>
                                                Door1 - MAIN GATE IN - Clener Side
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <input
                                                    type="checkbox"
                                                />
                                            </td>
                                            <td>
                                                Door1 - MAIN GATE OUT - Driver Side
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <input
                                                    type="checkbox"
                                                />
                                            </td>
                                            <td>
                                                Door1 - MAIN GATE OUT - Clener Side
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <input
                                                    type="checkbox"
                                                />
                                            </td>
                                            <td>
                                                Door1 - ACS Controller
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <input
                                                    type="checkbox"
                                                />
                                            </td>
                                            <td>
                                                Door2 - ACS Controller
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <input
                                                    type="checkbox"
                                                />
                                            </td>
                                            <td>
                                                Door3 - ACS Controller
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <input
                                                    type="checkbox"
                                                />
                                            </td>
                                            <td>
                                                Door4 - ACS Controller
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </>
    );
};

export default DoorOpenClose;
