namespace Atributos_e_metodos_01_12_part2
{
    public class Personagem
    {
        public string nome;
        public int idade;
        public string armadura;
        public string poderes;

        public string Ataque(){
            return "Ataque de espadas";
        }
        public string Defesa(){
            return "Escudo";
        }
        public string Magia(){
            return "Chuva de fogo";
        }
        public string Magia2(){
            return "Domo de pedra";
        }
    }
}