import React from 'react';

import './CardSearch.css';

const CardSearch = props => {
    return(
        <div className="card-search">
            <div className="combo-search">
                <input type="text" className="field-search" placeholder="Procure seu restaurante"
                        value={props.search} onChange={props.changeSearch}/>
                <i className="fa fa-search icon-search"></i>
            </div>
            <select className="select-search"> 
                <option>Teste</option>
            </select>
        </div>
    )
}

export default CardSearch;