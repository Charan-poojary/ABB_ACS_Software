import React, { useState, useEffect, useRef } from 'react';
import '../../assets/styles/fetchEmployee.css';
import '../../assets/styles/Login.css'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPlus, faTrash, faSync, faEdit } from '@fortawesome/free-solid-svg-icons';

const VillageMaster = () => {
    const [villageMasters, setVillageMasters] = useState([]);
    const [selectedRows, setSelectedRows] = useState([]);
    const [editedVillageMaster, setEditedVillageMaster] = useState({
        srNo: '',
        villagename: '',
    });
    const [newVillageMaster, setNewVillageMaster] = useState({
        srNo: '',
        villagename: '',
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
        fetchVillagesMasters();
    }, []);

    const fetchVillagesMasters = async () => {
        try {
            setLoading(true);
            const response = await fetch('http://localhost:5213/api/Villages');
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            const data = await response.json();
            setVillageMasters(data);
            console.log("here", data);
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        } finally {
            setLoading(false);
        }
    };

    const handleCheckboxChange = (srNo) => {
        if (selectedRows.includes(srNo)) {
            setSelectedRows(selectedRows.filter(row => row !== srNo));
        } else {
            setSelectedRows([...selectedRows, srNo]);
        }
    };

    const handleAddClick = async () => {

        if (!newVillageMaster.villagename) {
            setError("Fields cannot be empty");
            return;
        }


        try {

            // Check if location exists
            const checkResponse = await fetch(`http://localhost:5213/api/Villages/CheckVillages/${newVillageMaster.villagename}`);
            if (!checkResponse.ok) {
                throw new Error('Network response was not ok');
            }
            const checkData = await checkResponse.json();
            if (checkData.exists) {
                setError('Village already exists.');
                return;

            }
            else {
                const response = await fetch('http://localhost:5213/api/Villages', {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json',
                    },
                    body: JSON.stringify({
                        villagename: newVillageMaster.villagename,
                    }),
                });

                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }

                setSuccessMessage('New Village added successfully');
                setNewVillageMaster({
                    srNo: '',
                    villagename: '',
                });
            }
            setTimeout(() => {
                const addModalElement1 = document.getElementById('addModal');
                const addModalInstance1 = bootstrap.Modal.getInstance(addModalElement1);
                addModalInstance1.hide();
            }, 1000);
            fetchVillagesMasters();
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        }
    };

    const handleEdit = (villageMaster) => {
        setEditedVillageMaster(villageMaster);
    };

    const handleCancel = async () => {
        setEditedVillageMaster({
            srNo: '',
            villagename: '',
        });

        setNewVillageMaster({
            srNo: '',
            villagename: '',
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
        if (!editedVillageMaster.villagename) {
            setError("Fields cannot be empty");
            return;
        }

        try {
            const checkResponse = await fetch(`http://localhost:5213/api/Villages/CheckVillages/${editedVillageMaster.villagename}`);
            if (!checkResponse.ok) {
                throw new Error('Network response was not ok');
            }
            const checkData = await checkResponse.json();
            if (checkData.exists) {
                setError('Village already exists.');
                return;

            }
            else {

                const response = await fetch(`http://localhost:5213/api/Villages/${editedVillageMaster.srNo}`, {
                    method: 'PUT',
                    headers: {
                        'Content-Type': 'application/json',
                    },
                    body: JSON.stringify({
                        srNo: editedVillageMaster.srNo,
                        villagename: editedVillageMaster.villagename,
                    }),
                });

                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }

                setSuccessMessage('Data updated successfully');
                setEditedVillageMaster({
                    srNo: '',
                    villagename: '',
                });
            }
            setTimeout(() => {
                const editModalElement1 = document.getElementById('editModal');
                const editModalInstance1 = bootstrap.Modal.getInstance(editModalElement1);
                editModalInstance1.hide();
            }, 1000);

            fetchVillagesMasters();
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        }
    };

    const handleRefresh = () => {
        fetchVillagesMasters();
    };

    const handleInputChange = (event) => {
        const { name, value } = event.target;
        setEditedVillageMaster({
            ...editedVillageMaster,
            [name]: value
        });
    };

    const handleAddInputChange = (event) => {
        const { name, value } = event.target;
        setNewVillageMaster({
            ...newVillageMaster,
            [name]: value
        });
    };

    const handleDeleteConfirmation = (srNo) => {
        const isConfirmed = window.confirm('Are you sure you want to delete the Village?');
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
            const response = await fetch(`http://localhost:5213/api/Villages/${srNo}`, {
                method: 'DELETE',
            });

            if (!response.ok) {
                throw new Error('Network response was not ok');
            }

            console.log('Data deleted successfully');
            fetchVillagesMasters();
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        }
    };

    const handleSelectedDelete = async () => {
        try {
            await Promise.all(selectedRows.map(async (srNo) => {
                const response = await fetch(`http://localhost:5213/api/Villages/${srNo}`, {
                    method: 'DELETE',
                });

                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }
            }));

            setSelectedRows([]);
            fetchVillagesMasters();
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        }
    };




    return (
        <>
            <div className="container employeeContainer mt-2 justify-content-center align-items-start">
                <div className='card'>
                    <h1 className="mb-4 ms-2">Village Master</h1>
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
                        <p className="lead fw-bold">Count: <span className="text-danger">{villageMasters.length}</span></p>
                    </div>

                    <div className="table-responsive text-center">
                        <table className="table table-striped">
                            <thead>
                                <tr>
                                    <th>Select</th>
                                    <th>Villages</th>
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
                                    villageMasters.map(villageMaster => (
                                        <tr key={villageMaster.srNo}>
                                            <td>
                                                <input
                                                    type="checkbox"
                                                    onChange={() => handleCheckboxChange(villageMaster.srNo)}
                                                    checked={selectedRows.includes(villageMaster.srNo)}
                                                />
                                            </td>
                                            <td>{villageMaster.villagename}</td>
                                            <td>
                                                <button className="custom-btn primary" data-bs-toggle="modal" data-bs-target="#editModal" onClick={() => handleEdit(villageMaster)}>
                                                    <FontAwesomeIcon icon={faEdit} />
                                                </button>
                                            </td>
                                            <td>
                                                <button className="custom-btn danger" onClick={() => handleDeleteConfirmation(villageMaster.srNo)}>
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
                            <h5 className="modal-title" id="addModalLabel">Add Village</h5>
                            <button type="button" className="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                        </div>
                        <div className="modal-body">
                            <form>
                                <div className="mb-3">
                                    <label htmlFor="villagename" className="form-label2">Village Name</label>
                                    <input
                                        type="text"
                                        className="form-control2"
                                        id="addVillageName"
                                        name="villagename"
                                        value={newVillageMaster.villagename}
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
                            <h5 className="modal-title" id="editModalLabel">Edit Village</h5>
                            <button type="button" className="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                        </div>
                        <div className="modal-body">
                            <form>
                                <div className="mb-3">
                                    <label htmlFor="villagename" className="form-label2">Village Name</label>
                                    <input
                                        type="text"
                                        className="form-control2"
                                        id="editVillageName"
                                        name="villagename"
                                        value={editedVillageMaster.villagename}
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

export default VillageMaster;