import React, { Component } from 'react';

import './Lista.css';
import CardSearch from '../../../components/card/CardSearch';
import CardLista from '../../../components/card/CardLista';
import  Axios  from 'axios';

class ListaRestaurantes extends Component {

    constructor(props) {
        super(props)

        this.changeSearch = this.changeSearch.bind(this);

        this.state = {
            list: [],
            search: '' 
        }
    }

    componentDidMount() {
        Axios.get('https://eatapp.mybluemix.net/pegarRestaurantes')
             .then(res => this.setState({ list: res.data},()=> console.log(res.data)) )
    }

    changeSearch(e){
        this.setState({search: e.target.value});
    }

    render(){
        const sch = this.state.search.toLowerCase();

        const filterList = this.state.list.filter( item=> {
            return( item.restaurante_nome.toLowerCase().indexOf(sch) >=0 )
        })

        return(
            <div className="body-lista">
                <div className="block-search">
                    <CardSearch search={this.state.search} changeSearch={this.changeSearch}/>
                </div>
                <div className="block-lista row">
                   {
                        filterList.map(item => {
                          return (
                            <div key={item._id}> <CardLista  nomeRes={item.restaurante_nome} pais={item.pais}
                                                             especialidade={item.especialidade} cidade={item.cidade}
                                                             nota={item.avaliacao[0].nota}/> 
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
