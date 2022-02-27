
using PrimeiroProjeto;

Instituicao instituicao = new Instituicao();
System.Console.Write("Informe o NOME da instituição : ");
instituicao.Nome = System.Console.ReadLine();
System.Console.Write("Informe o ENDEREÇO da instituição : ");
instituicao.Endereco = System.Console.ReadLine();
System.Console.WriteLine("====================================");
System.Console.WriteLine($"Obrigado por informar os dados para a  {instituicao.Nome}");
System.Console.WriteLine("Pressione qualquer tecla para encerrar.");
System.Console.ReadKey();

