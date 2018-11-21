import { combineReducers, createStore } from 'redux';

import loginReducer from '../modules/home/login/loginReducer';

const rootReducer = combineReducers({
    usuario: loginReducer,
    restaurantes: () => ({

    }) 
});

export default rootReducer;