import React, { useState, useEffect, useRef } from 'react';
import '../../../assets/styles/fetchEmployee.css';
import '../../../assets/styles/Login.css'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPlus, faSync, faEdit } from '@fortawesome/free-solid-svg-icons';

const Vehicles = () => {
    const [EmployeeMasters, setEmployeeMasters] = useState([]);
    const [editedEmployeeMaster, setEditedEmployeeMaster] = useState({
        empid: '',
        empcode: '',
        name: '',
        cardno: '',
        pin: '',
        otlno: '',
    });
    const [newEmployeeMaster, setNewEmployeeMaster] = useState({
        empcode: '',
        name: '',
        cardno: '',
        pin: '',
        otlno: '',
    });
    const [searchParams, setSearchParams] = useState({
        empcode: '',
        name: '',
        cardno: '',
    });
    const [error, setError] = useState('');
    const [successMessage, setSuccessMessage] = useState('');
/*    const [loading, setLoading] = useState(false);
    const [currentPage, setCurrentPage] = useState(1);
    const itemsPerPage = 20;
*/
    const timeoutRef = useRef(null);

    useEffect(() => {
        timeoutRef.current = setTimeout(() => {
            setError('');
            setSuccessMessage('');
        }, 1000);

        return () => clearTimeout(timeoutRef.current);
    }, [error, successMessage]);
/*
    useEffect(() => {
        fetchEmployeeMasters();
    }, [currentPage]);*/

/*    const fetchEmployeeMasters = async () => {
        try {
            setLoading(true);
            const response = await fetch('http://localhost:5213/api/HelperDetails');
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
    };*/
/*
    const handleAddClick = async () => {
        if (!newEmployeeMaster.empcode || !newEmployeeMaster.name || !newEmployeeMaster.cardno || !newEmployeeMaster.otlno) {
            setError("Fields cannot be empty");
            return;
        }

        console.log("gewbubed", newEmployeeMaster);
        try {
            const response = await fetch('http://localhost:5213/api/HelperDetails', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json',
                },
                body: JSON.stringify(newEmployeeMaster),
            });

            if (!response.ok) {
                throw new Error('Network response was not ok');
            }

            setSuccessMessage('New Employee Entry added successfully');
            setNewEmployeeMaster({
                empcode: '',
                name: '',
                cardno: '',
                pin: '',
                otlno: '',
            });

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
*/
/*    const handleEdit = (EmployeeMaster) => {
        setEditedEmployeeMaster(EmployeeMaster);
    };*/

    const handleCancel = async () => {
        setEditedEmployeeMaster({
            empid: '',
            empcode: '',
            name: '',
            cardno: '',
            pin: '',
            otlno: '',
        });

        setNewEmployeeMaster({
            empcode: '',
            name: '',
            cardno: '',
            pin: '',
            otlno: '',
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

  /*  const handleSave = async () => {
        if (!editedEmployeeMaster.empcode || !editedEmployeeMaster.name || !editedEmployeeMaster.cardno || !editedEmployeeMaster.otlno) {
            setError("Fields cannot be empty");
            return;
        }

        try {
            const response = await fetch(`http://localhost:5213/api/HelperDetails/${editedEmployeeMaster.empid}`, {
                method: 'PUT',
                headers: {
                    'Content-Type': 'application/json',
                },
                body: JSON.stringify({
                    empid: editedEmployeeMaster.empid,
                    empcode: editedEmployeeMaster.empcode,
                    name: editedEmployeeMaster.name,
                    cardno: editedEmployeeMaster.cardno,
                    pin: editedEmployeeMaster.pin,
                    otlno: editedEmployeeMaster.otlno,
                }),
            });

            if (!response.ok) {
                throw new Error('Network response was not ok');
            }

            setSuccessMessage('Data updated successfully');
            setEditedEmployeeMaster({
                empid: '',
                empcode: '',
                name: '',
                cardno: '',
                pin: '',
                otlno: '',
            });

            setTimeout(() => {
                const editModalElement1 = document.getElementById('editModal');
                const editModalInstance1 = bootstrap.Modal.getInstance(editModalElement1);
                editModalInstance1.hide();
            }, 1000);

            fetchEmployeeMasters();
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        }
    };*/
/*
    const handleRefresh = () => {
        fetchEmployeeMasters();
    };*/

    const handleInputChange = (event) => {
        const { name, value } = event.target;
        setEditedEmployeeMaster({
            ...editedEmployeeMaster,
            [name]: value
        });
    };

    const handleNewInputChange = (event) => {
        const { name, value } = event.target;
        setNewEmployeeMaster({
            ...newEmployeeMaster,
            [name]: value
        });
    };

    const handleSearchInputChange = (event) => {
        const { name, value } = event.target;
        setSearchParams(
            (prevState) => ({
                ...prevState,
                [name]: value,
            })
        );
    };

   /* const handleSearch = async () => {
        try {
            setLoading(true);
            const query = new URLSearchParams(searchParams).toString();
            const response = await fetch(`http://localhost:5213/api/HelperDetails/Search?${query}`);
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            const data = await response.json();
            setSearchParams({
                empcode: '',
                name: '',
                cardno: '',
            })
            setEmployeeMasters(data);
        } catch (error) {
            console.error('There was a problem with your search operation:', error);
        } finally {
            setLoading(false);
        }
    };*/

/*    const handlePageChange = (pageNumber) => {
        setCurrentPage(pageNumber);
    };

    const paginate = (data, pageSize, pageNumber) => {
        const start = (pageNumber - 1) * pageSize;
        return data.slice(start, start + pageSize);
    };

    const paginatedEmployeeMasters = paginate(EmployeeMasters, itemsPerPage, currentPage);
    const totalPages = Math.ceil(EmployeeMasters.length / itemsPerPage);*/


    return (
        <>
            <div className="container employeeContainer mt-2 justify-content-center align-items-start">
                <div className='card'>
                    <h1 className="mb-4 ms-2">Vehicles</h1>
                    <div className='container-fluid mb-4'>
                        <div className="row mb-4">
                            <div className="col-md-3 mb-2">
                                <label className="form-label2">Vehicle No</label>
                                <input
                                    type="text"
                                    className="form-control border border-dark"
                                    name="empcode"
                                    value={searchParams.empcode}
                                    onChange={handleSearchInputChange}
                                />
                            </div>
                            <div className="col-md-3 mb-2">
                                <label className="form-label2">Tag No</label>
                                <input
                                    type="text"
                                    className="form-control border border-dark"
                                    name="name"
                                    value={searchParams.name}
                                    onChange={handleSearchInputChange}
                                />
                            </div>
                            <div className="col-md-3 mt-4 ms-5">
                                <button className="custom-btn danger" >Search</button>
                            </div>
                        </div>
                        <button className="custom-btn primary"
                            data-bs-toggle="modal" data-bs-target="#addModal"
                        >
                            <FontAwesomeIcon icon={faPlus} className="me-2" />
                            Add
                        </button>
                        <button className="custom-btn secondary float-end" >
                            <FontAwesomeIcon icon={faSync} />
                        </button>
                    </div>
                    <div className="ms-4">
                        <p className="lead fw-bold">Count: <span className="text-danger">{EmployeeMasters.length}</span></p>
                    </div>

                    {/* Pagination Controls */}
{/*                    <div className="d-flex justify-content-center">
                        <nav>
                            <ul className="pagination">
                                <li className={`page-item ${currentPage === 1 ? 'disabled' : ''}`}>
                                    <button className="page-link" onClick={() => handlePageChange(currentPage - 1)}>Previous</button>
                                </li>
                                {[...Array(totalPages).keys()].map(pageNumber => (
                                    <li key={pageNumber + 1} className={`page-item ${currentPage === pageNumber + 1 ? 'active' : ''}`}>
                                        <button className="page-link" onClick={() => handlePageChange(pageNumber + 1)}>{pageNumber + 1}</button>
                                    </li>
                                ))}
                                <li className={`page-item ${currentPage === totalPages ? 'disabled' : ''}`}>
                                    <button className="page-link" onClick={() => handlePageChange(currentPage + 1)}>Next</button>
                                </li>
                            </ul>
                        </nav>
                    </div>*/}

               {/*     <div className="table-responsive text-center">
                        <table className="table table-striped">
                            <thead>
                                <tr>
                                    <th>Employee Code</th>
                                    <th>Name </th>
                                    <th>Card No</th>
                                    <th>Pin</th>
                                    <th>OTL No</th>
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
                                    paginatedEmployeeMasters.map(EmployeeMaster => (
                                        <tr key={EmployeeMaster.empid}>
                                            <td>{EmployeeMaster.empcode}</td>
                                            <td>{EmployeeMaster.name}</td>
                                            <td>{EmployeeMaster.cardno}</td>
                                            <td>{EmployeeMaster.pin}</td>
                                            <td>{EmployeeMaster.otlno}</td>
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
                    </div>*/}
                </div>
            </div >

            {/* Add Modal */}
            <div className="modal fade" id="addModal" tabIndex="-1" aria-labelledby="addModalLabel" aria-hidden="true">
                <div className="modal-dialog">
                    <div className="modal-content">
                        {error && <div className="alert alert-danger">{error}</div>}
                        {successMessage && <div className="alert alert-success">{successMessage}</div>}
                        <div className="modal-header">
                            <h5 className="modal-title" id="addModalLabel">Add Vehicle</h5>
                            <button type="button" className="btn-close" data-bs-dismiss="modal" aria-label="Close" onClick={handleCancel}></button>
                        </div>
                        <div className="modal-body">
                            <div className="mb-3">
                                <label className="form-label2">Vehicle no</label>
                                <input
                                    type="text"
                                    className="form-control2"
                                    name="empcode"
                                    value={newEmployeeMaster.empcode}
                                    onChange={handleNewInputChange}
                                />
                            </div>
                            <div className="mb-3">
                                <label className="form-label2">Tag No</label>
                                <input
                                    type="text"
                                    className="form-control2"
                                    name="name"
                                    value={newEmployeeMaster.name}
                                    onChange={handleNewInputChange}
                                />
                            </div>
                        </div>
                        <div className="modal-footer">
                            <button type="button" className="btn btn-secondary" data-bs-dismiss="modal" onClick={handleCancel}>Close</button>
                            <button type="button" className="btn btn-primary" >Save</button>
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
                            <h5 className="modal-title" id="editModalLabel">Edit Helper Details</h5>
                            <button type="button" className="btn-close" data-bs-dismiss="modal" aria-label="Close" onClick={handleCancel}></button>
                        </div>
                        <div className="modal-body">
                            <div className="mb-3">
                                <label className="form-label2">Empcode</label>
                                <input
                                    type="text"
                                    className="form-control2"
                                    name="empcode"
                                    value={editedEmployeeMaster.empcode}
                                    onChange={handleInputChange}
                                />
                            </div>
                            <div className="mb-3">
                                <label className="form-label2">Name</label>
                                <input
                                    type="text"
                                    className="form-control2"
                                    name="name"
                                    value={editedEmployeeMaster.name}
                                    onChange={handleInputChange}
                                />
                            </div>
                            <div className="mb-3">
                                <label className="form-label2">Cardno</label>
                                <input
                                    type="text"
                                    className="form-control2"
                                    name="cardno"
                                    value={editedEmployeeMaster.cardno}
                                    onChange={handleInputChange}
                                />
                            </div>
                            <div className="mb-3">
                                <label className="form-label2">Pin</label>
                                <input
                                    type="text"
                                    className="form-control2"
                                    name="pin"
                                    value={editedEmployeeMaster.pin}
                                    onChange={handleInputChange}
                                />
                            </div>
                            <div className="mb-3">
                                <label className="form-label2">OTL Tag No</label>
                                <input
                                    type="text"
                                    className="form-control2"
                                    name="otlno"
                                    value={editedEmployeeMaster.otlno}
                                    onChange={handleNewInputChange}
                                />
                            </div>
                        </div>
                        <div className="modal-footer">
                            <button type="button" className="btn btn-secondary" data-bs-dismiss="modal" onClick={handleCancel}>Close</button>
                            <button type="button" className="btn btn-primary" >Save</button>
                        </div>
                    </div>
                </div>
            </div>

        </>
    );
};

export default Vehicles;
