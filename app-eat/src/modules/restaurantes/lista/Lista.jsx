import React, { Component } from 'react';

import './Lista.css';
import CardSearch from '../../../components/card/CardSearch';
import CardLista from '../../../components/card/CardLista';
import  Axios  from 'axios';

class ListaRestaurantes extends Component {

    constructor(props) {
        super(props)

        this.state = {
            list: [] 
        }
    }

    componentDidMount() {
        Axios.get('https://eatapp.mybluemix.net/pegarRestaurantes')
             .then(res => this.setState({ list: res.data},()=> console.log(res.data)) )
    }

    render(){
        return(
            <div className="body-lista">
                <div className="block-search">
                    <CardSearch />
                </div>
                <div className="block-lista row">
                   {
                       this.state.list.map(item => {
                          return (
                            <div key={item._id}> <CardLista  nomeRes={item.restaurante_nome} pais={item.pais}
                                                             especialidade={item.especialidade} cidade={item.cidade}/> 
                            </div>
                          )
                       })
                   }
              
                </div>
            </div>
        );
    }
}


export default ListaRestaurantes;
