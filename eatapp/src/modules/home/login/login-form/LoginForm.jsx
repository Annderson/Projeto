import React from 'react';
import './LoginForm.css';

const LoginForm = (props) => {
    return (
        <div className="form-login">
            <form action="" className="panel-login">
                <h4 className="text-center">Sign in</h4>
                <div className="form-group group-inputs" style={{display:'flex'}}>
                    <i className="fa fa-user"></i>
                    <input type="text" name="email" className="inputs-login"/>
                </div>
                <div className="form-group group-inputs" style={{display:'flex'}}>
                    <i class="fa fa-key"></i>
                    <input type="password" name="email" className="inputs-login"/>
                </div>
                <button className="btn btn-success btn-block btn-md">Entrar</button>
            </form>
        </div>
    )
}

export default LoginForm;