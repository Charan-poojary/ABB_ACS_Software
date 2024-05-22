import React, { useState, useEffect, useRef } from 'react';
import { Link, useNavigate } from 'react-router-dom';
import logo from '../../assets/images/logo.png';
import '../../assets/styles/Register.css';

const Register = () => {
    const navigate = useNavigate();
    const [AdminData, setAdminData] = useState({
        AdminName: '',
        AdminEmail: '',
        AdminDepartment: '',
        AdminPhone: '',
        AdminPassword: '',
    });
    const [AdminConfirmPassword, setAdminConfirmPassword] = useState('');
    const [error, setError] = useState('');
    const [successMessage, setSuccessMessage] = useState('');

    const isValidPassword = (AdminPassword) => {
        return AdminPassword.length >= 8;
    };

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
        setAdminData((prevState) => ({
            ...prevState,
            [name]: value,
        }));
    };

    const handleSubmit = async (event) => {
        event.preventDefault();

        const { AdminName, AdminEmail, AdminDepartment, AdminPhone, AdminPassword } = AdminData;

        if (!AdminName || !AdminEmail || !AdminDepartment || !AdminPhone || !AdminPassword || !AdminConfirmPassword) {
            setError('Fields cannot be empty');
            return;
        }

        if (!isValidPassword(AdminPassword)) {
            setError('Password must contain at least 8 characters.');
            return;
        }

        const isValidPhoneNumber = (AdminPhone) => {
            return /^\d{10}$/.test(AdminPhone);
        };

        if (AdminPassword !== AdminConfirmPassword) {
            setError('Password did not match');
            return;
        }

        if (!isValidPhoneNumber(AdminPhone)) {
            setError('Invalid phone number. Please enter a 10-digit numeric phone number.');
            return;
        }

        try {
            const response = await fetch('http://localhost:5213/api/Admin', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json',
                },
                body: JSON.stringify(AdminData),
            });

            if (!response.ok) {
                const errorData = await response.json();
                setError(errorData.message || 'Registration failed.');
                await response.text();
            } else {
                setSuccessMessage('Registration is Successful!');
                setAdminData({
                    AdminName: '',
                    AdminEmail: '',
                    AdminDepartment: '',
                    AdminPhone: '',
                    AdminPassword: '',
                });
                navigate('/');
            }
        } catch (error) {
            setError('Registeration Failed');
        }
    };

    return (
        <>
            <div className="container">
                <div className="card">
                    <div className="form">
                        <div className="left-side1 text-center justify-content-center">
                            <img src={logo} alt="Image Not found" />
                        </div>

                        <div className="right-side">
                            <div className="register">
                                <p>
                                    Already a member? <Link to="/">Sign In</Link>
                                </p>
                            </div>

                            <div className="hello">
                                <div className="min-img text-center justify-content-center">
                                    <img src={logo} alt="Logo" />
                                </div>
                                <br />
                                <h4>Welcome to our Community!</h4>
                            </div>

                            <form onSubmit={handleSubmit}>
                                <div className="input_text">
                                    <label htmlFor="username" className="form-label">
                                        Name
                                    </label>
                                    <input
                                        type="text"
                                        className="form-control col-sm-8"
                                        id="username"
                                        name="AdminName"
                                        value={AdminData.AdminName}
                                        onChange={handleChange}
                                    />
                                </div>
                                <div className="input_text">
                                    <label htmlFor="email" className="form-label">
                                        Email
                                    </label>
                                    <input
                                        type="email"
                                        className="form-control col-sm-8"
                                        id="email"
                                        name="AdminEmail"
                                        value={AdminData.AdminEmail}
                                        onChange={handleChange}
                                    />
                                </div>
                                <div className="input_text">
                                    <label htmlFor="department" className="form-label">
                                        Department
                                    </label>
                                    <input
                                        type="department"
                                        className="form-control col-sm-8"
                                        id="department"
                                        name="AdminDepartment"
                                        value={AdminData.AdminDepartment}
                                        onChange={handleChange}
                                    />
                                </div>
                                <div className="input_text">
                                    <label htmlFor="phone" className="form-label">
                                        Phone
                                    </label>
                                    <input
                                        type="number"
                                        className="form-control col-sm-8"
                                        id="phone"
                                        name="AdminPhone"
                                        value={AdminData.AdminPhone}
                                        onChange={handleChange}
                                    />
                                </div>
                                <div className="input_text">
                                    <label htmlFor="password" className="form-label">
                                        Password
                                    </label>
                                    <input
                                        type="password"
                                        className="form-control col-sm-8"
                                        id="password"
                                        name="AdminPassword"
                                        value={AdminData.AdminPassword}
                                        onChange={handleChange}
                                    />
                                </div>
                                <div className="input_text">
                                    <label htmlFor="confirmPassword" className="form-label">
                                        Confirm Password
                                    </label>
                                    <input
                                        type="password"
                                        className="form-control col-sm-8"
                                        id="confirmPassword"
                                        value={AdminConfirmPassword}
                                        onChange={(e) => setAdminConfirmPassword(e.target.value)}
                                    />
                                </div>
                                <div className="btn">
                                    <button type="submit">Sign in</button>
                                </div>
                            </form>
                            {error && <div className="alert alert-danger">{error}</div>}
                            {successMessage && <div className="alert alert-success">{successMessage}</div>}
                        </div>
                    </div>
                </div>
            </div>
        </>
    );
};
export default Register;
