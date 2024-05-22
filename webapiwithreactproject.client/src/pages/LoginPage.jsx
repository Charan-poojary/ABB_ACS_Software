import Login from '../components/LoginAndRegister/Login'

const LoginPage = ({ onLogin }) => {
    return (
        <>
            <Login onLogin={ onLogin} />
        </>
    );
};

export default LoginPage;