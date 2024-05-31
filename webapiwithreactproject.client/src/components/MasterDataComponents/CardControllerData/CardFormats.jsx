import React, { useState, useEffect, useRef } from 'react';
import '../../../assets/styles/fetchEmployee.css';
import '../../../assets/styles/Login.css'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPlus, faTrash, faSync, faEdit } from '@fortawesome/free-solid-svg-icons';

const CardFormats = () => {
    const [Masters, setMasters] = useState([]);
    const [selectedRows, setSelectedRows] = useState([]);
    const [editedMaster, setEditedMaster] = useState({
        srno:'',
        formatname: '',
        noofbits: '',
        facilitycode:'',
    });
    const [newMaster, setNewMaster] = useState({
        srno: '',
        formatname: '',
        noofbits: '',
        facilitycode: '',
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
        fetchMasters();
    }, []);

    const fetchMasters = async () => {
        try {
            setLoading(true);
            const response = await fetch('http://localhost:5213/api/CardFormatMasters');
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            const data = await response.json();
            setMasters(data);
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

        if (!newMaster.formatname) {
            setError("Fields cannot be empty");
            return;
        }


        try {

            // Check if location exists
            const checkResponse = await fetch(`http://localhost:5213/api/CardFormatMasters/CheckMasters/${newMaster.formatname}`);
            if (!checkResponse.ok) {
                throw new Error('Network response was not ok');
            }
            const checkData = await checkResponse.json();
            if (checkData.exists) {
                setError('Card Format already exists.');
                return;

            }
            else {
                const response = await fetch('http://localhost:5213/api/CardFormatMasters', {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json',
                    },
                    body: JSON.stringify({
                        formatname: newMaster.formatname,
                        noofbits: newMaster.noofbits,
                        facilitycode: newMaster.facilitycode,
                    }),
                });

                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }

                setSuccessMessage('New Village added successfully');
                setNewMaster({
                    srno: '',
                    formatname: '',
                    noofbits: '',
                    facilitycode: '',
                });
            }
            setTimeout(() => {
                const addModalElement1 = document.getElementById('addModal');
                const addModalInstance1 = bootstrap.Modal.getInstance(addModalElement1);
                addModalInstance1.hide();
            }, 1000);
            fetchMasters();
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        }
    };

    const handleEdit = (Master) => {
        setEditedMaster(Master);
    };

    const handleCancel = async () => {
        setEditedMaster({
            srno: '',
            formatname: '',
            noofbits: '',
            facilitycode: '',
        });

        setNewMaster({
            srno: '',
            formatname: '',
            noofbits: '',
            facilitycode: '',
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
        if (!editedMaster.formatname) {
            setError("Fields cannot be empty");
            return;
        }

        try {
            const checkResponse = await fetch(`http://localhost:5213/api/CardFormatMasters/CheckMasters/${editedMaster.formatname}`);
            if (!checkResponse.ok) {
                throw new Error('Network response was not ok');
            }
            const checkData = await checkResponse.json();
            if (checkData.exists) {
                setError('Card Format already exists.');
                return;

            }
            else {

                const response = await fetch(`http://localhost:5213/api/CardFormatMasters/${editedMaster.srno}`, {
                    method: 'PUT',
                    headers: {
                        'Content-Type': 'application/json',
                    },
                    body: JSON.stringify({
                        srno: editedMaster.srno,
                        formatname: editedMaster.formatname,
                        noofbits: editedMaster.noofbits,
                        facilitycode: editedMaster.facilitycode,
                    }),
                });

                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }

                setSuccessMessage('Data updated successfully');
                setEditedMaster({
                    srno: '',
                    formatname: '',
                    noofbits: '',
                    facilitycode: '',
                });
            }
            setTimeout(() => {
                const editModalElement1 = document.getElementById('editModal');
                const editModalInstance1 = bootstrap.Modal.getInstance(editModalElement1);
                editModalInstance1.hide();
            }, 1000);

            fetchMasters();
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        }
    };

    const handleRefresh = () => {
        fetchMasters();
    };

    const handleInputChange = (event) => {
        const { name, value } = event.target;
        setEditedMaster({
            ...editedMaster,
            [name]: value
        });
    };

    const handleAddInputChange = (event) => {
        const { name, value } = event.target;
        setNewMaster({
            ...newMaster,
            [name]: value
        });
    };

    const handleDeleteConfirmation = (srNo) => {
        const isConfirmed = window.confirm('Are you sure you want to delete the record?');
        if (isConfirmed) {
            handleDelete(srNo);
        }
    };

    const handleSelectdDeleteConfirmation = () => {
        const isConfirmed = window.confirm('Are you sure you want to delete these records?');
        if (isConfirmed) {
            handleSelectedDelete();
        }
    };

    const handleDelete = async (srno) => {
        try {
            const response = await fetch(`http://localhost:5213/api/CardFormatMaster/${srno}`, {
                method: 'DELETE',
            });

            if (!response.ok) {
                throw new Error('Network response was not ok');
            }

            console.log('Data deleted successfully');
            fetchMasters();
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        }
    };

    const handleSelectedDelete = async () => {
        try {
            await Promise.all(selectedRows.map(async (srno) => {
                const response = await fetch(`http://localhost:5213/api/CardFormatMaster/${srno}`, {
                    method: 'DELETE',
                });

                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }
            }));

            setSelectedRows([]);
            fetchMasters();
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        }
    };




    return (
        <>
            <div className="container employeeContainer mt-2 justify-content-center align-items-start">
                <div className='card'>
                    <h1 className="mb-4 ms-2">Card Format Master</h1>
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
                        <p className="lead fw-bold">Count: <span className="text-danger">{Masters.length}</span></p>
                    </div>

                    <div className="table-responsive text-center">
                        <table className="table table-striped">
                            <thead>
                                <tr>
                                    <th>Select</th>
                                    <th>Format Name</th>
                                    <th>No of Bits</th>
                                    <th>Facility Code</th>
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
                                    Masters.map(Master => (
                                        <tr key={Master.srno}>
                                            <td>
                                                <input
                                                    type="checkbox"
                                                    onChange={() => handleCheckboxChange(Master.srno)}
                                                    checked={selectedRows.includes(Master.srno)}
                                                />
                                            </td>
                                            <td>{Master.formatname}</td>
                                            <td>{Master.noofbits}</td>
                                            <td>{Master.facilitycode}</td>
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
                            <h5 className="modal-title" id="addModalLabel">Add Card Format</h5>
                            <button type="button" className="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                        </div>
                        <div className="modal-body">
                            <form>
                                <div className="mb-3">
                                    <label htmlFor="formatname" className="form-label2">Format Name</label>
                                    <input
                                        type="text"
                                        className="form-control2"
                                        name="formatname"
                                        value={newMaster.formatname}
                                        onChange={handleAddInputChange}
                                    />
                                </div>
                                <div>
                                    <input
                                        type="radio"
                                        id="26bits"
                                        name="format"
                                        value="26"
                                        defaultChecked
                                        onChange={() => {
                                            newMaster.noofbits = 26;
                                        }}
                                    />
                                    <label htmlFor="26bits">26 bits format</label>
                                </div>
                                <div>
                                    <input
                                        type="radio"
                                        id="octet"
                                        name="format"
                                        value="octet"
                                        onChange={() => {
                                            newMaster.noofbits = '';
                                        }}
                                    />
                                    <label htmlFor="octet">Octet format</label>
                                </div>
                                <div className="mb-3">
                                    <label htmlFor="noofbits" className="form-label2">Format Name</label>
                                    <input
                                        type="text"
                                        className="form-control2"
                                        name="noofbits"
                                        value={newMaster.noofbits}
                                        onChange={handleAddInputChange}
                                        disabled
                                    />
                                </div>
                                <div className="mb-3">
                                    <label htmlFor="facilitycode" className="form-label2">Format Name</label>
                                    <input
                                        type="text"
                                        className="form-control2"
                                        name="facilitycode"
                                        value={newMaster.facilitycode}
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
                                    <label htmlFor="formatname" className="form-label2">Format Name</label>
                                    <input
                                        type="text"
                                        className="form-control2"
                                        name="formatname"
                                        value={editedMaster.formatname}
                                        onChange={handleInputChange}
                                    />
                                </div>
                                <div>
                                    <input
                                        type="radio"
                                        id="26bits"
                                        name="format"
                                        value="26"
                                        defaultChecked
                                        onChange={() => {
                                            editedMaster.noofbits = 26;
                                        }}
                                    />
                                    <label htmlFor="26bits">26 bits format</label>
                                </div>
                                <div>
                                    <input
                                        type="radio"
                                        id="octet"
                                        name="format"
                                        value="octet"
                                        onChange={() => {
                                            editedMaster.noofbits = '';
                                        }}
                                    />
                                    <label htmlFor="octet">Octet format</label>
                                </div>
                                <div className="mb-3">
                                    <label htmlFor="noofbits" className="form-label2">Format Name</label>
                                    <input
                                        type="text"
                                        className="form-control2"
                                        name="noofbits"
                                        value={editedMaster.noofbits}
                                        onChange={handleInputChange}
                                        disabled
                                    />
                                </div>
                                <div className="mb-3">
                                    <label htmlFor="facilitycode" className="form-label2">Format Name</label>
                                    <input
                                        type="text"
                                        className="form-control2"
                                        name="facilitycode"
                                        value={editedMaster.facilitycode}
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

export default CardFormats;