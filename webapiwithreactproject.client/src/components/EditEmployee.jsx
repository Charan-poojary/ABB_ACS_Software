import React, { useState, useEffect, useRef } from 'react';
import '../assets/styles/form.css';

const EditEmployee = ({ initialEmployeeData, onSubmit }) => {
    const [employeeData, setEmployeeData] = useState(initialEmployeeData || { name: '', city: '', department: '' });
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
        setEmployeeData(initialEmployeeData || { name: '', city: '', department: '' });
    }, [initialEmployeeData]);

    useEffect(() => {
        if (initialEmployeeData) {
            employeeIdRef.current = initialEmployeeData.employeeId;
        }
    }, [initialEmployeeData]);

    const handleChange = (e) => {
        const { name, value } = e.target;
        setEmployeeData(prevState => ({
            ...prevState,
            [name]: value
        }));
    };

    const handleSubmit = async (e) => {
        e.preventDefault();

        const { name, city, department } = employeeData;
        const nameRegex = /^[a-zA-Z\s]*$/;

        if (!name || !city || !department) {
            setError('Fields cannot be empty');
            return;
        }

        if (!name.match(nameRegex) || !city.match(nameRegex) || !department.match(nameRegex)) {
            setError('All fields should only contain valid alphabetic characters or words.');
            return;
        }

        try {
            const response = await fetch(`http://localhost:5213/api/Employees/${employeeIdRef.current}`, {
                method: 'PUT',
                headers: {
                    'Content-Type': 'application/json',
                },
                body: JSON.stringify(employeeData),
            });

            if (!response.ok) {
                const errorData = await response.json();
                setError(errorData.message || 'Employee cannot be updated');
                await response.text();
            } else {
                setSuccessMessage('Employee Updated Successfully!');
                onSubmit();
            }
        } catch (error) {
            setError('An error occurred while updating the employee');
        }
    };

    return (
        <div className="container mt-5 formContainer">
            <div className="card p-5">
                <h2>Edit Employee</h2>
                <form onSubmit={handleSubmit}>
                    <div className="mb-3">
                        <label htmlFor="name" className="form-label formsL">Name</label>
                        <input type="text" className="form-control" id="name" name="name" value={employeeData.name} onChange={handleChange} required />
                    </div>
                    <div className="mb-3">
                        <label htmlFor="city" className="form-label formsL">City</label>
                        <input type="text" className="form-control" id="city" name="city" value={employeeData.city} onChange={handleChange} required />
                    </div>
                    <div className="mb-3">
                        <label htmlFor="department" className="form-label formsL">Department</label>
                        <input type="text" className="form-control" id="department" name="department" value={employeeData.department} onChange={handleChange} required />
                    </div>
                    <button type="submit" className="btn formBtn">Submit</button>
                </form>
                {error && <div className="alert alert-danger">{error}</div>}
                {successMessage && <div className="alert alert-success">{successMessage}</div>}
            </div>
        </div>
    );
};

export default EditEmployee;
