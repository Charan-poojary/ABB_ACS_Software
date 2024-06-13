import React, { useState, useEffect, useRef } from 'react';
import '../../../assets/styles/fetchEmployee.css';
import '../../../assets/styles/Login.css'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPlus, faSync, faEdit } from '@fortawesome/free-solid-svg-icons';

const CardInventory = () => {
    const [EmployeeMasters, setEmployeeMasters] = useState([]);
    const [selectedRows, setSelectedRows] = useState([]);
    const [allEmployeeMasters, setAllEmployeeMasters] = useState([]);
    const [editedEmployeeMaster, setEditedEmployeeMaster] = useState({
        cardid: '',
        cardno: '',
        cardformat: '',
        status: '',
    });
    const [searchParams, setSearchParams] = useState({
        cardno: '',
        cardformat: '',
        status: '',
    });
    const [error, setError] = useState('');
    const [successMessage, setSuccessMessage] = useState('');
    const [loading, setLoading] = useState(false);

    const [currentPage, setCurrentPage] = useState(1);
    const itemsPerPage = 20;


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
    }, [currentPage]);

/*    const handleCheckboxChange = (srno) => {
        if (selectedRows.includes(srno)) {
            setSelectedRows(selectedRows.filter(row => row !== srno));
        } else {
            setSelectedRows([...selectedRows, srno]);
        }
    };*/

    const fetchEmployeeDriver = async (cardno) => {
        try {
            const apiUrl = `http://localhost:5213/api/DriverDetails/GetEmployeeDetailsByCardno/${cardno}`;
            const response = await fetch(apiUrl);
            if (!response.ok) {
                throw new Error('Employee not found');
            }
            const employeeDetails = await response.text();
            return employeeDetails;
        } catch (error) {
            setError('There was an error fetching the employee details: ' + error.message);
        }
    };


    const fetchEmployeeHelper = async (cardno) => {
        try {
            const apiUrl = `http://localhost:5213/api/HelperDetails/GetEmployeeDetailsByCardno/${cardno}`;
            const response = await fetch(apiUrl);
            if (!response.ok) {
                throw new Error('Employee not found');
            }
            const employeeDetails = await response.text();
            return employeeDetails;
        } catch (error) {
            setError('There was an error fetching the employee details: ' + error.message);
        }
    };

    const fetchEmployeeEmp = async (cardno) => {
        try {
            const apiUrl = `http://localhost:5213/api/Employee/GetEmployeeDetailsByCardno/${cardno}`;
            const response = await fetch(apiUrl);
            if (!response.ok) {
                throw new Error('Employee not found');
            }
            const employeeDetails = await response.text();
            return employeeDetails;
        } catch (error) {
            setError('There was an error fetching the employee details: ' + error.message);
        }
    };



    const fetchEmployeeMasters = async () => {
        try {
            setLoading(true);
            const response = await fetch('http://localhost:5213/api/Mastercardinventories');
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            const data = await response.json();

            const updatedData = await Promise.all(data.map(async employee => {
                const driverName = await fetchEmployeeDriver(employee.cardno);
                const helperName = await fetchEmployeeHelper(employee.cardno);
                const empName = await fetchEmployeeEmp(employee.cardno);
                return { ...employee, driverName, helperName, empName };
            }));



            setEmployeeMasters(updatedData);
            setAllEmployeeMasters(updatedData); 

        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        } finally {
            setLoading(false);
        }
    };



    const handleSearch = async () => {
        try {
            setLoading(true);

            // Filter the stored employee data based on search parameters
            const filteredData = allEmployeeMasters.filter(employee => {
                return (
                    (searchParams.cardno ? employee.empcode === searchParams.empcode : true) &&
                    (searchParams.cardformat ? employee.cardformat === searchParams.cardformat : true) &&
                    (searchParams.status ? employee.status === searchParams.status : true)
                );
            });

            setSearchParams({
                cardno: '',
                cardformat: '',
                status: '',
            });

            console.log("filter", filteredData);

            setEmployeeMasters(filteredData);
        } catch (error) {
            console.error('There was a problem with your search operation:', error);
        } finally {
            setLoading(false);
        }
    };

  

    const handleEdit = (EmployeeMaster) => {
        setEditedEmployeeMaster(EmployeeMaster);
    };

    const handleCancel = async () => {
        setEditedEmployeeMaster({
            cardid: '',
            cardno: '',
            cardformat: '',
            status: ''
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
    };

    const handleSave = async () => {
        if (!editedEmployeeMaster.cardno || !editedEmployeeMaster.status) {
            setError("Fields cannot be empty");
            return;
        }

        try {
            const response = await fetch(`http://localhost:5213/api/Mastercardinventories/UpdateEmployee/${editedEmployeeMaster.cardid}`, {
                method: 'PUT',
                headers: {
                    'Content-Type': 'application/json',
                },
                body: JSON.stringify({
                    cardid: editedEmployeeMaster.cardid,
                    cardno: editedEmployeeMaster.cardno,
                    cardformat: editedEmployeeMaster.cardformat,
                    status: editedEmployeeMaster.status,
                }),
            });

            if (!response.ok) {
                throw new Error('Network response was not ok');
            }

            setSuccessMessage('Data updated successfully');
            setEditedEmployeeMaster({
                cardid: '',
                cardno: '',
                cardformat: '',
                status: '',
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
    };


    const handleInputChange = (event) => {
        const { name, value } = event.target;
        setEditedEmployeeMaster({
            ...editedEmployeeMaster,
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

    const handlePageChange = (pageNumber) => {
        setCurrentPage(pageNumber);
    };

    const paginate = (data, pageSize, pageNumber) => {
        const start = (pageNumber - 1) * pageSize;
        return data.slice(start, start + pageSize);
    };

    const paginatedEmployeeMasters = paginate(EmployeeMasters, itemsPerPage, currentPage);
    const totalPages = Math.ceil(EmployeeMasters.length / itemsPerPage);




    return (
        <>
            <div className="container employeeContainer mt-2 justify-content-center align-items-start">
                <div className='card'>
                    <h1 className="mb-4 ms-2">Card Inventory</h1>
                    <div className='container-fluid mb-4'>
                        <div className="row mb-4">
                            <div className="col-md-3 mb-2">
                                <label className="form-label2">Card No.</label>
                                <input
                                    type="text"
                                    className="form-control border border-dark"
                                    name="cardno"
                                    value={searchParams.cardno}
                                    onChange={handleSearchInputChange}
                                />
                            </div>
                            <div className="col-md-3 mb-2">
                                <label className="form-label2">Card Format</label>
                                <select
                                    className="form-control form-select border border-dark"
                                    name="cardformat"
                                    value={searchParams.cardformat}
                                    onChange={handleSearchInputChange}
                                >
                                    <option value="all">All</option>
                                </select>
                            </div>
                            <div className="col-md-3 mb-2">
                                <label className="form-label2">Status</label>
                                <select
                                    className="form-control form-select border border-dark"
                                    name="status"
                                    value={searchParams.status}
                                    onChange={handleSearchInputChange}
                                >
                                    <option value="all">All</option>
                                    <option value="assigned">assigned</option>
                                    <option value="available">available</option>
                                </select>
                            </div>

                            <div className="col-md-3 mt-4">
                                <button className="custom-btn danger" onClick={handleSearch}>Search</button>
                            </div>
                        </div>
                    </div>
                    <div className="ms-4">
                        <p className="lead fw-bold">Count: <span className="text-danger">{EmployeeMasters.length}</span></p>
                    </div>

                    {/* Pagination Controls */}
                    <div className="d-flex justify-content-center">
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
                    </div>

                    <div className="table-responsive text-center">
                        <table className="table table-striped">
                            <thead>
                                <tr>
                                    <th>Card No.</th>
                                    <th>Card Format</th>
                                    <th>No Format</th>
                                    <th>Assigned To</th>
                                    <th>Status</th>
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
                                        <tr key={EmployeeMaster.cardid}>
                                            <td>{EmployeeMaster.cardno}</td>
                                            <td></td>
                                                <td> <input
                                                    type="checkbox"
                                                    checked={true}
                                                    disabled
                                            /></td>
                                                <td>{`${EmployeeMaster.driverName || ''} ${EmployeeMaster.helperName || ''} ${EmployeeMaster.empName || ''}`.trim()}</td>
                                            <td>{EmployeeMaster.status}</td>
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
            </div >

           

            {/* Edit Modal */}
            <div className="modal fade" id="editModal" tabIndex="-1" aria-labelledby="editModalLabel" aria-hidden="true">
                <div className="modal-dialog">
                    <div className="modal-content">
                        {error && <div className="alert alert-danger">{error}</div>}
                        {successMessage && <div className="alert alert-success">{successMessage}</div>}
                        <div className="modal-header">
                            <h5 className="modal-title" id="editModalLabel">Edit Card Data</h5>
                            <button type="button" className="btn-close" data-bs-dismiss="modal" aria-label="Close" onClick={handleCancel}></button>
                        </div>
                        <div className="modal-body">
                            <div className="mb-3">
                                <label className="form-label2">Card No.</label>
                                <input
                                    type="text"
                                    className="form-control2"
                                    name="cardno"
                                    value={editedEmployeeMaster.cardno}
                                    onChange={handleInputChange}
                                />
                            </div>
                            <div className="mb-3">
                                <label className="form-label2">Card Format</label>

                                <select
                                    className="form-control form-select border border-dark"
                                    name="cardformat"
                                    value={editedEmployeeMaster.cardformat}
                                    onChange={handleInputChange}
                                >
                                    <option value="all">All</option>
                                </select>
                            </div>
                            <div className="mb-3">
                                <label className="form-label2">Status</label>

                                <select
                                    className="form-control form-select  border border-dark"
                                    name="status"
                                    value={editedEmployeeMaster.status}
                                    onChange={handleInputChange}
                                >
                                    <option value="all">All</option>
                                    <option value="assigned">assigned</option>
                                    <option value="available">available</option>
                                </select>
                            </div>
                            </div>
                        <div className="modal-footer">
                            <button type="button" className="btn btn-secondary" data-bs-dismiss="modal" onClick={handleCancel}>Close</button>
                            <button type="button" className="btn btn-primary" onClick={handleSave}>Save</button>
                        </div>
                    </div>

                    </div>
            </div>
        </>
    );
};

export default CardInventory;
