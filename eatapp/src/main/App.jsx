import React, { Component } from 'react';

import './App.css';
import '../../node_modules/bootstrap/dist/css/bootstrap.min.css';
import '../../node_modules/font-awesome/css/font-awesome.min.css';
import Home from '../modules/home/Home';
import Restaurantes from '../modules/restaurantes/Restaurantes';

class App extends Component {
  render() {
    return (
      <div style={{margin:0, padding:0}}>
         <Restaurantes/>
      </div>
    );
  }
}
export default App;
//<Home />

//#4f3631#533darkslategrayhsl(9,23,25)rgb(79,54,49)
//#55a068#5a7mediumseagreenhsl(135,30,48)rgb(85,160,104)

