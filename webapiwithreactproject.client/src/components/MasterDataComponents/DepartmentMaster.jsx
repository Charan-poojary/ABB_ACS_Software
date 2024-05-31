import React, { useState, useEffect, useRef } from 'react';
import '../../assets/styles/fetchEmployee.css';
import '../../assets/styles/Login.css'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPlus, faTrash, faSync, faEdit } from '@fortawesome/free-solid-svg-icons';

const DepartmentMaster = () => {
    const [departmentMasters, setDepartmentMasters] = useState([]);
    const [selectedRows, setSelectedRows] = useState([]);
    const [editedDepartmentMaster, setEditedDepartmentMaster] = useState({
        srNo: '',
        deptName: '',
    });
    const [newDepartmentMaster, setNewDepartmentMaster] = useState({
        srNo: '',
        deptName: '',
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
        fetchDepartmentMasters();
    }, []);

    const fetchDepartmentMasters = async () => {
        try {
            setLoading(true);
            const response = await fetch('http://localhost:5213/api/Departments');
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            const data = await response.json();
            setDepartmentMasters(data);
            console.log("here ", data);
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


        if (!newDepartmentMaster.deptName) {
            setError("Fields cannot be empty");
            return;
        }

        try {

            // Check if department exists
            const checkResponse = await fetch(`http://localhost:5213/api/Departments/CheckDepartments/${newDepartmentMaster.deptName}`);
            if (!checkResponse.ok) {
                throw new Error('Network response was not ok');
            }
            const checkData = await checkResponse.json();
            if (checkData.exists) {
                setError('Department already exists.');
                return;
            }
            else {
                const response = await fetch('http://localhost:5213/api/Departments', {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json',
                    },
                    body: JSON.stringify({
                        deptName: newDepartmentMaster.deptName,
                    }),
                });

                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }

                setSuccessMessage('New Department added successfully');
                setNewDepartmentMaster({
                    srNo: '',
                    deptName: '',
                });
            }
            setTimeout(() => {
                const addModalElement1 = document.getElementById('addModal');
                const addModalInstance1 = bootstrap.Modal.getInstance(addModalElement1);
                addModalInstance1.hide();
            }, 1000);
            fetchDepartmentMasters();
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        }
    };

    const handleEdit = (departmentMaster) => {
        setEditedDepartmentMaster(departmentMaster);
    };

    const handleCancel = async () => {
        // Clear the state
        setEditedDepartmentMaster({
            srNo: '',
            deptName: '',
        });

        setNewDepartmentMaster({
            srNo: '',
            deptName: '',
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

        if (!editedDepartmentMaster.deptName) {
            setError("Fields cannot be empty");
            return;
        }

        try {
            // Check if department exists
            const checkResponse = await fetch(`http://localhost:5213/api/Departments/CheckDepartments/${editedDepartmentMaster.deptName}`);
            if (!checkResponse.ok) {
                throw new Error('Network response was not ok');
            }
            const checkData = await checkResponse.json();
            if (checkData.exists) {
                setError('Department already exists.');
                return;
            }
            else {
                const response = await fetch(`http://localhost:5213/api/Departments/${editedDepartmentMaster.srNo}`, {
                    method: 'PUT',
                    headers: {
                        'Content-Type': 'application/json',
                    },
                    body: JSON.stringify({
                        srNo: editedDepartmentMaster.srNo,
                        deptName:editedDepartmentMaster.deptName,
                    }),
                });

                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }

                setSuccessMessage('Data updated successfully');
                setEditedDepartmentMaster({
                    srNo: '',
                    deptName: '',
                });
            }
            setTimeout(() => {
                const editModalElement1 = document.getElementById('editModal');
                const editModalInstance1 = bootstrap.Modal.getInstance(editModalElement1);
                editModalInstance1.hide();
            }, 1000);

            fetchDepartmentMasters();
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        }
    };

    const handleRefresh = () => {
        fetchDepartmentMasters();
    };

    const handleInputChange = (event) => {
        const { name, value } = event.target;
        setEditedDepartmentMaster({
            ...editedDepartmentMaster,
            [name]: value
        });
    };

    const handleAddInputChange = (event) => {
        const { name, value } = event.target;
        setNewDepartmentMaster({
            ...newDepartmentMaster,
            [name]: value
        });
    }


    const handleDeleteConfirmation = (srNo) => {
        const isConfirmed = window.confirm('Are you sure you want to delete the department?');

        if (isConfirmed) {
            handleDelete(srNo);
        }
    };


    const handleSelectdDeleteConfirmation = () => {
        const isConfirmed = window.confirm('Are you sure you want to delete the records?');

        if (isConfirmed) {
            handleSelectedDelete();
        }
    };

    const handleDelete = async (srNo) => {
        try {
            const response = await fetch(`http://localhost:5213/api/Departments/${srNo}`, {
                method: 'DELETE',
            });

            if (!response.ok) {
                throw new Error('Network response was not ok');
            }

            console.log('Data deleted successfully');
            fetchDepartmentMasters();
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        }
    };

    const handleSelectedDelete = async () => {
        try {
            await Promise.all(selectedRows.map(async (srNo) => {
                const response = await fetch(`http://localhost:5213/api/Departments/${srNo}`, {
                    method: 'DELETE',
                });

                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }

            }));

            setSelectedRows([]);
            fetchDepartmentMasters();
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        }
    };



    return (
        <>
            <div className="container employeeContainer mt-2 justify-content-center align-items-start">
                <div className='card'>
                    <h1 className="mb-4 ms-2">Department Master</h1>
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
                        <p className="lead fw-bold">Count: <span className="text-danger">{departmentMasters.length}</span></p>
                    </div>

                    <div className="table-responsive text-center">
                        <table className="table table-striped">
                            <thead>
                                <tr>
                                    <th>Select</th>
                                    <th>Departments</th>
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
                                    departmentMasters.map(departmentMaster => (
                                        <tr key={departmentMaster.srNo}>
                                            <td>
                                                <input
                                                    type="checkbox"
                                                    onChange={() => handleCheckboxChange(departmentMaster.srNo)}
                                                    checked={selectedRows.includes(departmentMaster.srNo)}
                                                />
                                            </td>
                                            <td>{departmentMaster.deptName}</td>
                                            <td>
                                                <button className="btn btn-primary btn-sm" data-bs-toggle="modal" data-bs-target="#editModal" onClick={() => handleEdit(departmentMaster)}>
                                                    <FontAwesomeIcon icon={faEdit} />
                                                </button>
                                            </td>
                                            <td>
                                                <button className="btn btn-danger btn-sm" onClick={() => handleDeleteConfirmation(departmentMaster.srNo)}>
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


            <div className="modal fade" tabIndex="-1" id="addModal" aria-labelledby="addDepartmentMasterModalLabel" aria-hidden="true">
                <div className="modal-dialog">
                    <div className="modal-content">
                        {error && <div className="alert alert-danger" role="alert">{error}</div>}
                        {successMessage && <div className="alert alert-success">{successMessage}</div>}
                        <div className="modal-header">
                            <h5 className="modal-title" id="addDepartmentMasterModalLabel">Add Departments Master</h5>
                            <button type="button" className="btn-close" data-bs-dismiss="modal" aria-label="Close" onClick={handleCancel}></button>
                        </div>
                        <div className="modal-body">
                            <div className="input_text">
                                <label htmlFor="deptName" className="form-label2">Department</label>
                                <input type="text" className="form-control2" id="addDepartment" name="deptName" value={newDepartmentMaster.deptName} onChange={handleAddInputChange} />
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

            <div className="modal fade" tabIndex="-1" id="editModal" aria-labelledby="editDepartmentMasterModalLabel" aria-hidden="true">
                <div className="modal-dialog">
                    <div className="modal-content">
                        {error && <div className="alert alert-danger" role="alert">{error}</div>}
                        {successMessage && <div className="alert alert-success">{successMessage}</div>}
                        <div className="modal-header">
                            <h5 className="modal-title" id="editDepartmentMasterModalLabel">Edit Departments Master</h5>
                            <button type="button" className="btn-close" data-bs-dismiss="modal" aria-label="Close" onClick={handleCancel}></button>
                        </div>
                        <div className="modal-body">
                            <div className="input_text">
                                <label htmlFor="deptName" className="form-label2">Department</label>
                                <input type="text" className="form-control2" id="editDepartment" name="deptName" value={editedDepartmentMaster.deptName} onChange={handleInputChange} />
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

export default DepartmentMaster;