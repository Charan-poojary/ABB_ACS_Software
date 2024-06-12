import React, { useState, useEffect, useRef } from 'react';
import DatePicker from 'react-datepicker';
import 'react-datepicker/dist/react-datepicker.css';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPlus, faTrash, faSync, faEdit } from '@fortawesome/free-solid-svg-icons';


const PendingActivities = () => {
    const [startDate, setStartDate] = useState(new Date());
    const [endDate, setEndDate] = useState(new Date());
    const [showTable, setShowTable] = useState(false);
    const [pendingActivities, setPendingActivities] = useState([]);
    const [filteredActivities, setFilteredActivities] = useState([]);
    const [selectedRows, setSelectedRows] = useState([]);
    const [error, setError] = useState('');
    const [successMessage, setSuccessMessage] = useState('');

 
        const fetchPendingActivities = async () => {
            try {
                const response = await fetch('http://localhost:5213/api/PendingActivity');
                if (!response.ok) {
                    throw new Error(`HTTP error! status: ${response.status}`);
                }
                const data = await response.json();
                console.log("here", data);
                setPendingActivities(data);
            } catch (error) {
                console.error('There was an error fetching the pending activities:', error);
            }
        };



    const timeoutRef = useRef(null);

    useEffect(() => {
        timeoutRef.current = setTimeout(() => {
            setError('');
            setSuccessMessage('');
        }, 1000);

        return () => clearTimeout(timeoutRef.current);
    }, [error, successMessage]);

    useEffect(() => {
        fetchPendingActivities();
    }, []);

    const handleCheckboxChange = (srno) => {
        if (selectedRows.includes(srno)) {
            setSelectedRows(selectedRows.filter(row => row !== srno));
        } else {
            setSelectedRows([...selectedRows, srno]);
        }
    };

    const handleRetry = (event) => {
        event.preventDefault();
        document.getElementById('pendingActivitiesSelect').value = 'all';
        setStartDate(new Date()); 
        setFilteredActivities(pendingActivities); 
        setShowTable(false);
    };




    const handleSearch = (event) => {
        event.preventDefault();
        const searchDate = startDate;

        const results = pendingActivities.filter(activity => {
            const activityDate = new Date(activity.dates);
            return (
                document.getElementById('pendingActivitiesSelect').value === 'all' ||
                activityDate.toDateString() === searchDate.toDateString()
            );
        });

        setFilteredActivities(results);
        setShowTable(true);
    };


    const handleSelectdDeleteConfirmation = () => {
        const isConfirmed = window.confirm('Are you sure you want to delete the records?');

        if (isConfirmed) {
            handleSelectedDelete();
        }
    };

    const handleSelectedDelete = async () => {
        try {
            await Promise.all(selectedRows.map(async (srno) => {
                const response = await fetch(`http://localhost:5213/api/PendingActivity/${srno}`, {
                    method: 'DELETE',
                });

                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }

            }));

            setSelectedRows([]);
            fetchPendingActivities();
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        }
    };


    return (
        <>
            <div className="container employeeContainer mt-2 justify-content-center align-items-start">
                {error && <div className="alert alert-danger" role="alert">{error}</div>}
                {successMessage && <div className="alert alert-success">{successMessage}</div>}
                <div className='card'>
                    <h1 className="mb-4 p-2">Delete Pending Activities</h1>
                    <form className='row g-3 align-items-end'>
                        <div className='row p-4'>
                            <button
                                className={`custom-btn danger ms-2 ${selectedRows.length === 0 ? 'disabled' : ''}`}
                                onClick={handleSelectdDeleteConfirmation}
                                disabled={selectedRows.length === 0}
                                style={{ opacity: selectedRows.length === 0 ? 0.5 : 1, pointerEvents: selectedRows.length === 0 ? 'none' : 'auto' }}
                            >
                                <FontAwesomeIcon icon={faTrash} className="me-2" />
                                Delete Pending Activies
                            </button>
                        </div>
                        <div className='col-md-3 ms-2'>
                            <div className="form-group">
                                <label htmlFor="pendingActivitiesSelect" className="form-label2">Pending Activities</label>
                                <select id="pendingActivitiesSelect" className="form-select">
                                    <option value="all">All</option>
                                    {pendingActivities.map(activity => (
                                        <option key={activity.srno} value={activity.srno}>{activity.activitytype}</option>
                                    ))}
                                </select>
                            </div>
                        </div>
                        <div className='col-md-3'>
                            <div className="form-group">
                                <label htmlFor="fromDate" className="form-label2">From</label>
                                <DatePicker selected={startDate} onChange={date => setStartDate(date)} className="form-control" />
                            </div>
                        </div>
                        <div className='col-md-3'>
                            <div className="form-group">
                                <label htmlFor="toDate" className="form-label2">To</label>
                                <DatePicker selected={endDate} onChange={date => setEndDate(date)} className="form-control" />
                            </div>
                        </div>
                        <div className='col-md-auto'>
                            <button onClick={(event) => handleSearch(event)} className="btn btn-danger">
                                Search
                            </button>
                        </div>
                        <div className='col-md-auto'>
                            <button onClick={(event)=>handleRetry(event)} className="btn btn-secondary">
                                Retry
                            </button>
                        </div>
                    </form>
                    {showTable && (
                        <div className="table-responsive text-center">
                            <table className="table table-striped">
                                <thead>
                                    <tr>
                                        <th>Select</th>
                                        <th>Activity Type</th>
                                        <th>Date</th>
                                        <th>Priority</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    {filteredActivities.map(activity => (
                                        <tr key={activity.srno}>
                                            <td><input
                                                type="checkbox"
                                                onChange={() => handleCheckboxChange(activity.srno)}
                                                checked={selectedRows.includes(activity.srno)}
                                            /></td>
                                            <td>{activity.activitytype}</td>
                                            <td>{activity.dates}</td>
                                            <td>{activity.priority}</td>
                                        </tr>
                                    ))}
                                </tbody>
                            </table>
                        </div>
                    )}
                </div>
            </div>

        </>
    );
};

export default PendingActivities;
