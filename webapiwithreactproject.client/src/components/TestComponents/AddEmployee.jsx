import React, { useState,useEffect,useRef } from 'react';
import '../assets/styles/form.css'

const AddEmployee = ({ onSubmit}) => {
    const [employeeData, setEmployeeData] = useState({
        name: '',
        city: '',
        department: '',
        gender: 'Male',
    });
    const [error, setError] = useState('');
    const [successMessage, setSuccessMessage] = useState('');

    const timeoutRef = useRef(null);

    useEffect(() => {
        timeoutRef.current = setTimeout(() => {
            setError('');
            setSuccessMessage('');
        }, 1000);

        return () => clearTimeout(timeoutRef.current);
    }, [error, successMessage]);

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
            const response = await fetch('http://localhost:5213/api/Employees', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json',
                },
                body: JSON.stringify(employeeData),
            });

            if (!response.ok) {
                const errorData = await response.json();
                setError(errorData.message || 'Employee cannot be added');
                await response.text();
            } else {
                setSuccessMessage('Employee Added Successfully!')
                setEmployeeData({
                    name: '',
                    city: '',
                    department: '',
                    gender: 'Male',
                });
                onSubmit();
            }
        } catch (error) {
            setError('Employee with this email already exists');
        }
    };

    return (
        <div className=" container ">
        <div className="card p-5">
            <h2>Add Employee</h2>
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
                <div className="mb-3">
                        <label className="form-label formsL">Gender</label>
                    <br />
                    <div>
                        <div className="form-check form-check-inline">
                            <input className="form-check-input" type="radio" id="male" name="gender" value="Male" checked={employeeData.gender === 'Male'} onChange={handleChange} />
                                <label className="form-check-label formsL" htmlFor="male">Male</label>
                        </div>
                        <div className="form-check form-check-inline">
                            <input className="form-check-input" type="radio" id="female" name="gender" value="Female" checked={employeeData.gender === 'Female'} onChange={handleChange} />
                                <label className="form-check-label formsL" htmlFor="female">Female</label>
                        </div>
                    </div>
                </div>
                <button type="submit" onClick={ handleSubmit } className="btn formBtn">Submit</button>
            </form>
            {error && <div className="alert alert-danger">{error}</div>}
                {successMessage && <div className="alert alert-success">{successMessage}</div>}
            </div>
        </div>
    );
};

export default AddEmployee;
