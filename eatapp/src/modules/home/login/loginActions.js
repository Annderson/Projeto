import Axios from 'axios';

export const changeEmail = (event) => ({
    type: 'EMAIL_CHANGED',
    payload: event.target.value
})

export const changeSenha = (event) => ({
    type: 'SENHA_CHANGED',
    payload: event.target.value
})

export const btnLogar = (username, password) => {
    
}