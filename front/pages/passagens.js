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
      .get("https://tvm.somee.com/api/Passagens")
      .then((response) => {
        setClients(response.data);
      })
      .catch((error) => {
        console.error("Erro ao buscar a lista de passagens:", error);
      });
  }, []);
 
  return (
    <div>
      <h1 className={style.h1}>Lista de Passagens</h1>
      <table className="table container tabela">
        <thead>
          <tr>
            <th>Id</th>
            <th>Cia Aérea</th>
            <th>Origem</th>
            <th>Destino</th>
            <th>Valor</th>
            <th>Ações</th> {/* Adicione uma coluna para as ações de edição e exclusão */}
          </tr>
        </thead>
        {clients.map((element) => (
          <tbody key={element.id}>
            <tr className={style.tabela}>
              <td>{element.idPassagem}</td>
              <td>{element.ciaAerea}</td>
              <td>{element.origem}</td>
              <td>{element.destino}</td>
              <td>{element.valor}</td>
              <td>
                <Link href={`/update-passagem/${element.idPassagem}`} className="btn btn-warning">Editar</Link>            
                <Link href={`/delete-passagem/${element.idPassagem}`} className="btn btn btn-danger">Excluir</Link>
              </td>
            </tr>
          </tbody>
        ))}
      </table>
    </div>
  );
};
 
export default Home;