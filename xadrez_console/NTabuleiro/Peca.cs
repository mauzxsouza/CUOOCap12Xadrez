namespace NTabuleiro
{
  class Peca
  {
    public Posicao Posicao { get; set; }
    public Cor Cor { get; protected set; }
    public int QteMovimentos { get; protected set; }
    public Tabuleiro Tab { get; protected set; }

    public Peca( Posicao posicao, Tabuleiro tab, Cor cor )
    {
      this.Posicao = posicao;
      this.Tab = tab;
      this.Cor = cor;
      this.QteMovimentos = 0; // 0 Movimento na criacao da peca no inicio do jogo
    }      
  }

}
