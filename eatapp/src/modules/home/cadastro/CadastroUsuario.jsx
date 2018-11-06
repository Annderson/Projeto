import React, { Component } from 'react';

import './CadastroUsuario.css';

export default class CadastroUsuario extends Component {
    render() {
        return(
            <div className="form-cadastro">
                <form action="" className="panel-cadastro">
                    <h4 className="text-center">Cadastro usuário</h4>
                    <div className="row">
                        <div className="col-lg-6 col-md-6 col-sm-6">
                            <div className="form-group group-inputs">
                                <input type="text" name="name" className="inputs-login"/>
                            </div>
                            <div className="form-group group-inputs">
                                <input type="text" name="name" className="inputs-login"/>
                            </div>
                            <div className="form-group group-inputs">
                                <input type="text" name="name" className="inputs-login"/>
                            </div>
                        </div>
                        <div className="col-lg-6 col-md-6 col-sm-6">
                            <div className="form-group group-inputs">
                                <input type="text" name="name" className="inputs-login"/>
                            </div>
                            <div className="form-group group-inputs">
                                <input type="text" name="name" className="inputs-login"/>
                            </div>
                            <div className="form-group group-inputs">
                                <input type="text" name="name" className="inputs-login"/>
                            </div>
                        </div>
                    </div>    
                    <button className="btn btn-success text-right btn-md">Salvar</button>
                </form>
            </div>
        )
    }
}
