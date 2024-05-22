import React, { useState, useEffect,useRef } from 'react';
import logo from '../../assets/images/logo.png';
import { Link } from 'react-router-dom';
import '../../assets/styles/Login.css'


const Login = ({ onLogin }) => {
    const [username, setUsername] = useState('');
    const [password, setPassword] = useState('');
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
        if (!username || !password) {
            setError('Fields cannot be empty');
            return;
        }
        try {
            const response = await fetch(`http://localhost:5213/api/Admin/by-credentials?usernameOrEmail=${username}&password=${password}`);
            const data = await response.json();
            if (response.ok) {
                const loginTime = new Date().toLocaleString();
                const lastAccessTime = localStorage.getItem('lastAccessTime') || 'First time access';
                localStorage.setItem('username', username);
                localStorage.setItem('loginTime', loginTime);
                localStorage.setItem('lastAccessTime', lastAccessTime);

                setSuccessMessage('Login Successful!');
                onLogin({ username, loginTime, lastAccessTime });
            } else {
                throw new Error(data.message || 'Invalid User Name or Password');
            }
        } catch (error) {
            setError(error.message || 'An unexpected error occurred');
        }
    };



    return (
        <>
            <div className="container">
                <div className="card">
                    <div className="form">
                        <div className="left-side text-center justify-content-center">
                            <img src={logo} alt="Image not found"/>
                        </div>

                        <div className="right-side">
                            <div className="register">
                                <p>Not a member? <Link to="/register">Register Now</Link></p>
                            </div>

                            <div className="hello">
                                <div className="min-img text-center justify-content-center">
                                    <img src={logo} />
                                </div>
                                <br />
                                <h4>Welcome back you have been missed! </h4>
                            </div>


                            <form onSubmit={handleSubmit}>

                                <div className="input_text">
                                    <label htmlFor="username" className="form-label">Username</label>
                                    <input type="text" className="form-control col-sm-8" id="username" value={username} onChange={(e) => setUsername(e.target.value)} />
                                </div>
                                <div className="input_text">
                                    <label htmlFor="password" className="form-label">Password</label>
                                    <input type="password" className="form-control col-sm-8" id="password" value={password} onChange={(e) => setPassword(e.target.value)} />
                                </div>
                                <div className="recovery">
                                    <p><Link to="/forgot-password">Forgot Password ?</Link></p>
                                </div>
                                <div className="btn">
                                    <button type="submit">Sign in</button>
                                </div>

                            </form>
                            {error && <div className="alert alert-danger">{error}</div>}
                            {successMessage && <div className="alert alert-success">{successMessage}</div>}

                       {/*     <hr />*/}
{/*                            <div className="or">
                                <p>or signin with</p>
                            </div>
                            <div className="boxes">
                                <span><img src="https://imgur.com/XnY9cKl.png" /></span>
                                <span><img src="https://imgur.com/ODlSChL.png" /></span>
                                <span><img src="https://imgur.com/mPBRdQt.png" /></span>
                            </div>*/} 
                        </div>
                    </div>
                </div>
            </div>

        </>
    );
};

export default Login;
