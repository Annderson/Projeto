import React from 'react';

import './LoginInfo.css';
import logo from '../../../../assets/img/icon-surrounding-restaurants-blue.png';

const LoginInfo = (props) => {
    return (
        <div className="body-login-info" >
            <h2><b>EatApp</b></h2>
            <h2>O Sabor do Mundo</h2>
            <div style={{width: '100%'}}><img src={logo}/></div>
        </div>
    )
}

export default LoginInfo;
