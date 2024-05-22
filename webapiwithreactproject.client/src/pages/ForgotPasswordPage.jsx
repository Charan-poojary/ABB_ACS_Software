import React, { useState, useEffect, useRef } from 'react';
import logo from '../assets/images/logo.png';
import { useNavigate } from 'react-router-dom';
import '../assets/styles/Login.css';
import emailjs from 'emailjs-com';

const ForgotPasswordPage = () => {
    const [email, setEmail] = useState('');
    const [userOtp, UserSetOtp] = useState('');
    const [otp, setOtp] = useState('');
    const [error, setError] = useState('');
    const [user, setUser] = useState('');
    const [successMessage, setSuccessMessage] = useState('');
    const [showEmailInput, setShowEmailInput] = useState(true);
    const [otpTimer, setOtpTimer] = useState(null);
    const [otpExpired, setOtpExpired] = useState(false);
    const [remainingTime, setRemainingTime] = useState(0);
    const [originalEmail, setOriginalEmail] = useState('');
    const [otpVerified, setOtpVerified] = useState(false);

    const timeoutRef = useRef(null);
    const navigate = useNavigate();

    const isValidEmail = (email) => {
        return /^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(email);
    };

    useEffect(() => {
        timeoutRef.current = setTimeout(() => {
            setError('');
            setSuccessMessage('');
        }, 1000);

        return () => clearTimeout(timeoutRef.current);
    }, [error, successMessage]);

    useEffect(() => {
        return () => clearTimeout(otpTimer);
    }, []);

    const sendEmail = (generatedOtp, username,userEmail) => {
        const serviceID = 'service_8vyt2oq';
        const templateID = 'template_xeo9gwh';
        const userID = 'cM0uQ4EtAbOl8m5ap';

        const templateParams = {
            name: username,
            otp: generatedOtp,
            userEmail: userEmail,
        };

        emailjs.send(serviceID, templateID, templateParams, userID)
            .then((response) => {
                setSuccessMessage('OTP sent successfully');
                console.log(response);
                setEmail('');
            })
            .catch((error) => {
                setError('Failed to send OTP');
                console.log(error);
            });

        setOtpTimer(setTimeout(() => {
            setOtpExpired(true);
            setOtp('');
        }, 60000));

        setRemainingTime(60);
    };

    const handleSubmit = async (e) => {
        e.preventDefault();

        if (!email) {
            setError('This field cannot be empty');
            return;
        }

        if (!isValidEmail(email)) {
            setError('Invalid email format');
            return;
        }

        const generatedOtp = Math.floor(100000 + Math.random() * 900000);
        setOtp(generatedOtp);
        setOtpExpired(false);
        clearTimeout(otpTimer);

        fetch(`http://localhost:5213/api/Admin/forgot-password?email=${email}`)
            .then(response => response.ok ? response.text() : Promise.reject(response))
            .then(username => {
                setUser(username);
                sendEmail(generatedOtp, username,email);
                setShowEmailInput(false);
                setOriginalEmail(email);
            })
            .catch(error => {
                setError('User not found');
            });
    };

    useEffect(() => {
        if (remainingTime > 0) {
            setTimeout(() => setRemainingTime(remainingTime - 1), 1000);
        }
    }, [remainingTime]);


    const handleVerifyOtp = (e) => {
        e.preventDefault();
        const userOtpNumber = parseInt(userOtp, 10);
        if (otp === userOtpNumber) {
            setSuccessMessage('OTP verified successfully');
            setOtpVerified(true);
            navigate('/change-password', { state: { username: user } });
        } else {
            setError('Invalid OTP');
        }
    };

    const handleResendButtonSubmit = (e) => {
        e.preventDefault();
        const NewGeneratedOtp = Math.floor(100000 + Math.random() * 900000);
        setOtp(NewGeneratedOtp);
        setOtpExpired(false);
        clearTimeout(otpTimer);
        sendEmail(NewGeneratedOtp, user, originalEmail);
        setShowEmailInput(false);
        const resendButton = document.getElementById('resendOtpButton');
        if (resendButton) {
            resendButton.disabled = true;
            setTimeout(() => {
                resendButton.disabled = false;
            }, 60000);
        }
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
                                <h4>Forgot Your Password? </h4>
                            </div>

                            <form onSubmit={handleSubmit}>
                                {showEmailInput && (
                                    <div className="input_text">
                                        <label htmlFor="email" className="form-label">Email</label>
                                        <input type="email" className="form-control col-sm-8" id="email" value={email} onChange={(e) => setEmail(e.target.value)} />
                                    </div>
                                )}

                                {!showEmailInput && (
                                    <div className="input_text">
                                        <label htmlFor="otp" className="form-label">Enter OTP</label>
                                        <input type="text" className="form-control col-sm-8" id="otp" value={userOtp} onChange={(e) => UserSetOtp(e.target.value)} />
                                    </div>
                                )}

                                <div className="btn">
                                    {showEmailInput ? (
                                        <button type="submit">Send OTP</button>
                                    ) : (
                                        <button type="submit" onClick={handleVerifyOtp}>Verify OTP</button>
                                    )}
                                </div>


                                <div className="text-center">
                                    {!showEmailInput && (
                                        <>
                                            {remainingTime > 0 ? (
                                                <p className="lead text-light">Your OTP will expire in: {remainingTime} seconds</p>
                                            ) : (
                                                <>
                                                    <p className="lead text-light">Your OTP has expired.</p>
                                                    <div className="btn">
                                                            <button id="resendOtpButton" type="submit" onClick={handleResendButtonSubmit}>Resend OTP</button>
                                                    </div>
                                                </>
                                            )}
                                        </>
                                    )}
                                </div>
                                {error && <div className="alert alert-danger">{error}</div>}
                                {successMessage && <div className="alert alert-success">{successMessage}</div>}
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </>
    );
}
export default ForgotPasswordPage;
