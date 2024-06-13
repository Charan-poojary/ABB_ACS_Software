import React, { useState, useEffect, useRef } from 'react';
import '../../../assets/styles/fetchEmployee.css';
import '../../../assets/styles/Login.css'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPlus, faTrash, faSync, faEdit } from '@fortawesome/free-solid-svg-icons';

const HolidayGroup = () => {

    return (
        <>
            <div className="container employeeContainer mt-2 justify-content-center align-items-start">
                <div className='card'>
                    <h1 className="mb-4 ms-2">Holiday Group Master</h1>
                    <div className='container-fluid mb-4'>
                        <button className="custom-btn primary"
                        >
                            <FontAwesomeIcon icon={faPlus} className="me-2" />
                            Add
                        </button>
                        <button
                            className="custom-btn danger ms-2"
                        >
                            <FontAwesomeIcon icon={faTrash} className="me-2" />
                            Delete
                        </button>
                    </div>

                    {/*                    <div className="table-responsive text-center">
                        <table className="table table-striped">
                            <thead>
                                <tr>
                                    <th>Select</th>
                                    <th>Time Zone</th>
                                    <th></th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
                                <td>
                                    <input
                                        type="checkbox"
                                    />
                                </td>
                                <td>All Time</td>
                                <td>
                                    <button className="custom-btn primary">
                                        <FontAwesomeIcon icon={faEdit} />
                                    </button>
                                </td>
                                <td>
                                    <button className="custom-btn danger" >
                                        <FontAwesomeIcon icon={faTrash} />
                                    </button>
                                </td>
                                <td></td>
                                <td>
                                </td>
                            </tbody>
                        </table>
                    </div>*/}
                </div>
            </div>


        </>
    );
};

export default HolidayGroup;