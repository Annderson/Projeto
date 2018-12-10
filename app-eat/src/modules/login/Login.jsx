import React from 'react';

import './Login.css';

const Login = props => {

    const error =  props.errorLogin ? 'E-mail ou senha invalido!' : '';

        return(
            <div className="body-login">
               <div>
                    <h2 className="text-center"><b>EatApp</b></h2>
                    <h2 className="text-center">O Sabor do Mundo</h2> <br/><br/>
                    <form action="" className="panel-login">
                        <h4 className="text-center">Sign in</h4>
                        <div style={{color: 'red'}}>{error}</div>
                        <div className="form-group group-inputs" style={{display:'flex'}}>
                            <i className="fa fa-user"></i>
                            <input type="text" name="email" className="inputs-login" placeholder="e-mail" required
                                value={props.email} onChange={props.changeEmail}/>
                        </div>
                        <div className="form-group group-inputs" style={{display:'flex'}}>
                            <i className="fa fa-key"></i>
                            <input type={props.btnEye?'text':'password'} className="inputs-login" placeholder="senha" required
                                    value={props.senha} onChange={props.changeSenha}/>
                            <i id="bnt-eye" className="fa fa-eye" onClick={props.handleBtnEye}></i>
                        </div>
                        <button type="button" className="btn btn-success btn-block btn-md"
                                onClick={props.handleClickLogar}>
                            Entrar
                        </button>

                    </form>
                </div>
            </div>
        )
}


export default Login;