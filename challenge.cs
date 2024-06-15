using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o nome do seu Herói: ");
        string nomeHeroi = Console.ReadLine();
        Console.Write("Digite a experiencia do seu Herói: ");
        string experienciaText = Console.ReadLine();
        int experienciaHeroi = int.Parse(experienciaText);
        string rankingHeroi;
        switch(experienciaHeroi)
        {
           case < 1000:
             rankingHeroi = "Ferro";
             break;
           case < 2001:
             rankingHeroi = "Bronze";
             break;  
           case < 5001:
             rankingHeroi = "Prata";
             break;    
           case < 7001:
             rankingHeroi = "Ouro";
             break;  
           case < 8001:
             rankingHeroi = "Platina";
             break;  
           case < 9001:
             rankingHeroi = "Ascendente";
             break;  
           case < 10001:
             rankingHeroi = "Imortal";
             break;  
           case > 10001:
             rankingHeroi = "Radiante";
             break;  
           default: 
             rankingHeroi = "Unranked";
             break;
        }
        Console.Write("O herói de nome " + nomeHeroi + " está no nível de " + rankingHeroi);
    }
}