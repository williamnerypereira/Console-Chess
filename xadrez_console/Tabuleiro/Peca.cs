namespace Tabuleiro
{
     abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
    
        public int qteMovimentos { get; protected set; }
        public Tab tab { get; protected set; }

        public Peca(Tab tab, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.qteMovimentos = 0;
            this.tab = tab;
        }

        public void IncrementarQteMovimentos()
        {
            qteMovimentos++;
        }

        public void DecrementarQteMovimentos()
        {
            qteMovimentos--;
        }

        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();

            for(int i=0; i < tab.linhas; i++)
            {
                for(int j=0; j < tab.linhas; j++)
                {
                    if(mat[i, j])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool MovimentoPossivel(Posicao pos)
        {
            return MovimentosPossiveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] MovimentosPossiveis();
        
    }
}
