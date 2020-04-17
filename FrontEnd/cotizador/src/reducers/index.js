import {combineReducers} from 'redux'
import {showDolars} from './cotizacionDolar'
import { showEuros } from './cotizacionEuro'
import { showReales } from './cotizacionReal'

const rootReducer = combineReducers({
    cotizacionDolar: showDolars,
    cotizacionEuro: showEuros,
    cotizacionReal: showReales,
})

export default rootReducer