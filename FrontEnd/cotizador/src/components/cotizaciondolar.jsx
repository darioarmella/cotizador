import React from "react"
import {Component} from 'react'
import { connect } from "react-redux"
import { showDolars } from '../actions'

class App extends Component {
  
    componentWillMount() {
      this.props.showDolars()
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
      monedas: state.cotizacionDolar.list
    }
  }

  export default connect(mapStateToProps, { showDolars })(App)
