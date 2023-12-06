// See https://aka.ms/new-console-template for more information
using tabuleiro;
using Xadrez;
using jogo;

Tabuleiro tab = new Tabuleiro(8, 8);

tab.colocarPeca(new Torre(tab,Cor.Preta),new Posicao(0,0));
tab.colocarPeca(new Rei(tab,Cor.Preta),new Posicao(1,3));


Tela.imprimirTabuleiro(tab);

Console.ReadLine();