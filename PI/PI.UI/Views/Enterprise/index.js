
import { View, Text, StyleSheet, TextInput, TouchableOpacity} from 'react-native'
import React from 'react'

import * as Animetable from 'react-native-animatable'

export default function SignIn() {
  return (
    <View style={styles.container}>
      
      <Animetable.View
        animation="fadeInLeft" delay={600} style={styles.containerHeader}>
        <Text style={styles.primeiroTitulo}>Informe as principais informações da sua</Text>
        <Text style={styles.segundoTitulo}>empresa</Text>
      </Animetable.View>

      <Animetable.View animation="fadeInUp" style={styles.containerForm}>
        <Text style={styles.title}>CNPJ</Text>
        <TextInput 
          style={styles.input}
          placeholder="Digite o CNPJ da empresa"
          />
        <Text style={styles.title}>Senha</Text>
        <TextInput
          style={styles.input}
          placeholder='Digite sua senha'
        />
        <Text style={styles.title}>Confirmar Senha</Text>
        <TextInput
          style={styles.input}
          placeholder='Digite sua senha novamente'
        />
        <TouchableOpacity style={styles.buttonCadastrar}>
          <Text style={styles.buttonCadastrarText}>Cadastrar</Text>
        </TouchableOpacity>
        
        <TouchableOpacity style={styles.buttonLogin}>
          <Text>Ja tem cadastro? Faça o <Text style={styles.textoLogin}>Login</Text></Text>
        </TouchableOpacity>

      </Animetable.View>

      
    </View>
  )
}

const styles = StyleSheet.create ({
  container: {
    flex: 1,
    backgroundColor: "#D3DDDC",
    
  },
  containerHeader: {
    marginTop: '15%',
    marginBottom: '2%',
    paddingLeft: '5%',
    borderLeftWidth: 20,
    borderLeftColor: '#006666',
    // borderLeftRadius: 20,
  },
  primeiroTitulo: {
    fontSize: '30',
    fontWeight: 'bold',
    color: 'black'
  },
  segundoTitulo:{
    fontSize: '30',
    fontWeight: 'bold',
    color: '#006666',
  },
  input:{
    borderBottomWidth: 1,
    borderBottomColor: '#006666',
    height: 40,
  },
  containerForm:{
    backgroundColor: '#f5f5f5',
    borderTopRightRadius: '30',
    borderTopLeftRadius: '30',
    flex: 1,
    marginTop: '20%',
    paddingLeft: '6%',
    paddingRight: '6%',
  },
  title: {
    fontSize: '20',
    paddingTop: '5%',
  },
  buttonCadastrar:{
    marginTop: '20%',
    width: '100%',
    backgroundColor: '#006666',
    borderRadius: '20',
    alignSelf: 'center',
    alignItems: 'center',
  },
  buttonCadastrarText:{
    padding: '4%',
    color: 'white',
    fontSize: '20',
  },
  buttonLogin: {
    marginTop: '5%',
    alignSelf: 'center',

  },
  textoLogin:{
    color: '#006666',
    fontWeight: 'bold',
  }


})

