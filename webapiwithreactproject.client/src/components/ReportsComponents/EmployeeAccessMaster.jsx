import React, { useState, useEffect,useRef } from 'react';
import '../../assets/styles/fetchEmployee.css';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPlus, faTrash, faSync } from '@fortawesome/free-solid-svg-icons';
import jsPDF from 'jspdf';
import 'jspdf-autotable';
import * as XLSX from 'xlsx';
import { saveAs } from 'file-saver';

const EmployeeAccessMaster = () => {
    const [EmployeeMasters, setEmployeeMasters] = useState([]);
    const [allEmployeeMasters, setAllEmployeeMasters] = useState([]);
    const [selectedRows, setSelectedRows] = useState([]);
    const [format, setFormat] = useState('1');
    const [error, setError] = useState('');
    const [successMessage, setSuccessMessage] = useState('');
    const [loading, setLoading] = useState(false);
    const [exportedFile, setExportedFile] = useState(null);

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

    const fetchCompanyName = async (compid) => {
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

    const fetchEmployeeMasters = async () => {
        try {
            setLoading(true);
            const response = await fetch('http://localhost:5213/api/Employee');
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            const data = await response.json();

            const updatedData = await Promise.all(data.map(async employee => {
                const compname = await fetchCompanyName(employee.compid);
                const locationName = await fetchLocationName(employee.locationid);
                const designationName = await fetchDesignationName(employee.designation);
                const departmentName = await fetchDepartmentName(employee.deptName);
                return { ...employee, compname, locationName, designationName, departmentName };
            }));



            setEmployeeMasters(updatedData);
            setAllEmployeeMasters(updatedData);
            console.log("Employee Masters: ", updatedData);
        } catch (error) {
            console.error('There was a problem with your fetch operation:', error);
        } finally {
            setLoading(false);
        }
    };


    const handleCheckboxChange = (srno) => {
        if (selectedRows.includes(srno)) {
            setSelectedRows(selectedRows.filter(row => row !== srno));
        } else {
            setSelectedRows([...selectedRows, srno]);
        }
    };

    const handleExport = () => {
        if (selectedRows.length === 0) {
            setError('No employees selected');
            return;
        }

        const dataToExport = EmployeeMasters.filter(emp => selectedRows.includes(emp.srno));
        exportData(dataToExport);
    };

    const handleExportForAll = () => {
        exportData(EmployeeMasters);
    };

    const exportData = (data) => {
        if (format === '1') {
            exportToPDF(data);
        } else if (format === '2') {
            exportToExcel(data);
        }
    };
    const exportToPDF = (employees) => {
        const doc = new jsPDF();
        doc.text("Employee Access Master", 14, 16);
        doc.text(`Date: ${new Date().toLocaleString()}`, 14, 24);

        const tableColumn = ["Employee Code", "Name", "Card No.", "Company", "Location", "Department", "Sub-Dept"];
        const tableRows = [];

        employees.forEach(employee => {
            const employeeData = [
                employee.empcode,
                employee.fname,
                employee.cardno,
                employee.compname,
                employee.locationName,
                employee.departmentName,
                ""
            ];
            tableRows.push(employeeData);
        });
        doc.autoTable({ head: [tableColumn], body: tableRows, startY: 32 });
        const pdfOutput = doc.output('blob');
        setExportedFile(new Blob([pdfOutput], { type: 'application/pdf' }));
        saveAs(pdfOutput, 'EmployeeAccessMaster.pdf');
        setSuccessMessage('PDF exported successfully');
    };

    const exportToExcel = (employees) => {
        const worksheet = XLSX.utils.aoa_to_sheet([
            ["Employee Access Master"], // Heading
            [`Date: ${new Date().toLocaleString()}`], // Date/Time
            [], 
        ]);

        XLSX.utils.sheet_add_json(worksheet, employees.map(employee => ({
            "Employee Code": employee.empcode,
            "Name": employee.fname,
            "Card No.": employee.cardno,
            "Company": employee.compname,
            "Location": employee.locationName,
            "Department": employee.departmentName,
            "Sub-Dept": ""
        })), { origin: 'A4', skipHeader: false });


        worksheet['!merges'] = [
            { s: { r: 0, c: 0 }, e: { r: 0, c: 6 } }, // Merge cells for heading
            { s: { r: 1, c: 0 }, e: { r: 1, c: 6 } }, // Merge cells for date/time
        ];


        worksheet['A1'].s = { font: { bold: true, sz: 14 } }; // Heading
        worksheet['A2'].s = { font: { bold: true, sz: 12 } }; // Date/Time

        const workbook = XLSX.utils.book_new();
        XLSX.utils.book_append_sheet(workbook, worksheet, "Employee Access Master");

        const excelOutput = XLSX.write(workbook, { bookType: 'xlsx', type: 'array' });
        const blob = new Blob([excelOutput], { type: 'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet' });
        setExportedFile(blob);
        saveAs(blob, 'EmployeeAccessMaster.xlsx');
        setSuccessMessage('Excel exported successfully');
    };

    const handleView = () => {
        if (exportedFile) {
            const url = URL.createObjectURL(exportedFile);
            window.open(url, '_blank');
        } else {
            setError('No file exported yet');
        }
    };


    return (
        <>
            <div className="container employeeContainer  mt-2 justify-content-center align-items-start">
                <div className='card'>
                    <h1 className="mb-4 ms-2">Employee Access Master</h1>
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
                                <input type="checkbox" />
                                <label className="form-label2">&nbsp;Contoller-Reader</label>

                            </div>
                            <div className="col-md-3 mb-2">
                                <input type="checkbox" />
                                <label className="form-label2">&nbsp;Check All</label>

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
                            
                            <div className="col-md-3 mt-1">
                                <button className="custom-btn secondary float-end">
                                    <FontAwesomeIcon icon={faSync} />
                                </button>
                            </div>
                        </div>
                        <div className="row mb-4">
                            <div className="table-responsive text-center" style={{ height: '200px', overflowX: 'auto' }}>
                            <table className="table table-bordered">
                                <thead>
                                    <tr>
                                        <th>Select</th>
                                        <th>Reader</th>
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
                                            ACS Controller - Reader1
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <input
                                                type="checkbox"
                                            />
                                        </td>
                                        <td>
                                            ACS Controller - Reader2
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <input
                                                type="checkbox"
                                            />
                                        </td>
                                        <td>
                                            ACS Controller - Reader3
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <input
                                                type="checkbox"
                                            />
                                        </td>
                                        <td>
                                            ACS Controller - Reader4
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <input
                                                type="checkbox"
                                            />
                                        </td>
                                        <td>
                                            CONTROL ROOM IN - CONTROL ROOM IN
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <input
                                                type="checkbox"
                                            />
                                        </td>
                                        <td>
                                            CONTROL ROOM OUT - CONTROL ROOM OUT
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
                        <div className="row mb-4">
                            <div className="col-md-3 mb-2">
                                <label htmlFor="format" className="form-label2">Format:</label>
                                <select
                                    className="form-control form-select border border-dark"
                                    name="format"
                                    value={format}
                                    onChange={(e) => setFormat(e.target.value)}
                                >
                                    <option value="1">PDF</option>
                                    <option value="2">Excel</option>
                                </select>
                            </div>
                        </div>
                        <div className="row mb-4 justify-content-center">
                            <div className="col-md-3 mb-2">
                                <button className="btn btn-secondary w-80" onClick={handleView }>View</button>
                            </div>
                            <div className="col-md-3 mb-2">
                                <button className="btn btn-secondary w-80" onClick={handleExport}>Export</button>
                            </div>
                            <div className="col-md-3 mb-2">
                                <button className="btn btn-secondary w-80" onClick={handleExportForAll}>Export For All</button>
                            </div>
                        </div>
                        {error && <div className="alert alert-danger" role="alert">{error}</div>}
                        {successMessage && <div className="alert alert-success">{successMessage}</div>}
                        <div className="ms-4">
                            <p className="lead fw-bold">Count: <span className="text-danger">{EmployeeMasters.length}</span></p>
                        </div>
                        <div className="table-responsive text-center">
                            <table className="table table-striped">
                                <thead>
                                    <tr><th></th>
                                        <th>Employee Code </th>
                                        <th>Name</th>
                                        <th>Card No.</th>
                                        <th>Company</th>
                                        <th>Location</th>
                                        <th>Department</th>
                                        <th>Sub-Dept</th>
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
                                                <td>{EmployeeMaster.empcode}</td>
                                                <td>{EmployeeMaster.fname}</td>
                                                <td>{EmployeeMaster.cardno}</td>
                                                <td>{EmployeeMaster.compname}</td>
                                                <td>{EmployeeMaster.locationName}</td>
                                                <td>{EmployeeMaster.departmentName}</td>
                                                <td></td>
                                            </tr>
                                        ))
                                    )}
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
                </div>
        </>
    );
};

export default EmployeeAccessMaster;
