import React, { useState, useEffect } from 'react';
import { Routes, Route, Navigate } from 'react-router-dom';
import LoginPage from "./pages/LoginPage";
import RegisterPage from "./pages/RegisterPage";
import HomePage from "./pages/HomePage";
import ChangePasswordPage from "./pages/ChangePasswordPage" 
import ForgotPasswordPage from "./pages/ForgotPasswordPage" 
import { useNavigate } from 'react-router-dom';
import Cookies from 'js-cookie';
import './App.css';

const App = () => {
    const [isLoggedIn, setIsLoggedIn] = useState(false);

    const navigateTo = useNavigate();

    useEffect(() => {
        const storedAuth = Cookies.get('isLoggedIn');
        if (storedAuth === 'true') {
            setIsLoggedIn(true);
            navigateTo('/home');
        }
    }, [navigateTo]);

    const handleLogin = () => {
        setIsLoggedIn(true);
        Cookies.set('isLoggedIn', 'true');
        navigateTo('/home');
    };

    const handleRegister = () => {
        navigateTo('/');
    };

    const handleLogout = () => {
        setIsLoggedIn(false);
        Cookies.remove('isLoggedIn');
        navigateTo('/');
    };


    return (
        <Routes>
            <Route path="/" element={<LoginPage onLogin={handleLogin} />} />
            <Route path="/register" element={<RegisterPage onRegister={handleRegister} />} />
            <Route path="/home" element={isLoggedIn ? <HomePage onLogout={handleLogout} /> : <Navigate to="/" />} />
            <Route path="/change-password" element={<ChangePasswordPage />} />
            <Route path="/forgot-password" element={<ForgotPasswordPage />} />
        </Routes>
    );
};

export default App;
