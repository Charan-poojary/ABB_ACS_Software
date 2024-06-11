import React, { useState } from 'react';
import { Link } from 'react-router-dom';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faCaretRight } from '@fortawesome/free-solid-svg-icons';
import DoorOpenClose from './DoorOpenClose';


const DoorActions = () => {
    const [selectedLink, setSelectedLink] = useState(null);

    const handleLinkClick = (link) => {

        setSelectedLink(link);
    };

    return (
        <div className="container-fluid bg-light py-4">
            <div className="row justify-content-center">
                <div className="col-lg-8">
                    <div className="card p-4 ">
                        <div className="row">
                            <div className="col-md-4 bg-light">
                                <h2 className="mb-4">Door Actions</h2>
                                <div className="sidebar">
                                    <ul className="nav flex-column">
                                        <li className="nav-item">
                                            <Link className="nav-link" to="#" onClick={() => handleLinkClick('link1')}>
                                                <FontAwesomeIcon icon={faCaretRight} />
                                                &nbsp;
                                                Door Open/Close
                                            </Link>
                                        </li>
                                    </ul>
                                </div>
                            </div>

                            <div className="col-md-8">
                                <div className="main-content">
                                    {selectedLink === 'link1' && <DoorOpenClose />}
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    );
};

export default DoorActions;
