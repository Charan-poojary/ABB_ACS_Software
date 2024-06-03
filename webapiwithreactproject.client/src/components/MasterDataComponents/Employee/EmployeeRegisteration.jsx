import React, { useState, useEffect, useRef } from 'react';
import '../../../assets/styles/fetchEmployee.css';
import '../../../assets/styles/Login.css';
import 'bootstrap-datepicker/dist/css/bootstrap-datepicker.min.css';
import $ from 'jquery';
import 'bootstrap-datepicker';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPlus, faSync, faTrash,faCalendar } from '@fortawesome/free-solid-svg-icons';

const EmployeeRegisteration = () => {
    const [EmployeeMasters, setEmployeeMasters] = useState([]);
    const [allEmployeeMasters, setAllEmployeeMasters] = useState([]);
    const [selectedRows, setSelectedRows] = useState([]);
    const [validFrom, setValidFrom] = useState('');
    const [validTo, setValidTo] = useState('');

    const [searchParams, setSearchParams] = useState({
        empcode: '',
        fname: '',
        cardno:'',
        compid: '',
        locationid: '',
        deptname: '',
    });
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
                const departmentName = await fetchDepartmentName(employee.deptName);
                return { ...employee, compname, locationName, departmentName };
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



    const handleRefresh = () => {
        fetchEmployeeMasters();
    };


    const handleSearchInputChange = (event) => {
        const { name, value } = event.target;
        setSearchParams(
            (prevState) => ({
                ...prevState,
                [name]: value,
            })
        );
    };


    const handleCheckboxChange = (srno) => {
        if (selectedRows.includes(srno)) {
            setSelectedRows(selectedRows.filter(row => row !== srno));
        } else {
            setSelectedRows([...selectedRows, srno]);
        }
    };



    const handleSearch = async () => {
        try {
            setLoading(true);

            // Filter the stored employee data based on search parameters
            const filteredData = allEmployeeMasters.filter(employee => {
                return (
                    (searchParams.empcode ? employee.empcode === searchParams.empcode : true) &&
                    (searchParams.fname ? employee.fname === searchParams.fname : true) &&
                    (searchParams.cardno ? employee.cardno === searchParams.cardno : true) &&
                    (searchParams.compid ? employee.compid === searchParams.compid : true) &&
                    (searchParams.locationid ? employee.locationid === searchParams.locationid : true) &&
                    (searchParams.deptname ? employee.deptName.includes(searchParams.deptname) : true) &&
                    (searchParams.subdeptname ? employee.subdeptname.includes(searchParams.subdeptname) : true)
                );
            });

            setSearchParams({
                empcode: '',
                fname: '',
                cardno: '',
                compid: '',
                locationid: '',
                deptname: '',
            });

            console.log("filter", filteredData);

            setEmployeeMasters(filteredData);
        } catch (error) {
            console.error('There was a problem with your search operation:', error);
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
            <div className="container employeeContainer mt-2 justify-content-center align-items-start">
                <div className='card'>
                    <h1 className="mb-4 ms-2">Employee Registeration</h1>
                    <div className='container-fluid mb-4'>
                        <h5 className="mb-4">Search Existing Employee</h5>
                        <div className="row mb-4">
                            <div className="col-md-3 mb-2">
                                <label htmlFor="compid" className="form-label2">Company:</label>
                                <select
                                    className="form-select form-control border border-dark"
                                    name="compid"
                                    value={searchParams.compid}
                                    onChange={handleSearchInputChange}
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
                                    value={searchParams.locationid}
                                    onChange={handleSearchInputChange}
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
                                    value={searchParams.deptname}
                                    onChange={handleSearchInputChange}
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
                                <label htmlFor="empcode" className="form-label2">Empcode:</label>
                                <input
                                    type="text"
                                    className="form-control border border-dark"
                                    name="empcode"
                                    value={searchParams.empcode}
                                    onChange={handleSearchInputChange}
                                />
                            </div>
                            <div className="col-md-3 mb-2">
                                <label htmlFor="fname" className="form-label2">Name:</label>
                                <input
                                    type="text"
                                    className="form-control border border-dark"
                                    name="fname"
                                    value={searchParams.fname}
                                    onChange={handleSearchInputChange}
                                />
                            </div>
                            <div className="col-md-3 mb-2">
                                <label htmlFor="cardno" className="form-label2">Card No:</label>
                                <input
                                    type="text"
                                    className="form-control border border-dark"
                                    name="cardno"
                                    value={searchParams.cardno}
                                    onChange={handleSearchInputChange}
                                />
                            </div>
                            <div className="col-md-3 mt-3">
                                <button className="custom-btn danger mt-3" onClick={handleSearch}>Search</button>
                            </div>
                        </div>



                        {/*  Card and Access group SECTION*/}

                        <h5 className="mb-4"> Card and Access group</h5>
                        <div className="row mb-4">
                            <div className="col-md-3 mb-2">
                                <label>Apply </label>
                                <br/>
                                <input
                                    type="checkbox"
                                />
                            </div>
                            <div className="col-md-3 mb-2">
                                <label>Valid From</label>
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
                                <label>Valid To</label>
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
                        </div>

                        <div className="row mb-4">
                            <div className="col-md-3 mb-2 ">
                                <label>Appl[y </label>
                                <br />
                                <input
                                    type="checkbox"
                                />
                            </div>
                            <div className="col-md-3 mb-2">
                                <label>Access Type</label>

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
                                <label>Controller Group</label>
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
                            </div>

                        <div className="row mb-4">
                            <div className="col-md-6">
                                <div className="table-responsive" style={{ height: '200px', overflowX: 'auto' }}>
                                    <h5>Access Groups</h5>

                                    <table className="table table-bordered">
                                        <thead>
                                            <tr>
                                                <th>Select</th>
                                                <th>Access Group</th>
                                                <th>Controllers</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td>
                                                    <input
                                                        type="checkbox"
                                                    />
                                                </td>
                                                <td>Data 2</td>
                                                <td>Data 3</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                            <div className="col-md-6">
                                <div className="table-responsive" style={{ height: '200px', overflowX: 'auto'}} >
                                    <h5>Controllers</h5>

                                    <table className="table table-bordered">
                                        <thead>
                                            <tr>
                                                <th>Select</th>
                                                <th>Controller</th>
                                                <th>IP</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td>
                                                    <input
                                                        type="checkbox"
                                                    />
                                                </td>
                                                <td>Data B1</td>
                                                <td>Data C1</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>


                        <div className="row mb-4">
                            <div className="col-md-2 col-sm-4 col-6 mb-2">
                                <button className="btn btn-primary w-80">Save</button>
                            </div>
                            <div className="col-md-2 col-sm-4 col-6 mb-2">
                                <button className="btn btn-secondary w-80">Register</button>
                            </div>
                            <div className="col-md-2 col-sm-4 col-6 mb-2">
                                <button className="btn btn-secondary w-80">Unreg</button>
                            </div>
                            <div className="col-md-2 col-sm-4 col-6 mb-2">
                                <input
                                    type="checkbox"
                                />
                               <label>Is Blacklist</label>
                            </div>
                            <div className="col-md-2 col-sm-4 col-6 mb-2">
                                <label>Reason:</label>
                                <input
                                    type="text"
                                    className="form-control border border-dark"
                                    name="cardno"
                                    value={searchParams.cardno}
                                    onChange={handleSearchInputChange}
                                />

                            </div>
                            <div className="col-md-2 col-sm-4 col-6 mb-2">
                                <button className="btn btn-danger w-100">BlackList</button>
                            </div>
                        </div>


                        <div className="row">
                        </div>
                    </div>
                    <div className="ms-4">
                        <p className="lead fw-bold">Count: <span className="text-danger">{EmployeeMasters.length}</span></p>
                    </div>

                    <div className="table-responsive text-center" style={{ height: '800px', overflowX: 'auto' }}>
                        <table className="table table-striped ">
                            <thead>
                                <tr><th></th>
                                    <th>Id</th>
                                    <th>Code </th>
                                    <th>Name</th>
                                    <th>Card No</th>
                                    <th>Pin</th>
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
                                            <td>{EmployeeMaster.empid}</td>
                                            <td>{EmployeeMaster.empcode}</td>
                                            <td>{EmployeeMaster.fname}</td>
                                            <td>{EmployeeMaster.cardno}</td>
                                            <td>{EmployeeMaster.pin}</td>
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
            </div >

        
        </>
    );
};

export default EmployeeRegisteration;
