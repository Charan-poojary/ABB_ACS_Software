import React, { useState, useEffect, useRef } from 'react';
import '../../assets/styles/fetchEmployee.css';
import 'bootstrap-datepicker/dist/css/bootstrap-datepicker.min.css';
import $ from 'jquery';
import 'bootstrap-datepicker';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faCalendar } from '@fortawesome/free-solid-svg-icons';

const PictureTransactionsReport = () => {

    const [EmployeeMasters, setEmployeeMasters] = useState([]);
    const [validFrom, setValidFrom] = useState('');


    const readers = [
        "ACS Controller - Reader1",
        "ACS Controller - Reader2",
        "ACS Controller - Reader3",
        "ACS Controller - Reader4",
        "CONTROL ROOM IN - CONTROL ROOM IN",
        "CONTROL ROOM OUT - CONTROL ROOM OUT",
        "MAIN GATE IN - Driver Side",
        "MAIN GATE IN - Cleaner Side",
        "MAIN GATE OUT - Driver Side",
        "MAIN GATE OUT - Cleaner Side"
    ];

    const [error, setError] = useState('');
    const [successMessage, setSuccessMessage] = useState('');
    const [loading, setLoading] = useState(false);

    const timeoutRef = useRef(null);

    useEffect(() => {
        timeoutRef.current = setTimeout(() => {
            setError('');
            setSuccessMessage('');
        }, 1000);

        return () => clearTimeout(timeoutRef.current);
    }, [error, successMessage]);

    useEffect(() => {
        fetchEmployeeMasters();
    }, []);

  

    const fetchEmployeeMasters = async () => {
        try {
            setLoading(true);
            const response = await fetch('http://localhost:5213/api/Employee');
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            const data = await response.json();

            setEmployeeMasters(data);
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        } finally {
            setLoading(false);
        }
    };



    useEffect(() => {
        $('#validFrom').datepicker({
            format: 'mm/dd/yyyy',
            autoclose: true,
        }).on('changeDate', function (e) {
            setValidFrom(e.target.value);
        });

    }, []);

    const showDatePicker = (inputId) => {
        $(`#${inputId}`).datepicker('show');
    };



    return (
        <>
            <div className="container employeeContainer  mt-2 justify-content-center align-items-start">
                <div className='card'>
                    <h1 className="mb-4 ms-2">Delete Pending Activities</h1>
                    <div className='container-fluid mb-4'>
                        <div className="row mb-4">
                            <div className="col-md-3 mb-2">
                                <label htmlFor="name" className="form-label2">Employee:</label>
                                <select
                                    className="form-select form-control border border-dark"
                                    name="name"

                                >
                                    <option value="">All</option>
                                    {EmployeeMasters.map(employee => (
                                        <option key={employee.id} value={employee.id}>{employee.fname}</option>
                                    ))}
                                </select>
                            </div>
                            <div className="col-md-3 mb-2">
                                <label htmlFor="filter" className="form-label2">Filter:</label>
                                <input id="filter"
                                    className="form-control border border-dark"
                                >
                                </input>
                            </div>
                            <div className="col-md-3 mt-4">
                                <button className="custom-btn secondary float-end">
                                    Filter
                                </button>
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
                                <label htmlFor="reader" className="form-label2">Controllers:</label>
                                <select className="form-select form-control border border-dark" name="reader">
                                    <option value="">All</option>
                                    {readers.map((reader, index) => (
                                        <option key={index} value={reader}>{reader}</option>
                                    ))}
                                </select>
                            </div>
                            <div className="col-md-3 mt-4">
                                <button className="custom-btn secondary float-end">
                                Search
                                </button>
                            </div>
                        </div>
                    </div>
                </div>

                        
            </div>
        </>
    );
};

export default PictureTransactionsReport;
