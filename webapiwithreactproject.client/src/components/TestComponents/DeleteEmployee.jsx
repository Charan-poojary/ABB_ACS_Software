import React, { useState, useEffect, useRef } from 'react';
import '../assets/styles/form.css'

const DeleteEmployee = ({ initialEmployeeDataForDelete, onSubmit }) => {
    const [employeeDataForDelete, setEmployeeDataForDelete] = useState(initialEmployeeDataForDelete || { name: '', city: '', department: '' });
    const [error, setError] = useState('');
    const [successMessage, setSuccessMessage] = useState('');

    const employeeIdRef = useRef(null);
    const timeoutRef = useRef(null);

    useEffect(() => {
        timeoutRef.current = setTimeout(() => {
            setError('');
            setSuccessMessage('');
        }, 1000);

        return () => clearTimeout(timeoutRef.current);
    }, [error, successMessage]);

    useEffect(() => {
        setEmployeeDataForDelete(initialEmployeeDataForDelete || { name: '', city: '', department: '' });
    }, [initialEmployeeDataForDelete]);

    useEffect(() => {
        if (initialEmployeeDataForDelete) {
            employeeIdRef.current = initialEmployeeDataForDelete.employeeId;
        }
    }, [initialEmployeeDataForDelete]);

    const handleChange = (e) => {
        const { name, value } = e.target;
        setEmployeeDataForDelete(prevState => ({
            ...prevState,
            [name]: value
        }));
    };

    const handleDeleteConfirmation = () => {
        const isConfirmed = window.confirm('Are you sure you want to delete this employee?');

        if (isConfirmed) {
            handleSubmit();
        }
    };

    const handleSubmit = async (e) => {
        e.preventDefault();

        try {
            const response = await fetch(`http://localhost:5213/api/Employees/${employeeIdRef.current}`, {
                method: 'DELETE',
                headers: {
                    'Content-Type': 'application/json',
                },
            });

            if (!response.ok) {
                const errorData = await response.json();
                setError(errorData.message || 'Employee cannot be Deleted');
                await response.text();
            } else {
                setSuccessMessage('Employee Deleted Successfully!');
                onSubmit();
            }
        } catch (error) {
            setError('An error occurred while Deleting the employee');
        }
    };

    return (
        <div className="container mt-5 formContainer">
            <div className="card p-5">
                <h2>Delete Employee</h2>
                <form onSubmit={handleSubmit}>
                    <div className="mb-3">
                        <label htmlFor="name" className="form-label formsL">Name</label>
                        <input type="text" className="form-control dEmp" id="name" name="name" value={employeeDataForDelete.name} onChange={handleChange} readOnly />
                    </div>
                    <div className="mb-3">
                        <label htmlFor="city" className="form-label formsL">City</label>
                        <input type="text" className="form-control dEmp" id="city" name="city" value={employeeDataForDelete.city} onChange={handleChange} readOnly />
                    </div>
                    <div className="mb-3">
                        <label htmlFor="department" className="form-label formsL">Department</label>
                        <input type="text" className="form-control dEmp" id="department" name="department" value={employeeDataForDelete.department} onChange={handleChange} readOnly />
                    </div>
                    <button type="submit" className="btn formBtn" onClick={handleDeleteConfirmation}>Delete</button>
                </form>
                {error && <div className="alert alert-danger">{error}</div>}
                {successMessage && <div className="alert alert-success">{successMessage}</div>}
            </div>
        </div>
    );
};

export default DeleteEmployee;
