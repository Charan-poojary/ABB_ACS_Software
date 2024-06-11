import React, { useState, useEffect, useRef } from 'react';
import '../../../assets/styles/fetchEmployee.css';
import '../../../assets/styles/Login.css'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPlus, faTrash, faSync, faEdit } from '@fortawesome/free-solid-svg-icons';

const Employee = () => {
    const [EmployeeMasters, setEmployeeMasters] = useState([]);
    const [allEmployeeMasters, setAllEmployeeMasters] = useState([]);
    const [selectedRows, setSelectedRows] = useState([]);

    /*const [editedCompanyMaster, setEditedCompanyMaster] = useState({
        srno: '',
        uname: '',
        pass: '',
        type: '',
    });
    const [newCompanyMaster, setNewCompanyMaster] = useState({
        srno: '',
        uname: '',
        pass: '',
        type: '',
    });*/
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

    const handleCheckboxChange = (srno) => {
        if (selectedRows.includes(srno)) {
            setSelectedRows(selectedRows.filter(row => row !== srno));
        } else {
            setSelectedRows([...selectedRows, srno]);
        }
    };
   /* const handleAddClick = async () => {


        if (!newCompanyMaster.uname || !newCompanyMaster.pass) {
            setError("Fields cannot be empty");
            return;
        }

        try {

            // Check if Admin name exists
            const checkResponse = await fetch(`http://localhost:5213/api/Admin/check-username?username=${newCompanyMaster.uname}`);
            if (!checkResponse.ok) {
                throw new Error('Network response was not ok');
            }
            const checkData = await checkResponse.json();
            if (checkData.exists) {
                setError('Admin already exists.');
                return;
            }
            else {
                const response = await fetch('http://localhost:5213/api/Admin', {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json',
                    },
                    body: JSON.stringify({
                        uname: newCompanyMaster.uname,
                        pass: newCompanyMaster.pass,
                        type: newCompanyMaster.type,
                    }),
                });

                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }

                setSuccessMessage('New Admin added successfully');
                setNewCompanyMaster({
                    srno: '',
                    uname: '',
                    pass: '',
                    type: '',
                });
            }
            setTimeout(() => {
                const addModalElement1 = document.getElementById('addModal');
                const addModalInstance1 = bootstrap.Modal.getInstance(addModalElement1);
                addModalInstance1.hide();
            }, 1000);
            fetchCompanyMasters();
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        }
    };

    const handleEdit = (companyMaster) => {
        setEditedCompanyMaster(companyMaster);
    };

    const handleCancel = async () => {
        // Clear the state
        setEditedCompanyMaster({
            srno: '',
            uname: '',
            pass: '',
            type: '',
        });

        setNewCompanyMaster({
            srno: '',
            uname: '',
            pass: '',
            type: '',
        });

        setError('');
        setSuccessMessage('');

        // Close the edit modal
        const editModalElement = document.getElementById('editModal');
        if (editModalElement) {
            const editModalInstance = bootstrap.Modal.getInstance(editModalElement);
            if (editModalInstance) {
                editModalInstance.hide();
            }
        }

        // Close the add modal
        const addModalElement = document.getElementById('addModal');
        if (addModalElement) {
            const addModalInstance = bootstrap.Modal.getInstance(addModalElement);
            if (addModalInstance) {
                addModalInstance.hide();
            }
        }
    };


    const handleSave = async () => {



        if (!editedCompanyMaster.uname || !editedCompanyMaster.pass) {
            setError("Fields cannot be empty");
            return;
        }

        try {
            // Check if Admin name exists
            const checkResponse = await fetch(`http://localhost:5213/api/Admin/check-username?username=${editedCompanyMaster.uname}`);
            if (!checkResponse.ok) {
                throw new Error('Network response was not ok');
            }
            const checkData = await checkResponse.json();
            if (checkData.exists) {
                setError('Admin name already exists.');
                return;
            }
            else {
                const response = await fetch(`http://localhost:5213/api/CompanyMasters/${editedCompanyMaster.srno}`, {
                    method: 'PUT',
                    headers: {
                        'Content-Type': 'application/json',
                    },
                    body: JSON.stringify(editedCompanyMaster),
                });

                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }

                setSuccessMessage('Data updated successfully');
                setEditedCompanyMaster({
                    srno: '',
                    compname: '',
                    details: '',
                    phno: '',
                    emailid: ''
                });
            }
            setTimeout(() => {
                const editModalElement1 = document.getElementById('editModal');
                const editModalInstance1 = bootstrap.Modal.getInstance(editModalElement1);
                editModalInstance1.hide();
            }, 1000);

            fetchCompanyMasters();
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        }
    };*/

    const [searchParams, setSearchParams] = useState({
        compid: '',
        locationid: '',
        deptname: '',
        status: '',
        designation: '',
        section: '',
    });

    const handleSearchInputChange = (event) => {
        const { name, value } = event.target;
        setSearchParams(
            (prevState) => ({
                ...prevState,
                [name]: value,
            })
        );
    };

    const handleSearch = async () => {
        try {
            setLoading(true);

            // Filter the stored employee data based on search parameters
            const filteredData = allEmployeeMasters.filter(employee => {
                return (
                    (searchParams.compid ? employee.compid === searchParams.compid : true) &&
                    (searchParams.locationid ? employee.locationid === searchParams.locationid : true) &&
                    (searchParams.deptname ? employee.deptName.includes(searchParams.deptname) : true) &&
                    (searchParams.subdeptname ? employee.subdeptname.includes(searchParams.subdeptname) : true)
                );
            });

            setSearchParams({
                compid: '',
                locationid: '',
                deptname: '',
                status: '',
                subdeptname: '',
                designation: '',
                section: '',
            });

            console.log("filter", filteredData);

            setEmployeeMasters(filteredData);
        } catch (error) {
            console.error('There was a problem with your search operation:', error);
        } finally {
            setLoading(false);
        }
    };

 /*   const handleInputChange = (event) => {
        const { name, value } = event.target;
        setEditedCompanyMaster({
            ...editedCompanyMaster,
            [name]: value
        });
    };

    const handleAddInputChange = (event) => {
        const { name, value } = event.target;
        setNewCompanyMaster({
            ...newCompanyMaster,
            [name]: value
        });
    }


    const handleDeleteConfirmation = (srno) => {
        const isConfirmed = window.confirm('Are you sure you want to delete the company?');

        if (isConfirmed) {
            handleDelete(srno);
        }
    };


    const handleSelectdDeleteConfirmation = () => {
        const isConfirmed = window.confirm('Are you sure you want to delete the records?');

        if (isConfirmed) {
            handleSelectedDelete();
        }
    };

    const handleDelete = async (srno) => {
        try {
            const response = await fetch(`http://localhost:5213/api/Admin/${srno}`, {
                method: 'DELETE',
            });

            if (!response.ok) {
                throw new Error('Network response was not ok');
            }

            console.log('Data deleted successfully');
            fetchCompanyMasters();
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        }
    };

    const handleSelectedDelete = async () => {
        try {
            await Promise.all(selectedRows.map(async (srno) => {
                const response = await fetch(`http://localhost:5213/api/Admin/${srno}`, {
                    method: 'DELETE',
                });

                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }

            }));

            setSelectedRows([]);
            fetchCompanyMasters();
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        }
    };*/



    return (
        <>

            <div className="container employeeContainer mt-2 justify-content-center align-items-start">
                <div className='card'>
                    <h1 className="mb-4 ms-2">Create Employee Login</h1>
                    <div className='container-fluid mb-4'>
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
                            <div className="col-md-3 mt-1">
                                <button className="custom-btn danger mt-3" onClick={handleSearch}>Search</button>
                            </div>
                            <div className="col-md-3 mt-1">
                                <button className="custom-btn secondary mt-3" >Clear username and password</button>
                            </div>
                            <div className="col-md-3 mt-1">
                                <button className="custom-btn primary mt-3" >Save</button>
                            </div>
                        </div>
                    </div>
                    <div className="ms-4">
                        <p className="lead fw-bold">Count: <span className="text-danger">{EmployeeMasters.length}</span></p>
                    </div>
                    <div className="ms-4">
                        <input
                            type="checkbox"
                        />
                        <label>&nbsp;Check All</label>
                    </div>

                    <div className="table-responsive text-center">
                        <table className="table table-striped">
                            <thead>
                                <tr><th></th>
                                    <th>Enrollment No</th>
                                    <th>Employee Code </th>
                                    <th>Name</th>
                                    <th>VMS Login</th>
                                    <th>Username</th>
                                    <th>Password</th>
                                    <th>Head Mobile Auth</th>
                                    <th>Head Laptop Auth</th>
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
                                            <td>No</td>
                                            <td>
                                                <input
                                                    type="text"
                                                    name="input1"
                                                />
                                            </td>
                                            <td>
                                                <input
                                                    type="text"
                                                    name="input2"
                                                />
                                            </td>
                                            <td>
                                                <input
                                                    type="text"
                                                    name="input3"
                                                />
                                            </td>
                                            <td>
                                                <input
                                                    type="text"
                                                    name="input4"
                                                />
                                            </td>
                                            <td>
                                            </td>
                                        </tr>
                                    ))
                                )}
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>



        </>
    );
};

export default Employee;