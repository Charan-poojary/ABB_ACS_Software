import React, { useState, useEffect, useRef } from 'react';
import logo from '../assets/images/logo.png';
import { useNavigate, useLocation } from 'react-router-dom';
import '../assets/styles/Login.css';

const ChangePasswordPage = () => {
    const [oldpassword, setOldPassword] = useState('');
    const [password, setPassword] = useState('');
    const [confirmPassword, setConfirmPassword] = useState('');
    const [error, setError] = useState('');
    const [successMessage, setSuccessMessage] = useState('');

    const timeoutRef = useRef(null);
    const navigate = useNavigate();

    const user = localStorage.getItem('username');


    const isValidPassword = (password) => {
        return password.length >= 8;
    };

    const handlePasswordChange = (e) => {
        const newPassword = e.target.value;
        setPassword(newPassword);

        if (!isValidPassword(newPassword)) {
            setError('Password must contain at least 8 characters.');
        }
    };

    useEffect(() => {
        timeoutRef.current = setTimeout(() => {
            setError('');
            setSuccessMessage('');
        }, 1000);

        return () => clearTimeout(timeoutRef.current);
    }, [error, successMessage]);

    const handleSubmit = async (e) => {
        e.preventDefault();

        if (!oldpassword) {
            setError('Please Enter Old password');
            return;
        }

        if (!password && !confirmPassword) {
            setError('Fields cannot be empty');
            return;
        }

        if (!password) {
            setError('Password cannot be empty');
            return;
        }

        if (password !== confirmPassword) {
            setError('Password did not match');
            return;
        }

        fetch(`http://localhost:5213/api/Admin/change-password?username=${user}&password=${password}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json',
            },
        })
            .then(response => {
                if (response.ok) {
                    setSuccessMessage('Password updated successfully');
                    setOldPassword('');
                    setPassword('');
                    setConfirmPassword('');
                    navigate('/');
                } else {
                    setError('Failed to update password');
                }
            })
            .catch(error => {
                setError('An unexpected error occurred');
            });
    }

    return (
        <>
            <div className="container">
                <div className="card">
                    <div className="form">
                        <div className="left-side text-center justify-content-center">
                            <img src={logo} alt="Image not found" />
                        </div>

                        <div className="right-side">
                            <div className="hello">
                                <div className="min-img text-center justify-content-center">
                                    <img src={logo} alt="Logo" />
                                </div>
                                <br />
                                <h4>Change Your Password here</h4>
                            </div>

                            <form onSubmit={handleSubmit}>
                                <div className="input_text">
                                    <label htmlFor="oldpassword" className="form-label">Old Password</label>
                                    <input type="password" className="form-control col-sm-8" id="oldpassword" value={oldpassword} onChange={(e) => setOldPassword(e.target.value)} />
                                </div>
                                <div className="input_text">
                                    <label htmlFor="password" className="form-label">New Password</label>
                                    <input type="password" className="form-control col-sm-8" id="password" value={password} onChange={handlePasswordChange} />
                                </div>
                                <div className="input_text">
                                    <label htmlFor="confirmPassword" className="form-label">Confirm New Password</label>
                                    <input type="password" className="form-control col-sm-8" id="confirmPassword" value={confirmPassword} onChange={(e) => setConfirmPassword(e.target.value)} />
                                </div>

                                <div className="btn">
                                    <button type="submit">Submit</button>
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
}
export default ChangePasswordPage;