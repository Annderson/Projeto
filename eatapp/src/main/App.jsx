import React, { Component } from 'react';
import axios from 'axios';

import './App.css';
import '../../node_modules/bootstrap/dist/css/bootstrap.min.css';
import '../../node_modules/font-awesome/css/font-awesome.min.css';
import Home from '../modules/home/Home';
import Restaurantes from '../modules/restaurantes/Restaurantes';
import Login from '../modules/home/login/Login';

class App extends Component {

  state ={
    aux: null
  }

  componentDidMount(){
    axios.get(`https://eatapp.mybluemix.net/pegarLogin?email=marchioli.lucas@gmail.com&senha=1111`)
      .then(res => {
        const persons = res.data;
        console.log(persons);
        //this.setState({ aux: persons });
      })

  }
  render() {
    return (
      <div style={{margin:0, padding:0}}>
        <Home />  
      </div>
    );
  }
}
export default App;
//        <Restaurantes/>


//#4f3631#533darkslategrayhsl(9,23,25)rgb(79,54,49)
//#55a068#5a7mediumseagreenhsl(135,30,48)rgb(85,160,104)

