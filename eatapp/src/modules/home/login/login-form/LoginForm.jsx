import React from 'react';
import './LoginForm.css';

import { connect } from 'react-redux';
import { bindActionCreators } from 'redux'
import { changeEmail, changeSenha, btnLogar } from '../loginActions.js';

const LoginForm = (props) => {
    return (
        <div className="form-login">
            <form action="" className="panel-login">
                <h4 className="text-center">Sign in</h4>
                <div className="form-group group-inputs" style={{display:'flex'}}>
                    <i className="fa fa-user"></i>
                    <input type="text" name="email" className="inputs-login" placeholder="e-mail"
                           value={props.email} onChange={props.changeEmail}/>
                </div>
                <div className="form-group group-inputs" style={{display:'flex'}}>
                    <i className="fa fa-key"></i>
                    <input type="password" name="email" className="inputs-login" placeholder="senha"
                            value={props.senha} onChange={props.changeSenha}/>
                    <i id="bnt-eye" className="fa fa-eye"></i>
                </div>
                <button className="btn btn-success btn-block btn-md"
                        onClick={() => btnLogar(props.email, props.senha, true)}>
                    Entrar
                </button>
            </form>
        </div>
    )
}

const mapStateToProps = state => (
    {email: state.usuario.email, senha: state.usuario.senha}
);
const mapDispatchToProps = dispatch => bindActionCreators(
    { changeEmail, changeSenha }, dispatch
);
export default connect(mapStateToProps,mapDispatchToProps)(LoginForm);