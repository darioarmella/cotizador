import axios from 'axios'
export const SHOW_DOLARS = 'SHOW_DOLARS'
export const SHOW_EUROS = 'SHOW_EUROS'
export const SHOW_REALES = 'SHOW_REALES'
export const base_url = "https://localhost:44347/api/cotizacion/";
//export const base_url = "http://dacotizacionapi.azurewebsites.net/api/cotizacion/";


export function showDolars() {    
    return (dispatch, getState) => {
        axios.get(base_url + 'dolar')
            .then((response) => {
                dispatch( { type: SHOW_DOLARS, payload: response.data } ) 
            }) 
    }  
} 

export function showEuros() {    
    return (dispatch, getState) => {
        axios.get(base_url + 'euro')
            .then((response) => {
                dispatch( { type: SHOW_EUROS, payload: response.data } ) 
            }) 
    }   
} 

export function showReales() {    
    return (dispatch, getState) => {
        axios.get(base_url + 'real')
            .then((response) => {
                dispatch( { type: SHOW_REALES, payload: response.data } ) 
            }) 
    }   
} 