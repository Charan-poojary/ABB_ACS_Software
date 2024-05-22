import React, { useState, useEffect, useRef } from 'react';
import '../../../assets/styles/fetchEmployee.css';
import '../../../assets/styles/Login.css'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPlus, faTrash, faSync, faEdit } from '@fortawesome/free-solid-svg-icons';

const EmployeeMaster = () => {
    const [EmployeeMasters, setEmployeeMasters] = useState([]);
    const [editedEmployeeMaster, setEditedEmployeeMaster] = useState({
        srno: '',
        empcode: '',
        fname: '',
        lname: '',
        cardno: '',
        pin:'',
    });
    const [newEmployeeMaster, setNewEmployeeMaster] = useState({
        srno: '',
        empcode: '',
        fname: '',
        lname: '',
        cardno: '',
        pin: '',
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

    const fetchEmployeeMasters = async () => {
        try {
            setLoading(true);
            const response = await fetch('http://localhost:5213/api/Employee');
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            const data = await response.json();
            setEmployeeMasters(data);
            console.log("here", data);
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        } finally {
            setLoading(false);
        }
    };



    const handleAddClick = async () => {

        if (!newEmployeeMaster.empcode || !newEmployeeMaster.Fname || !newEmployeeMaster.Lname || !newEmployeeMaster.cardno) {
            setError("Fields cannot be empty");
            return;
        }

        try {
            // Check if location exists
/*            const checkResponse = await fetch(`http://localhost:5213/api/Employee/CheckEmployeeCategory/${newEmployeeCategoryMaster.catname}`);
            if (!checkResponse.ok) {
                throw new Error('Network response was not ok');
            }
            const checkData = await checkResponse.json();
            if (checkData.exists) {
                setError('Category already exists.');
                return;
            }
            else {*/
                const response = await fetch('http://localhost:5213/api/Employees', {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json',
                    },
                    body: JSON.stringify({
                        empcode: newEmployeeMaster.empcode,
                        fname: newEmployeeMaster.Fname,
                        lname: newEmployeeMaster.Lname,
                        cardno: newEmployeeMaster.cardno,
                        pin: newEmployeeMaster.pin,
                    }),
                });

                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }

                setSuccessMessage('New Employee Entry added successfully');
                setNewEmployeeMaster({
                    srno: '',
                    empcode: '',
                    fname: '',
                    lname: '',
                    cardno: '',
                    pin: '',
                });
       /*     }*/
            setTimeout(() => {
                const addModalElement1 = document.getElementById('addModal');
                const addModalInstance1 = bootstrap.Modal.getInstance(addModalElement1);
                addModalInstance1.hide();
            }, 1000);
            fetchEmployeeMasters();
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        }
    };

    const handleEdit = (EmployeeMaster) => {
        setEditedEmployeeMaster(EmployeeMaster);
    };

    const handleCancel = async () => {
        setEditedEmployeeMaster({
            srno: '',
            empcode: '',
            fname: '',
            lname: '',
            cardno: '',
            pin: '',
        });

        setNewEmployeeMaster({
            srno: '',
            empcode: '',
            fname: '',
            lname: '',
            cardno: '',
            pin: '',
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
        if (!editedEmployeeMaster.empcode || !editedEmployeeMaster.Fname || !editedEmployeeMaster.Lname || !editedEmployeeMaster.cardno) {
            setError("Fields cannot be empty");
            return;
        }

        try {
/*            const checkResponse = await fetch(`http://localhost:5213/api/EmployeeCategory/CheckEmployeeCategory/${editedEmployeeCategoryMaster.catname}`);
            if (!checkResponse.ok) {
                throw new Error('Network response was not ok');
            }
            const checkData = await checkResponse.json();
            if (checkData.exists) {
                setError('Category already exists.');
                return;

            }
            else {*/

            const response = await fetch(`http://localhost:5213/api/Employees/${editedEmployeeMaster.srno}`, {
                    method: 'PUT',
                    headers: {
                        'Content-Type': 'application/json',
                    },
                    body: JSON.stringify({
                        srno: editedEmployeeMaster.srno,
                        empcode: editedEmployeeMaster.empcode,
                        fname: editedEmployeeMaster.Fname,
                        lname: editedEmployeeMaster.Lname,
                        cardno: editedEmployeeMaster.cardno,
                        pin: editedEmployeeMaster.pin,
                    }),
                });

                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }

                setSuccessMessage('Data updated successfully');
                setEditedEmployeeMaster({
                    srno: '',
                    empcode: '',
                    fname: '',
                    lname: '',
                    cardno: '',
                    pin: '',
                });
/*            }*/
            setTimeout(() => {
                const editModalElement1 = document.getElementById('editModal');
                const editModalInstance1 = bootstrap.Modal.getInstance(editModalElement1);
                editModalInstance1.hide();
            }, 1000);

            fetchEmployeeMasters();
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        }
    };

    const handleRefresh = () => {
        fetchEmployeeMasters();
    };

    const handleInputChange = (event) => {
        const { name, value } = event.target;
        setEditedEmployeeMaster({
            ...editedEmployeeMaster,
            [name]: value
        });
    };

    const handleAddInputChange = (event) => {
        const { name, value } = event.target;
        setNewEmployeeMaster({
            ...newEmployeeMaster,
            [name]: value
        });
    };

    return (
        <>
            <div className="container employeeContainer mt-2 justify-content-center align-items-start">
                <div className='card'>
                    <h1 className="mb-4 ms-2">Employee Master</h1>
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
                        <p className="lead fw-bold">Count: <span className="text-danger">{EmployeeMasters.length}</span></p>
                    </div>

                    <div className="table-responsive text-center">
                        <table className="table table-striped">
                            <thead>
                                <tr>
                                    <th>Employee Code</th>
                                    <th>Name </th>
                                    <th>Card No</th>
                                    <th>Pin</th>
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
                                    EmployeeMasters.map(EmployeeMaster => (
                                        <tr key={EmployeeMaster.srno}>
                                            <td>{EmployeeMaster.empcode}</td>
                                            <td>{EmployeeMaster.fname}{EmployeeMaster.lname}</td>
                                            <td>{EmployeeMaster.cardno}</td>
                                            <td>{EmployeeMaster.pin}</td>
                                            <td>
                                                <button className="custom-btn primary" data-bs-toggle="modal" data-bs-target="#editModal" onClick={() => handleEdit(EmployeeMaster)}>
                                                    <FontAwesomeIcon icon={faEdit} />
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
                            <h5 className="modal-title" id="addModalLabel">Add Category</h5>
                            <button type="button" className="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                        </div>
                        <div className="modal-body">
                            <form>
                                <div className="mb-3">
                                    <label htmlFor="catname" className="form-label2">Category Name</label>
                                    <input
                                        type="text"
                                        className="form-control2"
                                        id="addCatName"
                                        name="catname"
                                        value={newEmployeeMaster.catname}
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
                                    <label htmlFor="catname" className="form-label2">Category Name</label>
                                    <input
                                        type="text"
                                        className="form-control2"
                                        id="editCatName"
                                        name="catname"
                                        value={editedEmployeeMaster.catname}
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

export default EmployeeMaster;