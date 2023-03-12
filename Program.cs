using Disciplina;
Console.Clear();
Console.WriteLine("Exericicio1");
Aluno aluno = new Aluno();
aluno.ReceberDados();
aluno.CalcularMedia();
aluno.CalcularNotaFinal();
aluno.ImprimirNotaFinal();

Console.Clear();
Console.WriteLine("Exercicio2");
Calculadora calculadora = new Calculadora();
calculadora.ExecutarCalculadora();

Console.Clear();
Console.WriteLine("Exercicio3");
ManipularArquivo manipulador = new ManipularArquivo();
manipulador.Conteudo = "náthan luciano de oliveira e silva";
manipulador.EnderecoNomeArquivo = @"C:\Users\043412\Desktop\novapasta\teste.txt"; // lembre-se de mudar sempre o diretório
if (manipulador.SalvarDadosEArquivo())
    Console.WriteLine(" o arquivo foi salvo com sucesso!");
else
    Console.WriteLine("erro, o arquivo no pode ser salvo");

Console.WriteLine(manipulador.PesquisarConteudoArquivo(manipulador.EnderecoNomeArquivo));

Console.Clear();
Console.WriteLine("Exercicio4");
Console.Write("Quantidade de Alunos: ");
int quatidade_de_alunos = int.Parse(Console.ReadLine());
Aluno[] alunos = new Aluno[quatidade_de_alunos];

for(int i = 0; i < quatidade_de_alunos; i++){
    Console.Clear();
    alunos[i] = new Aluno();
    Console.WriteLine($"Aluno {i+1} de {quatidade_de_alunos}");
    alunos[i].ReceberDados();
    alunos[i].CalcularMedia();
}
Console.Clear();
foreach(Aluno a in alunos){
    a.ImprimirNotaFinal();
}