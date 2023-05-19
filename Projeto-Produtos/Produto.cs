namespace Projeto_Produtos
{
    public class Produto
    {
        //    Atributos

        public int codigo { get; set; }

        public string NomeProduto { get; set; }

        public float Preco { get; set; }

        public DateTime DataCadastro { get; set; }

        Usuario usuario = new Usuario();

        public Marca Marca = new Marca();

        public string CadastradoPor { get; set; }

        public List<Produto> ListaDeProdutos = new List<Produto>();
        // Login l1 = new Login(ListaDeProdutos);


        // Metodos

        public void Cadastrar()
        {
            //aqui vai a lógica
            //instanciar o objeto
            //receber os dados e cadastrar nesse objeto
            //armazenar o objeto na lista

            Produto adcionado = new Produto();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"");
            Console.WriteLine($"############ CADASTRE O PRODUTO ################");
            Console.ResetColor();

            Console.WriteLine($"Insira o código:");
            adcionado.codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Nome do Produto:");
            adcionado.NomeProduto = Console.ReadLine();

            Console.WriteLine($"Seu preço:");
            adcionado.Preco = float.Parse(Console.ReadLine());

            adcionado.DataCadastro = DateTime.Now;

            adcionado.CadastradoPor = usuario.Nome;
            adcionado.Marca = Marca.Cadastrar();

            ListaDeProdutos.Add(adcionado);

        }

        public void Listar()
        {
                
            foreach (var p in ListaDeProdutos)
            {
                Console.WriteLine($"");
                Console.WriteLine(@$" 
                    =================================================
                    - Código: {p.codigo} 
                    - Nome do Produto: {p.NomeProduto} 
                    - Preço: {p.Preco:C} 
                    - Dia que foi cadastrada: {p.DataCadastro} 
                    - Cadastrado por: {p.CadastradoPor}
                    - Marca por: {p.Marca.nomeMarca}
                    =================================================
                    ");
                Console.WriteLine($"");
            }

        }


        public void Deletar(int codigo)
        {
            //aqui vai a lógica
            //buscar um objeto na lista pelo seu código
            //remove-lo

            Produto achado = new Produto();
            achado = ListaDeProdutos.Find(codigoProduto => codigoProduto.codigo == codigo)!;
            ListaDeProdutos.Remove(achado);

        }
    }
}