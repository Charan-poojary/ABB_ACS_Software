import React, { useState, useEffect } from 'react';
import 'react-datepicker/dist/react-datepicker.css';
import '../../assets/styles/fetchEmployee.css';

const ImportLicenseFile = () => {
    return (
        <>
            <div className="container employeeContainer mt-2 justify-content-center align-items-start">
                <div className='card'>
                    <h1 className="mb-4 ms-2">Import License File</h1>
                    <div className='container-fluid mb-4'>
                        <div className="row mb-4">
                            <div className="col ms-2 me-2">
                            <p className="lead p-2 fw-dark">Version Details</p>
                                <div className="table-responsive" style={{ height: '300px', overflowX: 'auto' }}>
                                    <table className="table table-bordered">
                                        <thead>
                                        <tr></tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                               
                                            </tr>
                                            <td></td>
                                            <td></td>
                                            <td></td>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <div className="col-md-4 mb-2">
                            <label>Excel file:</label>
                            <input
                                type="file"
                                accept=".xlsx, .xls, .pdf"
                                className="form-control border border-dark"
                            />
                        </div>
                        <div className="row mb-3 justify-content-start">
                            <div className="col-12 col-md-4 text-center">
                                <button className="btn btn-secondary">Import License File</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </>

    );
};

export default ImportLicenseFile;
