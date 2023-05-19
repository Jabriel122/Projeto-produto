namespace Projeto_Produtos
{
    public class Marca
    {
        // Atributos
        public int Codigo { get; set; }

        public string nomeMarca { get; set; }

        public DateTime DataCadastro { get; set; }

        public List<Marca> ListaDeMarca = new List<Marca>();


        // Metodos

        public Marca Cadastrar()
        {
              Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"");
            Console.WriteLine($"############ CADASTRE A MARCA ################");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Informe o código:");
            int codigo = int.Parse(Console.ReadLine());
            Console.ResetColor();

            Marca novaMarca = new Marca();
            novaMarca = ListaDeMarca.Find(x => x.Codigo == codigo);

            if (novaMarca == null)
            {
                novaMarca = new Marca();
                novaMarca.Codigo = codigo;

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"Informar a marca:");
                novaMarca.nomeMarca = Console.ReadLine();

                novaMarca.DataCadastro = DateTime.Now;

                ListaDeMarca.Add(novaMarca);
                
                Console.ResetColor();
                return novaMarca;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Marca já cadastrada!");
                return novaMarca;
                Console.ResetColor();
            }
            return new Marca();


        }

        public void Deletar()
        {
            Marca sarching = new Marca();

            sarching = ListaDeMarca.Find(codigoMarca => codigoMarca.Codigo == Codigo)!;
            ListaDeMarca.Remove(sarching);
        }

        public void Listar()
        {
            foreach (var p in ListaDeMarca)
            {      
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(@$"
                - Código: {p.Codigo} 
                - Nome da Marca: {p.nomeMarca} 
                - Data Cadastrada: {p.DataCadastro}
                ");
                 Console.ResetColor();

            }
        }

    }
}