import {SHOW_DOLARS} from '../actions'

const initialState = {
    list: []
}

export function showDolars(state = initialState, action){
    switch(action.type){
        case SHOW_DOLARS:
            return Object.assign({}, state, {list: action.payload})
            
        default:
            return state
    }
}