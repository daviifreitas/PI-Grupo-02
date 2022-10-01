import styles from './SingUpEmpresa.module.css'

// import * as Animetable from 'react-animatable'

function SingUpEmpresa() {
  return (
    <div className={styles.container}>
      
      <div
        className={styles.containerHeader}>
        <p className={styles.primeiroTitulo}>Informe as principais informações da sua
        <p className={styles.segundoTitulo}>empresa</p></p>
        
      </div>
      
      <div className={styles.containerForm}>
        <h3 className={styles.title}>CNPJ</h3>
        <input 
          className={styles.inputTexto}
          placeholder="Digite o CNPJ da empresa"
          />
        <h3 className={styles.title}>Senha</h3>
        <input
          className={styles.inputTexto}
          placeholder='Digite sua senha'
        />
        <h3 className={styles.title}>Confirmar Senha</h3>
        <input
          className={styles.inputTexto}
          placeholder='Digite sua senha novamente'
        />
       
        
        <a href="#" className={styles.buttonCadastrar}><button className={styles.buttonCadastrarText}>Cadastrar</button></a>


        <p className={styles.buttonLogin}>Ja tem cadastro? Faça o <a href="#" className={styles.textoLogin}>Login</a></p>

      </div>
    </div>
  )
}

export default SingUpEmpresa;


// <div
//         className={styles.containerHeader}>
//         <h2 className={styles.primeiroTitulo}>Informe as principais informações da sua</h2>
//         <h2 className={styles.segundoTitulo}>empresa</h2>
//       </div>
      
//       <div className={styles.containerForm}>
//         <h3 className={styles.title}>CNPJ</h3>
//         <TextInput 
//           className={styles.input}
//           placeholder="Digite o CNPJ da empresa"
//           />
//         <h3 className={styles.title}>Senha</h3>
//         <TextInput
//           className={styles.input}
//           placeholder='Digite sua senha'
//         />
//         <h3 className={styles.title}>Confirmar Senha</h3>
//         <TextInput
//           className={styles.input}
//           placeholder='Digite sua senha novamente'
//         />
//         <TouchableOpacity className={styles.buttonCadastrar}>
//           <h3 className={styles.buttonCadastrarText}>Cadastrar</h3>
//         </TouchableOpacity>
        
//         <TouchableOpacity className={styles.buttonLogin}>
//           <h3>Ja tem cadastro? Faça o <h3 className={styles.textoLogin}>Login</h3></h3>
//         </TouchableOpacity>

//       </div>