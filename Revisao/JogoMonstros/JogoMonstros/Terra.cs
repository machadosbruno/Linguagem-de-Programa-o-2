namespace JogoMonstros
{
    public class Terra : Monstro
    {
        public override void Atacar(Monstro alvo)
        {
            if(alvo is Agua)
            {
                int dano = 3 * this.ATK - alvo.DEF;
                alvo.Forca -= dano;
            }
            else if(alvo is Fogo)
            {
                int dano = 2 * this.ATK - alvo.DEF;
                alvo.Forca -= dano;
            }
            else if(alvo is Terra)
            {
                int dano = this.ATK -  4 * alvo.DEF;
                alvo.Forca -= dano;
            }
            else
            {
                throw new Exception("Monstro a ser atacado não foi criado corretamente");
            }
        }
        
        
    }
}