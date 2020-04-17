import React from "react"
import {Component} from 'react'
import { connect } from "react-redux"
import { showEuros } from '../actions'

class App extends Component {
  
    componentWillMount() {
      this.props.showEuros()
    }
    
    renderMonedasList() {
        return (
            <tr key={this.props.monedas.moneda}>
              <td>{this.props.monedas.moneda}</td>
              <td>{new Intl.NumberFormat("es-ES", {
                  style: "currency",
                  currency: "ARS"
                }).format(this.props.monedas.precio)}
              </td>
            </tr>
          )
      }
    
    render() {
      return (
        this.renderMonedasList()
      );
    }
  }
  
  function mapStateToProps(state) {
    return {      
      monedas: state.cotizacionEuro.list
    }
  }

  export default connect(mapStateToProps, { showEuros })(App)