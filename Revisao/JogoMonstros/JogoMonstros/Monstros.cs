namespace JogoMonstros
{
    public abstract class Monstro
    {
        private int atk;
        private int def;
        private int spd;
        private int forca;

        public int ATK
        {
            get { return atk; }
            set 
            {
                if(value < 0)
                {
                    atk = 0;
                }
                else if(value > 100)
                {
                    atk = 100;
                }
                else
                {
                    atk = value;
                }
            }
        }

        public int DEF
        {
            get { return def; }
            set 
            {
                if(value < 0)
                {
                    def = 0;
                }
                else if(value > 100)
                {
                    def = 100;
                }
                else
                {
                    def = value;
                }
            }
        }

        public int SPD
        {
            get { return spd; }
            set 
            {
                if(value < 0)
                {
                    spd = 0;
                }
                else if(value > 100)
                {
                    spd = 100;
                }
                else
                {
                    spd = value;
                }
            }
        }

        public int Forca
        {
            get { return forca; }
            set 
            {
                if(value < 0)
                {
                    forca = 0;
                }
                else if(value > 100)
                {
                    forca = 100;
                }
                else
                {
                    forca = value;
                }
            }
        }

        abstract public void Atacar(Monstro alvo);
    }
}