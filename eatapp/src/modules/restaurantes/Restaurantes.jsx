import React, { Component } from 'react';
import { BrowserRouter, Route, Redirect, Switch } from 'react-router-dom'
import Sidebar from '../../components/sidebar/Sidebar';
import ListaRestaurantes from './lista/Lista';
import Favoritos from './favoritos/Favoritos';

export default class Restaurantes extends Component {
    render() {
        return (
            <BrowserRouter>
                <div className="row" style={{margin:0}}>
                    <div className="col-md-2 col-sm-2" style={{padding:0}}>
                        <Sidebar />
                    </div>
                    <div className="col-md-10 col-sm-10" style={{padding:0}}>
                    <Switch>
                        <Route exact path="/" component={ListaRestaurantes}/>
                        <Route path="/favoritos" component={Favoritos}/>
                        <Redirect to="/" />
                    </Switch>
                    </div>
                </div>
            </BrowserRouter>
        )
    }
}
