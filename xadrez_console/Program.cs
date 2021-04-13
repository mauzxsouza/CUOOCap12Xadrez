﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTabuleiro;

namespace xadrez_console
{
  class Program
  {
    static void Main( string[] args )
    {
      Posicao posicao = new Posicao( 8, 8 );

      Tabuleiro tab = new Tabuleiro( 8, 8 );

      Tela.imprimirTabuleiro( tab );

      Console.Write( posicao );

      Console.ReadLine();
    }
  }
}
