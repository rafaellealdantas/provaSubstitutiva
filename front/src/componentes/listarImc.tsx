import { useEffect, useState } from "react";
import { Imc } from "../models/imc";


function listarImc(){
    const [imcs, setImcs] = useState<Imc[]>([]);

    useEffect(() => {
      carregarImc();
    }, []);
    
    function carregarImc() {
      //FETCH ou AXIOS
      fetch("http://localhost:5073/pages/imc/listar")
        .then((resposta) => resposta.json())
        .then((imcs: Imc[]) => {
          console.table(imcs);
          setImcs(imcs);
        });
    }
    
}