//instanciando o objeto, criando uma variavel
Bibliotecaria ger = new Bibliotecaria()//propiedades
{
    Matricula = "FN-001",
    Nome = "Roberta",
    Email = "admin@senaistore.com",
    Senha = "1234"
};

List<Aluno> alunos = new List<Aluno>()
{
    new Aluno{Nome = "Yasmin Cotoco", CodCurso = 152656, Email = "julio@email.com"},
    new Aluno{Nome = "Melissa Ianca", CodCurso = 158964, Email = "mel@email.com"},
    new Aluno{Nome = "Julia Boboca", CodCurso = 569258, Email = "julio@email.com"},
};

Livro catalogo = new Livro();
bool logado = false;
//enquanto o usuario nao estiver logado faça o que ta nos
while (!logado)
{
    Console.WriteLine($"===Login Bibliotecária===");
    Console.WriteLine($"Email: ");
    string emailInput = Console.ReadLine()!;
    Console.WriteLine($"Senha: ");
    string senhaInput = Console.ReadLine()!;

    if (emailInput == ger.Email && senhaInput == ger.Senha)
    {
        logado = true;
        Console.WriteLine($"Login realizado com sucesso!\n");

    }
    else
    {
        Console.WriteLine($"Não foi possivel efetuar o login.\n");
    }

}
bool sair = false;

while (!sair)
{
    Console.WriteLine($"=== Menu Principal ===");
    Console.WriteLine($"1 - Cadastrar Livro");
    Console.WriteLine($"2 - Remover Livro");
    Console.WriteLine($"3 - Listar Livro");
    Console.WriteLine($"4 - Listar Aluno");
    Console.WriteLine($"0 - Sair");

    Console.Write($"Escolha uma opção: ");
    string opcao = Console.ReadLine()!;

    switch (opcao)
    {
        case "1":
            Livro novoLivro = new Livro();
            Console.WriteLine($"Digite o nome do Livro: ");
            novoLivro.Nome = Console.ReadLine()!;

            Console.WriteLine($"Digite a categoria do Livro: ");
            novoLivro.Categoria = Console.ReadLine()!;

            Console.WriteLine($"Digite a Sinopse do Livro: ");
            novoLivro.Sinopse = Console.ReadLine()!;


            catalogo.CadastrarLivro(novoLivro);
            break;

        case "2":
            if (catalogo.ListaVazia())
            {
                Console.WriteLine($"Nenhum Livro cadastrado.");
                break;
            }
            Console.WriteLine($"Digite o id do Livro para remover");
            int idRemover;
            if (int.TryParse(Console.ReadLine(), out idRemover))// é um método seguro para converter tipos (geralmente string) para outro (como int, double, DateTime) sem lançar exceções se falhar
            {
                catalogo.Removerlivros(idRemover);
            }
            else
            {
                Console.WriteLine($"Id inválido.");
            }
            break;

        case "3":
            catalogo.ListarLivros();
            break;

        case "4":
            Console.WriteLine($"=== Lista de Alunos ===");
            int i = 1;
            foreach (var al in alunos)
            {
                Console.WriteLine($"{i}. Nome: {al.Nome} | Código Curso: {al.CodCurso} | Email: {al.Email}");
                i++;
            }
            Console.WriteLine();
            break;


        case "0":
            sair = true;
            Console.WriteLine($"Saindo do sistema...");

            break;
        default:
            Console.WriteLine($"Opção inválida. Tente novamente.");
            break;


    }

}