import React, { Component } from 'react';

import './CadastroUsuario.css';

export default class CadastroUsuario extends Component {
    render() {
        return(
            <div className="form-cadastro">
                <form action="" className="panel-cadastro">
                    <h3 className="text-center">Cadastro usuário</h3>
                    <div className="row">
                        <div className="col-lg-6 col-md-6 col-sm-6">
                            <div className="form-group group-inputs-cad">
                                <input type="text" name="name" className="inputs-cad" placeholder="nome completo"/>
                            </div>
                            <div className="form-group group-inputs-cad">
                                <input type="text" name="name" className="inputs-cad" placeholder="e-mail"/>
                            </div>
                            <div className="form-group group-inputs-cad">
                                <input type="text" name="name" className="inputs-cad" placeholder="senha"/>
                            </div>
                        </div>
                        <div className="col-lg-6 col-md-6 col-sm-6">
                            <div className="form-group group-inputs-cad">
                                <input type="text" name="name" className="inputs-cad" placeholder="país"/>
                            </div>
                            <div className="form-group group-inputs-cad">
                                <input type="text" name="name" className="inputs-cad" placeholder="estado"/>
                            </div>
                            <div className="form-group group-inputs-cad">
                                <input type="text" name="name" className="inputs-cad" placeholder="cidade"/>
                            </div>
                        </div>
                    </div>    
                    <button className="btn btn-success btn-md">Salvar</button>
                </form>
            </div>
        )
    }
}
