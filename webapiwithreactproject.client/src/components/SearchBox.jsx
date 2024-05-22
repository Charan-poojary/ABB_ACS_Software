import React, { useState,useRef,useEffect } from 'react';
import '../assets/styles/search.css';

const SearchBox = () => {
    const [searchQuery, setSearchQuery] = useState('');
    const [searchResults, setSearchResults] = useState([]);
    const [isLoading, setIsLoading] = useState(false);
    const [searchPerformed, setSearchPerformed] = useState(false);
    const [error, setError] = useState(null);
    const [successMessage, setSuccessMessage] = useState(null);

    const timeoutRef = useRef(null);
    useEffect(() => {
        timeoutRef.current = setTimeout(() => {
            setError(null);
            setSuccessMessage(null);
        }, 500);

        return () => clearTimeout(timeoutRef.current);
    }, [error, successMessage]);

    const handleSearch = async () => {
        if (searchQuery.trim() === '') {
            setError('Please type something to serach.');
            return;
        }

        try {
            setIsLoading(true);
            const response = await fetch(`http://localhost:5213/api/employees/search?query=${searchQuery}`);
            if (!response.ok) {
                throw new Error('Failed to fetch data');
            }
            const data = await response.json();
            setSearchResults(data);
            setSearchPerformed(true);
        } catch (error) {
            console.error(error);
        } finally {
            setIsLoading(false);
        }
    };

    const handleInputChange = async (e) => {
        setSearchQuery(e.target.value);
        setSearchPerformed(false);
        if (e.target.value.trim() == '') {
            setSearchResults([]);
        } else {
            await handleSearch();
        }
    };

    const handleKeyPress = (e) => {
        if (e.key === 'Enter') {
            handleSearch();
        }
    };

    return (
        <div className="mt-5 homeContainer">
            <div className="card p-4">
                <div className="input-group mb-3">
                    <input
                        type="text"
                        className="form-control"
                        placeholder="Type something to search"
                        aria-label="Recipient's username"
                        aria-describedby="button-addon2"
                        onChange={handleInputChange}
                        onKeyUp={handleKeyPress}
                    />
                    <button className="btn homeBtn" onClick={handleSearch} type="button" id="button-addon2">
                        Search
                    </button>
                </div>
                {error && <div className="alert alert-danger">{error}</div>}
                {successMessage && <div className="alert alert-success">{successMessage}</div>}
                {isLoading ? (
                    <p>Loading...</p>
                ) : searchResults.length && searchPerformed ? (
                    <div className="table-responsive">
                        <table className="table table-striped">
                            <thead>
                                <tr>
                                    <th>Employee ID</th>
                                    <th>Name</th>
                                    <th>City</th>
                                    <th>Department</th>
                                    <th>Gender</th>
                                </tr>
                            </thead>
                            <tbody>
                                {searchResults.map((employee) => (
                                    <tr key={employee.employeeId}>
                                        <td>{employee.employeeId}</td>
                                        <td>{employee.name}</td>
                                        <td>{employee.city}</td>
                                        <td>{employee.department}</td>
                                        <td>{employee.gender}</td>
                                    </tr>
                                ))}
                            </tbody>
                        </table>
                    </div>
                ) : null}
                {searchPerformed && !isLoading && !searchResults.length ? <p>No records found.</p> : null}
            </div>
        </div>
    );
};

export default SearchBox;
