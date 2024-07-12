import { BrowserRouter, Route, Routes, Link } from 'react-router-dom';
import listarImc from "./componentes/listarImc";

function App() {
  return (
    <div>
      <BrowserRouter>
        <nav>
          <ul>
            <li>
              <Link to={"/"}>Home</Link>
            </li>
            <li>
              <Link to={"/pages/imc/listar"}>
                Listar IMC{" "}
              </Link>
            </li>
            <li>
              <Link to={"/pages/aluno/cadastrar"}>
                Cadastrar Aluno{" "}
              </Link>
            </li>
          </ul>
        </nav>
        <Routes>
          <Route path="/pages/imc/listar" element={<ListarImc />} />
          <Route
            path="/pages/aluno/cadastrar"
            element={<ProdutoListar />}
          />
          {/* <Route
            path="/pages/produto/cadastrar"
            element={<ProdutoCadastrar />}
          />
          <Route
            path="/pages/cep/consultar"
            element={<CepConsultar />}
          />
          <Route
            path="/pages/produto/alterar/:id"
            element={<ProdutoAlterar />}
          /> */}
        </Routes>
        <footer>
          <p>Desenvolvido por Diogo Steinke Deconto</p>
        </footer>
      </BrowserRouter>
    </div>
  );
}

export default App;