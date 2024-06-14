import React, { useState, useEffect, useRef } from 'react';
import '../../../assets/styles/fetchEmployee.css';
import '../../../assets/styles/Login.css'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPlus, faTrash, faSync, faEdit } from '@fortawesome/free-solid-svg-icons';

const AccessGroup = () => {
    const [sectionMasters, setSectionMasters] = useState([]);
    const [editedSectionMaster, setEditedSectionMaster] = useState({
        agid: '',
        agname: '',
        details: '',
    });
    const [newSectionMaster, setNewSectionMaster] = useState({
        agname: '',
        details: '',
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
        fetchSectionMasters();
    }, []);

    const fetchSectionMasters = async () => {
        try {
            setLoading(true);
            const response = await fetch('http://localhost:5213/api/Masterags');
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            const data = await response.json();
            setSectionMasters(data);
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        } finally {
            setLoading(false);
        }
    };


    const handleAddClick = async () => {

        if (!newSectionMaster.agname) {
            setError("Fields cannot be empty");
            return;
        }


        try {
            // Check if group exists

            const checkResponse = await fetch(`http://localhost:5213/api/Masterags/CheckAccessGroup/${newSectionMaster.agname}`);
            if (!checkResponse.ok) {
                throw new Error('Network response was not ok');
            }
            const checkData = await checkResponse.json();
            if (checkData.exists) {
                setError('Access Group already exists.');
                return;

            }
            else {
                const response = await fetch('http://localhost:5213/api/Masterags', {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json',
                    },
                    body: JSON.stringify(newSectionMaster),
                });

                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }

                setSuccessMessage('New Access Group added successfully');
                setNewSectionMaster({
                    agname: '',
                    details: '',
                });
            }
            setTimeout(() => {
                const addModalElement1 = document.getElementById('addModal');
                const addModalInstance1 = bootstrap.Modal.getInstance(addModalElement1);
                addModalInstance1.hide();
            }, 1000);
            fetchSectionMasters();
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        }
    };

    const handleEdit = (sectionMaster) => {
        setEditedSectionMaster(sectionMaster);
    };

    const handleCancel = async () => {
        setEditedSectionMaster({
            agid: '',
            agname: '',
            details: '',
        });

        setNewSectionMaster({
            agname: '',
            details: '',
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
        if (!editedSectionMaster.agname) {
            setError("Fields cannot be empty");
            return;
        }

        try {
            const response = await fetch(`http://localhost:5213/api/Masterags/${editedSectionMaster.agid}`, {
                    method: 'PUT',
                    headers: {
                        'Content-Type': 'application/json',
                    },
                    body: JSON.stringify({
                        agid: editedSectionMaster.agid,
                        agname: editedSectionMaster.agname,
                        details: editedSectionMaster.details,
                    }),
                });

                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }

                setSuccessMessage('Data updated successfully');
                setEditedSectionMaster({
                    agid: '',
                    agname: '',
                    details: '',
                });

            setTimeout(() => {
                const editModalElement1 = document.getElementById('editModal');
                const editModalInstance1 = bootstrap.Modal.getInstance(editModalElement1);
                editModalInstance1.hide();
            }, 1000);

            fetchSectionMasters();
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        }
    };

    const handleRefresh = () => {
        fetchSectionMasters();
    };

    const handleInputChange = (event) => {
        const { name, value } = event.target;
        setEditedSectionMaster({
            ...editedSectionMaster,
            [name]: value
        });
    };

    const handleAddInputChange = (event) => {
        const { name, value } = event.target;
        setNewSectionMaster({
            ...newSectionMaster,
            [name]: value
        });
    };

 

    return (
        <>
            <div className="container employeeContainer mt-2 justify-content-center align-items-start">
                <div className='card'>
                    <h1 className="mb-4 ms-2">Access Groups</h1>
                    <div className='container-fluid mb-4'>
                        <button className="custom-btn primary"
                            data-bs-toggle="modal" data-bs-target="#addModal"
                        >
                            <FontAwesomeIcon icon={faPlus} className="me-2" />
                            Add
                        </button>
                        <button className="custom-btn secondary float-end" onClick={handleRefresh}>
                            <FontAwesomeIcon icon={faSync} />
                        </button>
                    </div>
                    <div className="ms-4">
                        <p className="lead fw-bold">Count: <span className="text-danger">{sectionMasters.length}</span></p>
                    </div>

                    <div className="table-responsive text-center">
                        <table className="table table-striped">
                            <thead>
                                <tr>
                                    <th>Access Group</th>
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
                                    sectionMasters.map(sectionMaster => (
                                        <tr key={sectionMaster.agid}>
                                            <td>{sectionMaster.agname}</td>
                                            <td>
                                                <button className="custom-btn primary" data-bs-toggle="modal" data-bs-target="#editModal" onClick={() => handleEdit(sectionMaster)}>
                                                    <FontAwesomeIcon icon={faEdit} />
                                                </button>
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

            {/* Add Modal */}
            <div className="modal fade" id="addModal" tabIndex="-1" aria-labelledby="addModalLabel" aria-hidden="true">
                <div className="modal-dialog">
                    <div className="modal-content">
                        {error && <div className="alert alert-danger">{error}</div>}
                        {successMessage && <div className="alert alert-success">{successMessage}</div>}
                        <div className="modal-header">
                            <h5 className="modal-title" id="addModalLabel">Add Access Group</h5>
                            <button type="button" className="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                        </div>
                        <div className="modal-body">
                            <form>
                                <div className="mb-3">
                                    <label htmlFor="agname" className="form-label2">Access Group Name</label>
                                    <input
                                        type="text"
                                        className="form-control2"
                                        id="agname"
                                        name="agname"
                                        value={newSectionMaster.agname}
                                        onChange={handleAddInputChange}
                                    />
                                </div>
                                <div className="mb-3">
                                    <label htmlFor="details" className="form-label2">Details</label>
                                    <input
                                        type="text"
                                        className="form-control2"
                                        id="details"
                                        name="details"
                                        value={newSectionMaster.details}
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
                            <h5 className="modal-title" id="editModalLabel">Edit Access Group</h5>
                            <button type="button" className="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                        </div>
                        <div className="modal-body">
                            <form>
                                <div className="mb-3">
                                    <label htmlFor="agname" className="form-label2">Access Group Name</label>
                                    <input
                                        type="text"
                                        className="form-control2"
                                        id="agname"
                                        name="agname"
                                        value={editedSectionMaster.agname}
                                        onChange={handleInputChange}
                                    />
                                </div>
                                <div className="mb-3">
                                    <label htmlFor="details" className="form-label2">Details</label>
                                    <input
                                        type="text"
                                        className="form-control2"
                                        id="details"
                                        name="details"
                                        value={editedSectionMaster.details}
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

export default AccessGroup;