const INITIAL_USUARIO_STATE = {
    nome: '',
    email: 'Teste',
    senha: 'Teste',
    pais: '',
    estado: '',
    cidade: '',
    loggout: false
}

export default (state = INITIAL_USUARIO_STATE, action) => {
    switch (action.type) {
        case 'EMAIL_CHANGED':
            return {...state, email: action.payload};
        case 'SENHA_CHANGED':
            return {...state, senha: action.payload};
        case 'LOGGOUT_CHANGED':
            return {...state, loggout: action.payload};
        default:
            return state;
    }
}