import React, { useState, useEffect,useRef } from 'react';
import '../../assets/styles/fetchEmployee.css';
import '../../assets/styles/Login.css'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPlus, faTrash, faSync, faEdit } from '@fortawesome/free-solid-svg-icons';

const CompanyMaster = () => {
    const [companyMasters, setCompanyMasters] = useState([]);
    const [selectedRows, setSelectedRows] = useState([]);
    const [editedCompanyMaster, setEditedCompanyMaster] = useState({
        srno: '',
        compname: '',
        details: '',
        phno: '',
        emailid: ''
    });
    const [newCompanyMaster, setNewCompanyMaster] = useState({
        compname: '',
        details: '',
        phno: '',
        emailid: ''
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
        fetchCompanyMasters();
    }, []);

    const fetchCompanyMasters = async () => {
        try {
            setLoading(true);
            const response = await fetch('http://localhost:5213/api/CompanyMasters');
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


        if (!newCompanyMaster.compname) {
            setError("Company Name cannot be empty");
            return;
        }

        const phone1 = newCompanyMaster.phno;

        const isValidPhoneNumber = (phone1) => {
            return /^\d{10}$/.test(phone1);
        };


        if (!isValidPhoneNumber(phone1)) {
            setError('Invalid phone number. Please enter a 10-digit numeric phone number.');
            return;

        }

        try {
            const checkResponse = await fetch(`http://localhost:5213/api/CompanyMasters/CheckCompanyName/${newCompanyMaster.compname}`);
            if (!checkResponse.ok) {
                throw new Error('Network response was not ok');
               
            }
            const checkData = await checkResponse.json();
            if (checkData.exists) {
                setError('Company name already exists.');
                return;
            }
                const response = await fetch('http://localhost:5213/api/CompanyMasters', {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json',
                    },
                    body: JSON.stringify(newCompanyMaster),
                });

                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }

                setSuccessMessage('New company added successfully');

                setNewCompanyMaster({
                    compname: '',
                    details: '',
                    phno: '',
                    emailid: ''
                });
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
            compname: '',
            details: '',
            phno: '',
            emailid: ''
        });

        setNewCompanyMaster({
            compname: '',
            details: '',
            phno: '',
            emailid: ''
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



        if (!editedCompanyMaster.compname) {
            setError("Company Name cannot be empty");
            return;
        }


        const phone = editedCompanyMaster.phno;

        const isValidPhoneNumber = (phone) => {
            return /^\d{10}$/.test(phone);
        };


        if (!isValidPhoneNumber(phone)) {
            setError('Invalid phone number. Please enter a 10-digit numeric phone number.');
            return;
        }


        try {

            const checkResponse = await fetch(`http://localhost:5213/api/CompanyMasters/CheckCompanyName/${newCompanyMaster.compname}`);
            if (!checkResponse.ok) {
                throw new Error('Network response was not ok');

            }
            const checkData = await checkResponse.json();
            if (checkData.exists) {
                setError('Company name already exists.');
                return;
            }
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
            const response = await fetch(`http://localhost:5213/api/CompanyMasters/${srno}`, {
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
                const response = await fetch(`http://localhost:5213/api/CompanyMasters/${srno}`, {
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
    };



    return (
        <>

            <div className="container employeeContainer mt-2 justify-content-center align-items-start">
                <div className='card'>
                    <h1 className="mb-4 ms-2">Company Master</h1>
                    <div className='container-fluid mb-4'>
                        <button className="custom-btn primary"
                            data-bs-toggle="modal" data-bs-target="#addModal"
                        >
                            <FontAwesomeIcon icon={faPlus} className="me-2" />
                            Add
                        </button>
                        <button
                            className={`custom-btn danger ms-2 ${selectedRows.length === 0 ? 'disabled' : ''}`}
                            onClick={handleSelectdDeleteConfirmation}
                            disabled={selectedRows.length === 0}
                            style={{ opacity: selectedRows.length === 0 ? 0.5 : 1, pointerEvents: selectedRows.length === 0 ? 'none' : 'auto' }}
                        >
                            <FontAwesomeIcon icon={faTrash} className="me-2" />
                            Delete
                        </button>
                        <button className="custom-btn secondary float-end" onClick={handleRefresh}>
                            <FontAwesomeIcon icon={faSync} />
                        </button>
                    </div>
                    <div className="ms-4">
                        <p className="lead fw-bold">Count: <span className="text-danger">{companyMasters.length}</span></p>
                    </div>

                    <div className="table-responsive text-center">
                        <table className="table table-striped">
                            <thead>
                                <tr>
                                    <th>Select</th>
                                    <th>Sno</th>
                                    <th>Compname</th>
                                    <th>Detailes</th>
                                    <th>Phone </th>
                                    <th>Email</th>
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
                                            <td>{companyMaster.srno}</td>
                                            <td>{companyMaster.compname}</td>
                                            <td>{companyMaster.details}</td>
                                            <td>{companyMaster.phno}</td>
                                            <td>{companyMaster.emailid}</td>
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
                    </div>
                </div>
            </div>


<div className="modal fade" tabIndex="-1" id="addModal" aria-labelledby="addCompanyMasterModalLabel" aria-hidden="true">
    <div className="modal-dialog">
        <div className="modal-content">
            {error && <div className="alert alert-danger" role="alert">{error}</div>}
            {successMessage && <div className="alert alert-success">{successMessage}</div>}
            <div className="modal-header">
                <h5 className="modal-title" id="addCompanyMasterModalLabel">Add Company Master</h5>
                <button type="button" className="btn-close" data-bs-dismiss="modal" aria-label="Close" onClick={handleCancel}></button>
            </div>
            <div className="modal-body">
                <div className="input_text">
                    <label htmlFor="editCompname" className="form-label2">Company Name</label>
                    <input type="text" className="form-control2" id="editCompname" name="compname" value={newCompanyMaster.compname} onChange={handleAddInputChange} />
                </div>
                <div className="input_text">
                    <label htmlFor="editDetailes" className="form-label2">Detailes</label>
                    <input type="text" className="form-control2" id="editDetailes" name="details" value={newCompanyMaster.details} onChange={handleAddInputChange} />
                </div>
                <div className="input_text">
                    <label htmlFor="phno" className="form-label2">Phone</label>
                    <input type="number" className="form-control2" id="phno" name="phno" value={newCompanyMaster.phno} onChange={handleAddInputChange} />
                </div>
                <div className="input_text">
                    <label htmlFor="emailid" className="form-label2">Email</label>
                    <input type="email" className="form-control2" id="emailid" name="emailid" value={newCompanyMaster.emailid} onChange={handleAddInputChange} />
                </div>
            </div>
            <div className="modal-footer">
                <div className="cancelBtn">
                    <button type="button" onClick={handleCancel}>Cancel</button>
                </div>
                <div className="btn">
                    <button type="submit" onClick={handleAddClick}>Save</button>
                </div>
            </div>
        </div>
    </div>
</div>

<div className="modal fade" tabIndex="-1" id="editModal" aria-labelledby="editCompanyMasterModalLabel" aria-hidden="true">
    <div className="modal-dialog">
        <div className="modal-content">
            {error && <div className="alert alert-danger" role="alert">{error}</div>}
            {successMessage && <div className="alert alert-success">{successMessage}</div>}
            <div className="modal-header">
                <h5 className="modal-title" id="editCompanyMasterModalLabel">Edit Company Master</h5>
                <button type="button" className="btn-close" data-bs-dismiss="modal" aria-label="Close" onClick={handleCancel}></button>
            </div>
            <div className="modal-body">
                <div className="input_text">
                    <label htmlFor="editCompname" className="form-label2">Company Name</label>
                    <input type="text" className="form-control2" id="editCompname" name="compname" value={editedCompanyMaster.compname} onChange={handleInputChange} />
                </div>
                <div className="input_text">
                    <label htmlFor="editDetailes" className="form-label2">Detailes</label>
                    <input type="text" className="form-control2" id="editDetailes" name="details" value={editedCompanyMaster.details} onChange={handleInputChange} />
                </div>
                <div className="input_text">
                    <label htmlFor="editPhone" className="form-label2">Phone</label>
                    <input type="number" className="form-control2" id="editPhone" name="phno" value={editedCompanyMaster.phno} onChange={handleInputChange} />
                </div>
                <div className="input_text">
                    <label htmlFor="editEmail" className="form-label2">Email</label>
                    <input type="email" className="form-control2" id="editEmail" name="emailid" value={editedCompanyMaster.emailid} onChange={handleInputChange} />
                </div>
            </div>
            <div className="modal-footer">
                <div className="cancelBtn">
                    <button type="button" onClick={handleCancel}>Cancel</button>
                </div>
                <div className="btn">
                    <button type="submit" onClick={handleSave}>Save changes</button>
                </div>
            </div>
        </div>
    </div>
</div>


        </>
    );
};

export default CompanyMaster;