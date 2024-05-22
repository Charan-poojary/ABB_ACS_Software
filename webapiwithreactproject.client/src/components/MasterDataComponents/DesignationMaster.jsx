import React, { useState, useEffect, useRef } from 'react';
import '../../assets/styles/fetchEmployee.css';
import '../../assets/styles/Login.css'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPlus, faTrash, faSync, faEdit } from '@fortawesome/free-solid-svg-icons';

const DesignationMaster = () => {
    const [designationMasters, setdesignationMasters] = useState([]);
    const [selectedRows, setSelectedRows] = useState([]);
    const [editedDesignationMaster, setEditedDesignationMaster] = useState({
        srNo: '',
        designation: '',
    });
    const [newDesignationMaster, setNewDesignationMaster] = useState({
        srNo: '',
        designation: '',
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
        fetchDesignationMasters();
    }, []);

    const fetchDesignationMasters = async () => {
        try {
            setLoading(true);
            const response = await fetch('http://localhost:5213/api/Designations');
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            const data = await response.json();
            setdesignationMasters(data);
            console.log("here", data);
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

        if (!newDesignationMaster.designation) {
            setError("Fields cannot be empty");
            return;
        }

        try {
            const response = await fetch('http://localhost:5213/api/Designations', {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json',
                    },
                    body: JSON.stringify({
                        designation: newDesignationMaster.designation,
                    }),
                });

                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }

                setSuccessMessage('New Location added successfully');
                setNewDesignationMaster({
                    srNo: '',
                    designation: '',
                });
            setTimeout(() => {
                const addModalElement1 = document.getElementById('addModal');
                const addModalInstance1 = bootstrap.Modal.getInstance(addModalElement1);
                addModalInstance1.hide();
            }, 1000);
            fetchDesignationMasters();
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        }
    };

    const handleEdit = (designationMaster) => {
        setEditedDesignationMaster(designationMaster);
    };

    const handleCancel = async () => {
        setEditedDesignationMaster({
            srNo: '',
            designation: '',
        });

        setNewDesignationMaster({
            srNo: '',
            designation: '',
        });

        setError('');
        setSuccessMessage('');

        const editModalElement = document.getElementById('editModal');
        if (editModalElement) {
            const editModalInstance = bootstrap.Modal.getInstance(editModalElement);
            if (editModalInstance) {
                editModalInstance.hide();
            }
        }

        const addModalElement = document.getElementById('addModal');
        if (addModalElement) {
            const addModalInstance = bootstrap.Modal.getInstance(addModalElement);
            if (addModalInstance) {
                addModalInstance.hide();
            }
        }
    };

    const handleSave = async () => {
        if (!editedDesignationMaster.designation) {
            setError("Fields cannot be empty");
            return;
        }

        try {

            const response = await fetch(`http://localhost:5213/api/Designations/${editedDesignationMaster.srNo}`, {
                    method: 'PUT',
                    headers: {
                        'Content-Type': 'application/json',
                    },
                    body: JSON.stringify({
                        srNo: editedDesignationMaster.srNo,
                        designation: editedDesignationMaster.designation,
                    }),
                });

                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }

                setSuccessMessage('Data updated successfully');
                setEditedDesignationMaster({
                    srNo: '',
                    designation: ''
                });

            setTimeout(() => {
                const editModalElement1 = document.getElementById('editModal');
                const editModalInstance1 = bootstrap.Modal.getInstance(editModalElement1);
                editModalInstance1.hide();
            }, 1000);

            fetchDesignationMasters();
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        }
    };

    const handleRefresh = () => {
        fetchDesignationMasters();
    };

    const handleInputChange = (event) => {
        const { name, value } = event.target;
        setEditedDesignationMaster({
            ...editedDesignationMaster,
            [name]: value
        });
    };

    const handleAddInputChange = (event) => {
        const { name, value } = event.target;
        setNewDesignationMaster({
            ...newDesignationMaster,
            [name]: value
        });
    };

    const handleDeleteConfirmation = (srno) => {
        const isConfirmed = window.confirm('Are you sure you want to delete the designation?');
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
            const response = await fetch(`http://localhost:5213/api/Designations/${srno}`, {
                method: 'DELETE',
            });

            if (!response.ok) {
                throw new Error('Network response was not ok');
            }

            console.log('Data deleted successfully');
            fetchDesignationMasters();
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        }
    };

    const handleSelectedDelete = async () => {
        try {
            await Promise.all(selectedRows.map(async (srno) => {
                const response = await fetch(`http://localhost:5213/api/Designations/${srno}`, {
                    method: 'DELETE',
                });

                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }
            }));

            setSelectedRows([]);
            fetchDesignationMasters();
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        }
    };




    return (
        <>
            <div className="container employeeContainer mt-2 justify-content-center align-items-start">
                <div className='card'>
                    <h1 className="mb-4 ms-2">Designation Master</h1>
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
                        <p className="lead fw-bold">Count: <span className="text-danger">{designationMasters.length}</span></p>
                    </div>

                    <div className="table-responsive text-center">
                        <table className="table table-striped">
                            <thead>
                                <tr>
                                    <th>Select</th>
                                    <th>Designations</th>
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
                                        designationMasters.map(designationMaster => (
                                            <tr key={designationMaster.srNo}>
                                            <td>
                                                <input
                                                    type="checkbox"
                                                        onChange={() => handleCheckboxChange(designationMaster.srNo)}
                                                        checked={selectedRows.includes(designationMaster.srNo)}
                                                />
                                            </td>
                                                <td>{designationMaster.designation}</td>
                                            <td>
                                                    <button className="custom-btn primary" data-bs-toggle="modal" data-bs-target="#editModal" onClick={() => handleEdit(designationMaster)}>
                                                    <FontAwesomeIcon icon={faEdit} />
                                                </button>
                                            </td>
                                            <td>
                                                    <button className="custom-btn danger" onClick={() => handleDeleteConfirmation(designationMaster.srNo)}>
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

            {/* Add Modal */}
            <div className="modal fade" id="addModal" tabIndex="-1" aria-labelledby="addModalLabel" aria-hidden="true">
                <div className="modal-dialog">
                    <div className="modal-content">
                        {error && <div className="alert alert-danger">{error}</div>}
                        {successMessage && <div className="alert alert-success">{successMessage}</div>}
                        <div className="modal-header">
                            <h5 className="modal-title" id="addModalLabel">Add Designation</h5>
                            <button type="button" className="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                        </div>
                        <div className="modal-body">
                            <form>
                                <div className="mb-3">
                                    <label htmlFor="designation" className="form-label2">Designation</label>
                                    <input
                                        type="text"
                                        className="form-control2"
                                        id="addDesignation"
                                        name="designation"
                                        value={newDesignationMaster.designation}
                                        onChange={handleAddInputChange}
                                    />
                                </div>
                            </form>
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

            {/* Edit Modal */}
            <div className="modal fade" id="editModal" tabIndex="-1" aria-labelledby="editModalLabel" aria-hidden="true">
                <div className="modal-dialog">
                    <div className="modal-content">
                        {error && <div className="alert alert-danger">{error}</div>}
                        {successMessage && <div className="alert alert-success">{successMessage}</div>}
                        <div className="modal-header">
                            <h5 className="modal-title" id="editModalLabel">Edit Designation</h5>
                            <button type="button" className="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                        </div>
                        <div className="modal-body">
                            <form>
                                <div className="mb-3">
                                    <label htmlFor="designation" className="form-label2">Designation</label>
                                    <input
                                        type="text"
                                        className="form-control2"
                                        id="editDesignation"
                                        name="designation"
                                        value={editedDesignationMaster.designation}
                                        onChange={handleInputChange}
                                    />
                                </div>
                            </form>
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

export default DesignationMaster;