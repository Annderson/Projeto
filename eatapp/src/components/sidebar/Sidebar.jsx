import React from 'react';
import { NavLink } from 'react-router-dom';
import './Sidebar.css';

const Sidebar = props => {

    return (
        <ul className="sidebar list-unstyled">
            <li>
                <NavLink className="links" to="">Restaurantes</NavLink>
            </li>
            <li>
                <NavLink className="links" to="favoritos">Favoritos</NavLink>
            </li>
            <li>
                <NavLink className="links" to=""> <label>Cadastro de<br/>restaurantes</label> </NavLink>
            </li>
            <li>
                <NavLink className="links" to="">Meus dados</NavLink>
            </li>
            <li className="loggout">
                <NavLink className="links row" to="#">Sair <i className="fa fa-arrow-circle-left ml-4 mt-1"></i></NavLink>
            </li>
        </ul>
    )
}

export default Sidebar;