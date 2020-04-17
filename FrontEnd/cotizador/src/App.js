import React from 'react';
import { Provider } from "react-redux";
import { createStore, applyMiddleware } from 'redux'
import logo from './logo.svg';
import './App.css';
import {Table} from 'react-bootstrap'
import Cotizacionesreal from "./components/cotizacionreal";
import Cotizaciondolar from "./components/cotizaciondolar";
import Cotizacioneuro from './components/cotizacioneuro'

import reducers from './reducers';
import thunk from 'redux-thunk'

const createStoreWithMiddleware = applyMiddleware(thunk)(createStore);

const App = () =>(
  <Provider store = {createStoreWithMiddleware(reducers)}>
    <main>
      <h1>Cotizaciones - Dario Armella</h1>
      <br/>
      <Table striped responsive>
            <thead>
              <tr>
                <th>Moneda</th>
                <th>Valor</th>
              </tr>
            </thead>
            <tbody>
              <Cotizacionesreal />
              <Cotizaciondolar />
              <Cotizacioneuro />
            </tbody>
        </Table>          
    </main>
  </Provider>
)

export default App;
