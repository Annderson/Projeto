import Axios from 'axios';
import { changeLoggout } from './loginActions';

export const changeEmail = (event) => ({
    type: 'EMAIL_CHANGED',
    payload: event.target.value
})

export const changeSenha = (event) => ({
    type: 'SENHA_CHANGED',
    payload: event.target.value
})

export const loggout = (value) => ({
    type: 'LOGGOUT_CHANGED',
    payload: value
})

export const btnLogar = (username, password, loggout) => {
    loggout(loggout)
}