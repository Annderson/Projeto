import  React  from 'react';

import './Cadastro.css'

const Cadastro = props => {
    return (
        <div className="form-cadastro">
            <form  className="panel-cadastro">
                <h3 className="text-center">Cadastro usuário</h3>
                <div className="row">
                    <div className="col-lg-6 col-md-6 col-sm-6" style={{borderRight: "2px solid black"}}>
                        <div className="form-group group-inputs-cad">
                            <input type="text" name="name" className="inputs-cad" 
                                    placeholder="nome completo" required
                                   value={props.nomeCad} onChange={props.changeNomeCad}/>
                        </div>
                        <div className="form-group group-inputs-cad">
                            <input type="text" name="name" className="inputs-cad" placeholder="e-mail" required
                                    value={props.emailCad} onChange={props.changeEmailCad}/>
                        </div>
                        <div className="form-group group-inputs-cad">
                            <input type="password" name="name" className="inputs-cad" placeholder="senha" required
                                    value={props.senhaCad} onChange={props.changeSenhaCad}/>
                            <i id="bnt-eye-cad" className="fa fa-eye"></i>
                        </div>
                    </div>
                    <div className="col-lg-6 col-md-6 col-sm-6">
                        <div className="form-group group-inputs-cad">
                            <input type="text" name="name" className="inputs-cad" placeholder="país" required
                                    value={props.paisCad} onChange={props.changePaisCad}/>
                        </div>
                        <div className="form-group group-inputs-cad">
                            <input type="text" name="name" className="inputs-cad" placeholder="estado" required
                                    value={props.estadoCad} onChange={props.changeEstadoCad}/>
                        </div>
                        <div className="form-group group-inputs-cad">
                            <input type="text" name="name" className="inputs-cad" placeholder="cidade" required
                                    value={props.cidadeCad} onChange={props.changeCidadeCad}/>
                        </div>
                    </div>
                </div>    
                <button type="button" className="btn btn-success btn-md" 
                        disabled={props.nomeCad !== '' && props.emailCad !== '' &&
                                    props.senhaCad !== '' && props.paisCad !== '' &&
                                    props.estadoCad !== '' && props.cidadeCad !== ''? false : true}
                        onClick={props.handleClickCadUsuario}>
                        Salvar
                </button>
            </form>
        </div>
    )
}

export default Cadastro;