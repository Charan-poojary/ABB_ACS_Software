import React from 'react';
import '../../assets/styles/fetchEmployee.css';
import '../../assets/styles/Login.css'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPlus, faTrash, faSync } from '@fortawesome/free-solid-svg-icons';

const subDepartmentMaster = () => {


    return (
        <>
            <div className="container employeeContainer mt-2 justify-content-center align-items-start">
                <div className='card'>
                    <h1 className="mb-4 ms-2">Sub Department Master</h1>
                    <div className='container-fluid mb-4'>
                        <button className="custom-btn primary"
                            disabled
                            style={{ opacity: 0.5 }}
                        >
                            <FontAwesomeIcon icon={faPlus} className="me-2" />
                            Add
                        </button>
                        <button
                            className='custom-btn danger ms-2'
                            disabled
                            style={{ opacity: 0.5 }} 
                        >
                            <FontAwesomeIcon icon={faTrash} className="me-2" />
                            Delete
                        </button>
                        <button className="custom-btn secondary float-end"
                            disabled
                            style={{ opacity: 0.5 }}
                        >
                            <FontAwesomeIcon icon={faSync} />
                        </button>
                    </div>
                    <div className="ms-4">
                        <p className="lead fw-bold">Count: <span className="text-danger"></span></p>
                    </div>

                    <div className="table-responsive text-center">
                        <table className="table table-striped">
                            <thead>
                                <tr>
                                    <th>Select</th>
                                    <th>Locations</th>
                                    <th></th>
                                    <th></th>
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

export default subDepartmentMaster;