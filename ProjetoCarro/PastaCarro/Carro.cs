namespace ProjetoCarro.PastaCarro;

public class Carro
{ // atributos simples de um carro. 
  // encapsulando esses atributos para que sejá usado só na classe Carro.
    private string marca;
    private int ano;
    private string modelo;
    private int atualVelocidade;

    public Carro(string marca, int ano, string modelo)
    { // diferenciando para o compilador os atributos da Classe (private marca, etc...) dos parâmetros usados usando this.
        this.marca = marca;
        this.ano = ano;
        this.modelo = modelo;
        this.atualVelocidade = 0;
    }
    public void Acelerar(int incremento)
    { // função para aumentar a velocidade do carro.
        atualVelocidade += incremento;
    }
    public void Desacelerar(int decremento)
    { // função para desacelerar o carro.
        atualVelocidade -= decremento;

      // se a velocidade for zero quando usado o desacelerar, o carro recebe 0 de velocidade.
      if(atualVelocidade < 0)
        {
            atualVelocidade = 0;
        }
    }
    public void ExibirInformacoes()
    { // aqui será exibido todas as informaçôes do carro.
        Console.WriteLine($"Marca do Carro: {marca}, Ano do Carro: {ano}, Modelo do Carro: {modelo}, Velocidade Atual do Carro: {atualVelocidade} KM/h . ");
    }
}
