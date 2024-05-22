import React, { useState, useEffect } from 'react';
import '../../assets/styles/fetchEmployee.css';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPlus, faTrash, faSync } from '@fortawesome/free-solid-svg-icons';

const DesignationMaster = () => {


    return (
        <>
            <div className="container employeeContainer">
                <div className='card'>
                    <h1 className="mb-4 ms-2">Designation Master</h1>
                    <div className='container-fluid mb-4'>
                        <button className="custom-btn primary">
                            <FontAwesomeIcon icon={faPlus} className="me-2" />
                            Create
                        </button>
                        <button className="custom-btn danger ms-2">
                            <FontAwesomeIcon icon={faTrash} className="me-2" />
                            Delete
                        </button>
                        <button className="custom-btn secondary float-end">
                            <FontAwesomeIcon icon={faSync} />
                        </button>
                    </div>
                        <div className="table-responsive text-center">
                            <table className="table table-striped">
                                <thead>
                                    <tr>
                                        <th>Employee Id</th>
                                        <th>Name</th>
                                        <th>City</th>
                                        <th>Department</th>
                                        <th>Gender</th>
                                    </tr>
                                </thead>
                                <tbody>

                                </tbody>
                            </table>
                        </div>
                </div>
            </div>
        </>
    );
};

export default DesignationMaster;
