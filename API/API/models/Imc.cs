using System.Reflection.Metadata;

namespace API.Models;

public class Imc
{
     public string ImcId { get; set; } = Guid.NewGuid().ToString();
    public double? Altura {get; set; }

    public double? Peso {get; set; }   
    public double? imcvalor {get; set; }  
    public string? imcresult {get; set; }  
    public Aluno? Aluno { get; set; }

    public void CalcularImc()
    {
        imcvalor = Peso / (Altura * 2) ;
        if (imcvalor > 40)
        {
            imcresult = "obesidade grave";
        }else if(imcvalor >= 30 || imcvalor <= 39.9)
        {
            imcresult = "obesidade";
        }else if(imcvalor >= 25 || imcvalor <= 29.9)
        {
            imcresult = "sobrepeso";
        }else if(imcvalor >= 18.5 || imcvalor <= 24.9)
        {
            imcresult = "normal";
        }else if(imcvalor < 18.5)
        {
            imcresult = "magreza";
        }
    }
        
}
