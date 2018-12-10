import React, { Component } from 'react';

import './Favoritos.css';
import CardSearch from '../../../components/card/CardSearch';
import CardFavorito from '../../../components/card/CardFavorito';
//import CardLista from '../../../components/card/CardLista';

class Favoritos extends Component {

    render(){
        return(
            <div className="body-favo">
                <div className="block-search-favo">
                    <CardSearch />
                </div>
                <div className="row block-favo" style={{margin:0}}>
                   <div className="col-md-3"> 
                       <CardFavorito />
                   </div>
                   <div className="col-md-3"> 
                       <CardFavorito />
                   </div>
                   <div className="col-md-3"> 
                       <CardFavorito />
                   </div>
                   <div className="col-md-3"> 
                       <CardFavorito />
                   </div>
                   <div className="col-md-3"> 
                       <CardFavorito />
                   </div>
                </div>
            </div>
        );
    }
}


export default Favoritos;