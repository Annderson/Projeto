import React from 'react';

import './CardLista.css';

import starF from './../../assets/img/starF.png';
import starM from './../../assets/img/starM.png';
import star from './../../assets/img/star.png';
import mapa from './../../assets/img/mapa.png';
import favorito from './../../assets/img/favoritoC.png';



const CardLista = props => {
    return(
        <div className="card-lista">
           <div className="img-card">
           </div>
           <div className="info-card">
                <h5 className="title-lista">{props.nomeRes}</h5>
                <div className="row">
                    <div className="col-md-9 col-sm-9">
                        <p>Cozinha: {props.cozinha}</p>
                        <p>Pais: {props.pais}</p>
                        <p>Cidade: {props.cidade}</p>
                        <p>Especialidade: {props.especialidade}</p>
                    </div>
                    <div className="col-md-3 col-sm-3">
                        <label>Avaliação:</label>
                        <div className="stars">
                            <img src={starF} className="img-fluid"/>
                            <img src={starF} className="img-fluid"/>
                            <img src={starF} className="img-fluid"/>
                            <img src={starM} className="img-fluid"/>
                            <img src={star} className="img-fluid"/>
                        </div>
                        <div className="actions">
                            <img src={mapa} className="img-fluid mapa"/>
                            <img src={favorito} className="img-fluid mapa"/>
                        </div>
                    </div>
                </div>
           </div>
        </div>
    )
}

export default CardLista;