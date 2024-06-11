import React, { useState, useEffect, useRef } from 'react';
import '../../../assets/styles/fetchEmployee.css';
import '../../../assets/styles/Login.css'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPlus, faTrash, faSync, faEdit } from '@fortawesome/free-solid-svg-icons';

const SectionAdmin = () => {
   /* const [companyMasters, setCompanyMasters] = useState([]);
    const [selectedRows, setSelectedRows] = useState([]);
    const [editedCompanyMaster, setEditedCompanyMaster] = useState({
        srno: '',
        uname: '',
        pass: '',
        type: '',
    });*/
    const [newCompanyMaster, setNewCompanyMaster] = useState({
        srno: '',
        uname: '',
        pass: '',
        type: '',
    });
    const [error, setError] = useState('');
    const [successMessage, setSuccessMessage] = useState('');
/*    const [loading, setLoading] = useState(false);*/

    const timeoutRef = useRef(null);

    useEffect(() => {
        timeoutRef.current = setTimeout(() => {
            setError('');
            setSuccessMessage('');
        }, 1000);

        return () => clearTimeout(timeoutRef.current);
    }, [error, successMessage]);

   /* useEffect(() => {
        fetchCompanyMasters();
    }, []);

    const fetchCompanyMasters = async () => {
        try {
            setLoading(true);
            const response = await fetch('http://localhost:5213/api/Admin');
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            const data = await response.json();
            setCompanyMasters(data);
            console.log(data);
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
    const handleAddClick = async () => {


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
    };*/

    const handleCancel = async () => {
        // Clear the state
/*        setEditedCompanyMaster({
            srno: '',
            uname: '',
            pass: '',
            type: '',
        });*/

        setNewCompanyMaster({
            srno: '',
            uname: '',
            pass: '',
            type: '',
        });

        setError('');
        setSuccessMessage('');

        // Close the edit modal
/*        const editModalElement = document.getElementById('editModal');
        if (editModalElement) {
            const editModalInstance = bootstrap.Modal.getInstance(editModalElement);
            if (editModalInstance) {
                editModalInstance.hide();
            }
        }*/

        // Close the add modal
        const addModalElement = document.getElementById('addModal');
        if (addModalElement) {
            const addModalInstance = bootstrap.Modal.getInstance(addModalElement);
            if (addModalInstance) {
                addModalInstance.hide();
            }
        }
    };

/*
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
    };

    const handleRefresh = () => {
        fetchCompanyMasters();
    };

    const handleInputChange = (event) => {
        const { name, value } = event.target;
        setEditedCompanyMaster({
            ...editedCompanyMaster,
            [name]: value
        });*/
/*    };*/

    const handleAddInputChange = (event) => {
        const { name, value } = event.target;
        setNewCompanyMaster({
            ...newCompanyMaster,
            [name]: value
        });
    }


/*    const handleDeleteConfirmation = (srno) => {
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
                    <h1 className="mb-4 ms-2">Section Admin</h1>
                    <div className='container-fluid mb-4'>
                        <button className="custom-btn primary"
                            data-bs-toggle="modal" data-bs-target="#addModal"
                        >
                            <FontAwesomeIcon icon={faPlus} className="me-2" />
                            Add
                        </button>
                        <button
                            className="custom-btn danger ms-2"
                            disabled
                            style={{ opacity: "0.5" }}
                        >
                            <FontAwesomeIcon icon={faTrash} className="me-2" />
                            Delete
                        </button>
                        <button className="custom-btn secondary float-end">
                            <FontAwesomeIcon icon={faSync} />
                        </button>
                    </div>
                    <div className="ms-4">
                        <p className="lead fw-bold">Count: <span className="text-danger">0</span></p>
                    </div>

{/*                    <div className="table-responsive text-center">
                        <table className="table table-striped">
                            <thead>
                                <tr>
                                    <th>Select</th>
                                    <th>User Id</th>
                                    <th>User Type</th>
                                    <th></th>
                                    <th></th>
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
                                    companyMasters.map(companyMaster => (
                                        <tr key={companyMaster.srno}>
                                            <td>
                                                <input
                                                    type="checkbox"
                                                    onChange={() => handleCheckboxChange(companyMaster.srno)}
                                                    checked={selectedRows.includes(companyMaster.srno)}
                                                />
                                            </td>
                                            <td>{companyMaster.uname}</td>
                                            <td>{companyMaster.type}</td>
                                            <td></td>
                                            <td></td>
                                            <td>
                                                <button className="btn btn-primary btn-sm" data-bs-toggle="modal" data-bs-target="#editModal" onClick={() => handleEdit(companyMaster)}>
                                                    <FontAwesomeIcon icon={faEdit} />
                                                </button>
                                            </td>
                                            <td>
                                                <button className="btn btn-danger btn-sm" onClick={() => handleDeleteConfirmation(companyMaster.srno)}>
                                                    <FontAwesomeIcon icon={faTrash} />
                                                </button>
                                            </td>
                                        </tr>
                                    ))
                                )}
                            </tbody>
                        </table>
                    </div>*/}
                </div>
            </div>


            <div className="modal fade" tabIndex="-1" id="addModal" aria-labelledby="addCompanyMasterModalLabel" aria-hidden="true">
                <div className="modal-dialog modal-lg">
                    <div className="modal-content">
                        {error && <div className="alert alert-danger" role="alert">{error}</div>}
                        {successMessage && <div className="alert alert-success">{successMessage}</div>}
                        <div className="modal-header">
                            <h5 className="modal-title" id="addCompanyMasterModalLabel">Create Section Admin</h5>
                            <button type="button" className="btn-close" data-bs-dismiss="modal" aria-label="Close" onClick={handleCancel}></button>
                        </div>
                        <div className="modal-body">
                            <div className="row">
                                <div className="col-md-6">
                                    <h6>Form Rights</h6>
                                    <table className="table table-bordered">
                                        <thead>
                                            <tr>
                                                <th>Form Rights</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td>Data</td>
                                            </tr>
                                            {/* Add more rows as needed */}
                                        </tbody>
                                    </table>
                                </div>
                                <div className="col-md-6">
                                    <div className="mb-4">
                                        <h6>Controllers</h6>
                                        <table className="table table-bordered">
                                            <thead>
                                                <tr>
                                                    <th>Controllers</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr>
                                                    <td>Data</td>
                                                </tr>
                                                {/* Add more rows as needed */}
                                            </tbody>
                                        </table>
                                    </div>
                                    <div className="mb-4">
                                        <h6>Access Groups</h6>
                                        <table className="table table-bordered">
                                            <thead>
                                                <tr>
                                                    <th>Access Groups</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr>
                                                    <td>Data</td>
                                                </tr>
                                                {/* Add more rows as needed */}
                                            </tbody>
                                        </table>
                                    </div>
                                    <div className="mb-4">
                                        <h6>Form Name</h6>
                                        <table className="table table-bordered">
                                            <thead>
                                                <tr>
                                                    <th>Form Name</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr>
                                                    <td>Data</td>
                                                </tr>
                                                {/* Add more rows as needed */}
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                            <div className="row mt-4">
                                <div className="col-md-4">
                                    <div className="input_text">
                                        <label htmlFor="section" className="form-label2">Select Section</label>
                                        <select className="form-control2" id="section" name="section" onChange={handleAddInputChange}>
                                            {/* Add options here */}
                                        </select>
                                    </div>
                                </div>
                                <div className="col-md-4">
                                    <div className="input_text">
                                        <label htmlFor="employee" className="form-label2">Select Employee</label>
                                        <select className="form-control2" id="employee" name="employee" onChange={handleAddInputChange}>
                                            {/* Add options here */}
                                        </select>
                                    </div>
                                </div>
                                <div className="col-md-4">
                                    <div className="input_text">
                                        <label htmlFor="email" className="form-label2">Email</label>
                                        <input type="email" className="form-control2" id="email" name="email" value={newCompanyMaster.email} onChange={handleAddInputChange} />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div className="modal-footer">
                            <div className="cancelBtn">
                                <button type="button" onClick={handleCancel}>Cancel</button>
                            </div>
                            <div className="btn">
                                <button type="submit">Save</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>


        </>
    );
};

export default SectionAdmin;