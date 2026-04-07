namespace JogoMonstros
{
    public class Fogo : Monstro
    {
        public override void Atacar(Monstro alvo)
        {
            if(alvo is Agua)
            {
                int dano = this.ATK - 3 * alvo.DEF;
                alvo.Forca -= dano;
            }
            else if(alvo is Fogo)
            {
                int dano = this.ATK - alvo.DEF;
                alvo.Forca -= dano;
            }
            else if(alvo is Terra)
            {
                int dano = this.ATK - alvo.DEF / 2;
                alvo.Forca -= dano;
            }
            else
            {
                throw new Exception("Monstro a ser atacado não foi criado corretamente");
            }
        }
        
        
    }
}