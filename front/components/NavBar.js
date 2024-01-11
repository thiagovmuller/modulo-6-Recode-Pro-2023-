import Link from 'next/link';
import styles from '../styles/Navbar.module.css';
 
const Navbar = () => {
  return (
    <nav className={styles.navbar}>
      <Link href="/">Clientes</Link>
      <Link href="/add-client" style={{backgroundColor:'green'}}>Inserir Cliente</Link>
      <Link href="/passagens">Passagens</Link>
      <Link href="/add-passagem" style={{backgroundColor:'green'}}>Inserir Passagem</Link>
      <Link href="/compras">Compras</Link>
      <Link href="/add-compra" style={{backgroundColor:'green'}}>Inserir Compra</Link>
    </nav>
  );
};
 
export default Navbar;