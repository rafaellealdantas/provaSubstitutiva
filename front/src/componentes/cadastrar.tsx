import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import { aluno } from "../models/aluno";
import { imc } from "../models/imc";

function Cadastraraluno() {
  const navigate = useNavigate();
  const [nome, setTitulo] = useState("");
  const [sobrenome, setDescricao] = useState("");
  const [alunoiaId, setCategoriaId] = useState("");
  const [alunos, setCategorias] = useState<Aluno[]>([]);

  useEffect(() => {
    carregarAluno();
  }, []);

  function carregarCategorias() {
    //FETCH ou AXIOS
    fetch("http://localhost:5000/categoria/listar")
      .then((resposta) => resposta.json())
      .then((aluno: Aluno[]) => {
        setCategorias(alunos);
      });
  }

  function cadastrarimc(e: any) {
    const tarefa: Imc = {
      nome: nome,
      sobrenome: sobrenome,
      alunoaId: alunoId,
    };

    //FETCH ou AXIOS
    fetch("http://localhost:5073/pages/imc/listar", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(tarefa),
    })
      .then((resposta) => resposta.json())
      .then((alunos: Aluno) => {
        navigate("/pages/tarefa/listar");
      });
    e.preventDefault();
  }

  return (
    <div>
      <h1>Cadastrar usuario</h1>
      <form onSubmit={Cadastraraluno}>
        <label>nome:</label>
        <input
          type="text"
          placeholder="Digite o nome"
          onChange={(e: any) => setNome(e.target.value)}
          required
        />
        <br />
        <label>sobrenome:</label>
        <input
          type="text"
          placeholder="Digite o sobrenome"
          onChange={(e: any) => setSobrenome(e.target.value)}
        />
        <br />
        <label>Categorias:</label>
        <select onChange={(e: any) => setalunoId(e.target.value)}>
          {aluno.map((aluno) => (
            <option
              value={aluno.alunoId}
              key={aluno.alunoId}
            >
              {aluno.nome}
            </option>
          ))}
        </select>
        <br />
        <button type="submit">Cadastrar</button>
      </form>
    </div>
  );
}

export default CadastrarAluno;