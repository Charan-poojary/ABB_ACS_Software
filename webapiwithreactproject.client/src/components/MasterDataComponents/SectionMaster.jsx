import React, { useState, useEffect, useRef } from 'react';
import '../../assets/styles/fetchEmployee.css';
import '../../assets/styles/Login.css'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPlus, faTrash, faSync, faEdit } from '@fortawesome/free-solid-svg-icons';

const SectionMaster = () => {
    const [sectionMasters, setSectionMasters] = useState([]);
    const [selectedRows, setSelectedRows] = useState([]);
    const [SerialNo, setSerialNo] = useState();
    const [editedSectionMaster, setEditedSectionMaster] = useState({
        srno: '',
        sectionname: '',
        sectionhead: '',
        email: '',
        contactno: '',
    });
    const [newSectionMaster, setNewSectionMaster] = useState({
        srno:'',
        sectionname: '',
        sectionhead: '',
        email: '',
        contactno: '',
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
            const response = await fetch('http://localhost:5213/api/Sections');
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            const data = await response.json();
            setSectionMasters(data);
            const length = data.length;
            setSerialNo(length);
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

        if (!newSectionMaster.sectionname || !newSectionMaster.sectionhead || !newSectionMaster.email || !newSectionMaster.contactno) {
            setError("Fields cannot be empty");
            return;
        }

        const phone1 = newSectionMaster.contactno;

        const isValidPhoneNumber = (phone1) => {
            return /^\d{10}$/.test(phone1);
        };


        if (!isValidPhoneNumber(phone1)) {
            setError('Invalid phone number. Please enter a 10-digit numeric phone number.');
            return;

        }

        try {
            // Check if location exists
            const checkResponse = await fetch(`http://localhost:5213/api/Sections/CheckSections/${newSectionMaster.sectionname}`);
            if (!checkResponse.ok) {
                throw new Error('Network response was not ok');
            }
            const checkData = await checkResponse.json();
            if (checkData.exists) {
                setError('Section already exists.');
                return;

            }
            else {
                const serialNo = SerialNo + 1;
                newSectionMaster.srno = serialNo;
                const response = await fetch('http://localhost:5213/api/Sections', {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json',
                    },
                    body: JSON.stringify(newSectionMaster),
                });

                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }

                setSuccessMessage('New Section added successfully');
                setNewSectionMaster({
                    srno: '',
                    sectionname: '',
                    sectionhead: '',
                    email: '',
                    contactno: '',
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
            srno: '',
            sectionname: '',
            sectionhead: '',
            email: '',
            contactno: '',
        });

        setNewSectionMaster({
            sectionname: '',
            sectionhead: '',
            email: '',
            contactno: '',
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
        if (!editedSectionMaster.sectionname || !editedSectionMaster.sectionhead || !editedSectionMaster.email || !editedSectionMaster.contactno) {
            setError("Fields cannot be empty");
            return;
        }


        const phone1 = editedSectionMaster.contactno;

        const isValidPhoneNumber = (phone1) => {
            return /^\d{10}$/.test(phone1);
        };


        if (!isValidPhoneNumber(phone1)) {
            setError('Invalid phone number. Please enter a 10-digit numeric phone number.');
            return;

        }

        try {

            // Check if location exists
            const checkResponse = await fetch(`http://localhost:5213/api/Sections/CheckSections/${editedSectionMaster.sectionname}`);
            if (!checkResponse.ok) {
                throw new Error('Network response was not ok');
            }
            const checkData = await checkResponse.json();
            if (checkData.exists) {
                setError('Section already exists.');
                return;

            }
            else {
                const response = await fetch(`http://localhost:5213/api/Sections/${editedSectionMaster.srno}`, {
                    method: 'PUT',
                    headers: {
                        'Content-Type': 'application/json',
                    },
                    body: JSON.stringify({
                        srno: editedSectionMaster.srno,
                        sectionname: editedSectionMaster.sectionname,
                        sectionhead: editedSectionMaster.sectionhead,
                        email: editedSectionMaster.email,
                        contactno: editedSectionMaster.contactno,
                    }),
                });

                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }

                setSuccessMessage('Data updated successfully');
                setEditedSectionMaster({
                    srno: '',
                    sectionname: '',
                    sectionhead: '',
                    email: '',
                    contactno: '',
                });
            }

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

    const handleDeleteConfirmation = (srno) => {
        const isConfirmed = window.confirm('Are you sure you want to delete the Section?');
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
            const response = await fetch(`http://localhost:5213/api/Sections/${srno}`, {
                method: 'DELETE',
            });

            if (!response.ok) {
                throw new Error('Network response was not ok');
            }

            console.log('Data deleted successfully');
            fetchSectionMasters();
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        }
    };

    const handleSelectedDelete = async () => {
        try {
            await Promise.all(selectedRows.map(async (srno) => {
                const response = await fetch(`http://localhost:5213/api/Sections/${srno}`, {
                    method: 'DELETE',
                });

                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }
            }));

            setSelectedRows([]);
            fetchSectionMasters();
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        }
    };




    return (
        <>
            <div className="container employeeContainer mt-2 justify-content-center align-items-start">
                <div className='card'>
                    <h1 className="mb-4 ms-2">Sections Master</h1>
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
                        <p className="lead fw-bold">Count: <span className="text-danger">{sectionMasters.length}</span></p>
                    </div>

                    <div className="table-responsive text-center">
                        <table className="table table-striped">
                            <thead>
                                <tr>
                                    <th>Select</th>
                                    <th>Section Name</th>
                                    <th>Section Head</th>
                                    <th>Email</th>
                                    <th>Phone</th>
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
                                        sectionMasters.map(sectionMaster => (
                                            <tr key={sectionMaster.srno}>
                                            <td>
                                                <input
                                                    type="checkbox"
                                                        onChange={() => handleCheckboxChange(sectionMaster.srno)}
                                                        checked={selectedRows.includes(sectionMaster.srno)}
                                                />
                                                </td>
                                                <td>{sectionMaster.sectionname}</td>
                                                <td>{sectionMaster.sectionhead}</td>
                                                <td>{sectionMaster.email}</td>
                                                <td>{sectionMaster.contactno}</td>

                                            <td>
                                                <button className="custom-btn primary" data-bs-toggle="modal" data-bs-target="#editModal" onClick={() => handleEdit(sectionMaster)}>
                                                    <FontAwesomeIcon icon={faEdit} />
                                                </button>
                                            </td>
                                                <td>
                                                    <button className="custom-btn danger" onClick={() => handleDeleteConfirmation(sectionMaster.srno)}>
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
                            <h5 className="modal-title" id="addModalLabel">Add Section</h5>
                            <button type="button" className="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                        </div>
                        <div className="modal-body">
                            <form>
                                <div className="mb-3">
                                    <label htmlFor="sectionname" className="form-label2">Section Name</label>
                                    <input
                                        type="text"
                                        className="form-control2"
                                        id="addSectionName"
                                        name="sectionname"
                                        value={newSectionMaster.sectionname}
                                        onChange={handleAddInputChange}
                                    />
                                </div>
                                <div className="mb-3">
                                    <label htmlFor="sectionhead" className="form-label2">Section Head</label>
                                    <input
                                        type="text"
                                        className="form-control2"
                                        id="addSectionHead"
                                        name="sectionhead"
                                        value={newSectionMaster.sectionhead}
                                        onChange={handleAddInputChange}
                                    />
                                </div>
                                <div className="mb-3">
                                    <label htmlFor="email" className="form-label2">Email</label>
                                    <input
                                        type="text"
                                        className="form-control2"
                                        id="addEmail"
                                        name="email"
                                        value={newSectionMaster.email}
                                        onChange={handleAddInputChange}
                                    />
                                </div>
                                <div className="mb-3">
                                    <label htmlFor="contactno" className="form-label2">Phone</label>
                                    <input
                                        type="text"
                                        className="form-control2"
                                        id="addContactNo"
                                        name="contactno"
                                        value={newSectionMaster.contactno}
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
                            <h5 className="modal-title" id="editModalLabel">Edit Location</h5>
                            <button type="button" className="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                        </div>
                        <div className="modal-body">
                            <form>
                                <div className="mb-3">
                                    <label htmlFor="sectionname" className="form-label2">Section</label>
                                    <input
                                        type="text"
                                        className="form-control2"
                                        id="editSectionName"
                                        name="sectionname"
                                        value={editedSectionMaster.sectionname}
                                        onChange={handleInputChange}
                                    />
                                </div>
                                <div className="mb-3">
                                    <label htmlFor="sectionhead" className="form-label2">Section</label>
                                    <input
                                        type="text"
                                        className="form-control2"
                                        id="editSectionHead"
                                        name="sectionhead"
                                        value={editedSectionMaster.sectionhead}
                                        onChange={handleInputChange}
                                    />
                                </div>
                                <div className="mb-3">
                                    <label htmlFor="email" className="form-label2">Email</label>
                                    <input
                                        type="text"
                                        className="form-control2"
                                        id="editEmail"
                                        name="email"
                                        value={editedSectionMaster.email}
                                        onChange={handleInputChange}
                                    />
                                </div>
                                <div className="mb-3">
                                    <label htmlFor="contactno" className="form-label2">Phone</label>
                                    <input
                                        type="text"
                                        className="form-control2"
                                        id="editContactNo"
                                        name="contactno"
                                        value={editedSectionMaster.contactno}
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

export default SectionMaster;