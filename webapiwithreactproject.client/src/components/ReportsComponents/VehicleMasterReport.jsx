import React from 'react';
import '../../assets/styles/fetchEmployee.css';


const VehicleMasterReport = () => {

/*    const [EmployeeMasters, setEmployeeMasters] = useState([]);
    const [allEmployeeMasters, setAllEmployeeMasters] = useState([]);
    const [selectedRows, setSelectedRows] = useState([]);*/



    return (
        <>
            <div className="container employeeContainer  mt-2 justify-content-center align-items-start">
                <div className='card'>
                    <h1 className="mb-4 ms-2">Vehicle Master Report</h1>
                    <div className='container-fluid mb-4'>
                        <div className="row mb-4">
                            <div className="col-md-3 mb-2">
                                <label htmlFor="compid" className="form-label2">Company:</label>
                                <select
                                    className="form-select form-control border border-dark"
                                    name="compid"

                                >
                                    <option value="">All</option>
                                    <option value="1">Bharat Petroleum Corporation Limited</option>
                                </select>
                            </div>
                            <div className="col-md-3 mb-2">
                                <label htmlFor="locationid" className="form-label2">Location:</label>
                                <select
                                    className="form-control form-select border border-dark"
                                    name="locationid"

                                >
                                    <option value="">All</option>
                                    <option value="1">WARANGAL DEPOT</option>
                                </select>
                            </div>
                            <div className="col-md-3 mb-2">
                                <label htmlFor="deptname" className="form-label2">Department:</label>
                                <select
                                    className="form-control form-select border border-dark"
                                    name="deptname"

                                >
                                    <option value="">All</option>
                                    <option value="1">Administrator</option>
                                    <option value="2">CLEANER</option>
                                    <option value="3">DRIVER</option>
                                    <option value="4">Electrical</option>
                                    <option value="5">Maintainance</option>
                                    <option value="6">Operation</option>
                                    <option value="7">Planning</option>
                                    <option value="8">Safety</option>
                                </select>
                            </div>
                            <div className="col-md-3 mb-2">
                                <label htmlFor="subdeptname" className="form-label2">Sub Dept:</label>
                                <select
                                    className="form-control form-select border border-dark"
                                    name="subdeptname"
                                    value=""
                                >
                                    <option value="">All</option>
                                </select>
                            </div>
                        </div>
                        <div className="row mb-4">
                            <div className="col-md-3 mb-2">
                                <label htmlFor="type" className="form-label2">Type:</label>
                                <select
                                    className="form-control form-select border border-dark"
                                    name="type"
                                    disabled
                                >
                                    <option value="">Vehicle Master Report</option>
                                </select>
                            </div>

                            <div className="col-md-3 mb-2">
                                <label htmlFor="status" className="form-label2">Status:</label>
                                <select
                                    className="form-control form-select border border-dark"
                                    name="status"

                                >
                                    <option value="">All</option>
                                    <option value="Active">Active</option>
                                    <option value="Deactive">Deactive</option>
                                </select>
                            </div>
                            <div className="col-md-3 mt-4">
                                <button className="custom-btn secondary float-end">Refresh 
                                </button>
                            </div>
                        </div>
                        <div className="row mb-4">
                            <div className="col-md-3 mb-2">
                                <label htmlFor="format" className="form-label2">Format:</label>
                                <select
                                    className="form-control form-select border border-dark"
                                    name="format"
                                >
                                    <option value="1">PDF</option>
                                    <option value="2">Excel</option>
                                </select>
                            </div>
                          
                            </div>

                        <div className="row mb-4 justify-content-center">
                            <div className="col-md-3 mb-2">
                                <button className="btn btn-secondary w-80">Export</button>
                            </div>
                            <div className="col-md-3 mb-2">
                                <button className="btn btn-secondary w-80">Export For All</button>
                            </div>
                        </div>
                        <div className="row mb-4 justify-content-end">
                            <div className="col-md-3 mb-2">
                                <label htmlFor="vehiclecount" className="form-label2">Vehicle Count:</label>
                                <input id="vehiclecount"
                                    className="form-control border border-dark"
                                >
                                </input>
                            </div>
                        </div>
                       
                    </div>
                </div>
            </div>
        </>
    );
};

export default VehicleMasterReport;
