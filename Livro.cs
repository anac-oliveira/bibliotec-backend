class Livro
{

    private static int contadorId = 1;
    
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Categoria { get; set; }
    public string? Sinopse { get; set; }

    private List<Livro> livros = new List<Livro>();

    public void CadastrarLivro(Livro livroParaCadastrar) //não retorna nada quando o void esta antes do metodo, ele apenas vai fazer o que tem que fazer
    {
        livroParaCadastrar.Id = contadorId++;//++ é um somador de incremento.
        livros.Add(livroParaCadastrar);
        Console.WriteLine($"livros cadastrado com sucesso! Id:{livroParaCadastrar.Id} | {livroParaCadastrar.Nome} | {livroParaCadastrar.Categoria} | {livroParaCadastrar.Sinopse}");
    }

    public void Removerlivros(int id)
    {
        Livro? livr = livros.Find(l => l.Id == id);
        if (livr != null)
        {
            livros.Remove(livr);
            Console.WriteLine($"livro foi removido com sucesso!\n");// (\n) é uma forma de dizer para clicar no enter

        }
        else
        {
            Console.WriteLine($"livro não encontrado.\n");
        }

    }

    public void ListarLivros()
    {
     Console.WriteLine($"=== Lista de Livros ===");
     if (livros.Count == 0)
     {
        Console.WriteLine($"Nenhum livro cadastrado. \n");
        return;//paro aqui
     }

     foreach (var item in livros)
     {
        Console.WriteLine($"Id:{item.Id} | Nome: {item.Nome} | Categoria: {item.Categoria} | Sinopse:{item.Sinopse} ");
        
     }
        
    }

    public bool ListaVazia()
    {
        return livros.Count == 0; //retorna true or false
    }

}