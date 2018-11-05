import React from 'react';
import { NavLink } from 'react-router-dom';
import './Menu.css';

const Menu = props => {

    return (
        <div className="body-menu ">
            <ul className="menu-bar ">
                <li>
                    <a href="#">Login</a>
                </li>
                <li>
                    <a href="#">Cadastro</a>
                </li>
                <li>
                    <a href="#">Sobre</a>
                </li>
            </ul>
        </div>
    )
}

export default Menu;