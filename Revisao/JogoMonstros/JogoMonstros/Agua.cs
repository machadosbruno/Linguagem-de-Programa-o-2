namespace JogoMonstros
{
    public class Agua : Monstro
    {
        public void Atacar(Monstro alvo)
        {
            if(alvo is Agua)
            {
                
            }
            else if(alvo is Fogo)
            {
                int dano = 2;
            }
            else if(alvo is Terra)
            {
                
            }
            else
            {
                throw new Exception("Monstro a ser atacado não foi criado corretamente");
            }
        }
        
        
    }
}