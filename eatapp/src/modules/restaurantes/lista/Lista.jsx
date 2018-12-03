import React, { Component } from 'react';

import './Lista.css';
import CardSearch from '../../../components/card/CardSearch';
import CardLista from '../../../components/card/CardLista';

class ListaRestaurantes extends Component {

    render(){
        return(
            <div className="body-lista">
                <div className="block-search">
                    <CardSearch />
                </div>
                <div className="block-lista row">
                   <CardLista />
                   <CardLista />
                   <CardLista />
                   <CardLista />
                   <CardLista />
                </div>
            </div>
        );
    }
}


export default ListaRestaurantes;
