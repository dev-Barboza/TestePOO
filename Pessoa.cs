using System;

class Pessoa
{

 //atributos = caracteristicas que pode ter 

public string nome; 
// public = vai ter visualizaçao do atributo 
// string = uma infrmação textual recebe numeros letras etc

public int idade; //referencia é quando utilizamos os atributos ou a classe em algum lugar 

// metodos = funçoes 

public void mensagem()//void = nulo, não armazenara a variavel 
{
    Console.WriteLine("Ola "+nome+" voce tem "+idade+" anos ");
}




}