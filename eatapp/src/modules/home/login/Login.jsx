import React, { Component } from 'react';
import LoginForm from './login-form/LoginForm';
import LoginInfo from './login-info/LoginInfo';

export default class Login extends Component {
    constructor(props){
        super(props)
    }

    render(){
        return (
            <div className="row" style={{margin:0, overflow: 'auto', backgroundColor: '#4f3631'}}>
                <div className="col-lg-6 col-md-6">
                    <LoginInfo />
                </div>
                <div className="col-lg-6 col-md-6" >
                    <LoginForm btnLogar={e => console.log('teste btn')} />
                </div>
            </div>
        )
    }

}