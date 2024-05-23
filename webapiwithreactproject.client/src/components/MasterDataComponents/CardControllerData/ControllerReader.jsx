import React, { useState, useEffect } from 'react';
import '../../../assets/styles/Controller.css';
import '../../../assets/styles/Login.css';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPlus, faTrash, faSync, faEdit, faCog } from '@fortawesome/free-solid-svg-icons';

const ControllerReader = () => {
    const [activeComponent, setActiveComponent] = useState('add');
    const [formData, setFormData] = useState({
        location: '',
        macAddress: '',
        type: '',
        name: '',
        authMode: '',
        cardReadType: '',
        ipAddress: '',
        numOfDoors: '',
        terminalId: '',
        status: false,
        interlocking: false,
        globalPassback: false,
        enroller: false,
        serialFormat: '',
        portNo: ''
    });

    useEffect(() => {
        // Update form data based on activeComponent
        switch (activeComponent) {
            case 'ACS':
                // Set form data for edit
                break;
            case 'CIN':
                // Set form data for delete
                break;
            case 'COUT':
                // Set form data for sync
                break;
            case 'MGIND':
                // Set form data for view
                break;
            case 'MGINC':
                // Set form data for view
                break;
            case 'MGOUTD':
                // Set form data for view
                break;
            case 'MGOUTC':
                // Set form data for view
                break;
            default:
                // Set form data for add
                break;
        }
    }, [activeComponent]);

    const handleChange = (e) => {
        const { name, value, type, checked } = e.target;
        setFormData({
            ...formData,
            [name]: type === 'checkbox' ? checked : value
        });
    };

    return (
        <>
            <div className="container-fluid">
                <div className="row">
                    <div className="col-auto d-md-block bg-light sidebar">
                        <div className="position-sticky">
                            <p className="mb-4 ms-2 lead fw-bold">Hardware Architecture Setup</p>
                            <ul className="nav flex-column">
                                <li className="nav-item">
                                    <a className="nav-link" href="#" data-bs-toggle="modal" data-bs-target="#addModal" onClick={() => setActiveComponent('add')}>
                                        <FontAwesomeIcon icon={faCog} className="me-2" />
                                        Add Controller
                                    </a>
                                </li>
                                <li className="nav-item">
                                    <a className="nav-link" href="#" onClick={() => setActiveComponent('ACS')}>
                                        <FontAwesomeIcon icon={faCog} className="me-2" />
                                        ACS Controller
                                    </a>
                                </li>
                                <li className="nav-item">
                                    <a className="nav-link" href="#" onClick={() => setActiveComponent('CIN')}>
                                        <FontAwesomeIcon icon={faCog} className="me-2" />
                                        CONTROL ROOM IN
                                    </a>
                                </li>
                                <li className="nav-item">
                                    <a className="nav-link" href="#" onClick={() => setActiveComponent('COUT')}>
                                        <FontAwesomeIcon icon={faCog} className="me-2" />
                                        CONTROL ROOM OUT
                                    </a>
                                </li>
                                <li className="nav-item">
                                    <a className="nav-link" href="#" onClick={() => setActiveComponent('MGIND')}>
                                        <FontAwesomeIcon icon={faCog} className="me-2" />
                                        Main Gate IN - Driver Side
                                    </a>
                                </li>
                                <li className="nav-item">
                                    <a className="nav-link" href="#" onClick={() => setActiveComponent('MGINC')}>
                                        <FontAwesomeIcon icon={faCog} className="me-2" />
                                        Main Gate IN - Clener Side
                                    </a>
                                </li>
                                <li className="nav-item">
                                    <a className="nav-link" href="#" onClick={() => setActiveComponent('MGOUTD')}>
                                        <FontAwesomeIcon icon={faCog} className="me-2" />
                                        Main Gate OUT - Driver Side
                                    </a>
                                </li>
                                <li className="nav-item">
                                    <a className="nav-link" href="#" onClick={() => setActiveComponent('MGOUTC')}>
                                        <FontAwesomeIcon icon={faCog} className="me-2" />
                                        Main Gate OUT - Clener Side
                                    </a>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div className="col">
                        <div className="controllerContainer mt-2">
                            <h5 className="mb-4 ms-2 fw-bold">Controller Reader</h5>
                            <form>
                                <div className="row">
                                    <div className="col-md-6">
                                        <div className="mb-3">
                                            <label htmlFor="location" className="form-label2">Selection Location</label>
                                            <select
                                                className="form-select"
                                                id="location"
                                                name="location"
                                                value={formData.location}
                                                onChange={handleChange}
                                            >
                                                <option value="location1">WARANGAL DEPOT </option>
                                                <option value="location2">-----</option>
                                            </select>
                                        </div>
                                        <div className="mb-3">
                                            <label htmlFor="macAddress" className="form-label2">Mac Address</label>
                                            <input
                                                type="text"
                                                className="form-control border border-dark"
                                                id="macAddress"
                                                name="macAddress"
                                                value={formData.macAddress}
                                                onChange={handleChange}
                                            />
                                        </div>
                                        <div className="mb-3">
                                            <label htmlFor="type" className="form-labe2l">Type</label>
                                            <select
                                                className="form-select"
                                                id="type"
                                                name="type"
                                                disabled
                                                value={formData.type}
                                                onChange={handleChange}
                                            >
                                                <option value="type1">Standalone(Vridi)</option>
                                                <option value="type2">Standalone(Wiegand-Vridi)</option>
                                                <option value="type3">4 Door 8 Reader</option>
                                                <option value="type4">4 Door 4 Reader</option>

                                            </select>
                                        </div>
                                        <div className="mb-3">
                                            <label htmlFor="name" className="form-labe2">Name</label>
                                            <input
                                                type="text"
                                                className="form-control border border-dark"
                                                id="name"
                                                name="name"
                                                value={formData.name}
                                                onChange={handleChange}
                                            />
                                        </div>
                                        <div className="mb-3">
                                            <label htmlFor="authMode" className="form-label2">Auth Mode</label>
                                            <select
                                                className="form-select"
                                                id="authMode"
                                                name="authMode"
                                                value={formData.authMode}
                                                onChange={handleChange}
                                            >
                                                <option value="auth1">NS</option>
                                                <option value="auth2">SN</option>
                                                <option value="auth3">NO</option>
                                                <option value="auth4">SO</option>

                                            </select>
                                        </div>
                                        <div className="mb-3">
                                            <label htmlFor="cardReadType" className="form-label2">Card Read Type</label>
                                            <select
                                                className="form-select"
                                                id="cardReadType"
                                                name="cardReadType"
                                                value={formData.cardReadType}
                                                onChange={handleChange}
                                            >
                                                <option value="type1">Card Serial No</option>
                                                <option value="type2">Card Data</option>
                                                <option value="type3">MAD</option>
                                            </select>
                                        </div>
                                        <div className="mb-3">
                                            <label htmlFor="ipAddress" className="form-label2">IP Address</label>
                                            <input
                                                type="text"
                                                className="form-control border border-dark"
                                                id="ipAddress"
                                                name="ipAddress"
                                                value={formData.ipAddress}
                                                onChange={handleChange}
                                            />
                                        </div>
                                        <div className="mb-3">
                                            <label htmlFor="numOfDoors" className="form-label2">No of Doors</label>
                                            <input
                                                type="number"
                                                className="form-control border border-dark"
                                                id="numOfDoors"
                                                name="numOfDoors"
                                                value={formData.numOfDoors}
                                                onChange={handleChange}
                                            />
                                        </div>
                                    </div>
                                    <div className="col-md-6">
                                        <div className="mb-3">
                                            <label htmlFor="terminalId" className="form-label2">Terminal ID</label>
                                            <input
                                                type="text"
                                                className="form-control border border-dark"
                                                id="terminalId"
                                                name="terminalId"
                                                value={formData.terminalId}
                                                onChange={handleChange}
                                            />
                                        </div>
                                        <label className="form-check-label mt-3" htmlFor="status">Status</label>
                                        <div className="mb-3 form-check mt-1">
                                            <input
                                                type="checkbox"
                                                className="form-check-input"
                                                id="status"
                                                name="status"
                                                checked={formData.status}
                                                onChange={handleChange}
                                            />
                                            <label className="form-check-label" htmlFor="Active">Active</label>
                                        </div>
                                        <div className="mb-3 mt-4">
                                            <div className="d-flex align-items-center">
                                                <input
                                                    type="checkbox"
                                                    className="form-check-input me-2"
                                                    id="interlocking"
                                                    name="interlocking"
                                                    checked={formData.interlocking}
                                                    onChange={handleChange}
                                                />
                                                <label className="form-check-label" htmlFor="interlocking">Interlocking</label>
                                            </div>
                                            <div className="d-flex align-items-center">
                                                <input
                                                    type="checkbox"
                                                    className="form-check-input me-2"
                                                    id="globalPassback"
                                                    name="globalPassback"
                                                    checked={formData.globalPassback}
                                                    onChange={handleChange}
                                                />
                                                <label className="form-check-label" htmlFor="globalPassback">Global Passback</label>
                                            </div>
                                            <div className="d-flex align-items-center">
                                                <input
                                                    type="checkbox"
                                                    className="form-check-input me-2"
                                                    id="enroller"
                                                    name="enroller"
                                                    checked={formData.enroller}
                                                    onChange={handleChange}
                                                />
                                                <label className="form-check-label" htmlFor="enroller">Enroller</label>
                                            </div>
                                        </div>

                                        <div className="mb-3 mt-5">
                                            <label htmlFor="serialFormat" className="form-label2">Serial Format</label>
                                            <select
                                                className="form-select"
                                                id="serialFormat"
                                                name="serialFormat"
                                                value={formData.serialFormat}
                                                onChange={handleChange}
                                            >
                                                <option value="format1">Default</option>
                                                <option value="format2">Hexa String</option>
                                                <option value="format3">Decimal String</option>
                                                <option value="format4">3.5 Decimal</option>
                                            </select>
                                        </div>
                                        <div className="mb-3 mt-5">
                                            <label htmlFor="portNo" className="form-label2">Port No</label>
                                            <input
                                                type="text"
                                                className="form-control border border-dark"
                                                id="portNo"
                                                name="portNo"
                                                value={formData.portNo}
                                                onChange={handleChange}
                                            />
                                        </div>
                                    </div>
                                    <div className="col-md-6 d-flex align-items-end">
                                        <div className="mb-3">
                                            <button type="button" className="custom-btn primary mt-3">Door Settings</button>
                                        </div>
                                    </div>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>

                <div className="modal fade" tabIndex="-1" id="addModal" aria-labelledby="addControllerReaderModalLabel" aria-hidden="true">
                    <div className="modal-dialog">
                        <div className="modal-content">
                            <div className="modal-header">
                                <h5 className="modal-title" id="addControllerReaderModalLabel">Add Controller</h5>
                                <button type="button" className="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                            </div>
                            <div className="modal-body">
                                <form>
                                    <div className="row">
                                        <div className="col-md-6">
                                            <div className="mb-3">
                                                <label htmlFor="location" className="form-label2">Selection Location</label>
                                                <select
                                                    className="form-select"
                                                    id="location"
                                                    name="location"
                                                    value={formData.location}
                                                    onChange={handleChange}
                                                >
                                                    <option value="location1">WARANGAL DEPOT </option>
                                                    <option value="location2">-----</option>
                                                </select>
                                            </div>
                                            <div className="mb-3">
                                                <label htmlFor="macAddress" className="form-label2">Mac Address</label>
                                                <input
                                                    type="text"
                                                    className="form-control border border-dark"
                                                    id="macAddress"
                                                    name="macAddress"
                                                    value={formData.macAddress}
                                                    onChange={handleChange}
                                                />
                                            </div>
                                            <div className="mb-3">
                                                <label htmlFor="type" className="form-labe2l">Type</label>
                                                <select
                                                    className="form-select"
                                                    id="type"
                                                    name="type"
                                                    value={formData.type}
                                                    onChange={handleChange}
                                                >
                                                    <option value="type1">Standalone(Vridi)</option>
                                                    <option value="type2">Standalone(Wiegand-Vridi)</option>
                                                    <option value="type3">4 Door 8 Reader</option>
                                                    <option value="type4">4 Door 4 Reader</option>

                                                </select>
                                            </div>
                                            <div className="mb-3">
                                                <label htmlFor="name" className="form-labe2">Name</label>
                                                <input
                                                    type="text"
                                                    className="form-control border border-dark"
                                                    id="name"
                                                    name="name"
                                                    value={formData.name}
                                                    onChange={handleChange}
                                                />
                                            </div>
                                            <div className="mb-3">
                                                <label htmlFor="authMode" className="form-label2">Auth Mode</label>
                                                <select
                                                    className="form-select"
                                                    id="authMode"
                                                    name="authMode"
                                                    value={formData.authMode}
                                                    onChange={handleChange}
                                                >
                                                    <option value="auth1">NS</option>
                                                    <option value="auth2">SN</option>
                                                    <option value="auth3">NO</option>
                                                    <option value="auth4">SO</option>
                                                </select>
                                            </div>
                                            <div className="mb-3">
                                                <label htmlFor="cardReadType" className="form-label2">Card Read Type</label>
                                                <select
                                                    className="form-select"
                                                    id="cardReadType"
                                                    name="cardReadType"
                                                    value={formData.cardReadType}
                                                    onChange={handleChange}
                                                >
                                                    <option value="type1">Card Serial No</option>
                                                    <option value="type2">Card Data</option>
                                                    <option value="type3">MAD</option>
                                                </select>
                                            </div>
                                            <div className="mb-3">
                                                <label htmlFor="ipAddress" className="form-label2">IP Address</label>
                                                <input
                                                    type="text"
                                                    className="form-control border border-dark"
                                                    id="ipAddress"
                                                    name="ipAddress"
                                                    value={formData.ipAddress}
                                                    onChange={handleChange}
                                                />
                                            </div>
                                            <div className="mb-3">
                                                <label htmlFor="numOfDoors" className="form-label2">No of Doors</label>
                                                <input
                                                    type="number"
                                                    className="form-control border border-dark"
                                                    id="numOfDoors"
                                                    name="numOfDoors"
                                                    value={formData.numOfDoors}
                                                    onChange={handleChange}
                                                />
                                            </div>
                                        </div>
                                        <div className="col-md-6">
                                            <div className="mb-3">
                                                <label htmlFor="terminalId" className="form-label2">Terminal ID</label>
                                                <input
                                                    type="text"
                                                    className="form-control border border-dark"
                                                    id="terminalId"
                                                    name="terminalId"
                                                    value={formData.terminalId}
                                                    onChange={handleChange}
                                                />
                                            </div>
                                            <label className="form-check-label mt-3" htmlFor="status">Status</label>
                                            <div className="mb-3 form-check mt-1">
                                                <input
                                                    type="checkbox"
                                                    className="form-check-input"
                                                    id="status"
                                                    name="status"
                                                    checked={formData.status}
                                                    onChange={handleChange}
                                                />
                                                <label className="form-check-label" htmlFor="Active">Active</label>
                                            </div>
                                            <div className="mb-3 mt-4">
                                                <div className="d-flex align-items-center">
                                                    <input
                                                        type="checkbox"
                                                        className="form-check-input me-2"
                                                        id="interlocking"
                                                        name="interlocking"
                                                        checked={formData.interlocking}
                                                        onChange={handleChange}
                                                    />
                                                    <label className="form-check-label" htmlFor="interlocking">Interlocking</label>
                                                </div>
                                                <div className="d-flex align-items-center">
                                                    <input
                                                        type="checkbox"
                                                        className="form-check-input me-2"
                                                        id="globalPassback"
                                                        name="globalPassback"
                                                        checked={formData.globalPassback}
                                                        onChange={handleChange}
                                                    />
                                                    <label className="form-check-label" htmlFor="globalPassback">Global Passback</label>
                                                </div>
                                                <div className="d-flex align-items-center">
                                                    <input
                                                        type="checkbox"
                                                        className="form-check-input me-2"
                                                        id="enroller"
                                                        name="enroller"
                                                        checked={formData.enroller}
                                                        onChange={handleChange}
                                                    />
                                                    <label className="form-check-label" htmlFor="enroller">Enroller</label>
                                                </div>
                                            </div>

                                            <div className="mb-3 mt-5">
                                                <label htmlFor="serialFormat" className="form-label2">Serial Format</label>
                                                <select
                                                    className="form-select"
                                                    id="serialFormat"
                                                    name="serialFormat"
                                                    value={formData.serialFormat}
                                                    onChange={handleChange}
                                                >
                                                    <option value="format1">Default</option>
                                                    <option value="format2">Hexa String</option>
                                                    <option value="format3">Decimal String</option>
                                                    <option value="format4">3.5 Decimal</option>
                                                </select>
                                            </div>
                                            <div className="mb-3 mt-5">
                                                <label htmlFor="portNo" className="form-label2">Port No</label>
                                                <input
                                                    type="text"
                                                    className="form-control border border-dark"
                                                    id="portNo"
                                                    name="portNo"
                                                    value={formData.portNo}
                                                    onChange={handleChange}
                                                />
                                            </div>
                                        </div>
                                        <div className="col-md-6 d-flex align-items-end">
                                            <div className="mb-3">
                                                <button type="button" className="custom-btn primary mt-3">Door Settings</button>
                                            </div>
                                        </div>
                                    </div>
                                </form>
                            </div>
                            <div className="modal-footer">
                                <button type="button" className="btn btn-secondary" data-bs-dismiss="modal">Cancel</button>
                                <button type="button" className="btn btn-primary">Save</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </>
    );
};

export default ControllerReader;

