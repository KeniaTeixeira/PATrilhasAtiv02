/*
 * Criado por SharpDevelop.
 * Usuário: Kenia Teixeira
 * Data: 28/01/2025
 * Hora: 08:25
*/
using System;
namespace ListaAtividade02{
	class ListaDeAtividade{
		public static void Main(string[] args){
			int sair = 1;
			
			while(sair == 1){
			Console.WriteLine("\n\n ------ LISTA 02 ------- \nEscolha uma questão: A - B - C - D - E - F - G - H - I - J \n   PRESIONE S PARA SAIR");
			char x = Convert.ToChar(Console.ReadLine());
			char escolha = char.ToLower(x);
			switch(escolha){
					case 'a':
					/*Escreva um programa que peça ao usuário para digitar dois números e exiba
					a soma deles.*/
						questaoA();
					break;
					
					case 'b':
					/*Escreva um programa que peça ao usuário para digitar um número e exiba o	
					seu dobro.*/
						questaoB();
						break;
					
					case 'c':
					/*Escreva um programa que peça ao usuário para digitar um número e exiba a
					sua metade.*/
						questaoC();
						break;
					
					case 'd':
					/*Escreva um programa que peça ao usuário para digitar um número e exiba o
					seu quadrado.*/
						questaoD();
						break;
						
					case 'e':
					/*Escreva um programa que peça ao usuário para digitar dois números e exiba
					o resultado da divisão do primeiro pelo segundo.*/
						questaoE();
						break;
					case 'f':
					/*Escreva um programa que peça ao usuário para digitar um número e exiba a
					sua raiz quadrada.*/
						questaoF();
						break;
						
					case 'g':
					/*Escreva um programa que peça ao usuário para digitar dois números e exiba
					o resultado da subtração do segundo pelo primeiro.*/
						questaoG();
						break;
						
					case 'h':
					/*Escreva um programa que peça ao usuário para digitar um número e exiba o
					seu valor absoluto.*/
						questaoH();
						break;
						
					case 'i':
					/*Escreva um programa que peça ao usuário para digitar dois números e exiba
					o resultado da multiplicação entre eles.*/
						questaoI();
						break;
						
					case 'j':
					/*Escreva um programa que peça ao usuário para digitar um número e exiba o
					seu resto da divisão por 2.*/
						questaoJ();
						break;
						
					case 's':
					sair = 0;
					break;
					
					default:
						Console.WriteLine("Opção Invalida!!");
					break;
					}	
			}
			
			Console.Write("Precione qualquer tecla para sair . . . ");
			Console.ReadKey(true);
		}
		
			static void questaoA(){
				Console.WriteLine(" -------- QUESTAO A --------");
				int x, y;
				Console.Write("Digite o primeiro numero: ");
				x = Convert.ToInt32(Console.ReadLine());
				Console.Write("Digite o segundo numero: ");
				y = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(" --- SOMA --- \n" + x + " + " + y + " = " + (x+y));
			}
		
			static void questaoB(){
				Console.WriteLine(" -------- QUESTAO B --------");
				Console.Write("Digite um valor: ");
				int x = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("O dobro de " + x + " é: " + (x*2));
			}
			
			static void questaoC(){
				Console.WriteLine(" -------- QUESTAO C --------");
				Console.Write("Digite um valor: ");
				float x = float.Parse(Console.ReadLine());
				float resultado = x/2;
				Console.WriteLine("A metade de " + x + " é: " + resultado);
			}
			
			static void questaoD(){
				Console.WriteLine(" -------- QUESTAO D --------");
				Console.Write("Digite um valor: ");
				int x = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("O quadrado de " + x + " é: " + (x*2));
			}
			
			static void questaoE(){
				Console.WriteLine(" -------- QUESTAO E --------");
				Console.Write("Digite o primeiro valor: ");
				float x = float.Parse(Console.ReadLine());
				Console.Write("Digite o segundo valor: ");
				float y = float.Parse(Console.ReadLine());
				Console.WriteLine("A divisao de " + x + " por " + y + " é: " + (x/y));
			}
			
			static void questaoF(){
				Console.WriteLine(" -------- QUESTAO F --------");
				Console.Write("Digite um valor: ");
				int x = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("A raiz quadrada de " + x + " é: " + Math.Sqrt(x));
			}
		
			static void questaoG(){
				Console.WriteLine(" -------- QUESTAO G --------");
				Console.Write("Digite o primeiro valor: ");
				int x = Convert.ToInt32(Console.ReadLine());
				Console.Write("Digite o segundo valor: ");
				int y = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("A subtração de " + y + " com " + x + " é: " + (y-x));
			}
		
			static void questaoH(){
				Console.WriteLine(" -------- QUESTAO H --------");
				Console.Write("Digite um valor: ");
				int x = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("O valor absoluto de " + x + " é: " + Math.Abs(x));
			}
		
			static void questaoI(){
				Console.WriteLine(" -------- QUESTAO I --------");
				Console.Write("Digite o primeiro valor: ");
				int x = Convert.ToInt32(Console.ReadLine());
				Console.Write("Digite o segundo valor: ");
				int y = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("A multiplicação de " + x + " e " + y + " é: " + (x*y));
			}
		
			static void questaoJ(){
				Console.WriteLine(" -------- QUESTAO H --------");
				Console.Write("Digite um valor: ");
				int x = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("O resto da divisao de " + x + " por 2 é: " + (x%2));
			}
	}
}