import "bootstrap/dist/css/bootstrap.css";
import { useEffect, useState } from "react";
import axios from "axios";
import style from '../styles/Home.module.css';
import Link from 'next/link'; // Importe o Link para criar links de navegação
 
const Home = () => {
  const [clients, setClients] = useState([]);
 
  useEffect(() => {
    // Faça uma chamada GET para a API Spring Boot
    axios
      .get("https://tvm.somee.com/api/Clientes")
      .then((response) => {
        setClients(response.data);
      })
      .catch((error) => {
        console.error("Erro ao buscar a lista de clientes:", error);
      });
  }, []);
 
  return (
    <div>
      <h1 className={style.h1}>Lista de Clientes</h1>
      <table className="table container tabela">
        <thead>
          <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>CPF</th>
            <th>Data Nascimento</th>
            <th>Telefone</th>
            <th>Ações</th> {/* Adicione uma coluna para as ações de edição e exclusão */}
          </tr>
        </thead>
        {clients.map((element) => (
          <tbody key={element.id}>
            <tr className={style.tabela}>
              <td>{element.idCliente}</td>
              <td>{element.nome}</td>
              <td>{element.cpf}</td>
              <td>{element.dataNasc}</td>
              <td>{element.telefone}</td>
              <td>
                <Link href={`/update-client/${element.idCliente}`} className="btn btn-warning">Editar</Link>            
                <Link href={`/delete-client/${element.idCliente}`} className="btn btn btn-danger">Excluir</Link>
              </td>
            </tr>
          </tbody>
        ))}
      </table>
    </div>
  );
};
 
export default Home;