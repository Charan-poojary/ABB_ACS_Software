import React, { useState, useEffect, useRef } from 'react';
import { Link, useNavigate } from 'react-router-dom';
import logo from '../../assets/images/logo.png';
import '../../assets/styles/Register.css';
import ABB_Video from '../../assets/Videos/banner.mp4';


const Register = () => {
    const navigate = useNavigate();
    const [AdminData, setAdminData] = useState({
        uname: '',
        email: '',
        dept: '',
        phno: '',
        pass: '',
    });
    const [cpass, setCpass] = useState('');
    const [error, setError] = useState('');
    const [successMessage, setSuccessMessage] = useState('');

    const isValidPassword = (pass) => {
        return pass.length >= 8;
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

        const { uname, email, dept, phno, pass } = AdminData;

        if (!uname && !email && !dept && !phno && !pass && !cpass) {
            setError('Fields cannot be empty');
            return;
        }

        if (!uname) {
            setError('Username cannot be empty');
            return;
        }

        if (!email) {
            setError('Email cannot be empty');
            return;
        }

        if (!phno) {
            setError('Phone number cannot be empty');
            return;
        }

        if (!pass) {
            setError('Password cannot be empty');
            return;
        }

        if (!cpass) {
            setError('Confirm Password cannot be empty');
            return;
        }

        if (!isValidPassword(pass)) {
            setError('Password must contain at least 8 characters.');
            return;
        }

        const isValidPhoneNumber = (phno) => {
            return /^\d{10}$/.test(phno);
        };

        if (pass !== cpass) {
            setError('Password did not match');
            return;
        }

        if (!isValidPhoneNumber(phno)) {
            setError('Invalid phone number. Please enter a 10-digit numeric phone number.');
            return;
        }

        try {
            // Check if user with same email already exists
            const checkResponse = await fetch(`http://localhost:5213/api/Admin/check-email/${email}`);
            if (!checkResponse.ok) {
                throw new Error('Network response was not ok');
            }
            const checkData = await checkResponse.json();
            if (checkData.exists) {
                setError('User with this email already exists,Please try some other email.');
                return;
            }

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
                    uname: '',
                    email: '',
                    dept: '',
                    phno: '',
                    pass: '',
                });
                navigate('/');
            }
        } catch (error) {
            setError('Registeration Failed');
        }
    };

    return (
        <>
            <div className="video-background">
                <video autoPlay loop muted style={{ opacity: 0.7 }}>
                    <source src={ABB_Video} type="video/mp4" />
                </video>
                <div className="login-container">
            <div className="container">
                <div className="card">
                    <div className="form">
                        <div className="left-side1 text-center justify-content-center">
                            <img src={logo} alt="Image Not found" />
                        </div>

                        <div className="right-side">
                            <div className="register">
                                <p>
                                    Already a User? <Link to="/">Sign In</Link>
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
                                        id="uname"
                                        name="uname"
                                        value={AdminData.uname}
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
                                        name="email"
                                        value={AdminData.email}
                                        onChange={handleChange}
                                    />
                                </div>
                                <div className="input_text">
                                    <label htmlFor="dept" className="form-label">
                                        Department
                                    </label>
                                    <input
                                        type="department"
                                        className="form-control col-sm-8"
                                        id="dept"
                                        name="dept"
                                        value={AdminData.dept}
                                        onChange={handleChange}
                                    />
                                </div>
                                <div className="input_text">
                                    <label htmlFor="phno" className="form-label">
                                        Phone
                                    </label>
                                    <input
                                        type="number"
                                        className="form-control col-sm-8"
                                        id="phno"
                                        name="phno"
                                        value={AdminData.phno}
                                        onChange={handleChange}
                                    />
                                </div>
                                <div className="input_text">
                                    <label htmlFor="pass" className="form-label">
                                        Password
                                    </label>
                                    <input
                                        type="password"
                                        className="form-control col-sm-8"
                                        id="pass"
                                        name="pass"
                                        value={AdminData.pass}
                                        onChange={handleChange}
                                    />
                                </div>
                                <div className="input_text">
                                    <label htmlFor="cpass" className="form-label">
                                        Confirm Password
                                    </label>
                                    <input
                                        type="password"
                                        className="form-control col-sm-8"
                                        id="cpass"
                                        value={cpass}
                                        onChange={(e) => setCpass(e.target.value)}
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
                </div>
            </div>
        </>
    );
};
export default Register;
