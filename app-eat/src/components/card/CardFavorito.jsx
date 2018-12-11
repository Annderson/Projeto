import React from 'react';

import './CardFavorito.css';

import starF from './../../assets/img/starF.png';
import starM from './../../assets/img/starM.png';
import star from './../../assets/img/star.png';
import mapa from './../../assets/img/mapa.png';
import favorito from './../../assets/img/favoritoC.png';



const CardFavorito = props => {
    return(
        <div className="card-favorito">
            <div className="header-card row">
                <div className="img-card-favo col-md-8">
                </div>
                <div className="card-favo-actions col-md-4">
                </div>
            </div>
           
           <div className="info-card-favo">
                <div className="stars-favo">
                    <img src={starF} className="img-fluid"/>
                    <img src={starF} className="img-fluid"/>
                    <img src={starF} className="img-fluid"/>
                    <img src={starM} className="img-fluid"/>
                    <img src={star} className="img-fluid"/>
                </div>
            
                <label className=""><b>Nome do restaurante</b></label>
                <p htmlFor="">Pais:</p>
                <p htmlFor="">Especialidade:</p>
           </div>
        </div>       
    )
}

export default CardFavorito;