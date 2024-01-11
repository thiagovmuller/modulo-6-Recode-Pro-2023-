import { useState, useEffect } from "react";
import axios from "axios";
import style from "../../styles/Home.module.css";
import { useRouter } from 'next/router';
 
 
const UpdateClient = () => {
  const [client, setClient] = useState({ idCliente: "", nome: "", cpf: "", dataNasc: "", telefone: "" });
  const router = useRouter();
  const { codigo } = router.query;
 
  useEffect(() => {
    // Faça uma chamada GET para a API para obter detalhes do cliente a ser atualizado
    axios
      .get("https://tvm.somee.com/api/Clientes/" + client.idCliente)
      .then((response) => {
        setClient(response.data);      
      })
      .catch((error) => {
        console.error("Erro ao buscar detalhes do cliente:", error);
      });
  }, [client.idCliente]);
 
  const handleInputChange = (e) => {
    setClient({ ...client, [e.target.name]: e.target.value });
  };
 
  const handleUpdateClient = () => {
    axios
      .put("https://tvm.somee.com/api/Clientes" + client.idCliente, client)
      .then((response) => {
        router.push('/');    
   
      })
      .catch((error) => {
        console.error("Erro ao atualizar cliente:", error);
      });
  };
 
  return (
   
    <div>
      <h1 className={style.h1}>Atualizar Cliente</h1>
      <table style={{marginLeft:'20px'}}>
        <tbody>
          <tr>
            <td>
              <label>ID do Cliente:</label>
            </td>
            <td>
              <input
                type="text"
                name="idCliente"
                value={client.idCliente = codigo}
                onChange={handleInputChange}
              />
            </td>
          </tr>
          <tr>
            <td>
              <label>Nome:</label>
            </td>
            <td>
              <input
                type="text"
                name="name"
                value={client.nome}
                onChange={handleInputChange}
              />
            </td>
          </tr>
          <tr>
            <td>
              <label>CPF:</label>
            </td>
            <td>
              <input
                type="text"
                name="cpf"
                value={client.cpf}
                onChange={handleInputChange}
              />
            </td>
          </tr>
          <tr>
            <td>
              <label>Data de Nascimento:</label>
            </td>
            <td>
              <input
                type="text"
                name="dataNasc"
                value={client.dataNasc}
                onChange={handleInputChange}
              />
            </td>
          </tr>
          <tr>
            <td>
              <label>Telefone:</label>
            </td>
            <td>
              <input
                type="text"
                name="telefone"
                value={client.telefone}
                onChange={handleInputChange}
              />
            </td>
          </tr>
          <tr>
            <td colSpan="2">
              <button onClick={handleUpdateClient}>Atualizar Cliente</button>
            </td>
          </tr>
        </tbody>
      </table>
    </div>
  );
};
 
export default UpdateClient;