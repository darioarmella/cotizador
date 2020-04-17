import {SHOW_EUROS} from '../actions'

const initialState = {
    list: []
}

export function showEuros(state = initialState, action){
    switch(action.type){
        case SHOW_EUROS:
            return Object.assign({}, state, {list: action.payload})
            
        default:
            return state
    }
}