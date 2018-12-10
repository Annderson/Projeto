import React from 'react';
import './Menu.css';

const Menu = props => {

    return (
        <div className="body-menu ">
            <ul className="menu-bar ">
                <li>
                    <a href="#" onClick={() => props.handleMenu('login')}>Login</a>
                </li>
                <li>
                    <a href="#"  onClick={() => props.handleMenu('cadastro')}>Cadastro</a>
                </li>
                <li>
                    <a href="#" >Sobre</a>
                </li>
            </ul>
        </div>
    )
}

export default Menu;