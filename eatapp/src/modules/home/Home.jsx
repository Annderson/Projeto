import React, { Component } from 'react';
import { BrowserRouter, Route, Redirect, Switch } from 'react-router-dom'

import Menu from '../../components/menu/Menu';

import './Home.css';
import Login from './login/Login';
import CadastroUsuario from './cadastro/CadastroUsuario';

export default class Home extends Component {

    render(){
        return(
            <BrowserRouter>
                <div>
                    <Menu />
                    <div className="body-home">
                    <Switch>
                       <Route exact path="/" component={Login} />
                       <Route path="/cadastro" component={CadastroUsuario} />
                       <Redirect to="/" />
                    </Switch>
                    </div>
                </div>
            </BrowserRouter>
        )
    }
}
