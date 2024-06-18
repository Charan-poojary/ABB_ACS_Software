import React, { useState, useEffect, useRef } from 'react';
import '../../assets/styles/fetchEmployee.css';
import 'bootstrap-datepicker/dist/css/bootstrap-datepicker.min.css';
import $ from 'jquery';
import 'bootstrap-datepicker';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faSync, faCalendar, faClock } from '@fortawesome/free-solid-svg-icons';

const DepartmentWiseReport = () => {

    const [EmployeeMasters, setEmployeeMasters] = useState([]);
    const [allEmployeeMasters, setAllEmployeeMasters] = useState([]);
    const [selectedRows, setSelectedRows] = useState([]);
    const [validFrom, setValidFrom] = useState('');
    const [validTo, setValidTo] = useState('');
    const [fromTime, setFromTime] = useState('10:00');
    const [toTime, setToTime] = useState('11:00');


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

    const fetchCompanyName = async (compid) => {
        try {
            const response = await fetch(`http://localhost:5213/api/CompanyMasters/${compid}`);
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            const compname = await response.text();
            return compname;
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
            return compid; // Fallback to compid if there's an error
        }
    };

    const fetchLocationName = async (locationid) => {
        try {
            const response = await fetch(`http://localhost:5213/api/Locations/Name/${locationid}`);
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            const locationName = await response.text();
            return locationName;
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
            return locationid; // Fallback to locationid if there's an error
        }
    };

    const fetchDesignationName = async (designationid) => {
        try {
            const response = await fetch(`http://localhost:5213/api/Designations/Name/${designationid}`);
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            const designationName = await response.text();
            return designationName;
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
            return designationid; // Fallback to designationid if there's an error
        }
    };

    const fetchDepartmentName = async (deptname) => {
        try {
            const response = await fetch(`http://localhost:5213/api/Departments/Name/${deptname}`);
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            const departmentName = await response.text();
            return departmentName;
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
            return deptname; // Fallback to deptid if there's an error
        }
    };

    const fetchEmployeeMasters = async () => {
        try {
            setLoading(true);
            const response = await fetch('http://localhost:5213/api/Employee');
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            const data = await response.json();

            const updatedData = await Promise.all(data.map(async employee => {
                const compname = await fetchCompanyName(employee.compid);
                const locationName = await fetchLocationName(employee.locationid);
                const designationName = await fetchDesignationName(employee.designation);
                const departmentName = await fetchDepartmentName(employee.deptName);
                return { ...employee, compname, locationName, designationName, departmentName };
            }));



            setEmployeeMasters(updatedData);
            setAllEmployeeMasters(updatedData);
            console.log("Employee Masters: ", updatedData);
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        } finally {
            setLoading(false);
        }
    };


    const handleCheckboxChange = (srno) => {
        if (selectedRows.includes(srno)) {
            setSelectedRows(selectedRows.filter(row => row !== srno));
        } else {
            setSelectedRows([...selectedRows, srno]);
        }
    };


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
                    <h1 className="mb-4 ms-2">Department Wise Report</h1>
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
                                    <option value="">Department Wise Report</option>
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
                                <button className="btn btn-secondary w-80">Export</button>
                            </div>
                            <div className="col-md-3 mb-2">
                                <button className="btn btn-secondary w-80">Export For All</button>
                            </div>
                        </div>
                        <div className="ms-4">
                            <p className="lead fw-bold">Count: <span className="text-danger">{EmployeeMasters.length}</span></p>
                        </div>
                        <div className="table-responsive text-center">
                            <table className="table table-striped">
                                <thead>
                                    <tr><th></th>
                                        <th>Employee Code </th>
                                        <th>Name</th>
                                        <th>Card No.</th>
                                        <th>Company</th>
                                        <th>Location</th>
                                        <th>Department</th>
                                        <th>Sub-Dept</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    {loading ? (
                                        <tr>
                                            <td colSpan="8">
                                                <div className="loading-container">
                                                    <div className="spinner-border text-primary" role="status">
                                                        <span className="visually-hidden">Loading...</span>
                                                    </div>
                                                </div>
                                            </td>
                                        </tr>
                                    ) : (
                                        EmployeeMasters.map(EmployeeMaster => (
                                            <tr key={EmployeeMaster.srno}>
                                                <td>
                                                    <input
                                                        type="checkbox"
                                                        onChange={() => handleCheckboxChange(EmployeeMaster.srno)}
                                                        checked={selectedRows.includes(EmployeeMaster.srno)}
                                                    />
                                                </td>
                                                <td>{EmployeeMaster.empcode}</td>
                                                <td>{EmployeeMaster.fname}</td>
                                                <td>{EmployeeMaster.cardno}</td>
                                                <td>{EmployeeMaster.compname}</td>
                                                <td>{EmployeeMaster.locationName}</td>
                                                <td>{EmployeeMaster.departmentName}</td>
                                                <td></td>
                                            </tr>
                                        ))
                                    )}
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </>
    );
};

export default DepartmentWiseReport;
