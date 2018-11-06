import React from 'react';
import { NavLink } from 'react-router-dom';
import './Menu.css';

const Menu = props => {

    return (
        <div className="body-menu ">
            <ul className="menu-bar ">
                <li>
                    <NavLink to="">Login</NavLink>
                </li>
                <li>
                    <NavLink to="cadastro">Cadastro</NavLink>
                </li>
                <li>
                    <NavLink to="#">Sobre</NavLink>
                </li>
            </ul>
        </div>
    )
}

export default Menu;