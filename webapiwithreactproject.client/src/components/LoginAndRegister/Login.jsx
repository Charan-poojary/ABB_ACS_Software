import React, { useState, useEffect, useRef } from 'react';
import { Link } from 'react-router-dom';
import logo from '../../assets/images/logo.png';
import ABB_Video from '../../assets/Videos/banner.mp4';
import '../../assets/styles/Login.css';

const Login = ({ onLogin }) => {
    const [uname, setUsername] = useState('');
    const [pass, setPassword] = useState('');
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

    const handleSubmit = async (e) => {
        e.preventDefault();

        if (!uname && !pass) {
            setError('Fields cannot be empty');
            return;
        }

        if (!uname) {
            setError('Username cannot be empty');
            return;
        }
        if (!pass) {
            setError('Password cannot be empty');
            return;
        }

        try {
            const response = await fetch(`http://localhost:5213/api/Admin/by-credentials?usernameOrEmail=${uname}&password=${pass}`);
            const data = await response.json();
            if (response.ok) {
                const loginTime = new Date().toLocaleString();
                const lastLoginTime = localStorage.getItem('loginTime');

                localStorage.setItem('username', uname);
                localStorage.setItem('loginTime', loginTime);
                localStorage.setItem('lastAccessTime', lastLoginTime || loginTime);

                setSuccessMessage('Login Successful!');
                onLogin({ uname, loginTime, lastAccessTime: lastLoginTime || loginTime });
            } else {
                throw new Error(data.message || 'Invalid User Name or Password');
            }
        } catch (error) {
            setError(error.message || 'An unexpected error occurred');
        }
    };

    return (
        <div className="video-background">
            <video autoPlay loop muted style={{ opacity: 0.7 }}>
                <source src={ABB_Video} type="video/mp4" />
            </video>
            <div className="login-container">
                <div className="container">
                    <div className="card">
                        <div className="form">
                            <div className="left-side text-center justify-content-center">
                                <img src={logo} alt="Image not found" />
                            </div>

                            <div className="right-side">
                                <div className="register">
                                    <p>New User ? <Link to="/register">Register Now</Link></p>
                                </div>

                                <div className="hello">
                                    <div className="min-img text-center justify-content-center">
                                        <img src={logo} />
                                    </div>
                                    <br />
                                    <h4>Welcome back you have been missed!</h4>
                                </div>

                                <form onSubmit={handleSubmit}>
                                    <div className="input_text">
                                        <label htmlFor="uname" className="form-label">Username</label>
                                        <input
                                            type="text"
                                            className="form-control col-sm-8"
                                            id="uname"
                                            value={uname}
                                            onChange={(e) => setUsername(e.target.value)}
                                        />
                                    </div>
                                    <div className="input_text">
                                        <label htmlFor="pass" className="form-label">Password</label>
                                        <input
                                            type="password"
                                            className="form-control col-sm-8"
                                            id="pass"
                                            value={pass}
                                            onChange={(e) => setPassword(e.target.value)}
                                        />
                                    </div>
                                    <div className="recovery">
                                        <p><Link style={{color:"red"}} to="/forgot-password">Forgot Password?</Link></p>
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
    );
};

export default Login;
