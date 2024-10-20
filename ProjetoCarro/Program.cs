//chamando a "PastaCarro" para o arquivo principal.
using ProjetoCarro.PastaCarro;
// nome do espaço principal.
namespace ProjetoCarro;
// projeto simples sobre um carro.
internal class Program
{
    static void Main()
    {
        // criando um objeto Carro
        Carro meuCarro = new Carro("suzuki", 2004, "Suzuki Swift");
        //acelerando o Carro
        meuCarro.Acelerar(40);
        //Exibindo todas as informações acima.
        meuCarro.ExibirInformacoes();
        //desacelerando o Carro.
        meuCarro.Desacelerar(39);
        //Exibindo denovo as informações.
        meuCarro.ExibirInformacoes();

        //SAIDA DEPOIS DE ACELERAR: Marca suzuki, Ano do Carro 2004, Modelo do Carro Suzuki Swift, Velocidade Atual do Carro: 40 KM/h .
        //SAIDA DEPOIS DE DESACELERAR: Marca suzuki, Ano do Carro 2004, Modelo do Carro Suzuki Swift, Velocidade Atual do Carro: 1 KM / h.

        //fim do projeto usando classes e modificadores de acesso.
    }
}