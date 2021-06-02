namespace Tabuleiro
{
    class Peca
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
    }
}
