import React, { Component } from 'react';
import './App.css';
import Axios from 'axios';
import Login from '../modules/login/Login';
import Cadastro from '../modules/cadastro/Cadastro';
import Menu from '../components/menu/Menu';
import Restaurantes from '../modules/restaurantes/Restaurantes';

class App extends Component {

  constructor(props) {
    super(props)

    this.handleMenu = this.handleMenu.bind(this);
    this.changeEmail = this.changeEmail.bind(this);
    this.changeSenha = this.changeSenha.bind(this);
    this.handleBtnEye = this.handleBtnEye.bind(this);
    this.handleClickLogar = this.handleClickLogar.bind(this);
    this.iniciarMethodCadUsuario();

  
    this.state = {
      email: 'anderson@gmail.com',
      password: '654321',
      nomeCad: '',
      errorLogin: '',
      emailCad: '',
      senhaCad: '',
      paisCad: '',
      estadoCad: '',
      cidadeCad: '',
      objusuario: [],
      menu: 'login',
      bntEye: false,
      loggout: false
    }
  }

  iniciarMethodCadUsuario(){
    this.handleClickCadUsuario = this.handleClickCadUsuario.bind(this);
    this.changeNomeCad = this.changeNomeCad.bind(this);
    this.changeEmailCad = this.changeEmailCad.bind(this);
    this.changeSenhaCad = this.changeSenhaCad.bind(this);
    this.changePaisCad = this.changePaisCad.bind(this);
    this.changeEstadoCad = this.changeEstadoCad.bind(this);
    this.changeCidadeCad = this.changeCidadeCad.bind(this);
  }

  componentDidMount() {
    
  }

  handleMenu(e) {
    this.setState({ menu: e })
  }

  handleClickLogar(){
    Axios.get(`https://eatapp.mybluemix.net/pegarLogin?email=${this.state.email}&senha=${this.state.password}`)
         .then(res => 
            this.setState({ 
              errorLogin: res.data.length !== 0 ? false : true,
              objusuario: res.data,
              loggout: res.data.length !== 0 ? true : false
            })
          );
    
  }



  handleClickCadUsuario(){
    Axios.post('https://eatapp.mybluemix.net/cadastrar',
       {
         nome: this.state.nomeCad,
         email: this.state.emailCad,
         senha: this.state.senhaCad,
         pais: this.state.paisCad,
         estado: this.state.estadoCad,
         cidade: this.state.cidadeCad
       }
    ).then(res => console.log('Post cad ' + res.data))
    this.setState({
      nomeCad: '',
      emailCad: '',
      senhaCad: '',
      paisCad: '',
      estadoCad: '',
      cidadeCad: '',
      menu: 'login'
    });
  }

  changeNomeCad(e) {
    this.setState({ nomeCad: e.target.value});
  }
  changeEmailCad(e) {
    this.setState({ emailCad: e.target.value});
  }
  changeSenhaCad(e) {
    this.setState({ senhaCad: e.target.value});
  }
  changePaisCad(e) {
    this.setState({ paisCad: e.target.value});
  }
  changeEstadoCad(e) {
    this.setState({ estadoCad: e.target.value});
  }
  changeCidadeCad(e) {
    this.setState({ cidadeCad: e.target.value});
  }
  changeEmail(e) {
    console.log(e.target.value);
    this.setState({
      email: e.target.value,
      errorLogin: this.state.password === '' || this.state.email === '' ? true : false
    });
  }
  changeSenha(e) {
    console.log( e.target.value) ;
    this.setState({ 
      password: e.target.value,
      errorLogin: this.state.password === '' || this.state.email === '' ? true : false
    });
  }
  handleBtnEye() {
    this.setState({ bntEye: !this.state.bntEye });
  }

  render() {

    let menu = this.state.menu === 'cadastro' ? <Cadastro nomeCad={this.state.nomeCad} emailCad={this.state.emailCad}
                                                    senhaCad={this.state.senhaCad} paisCad={this.state.paisCad}
                                                    estadoCad={this.state.estadoCad} cidadeCad={this.state.cidadeCad} 
                                                    changeNomeCad={this.changeNomeCad} changeEmailCad={this.changeEmailCad}
                                                    changeSenhaCad={this.changeSenhaCad} changePaisCad={this.changePaisCad}
                                                    changeEstadoCad={this.changeEstadoCad} changeCidadeCad={this.changeCidadeCad}
                                                    handleClickCadUsuario={this.handleClickCadUsuario} />
                                              : <Login email={this.state.email} senha={this.state.password} errorLogin={this.state.errorLogin}
                                                    handleBtnEye={this.handleBtnEye} btnEye={this.state.bntEye}
                                                    changeEmail={this.changeEmail} changeSenha={this.changeSenha}
                                                    handleClickLogar={this.handleClickLogar} />

    return (
      <div >
        {
          this.state.loggout === true ? '' :  <Menu handleMenu={this.handleMenu} />
        }
        <div>
          {
            this.state.loggout === true ? <Restaurantes /> : menu
          }
        </div>
        
      </div>
    );
  }
}

export default App;
//<Login handleClickLogar={this.handleClickLogar} />