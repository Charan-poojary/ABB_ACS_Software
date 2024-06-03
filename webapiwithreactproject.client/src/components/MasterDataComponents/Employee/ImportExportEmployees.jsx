import React, { useState } from 'react';
import '../../../assets/styles/fetchEmployee.css';
import '../../../assets/styles/Login.css';

const ImportExportEmployees = () => {
    const [selectedFile, setSelectedFile] = useState(null);
    const [sheetName, setSheetName] = useState('');

    const handleFileChange = (e) => {
        setSelectedFile(e.target.files[0]);
    };

    const handleSheetNameChange = (e) => {
        setSheetName(e.target.value);
    };

    const handleSave = () => {
        // Handle save logic here
        console.log('Save clicked', selectedFile, sheetName);
    };

    const handleExport = () => {
        // Handle export logic here
        console.log('Export clicked');
    };

    return (
        <>
            <div className="container employeeContainer mt-2 justify-content-center align-items-start">
                <div className='card'>
                    <h1 className="mb-4 ms-2">Import Employee</h1>
                    <div className='container-fluid mb-4'>
                        <div className="row mb-4">
                            <div className="col-md-4 mb-2">
                                <div className="d-flex align-items-end">
                                    <a href="/path/to/format/file" download="format.xlsx" className="btn btn-link">Download Format</a>
                                </div>
                            </div>
                            <div className="col-md-4 mb-2">
                                <label>Excel file:</label>
                                <input
                                    type="file"
                                    accept=".xlsx, .xls, .pdf"
                                    className="form-control border border-dark"
                                />
                            </div>
                            <div className="col-md-4 mb-2">
                                <label>Sheet name:</label>
                                <input
                                    type="text"
                                    className="form-control border border-dark"
                                />
                            </div>
                        </div>

                        <div className="row">
                            <div className="col-md-12 d-flex justify-content-end">
                                <button className="btn btn-primary me-2">Save</button>
                                <button className="btn btn-secondary">Export</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </>
    );
};

export default ImportExportEmployees;
