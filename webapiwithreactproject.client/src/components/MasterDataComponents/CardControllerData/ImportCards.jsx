import React, { useState } from 'react';
import '../../../assets/styles/fetchEmployee.css';
import '../../../assets/styles/Login.css';

const ImportCards = () => {
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

    const getFileIcon = (file) => {
        const fileType = file.name.split('.').pop();
        if (fileType === 'pdf') {
            return <i className="bi bi-file-earmark-pdf" style={{ fontSize: '2rem', marginRight: '1rem' }}></i>;
        } else if (fileType === 'xlsx' || fileType === 'xls') {
            return <i className="bi bi-file-earmark-excel" style={{ fontSize: '2rem', marginRight: '1rem' }}></i>;
        } else {
            return <i className="bi bi-file-earmark" style={{ fontSize: '2rem', marginRight: '1rem' }}></i>;
        }
    };

    return (
        <>
            <div className="container employeeContainer mt-2 justify-content-center align-items-start">
                <div className='card'>
                    <h1 className="mb-4 ms-2">Import Cards</h1>
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
                                    onChange={handleFileChange}
                                />
                            </div>
                            <div className="col-md-4 mb-2">
                                <label>Sheet name:</label>
                                <input
                                    type="text"
                                    className="form-control border border-dark"
                                    value={sheetName}
                                    onChange={handleSheetNameChange}
                                />
                            </div>
                        </div>

                        <div className="row">
                            <div className="col-md-12 d-flex justify-content-end">
                                <button className="btn btn-primary me-2" onClick={handleSave}>Save</button>
                                <button className="btn btn-secondary" onClick={handleExport}>Export</button>
                            </div>
                        </div>

                        {selectedFile && (
                            <div className="row mt-4">
                                <div className="col-md-12 d-flex align-items-center">
                                    {getFileIcon(selectedFile)}
                                    <a href={URL.createObjectURL(selectedFile)} target="_blank" rel="noopener noreferrer">
                                        {selectedFile.name}
                                    </a>
                                </div>
                            </div>
                        )}
                    </div>
                </div>
            </div>
        </>
    );
};

export default ImportCards;
