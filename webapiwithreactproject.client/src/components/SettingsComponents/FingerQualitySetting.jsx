import React, { useState, useEffect } from 'react';
import '../../assets/styles/fetchEmployee.css';

const FingerQualitySetting = () => {

    return (
        <>
            <div className="container employeeContainer mt-2 justify-content-center align-items-start">
                <div className='card'>
                    <h1 className="mb-4 ms-2">Fingerprint Quality Settings</h1>
                    <div className='container-fluid mb-4'>
                        <div className="row mb-3 justify-content-center">
                            <div className="col-12 col-md-6">
                                <label htmlFor="qualitySetting1" className="form-label2">Security Level For Enroll:</label>
                                <select id="qualitySetting1" className="form-select">
                                    <option value="Normal">Normal</option>
                                    <option value="Lowest">Lowest</option>
                                    <option value="Lower">Lower</option>
                                    <option value="Low">Low</option>
                                    <option value="Below Normal">Below Normal</option>
                                    <option value="Above Normal">Above Normal</option>
                                    <option value="High">High</option>
                                    <option value="Higher">Higher</option>
                                    <option value="Highest">Highest</option>
                                </select>
                            </div>
                        </div>
                        <div className="row mb-3 justify-content-center">
                            <div className="col-12 col-md-6">
                                <label htmlFor="qualitySetting2" className="form-label2">Security Level For Verify:</label>
                                <select id="qualitySetting2" className="form-select">
                                    <option value="Normal">Normal</option>
                                    <option value="Lowest">Lowest</option>
                                    <option value="Lower">Lower</option>
                                    <option value="Low">Low</option>
                                    <option value="Below Normal">Below Normal</option>
                                    <option value="Above Normal">Above Normal</option>
                                    <option value="High">High</option>
                                    <option value="Higher">Higher</option>
                                    <option value="Highest">Highest</option>
                                </select>
                            </div>
                        </div>
                        <div className="row mb-3 justify-content-center">
                            <div className="col-12 col-md-6">
                                <label htmlFor="qualitySetting3" className="form-label2">Enroll Quality:</label>
                                <select id="qualitySetting3" className="form-select">
                                    <option value="Normal">Normal</option>
                                    <option value="Lowest">Lowest</option>
                                    <option value="Lower">Lower</option>
                                    <option value="Low">Low</option>
                                    <option value="Below Normal">Below Normal</option>
                                    <option value="Above Normal">Above Normal</option>
                                    <option value="High">High</option>
                                    <option value="Higher">Higher</option>
                                    <option value="Highest">Highest</option>
                                </select>
                            </div>
                        </div>
                        <div className="row mb-3 justify-content-center">
                            <div className="col-12 col-md-6">
                                <label htmlFor="qualitySetting4" className="form-label2">Verify Quality:</label>
                                <select id="qualitySetting4" className="form-select">
                                    <option value="Normal">Normal</option>
                                    <option value="Lowest">Lowest</option>
                                    <option value="Lower">Lower</option>
                                    <option value="Low">Low</option>
                                    <option value="Below Normal">Below Normal</option>
                                    <option value="Above Normal">Above Normal</option>
                                    <option value="High">High</option>
                                    <option value="Higher">Higher</option>
                                    <option value="Highest">Highest</option>
                                </select>
                            </div>
                        </div>
                        </div>
                </div>
            </div>
        </>
    );
};

export default FingerQualitySetting;
