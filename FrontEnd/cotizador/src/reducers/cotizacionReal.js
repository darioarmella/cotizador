import {SHOW_REALES} from '../actions'

const initialState = {
    list: []
}

export function showReales(state = initialState, action){
    switch(action.type){
        case SHOW_REALES:
            return Object.assign({}, state, {list: action.payload})
            
        default:
            return state
    }
}