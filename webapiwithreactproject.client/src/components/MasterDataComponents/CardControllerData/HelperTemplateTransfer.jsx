import React, { useState, useEffect, useRef } from 'react';
import '../../../assets/styles/fetchEmployee.css';
import '../../../assets/styles/Login.css'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPlus, faSync, faTrash } from '@fortawesome/free-solid-svg-icons';

const HelperTemplateTransfer = () => {
    const [EmployeeMasters, setEmployeeMasters] = useState([]);
    /*  const [allEmployeeMasters, setAllEmployeeMasters] = useState([]);*/
    const [selectedRows, setSelectedRows] = useState([]);
    /* const [newEmployeeMaster, setNewEmployeeMaster] = useState({
         srno: '',
         empid: '',
         empcode: '',
         enrollno: '',
         fname: '',
         compid: '',
         locationid: '',
         subdeptname: '',
         deptname: '',
         designation: '',
         section: '',
         status: '',
         project: '',
     });
     const [editedEmployeeMaster, setEditedEmployeeMaster] = useState({
         srno: '',
         empid: '',
         empcode: '',
         enrollno: '',
         fname: '',
         compid: '',
         locationid: '',
         subdeptname: '',
         deptname: '',
         designation: '',
         section: '',
         status: '',
         project: '',
     });
     const [searchParams, setSearchParams] = useState({
         compid: '',
         locationid: '',
         deptname: '',
         status: '',
         designation: '',
         section: '',
     });*/

    const [error, setError] = useState('');
    const [successMessage, setSuccessMessage] = useState('');
    const [loading, setLoading] = useState(false);

    const timeoutRef = useRef(null);

    useEffect(() => {
        timeoutRef.current = setTimeout(() => {
            setError('');
            setSuccessMessage('');
        }, 1000);

        return () => clearTimeout(timeoutRef.current);
    }, [error, successMessage]);

    useEffect(() => {
        fetchEmployeeMasters();
    }, []);

    /*const fetchCompanyName = async (compid) => {
        try {
            const response = await fetch(`http://localhost:5213/api/CompanyMasters/${compid}`);
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            const compname = await response.text();
            return compname;
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
            return compid; // Fallback to compid if there's an error
        }
    };

    const fetchLocationName = async (locationid) => {
        try {
            const response = await fetch(`http://localhost:5213/api/Locations/Name/${locationid}`);
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            const locationName = await response.text();
            return locationName;
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
            return locationid; // Fallback to locationid if there's an error
        }
    };

    const fetchDesignationName = async (designationid) => {
        try {
            const response = await fetch(`http://localhost:5213/api/Designations/Name/${designationid}`);
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            const designationName = await response.text();
            return designationName;
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
            return designationid; // Fallback to designationid if there's an error
        }
    };

    const fetchDepartmentName = async (deptname) => {
        try {
            const response = await fetch(`http://localhost:5213/api/Departments/Name/${deptname}`);
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            const departmentName = await response.text();
            return departmentName;
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
            return deptname; // Fallback to deptid if there's an error
        }
    };
*/
    const fetchEmployeeMasters = async () => {
        try {
            setLoading(true);
            const response = await fetch('http://localhost:5213/api/HelperDetails');
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            const data = await response.json();
            setEmployeeMasters(data);
            console.log("here", data);
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        } finally {
            setLoading(false);
        }
    };


    /*   const handleAddClick = async () => {
           if (!newEmployeeMaster.enrollno && !newEmployeeMaster.empcode) {
               setError("The Employee code and Enrollment number cannot be empty");
               return;
           }
           console.log("length", EmployeeMasters.length);
           const newEmpId = EmployeeMasters.length + 1;
           newEmployeeMaster.empid = newEmpId;
           console.log("new here", newEmployeeMaster.empid);
   
           try {
               if (newEmployeeMaster.empcode) {
                   // Check if empcode exists
                   const checkEmpcodeResponse = await fetch(`http://localhost:5213/api/Employee/CheckEmployeeByEmpcode/${newEmployeeMaster.empcode}`);
                   if (!checkEmpcodeResponse.ok) {
                       throw new Error('Network response was not ok');
                   }
                   const checkEmpcodeData = await checkEmpcodeResponse.json();
                   if (checkEmpcodeData.exists) {
                       setError('Employee code already exists.');
                       return;
                   }
               }
   
               if (newEmployeeMaster.enrollno) {
                   // Check if enrollno exists
                   const checkEnrollnoResponse = await fetch(`http://localhost:5213/api/Employee/CheckEmployeeByEnrollno/${newEmployeeMaster.enrollno}`);
                   if (!checkEnrollnoResponse.ok) {
                       throw new Error('Network response was not ok');
                   }
                   const checkEnrollnoData = await checkEnrollnoResponse.json();
                   if (checkEnrollnoData.exists) {
                       setError('Enrollment Number already exists.');
                       return;
                   }
               }
   
   
               // Add the new employee if both checks pass
               const response = await fetch('http://localhost:5213/api/Employee', {
                   method: 'POST',
                   headers: {
                       'Content-Type': 'application/json',
                   },
                   body: JSON.stringify(newEmployeeMaster),
               });
   
               if (!response.ok) {
                   throw new Error('Network response was not ok');
               }
   
               setSuccessMessage('New Employee Entry added successfully');
               setNewEmployeeMaster({
                   srno: '',
                   empid: '',
                   empcode: '',
                   enrollno: '',
                   fname: '',
                   compid: '',
                   locationid: '',
                   subdeptname: '',
                   deptname: '',
                   designation: '',
                   section: '',
                   status: '',
                   project: '',
               });
   
               // Hide the modal after successful addition
               setTimeout(() => {
                   const addModalElement1 = document.getElementById('addModal');
                   const addModalInstance1 = bootstrap.Modal.getInstance(addModalElement1);
                   addModalInstance1.hide();
               }, 1000);
   
               *//* fetchEmployeeMasters();*//*
} catch (error) {
console.error('There was a problem with your fetch operation:', error);
setError('There was a problem adding the employee.');
}
};


const handleCancel = async () => {

setNewEmployeeMaster({
srno: '',
empid: '',
empcode: '',
enrollno: '',
fname: '',
compid: '',
locationid: '',
subdeptname: '',
deptname: '',
designation: '',
section: '',
status: '',
project: '',
});

setError('');
setSuccessMessage('');

const addModalElement = document.getElementById('addModal');
if (addModalElement) {
const addModalInstance = bootstrap.Modal.getInstance(addModalElement);
if (addModalInstance) {
addModalInstance.hide();
}
}
};
*/


    const handleRefresh = () => {
        fetchEmployeeMasters();
    };


    /*  const handleInputChange = (event) => {
          const { name, value } = event.target;
          setEditedEmployeeMaster({
              ...editedEmployeeMaster,
              [name]: value
          });
      };
  
      const handleNewInputChange = (event) => {
          const { name, value } = event.target;
          setNewEmployeeMaster({
              ...newEmployeeMaster,
              [name]: value
          });
      };
  
      const handleSearchInputChange = (event) => {
          const { name, value } = event.target;
          setSearchParams(
              (prevState) => ({
                  ...prevState,
                  [name]: value,
              })
          );
      };*/


    const handleCheckboxChange = (srno) => {
        if (selectedRows.includes(srno)) {
            setSelectedRows(selectedRows.filter(row => row !== srno));
        } else {
            setSelectedRows([...selectedRows, srno]);
        }
    };


    const handleSelectedDeleteConfirmation = () => {
        const isConfirmed = window.confirm('Are you sure you want to delete the records?');

        if (isConfirmed) {
            handleSelectedDelete();
        }
    };

    const handleSelectedDelete = async () => {
        try {
            await Promise.all(selectedRows.map(async (srno) => {
                const response = await fetch(`http://localhost:5213/api/Employee/${srno}`, {
                    method: 'DELETE',
                });

                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }

            }));

            setSelectedRows([]);
            fetchEmployeeMasters();
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        }
    };

    /*  const handleSearch = async () => {
          try {
              setLoading(true);
  
              // Filter the stored employee data based on search parameters
              const filteredData = allEmployeeMasters.filter(employee => {
                  return (
                      (searchParams.compid ? employee.compid === searchParams.compid : true) &&
                      (searchParams.locationid ? employee.locationid === searchParams.locationid : true) &&
                      (searchParams.deptname ? employee.deptName.includes(searchParams.deptname) : true) &&
                      (searchParams.status ? employee.status === searchParams.status : true) &&
                      (searchParams.subdeptname ? employee.subdeptname.includes(searchParams.subdeptname) : true) &&
                      (searchParams.designation ? employee.designation.includes(searchParams.designation) : true) &&
                      (searchParams.section ? employee.section.includes(searchParams.section) : true)
                  );
              });
  
              setSearchParams({
                  compid: '',
                  locationid: '',
                  deptname: '',
                  status: '',
                  subdeptname: '',
                  designation: '',
                  section: '',
              });
  
              console.log("filter", filteredData);
  
              setEmployeeMasters(filteredData);
          } catch (error) {
              console.error('There was a problem with your search operation:', error);
          } finally {
              setLoading(false);
          }
      };
  
  
      const handleAssignClick = async () => {
          try {
              if (selectedRows.length === 0) {
                  setError('No employee selected to assign');
                  return;
              }
              if (!editedEmployeeMaster.compid || !editedEmployeeMaster.locationid || !editedEmployeeMaster.deptname || !editedEmployeeMaster.status || !editedEmployeeMaster.designation) {
                  setError("Fields cannot be empty before assigning");
                  return;
              }
              await Promise.all(selectedRows.map(async (srno) => {
                  const response = await fetch(`http://localhost:5213/api/Employee/${srno}`, {
                      method: 'PUT',
                      headers: {
                          'Content-Type': 'application/json',
                          'Accept': 'application/json',
                      },
                      body: JSON.stringify({
                          srno: srno,
                          compid: editedEmployeeMaster.compid,
                          locationid: editedEmployeeMaster.locationid,
                          deptname: editedEmployeeMaster.deptname,
                          status: editedEmployeeMaster.status,
                          designation: editedEmployeeMaster.designation,
                          section: editedEmployeeMaster.section,
                      }),
                  });
  
                  if (!response.ok) {
                      throw new Error('Network response was not ok');
                  }
  
              }));
              setSuccessMessage('Data Assigned successfully');
              fetchEmployeeMasters();
              setSelectedRows([]);
              setEditedEmployeeMaster({
                  srno: '',
                  empid: '',
                  empcode: '',
                  enrollno: '',
                  fname: '',
                  compid: '',
                  locationid: '',
                  subdeptname: '',
                  deptname: '',
                  designation: '',
                  section: '',
                  status: '',
                  project: '',
              })
          } catch (error) {
              console.error('There was a problem with your fetch operation:', error);
          }
  
      }*/

    return (
        <>
            <div className="container employeeContainer mt-2 justify-content-center align-items-start">
                <div className='card'>
                    <h1 className="mb-4 ms-2">Template Transfer</h1>
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
                            <div className="col-md-3 mb-2">
                                <label htmlFor="designation" className="form-label2">Designation:</label>
                                <select
                                    className="form-control form-select border border-dark"
                                    name="designation"

                                >
                                    <option value="">All</option>
                                    <option value="1">Assistant Manager Operation</option>
                                    <option value="2">Depot Manager</option>
                                    <option value="3">DRIVER</option>
                                    <option value="4">HELPER</option>
                                    <option value="5">Manager E & P</option>
                                    <option value="6">Manager HSSE</option>
                                    <option value="7">Planning Officer</option>
                                    <option value="8">Retail Sales Officer</option>
                                    <option value="9">Territory Manager</option>
                                </select>
                            </div>
                            <div className="col-md-3 mb-2">
                                <label htmlFor="controller" className="form-label2">From Controller:</label>
                                <select
                                    className="form-control form-select border border-dark"
                                    name="controller"

                                >
                                    <option value="1">CONTROL ROOM IN</option>
                                    <option value="2">CONTROL ROOM OUT</option>
                                    <option value="3">Main Gate IN - Driver Side</option>
                                    <option value="4">Main Gate IN - Clener Side</option>
                                    <option value="5">Main Gate OUT - Driver Side</option>
                                    <option value="6">Main Gate OUT - Clener Side</option>
                                </select>
                            </div>

                            <div className="col-md-6">
                                <div className="col-md-3 mt-1">
                                    <button className="custom-btn secondary mt-3" >Download</button>
                                </div>
                                <div className="col-md-3 mt-1">
                                    <button className="custom-btn secondary mt-3" >Upload</button>
                                </div>
                            </div>
                            <div className="row mb-4">
                                <div className="col ms-2 me-2">
                                    <input
                                        type="checkbox"
                                    />
                                    <label>&nbsp;Check All</label>
                                    <div className="table-responsive" style={{ height: '200px', overflowX: 'auto' }}>
                                        <table className="table table-bordered">
                                            <thead>
                                                <tr>
                                                    <th>Select</th>
                                                    <th>Controller</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr>
                                                    <td>
                                                        <input
                                                            type="checkbox"
                                                        />
                                                    </td>
                                                    <td>
                                                        CONTROL ROOM IN
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <input
                                                            type="checkbox"
                                                        />
                                                    </td>
                                                    <td>
                                                        CONTROL ROOM OUT
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <input
                                                            type="checkbox"
                                                        />
                                                    </td>
                                                    <td>
                                                        MAIN GATE IN - Driver Side
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <input
                                                            type="checkbox"
                                                        />
                                                    </td>
                                                    <td>
                                                        MAIN GATE IN - Clener Side
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <input
                                                            type="checkbox"
                                                        />
                                                    </td>
                                                    <td>
                                                        MAIN GATE OUT - Driver Side
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <input
                                                            type="checkbox"
                                                        />
                                                    </td>
                                                    <td>
                                                        MAIN GATE OUT - Clener Side
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                            <p className="text-primary">Select templated to upload</p>
                            <div className="col ms-2 me-2">
                                <input
                                    type="checkbox"
                                />
                                <label>&nbsp;Select All</label>
                            </div>
                        </div>
                        <div className="row">
                            <div className="col-md-6">
                                <button
                                    className={`custom-btn danger ms-2 ${selectedRows.length === 0 ? 'disabled' : ''}`}
                                    onClick={handleSelectedDeleteConfirmation}
                                    disabled={selectedRows.length === 0}
                                    style={{ opacity: selectedRows.length === 0 ? 0.5 : 1, pointerEvents: selectedRows.length === 0 ? 'none' : 'auto' }}
                                >
                                    <FontAwesomeIcon icon={faTrash} className="me-2" />
                                    Delete Templates
                                </button>
                            </div>
                            <div className="col-md-3 text-end">
                                <button className="custom-btn secondary" onClick={handleRefresh}>
                                    <FontAwesomeIcon icon={faSync} />
                                </button>
                            </div>
                        </div>
                    </div>
                    <div className="ms-4">
                        <p className="lead fw-bold">Count: <span className="text-danger">{EmployeeMasters.length}</span></p>
                    </div>

                    <div className="table-responsive text-center">
                        <table className="table table-striped">
                            <thead>
                                <tr><th>Select</th>
                                    <th>Enrollment No</th>
                                    <th>Employee Code </th>
                                    <th>Name</th>
                                    <th>FPCount</th>
                                    <th>Template</th>
                                </tr>
                            </thead>
                            <tbody>
                                {loading ? (
                                    <tr>
                                        <td colSpan="8">
                                            <div className="loading-container">
                                                <div className="spinner-border text-primary" role="status">
                                                    <span className="visually-hidden">Loading...</span>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                ) : (
                                    EmployeeMasters.map(EmployeeMaster => (
                                        <tr key={EmployeeMaster.srno}>
                                            <td>
                                                <input
                                                    type="checkbox"
                                                    onChange={() => handleCheckboxChange(EmployeeMaster.srno)}
                                                    checked={selectedRows.includes(EmployeeMaster.srno)}
                                                />
                                            </td>
                                            <td>{EmployeeMaster.empid}</td>
                                            <td>{EmployeeMaster.empcode}</td>
                                            <td>{EmployeeMaster.name}</td>
                                            <td>{EmployeeMaster.compname}</td>
                                            <td>{EmployeeMaster.locationName}</td>
                                        </tr>
                                    ))
                                )}
                            </tbody>
                        </table>
                    </div>
                </div>
            </div >

        </>
    );
};

export default HelperTemplateTransfer;
