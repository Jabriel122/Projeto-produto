namespace Projeto_Produtos
{
    public class Login
    {
        // Atributos
        private bool Logado { get; set; }

        // Metedos

        public Login()
        {
            Usuario user = new Usuario();

            Logar(user);
            if (Logado)
            {
                GerarMenu();
            }

        }

        public void Logar(Usuario Usuario)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"");
            Console.WriteLine($"############ LOGIN ################");
            Console.ResetColor();

            Console.WriteLine($"Informe seu email:");
            string email = Console.ReadLine();

            Console.WriteLine($"Informe sua senha:");
            string senha = Console.ReadLine();

            if (email == Usuario.Email && senha == Usuario.Senha)
            {
                this.Logado = true;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Login efetuado com sucesso!");
                Console.ResetColor();

            }
            else
            {
                // Arrumar esse código e fazer ele funcionar
                
                Console.WriteLine($"Falha ao logar.");
                Console.WriteLine($"Possui Cadastro?");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"S -(Sim)");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"N -(Não)");
                Console.ResetColor();

                string YesOrNo;

                YesOrNo = Console.ReadLine().ToLower();

                if (YesOrNo == "s")
                {
                    do
                    {
                        Console.WriteLine($"Informe seu email:");
                        email = Console.ReadLine();

                        Console.WriteLine($"Informe sua senha:");
                        senha = Console.ReadLine();
                    }
                    while (email != Usuario.Email || senha != Usuario.Senha);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Login efetuado com sucesso!");
                    Console.ResetColor();

                    GerarMenu();
                }

                else if (YesOrNo == "n")
                {
                    Usuario.Cadastrar();
                }




            }
        }

        public void Deslogar()
        {
            Logado = false;
        }

        public void GerarMenu()
        {
            Produto produto = new Produto();
            Marca marca = new Marca();
            ConsoleKeyInfo Opcao;
            string SimOuNão;

            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"################################");
                Console.WriteLine($"#   [1] - Cadastrar Produto    #");
                Console.WriteLine($"#   [2] - Listar Produto       #");
                Console.WriteLine($"#   [3] - Remover Produto      #");
                Console.WriteLine($"# ---------------------------- #");
                Console.WriteLine($"#   [4] - Cadastras Marca      #");
                Console.WriteLine($"#   [5] - Listar Mrca          #");
                Console.WriteLine($"#   [6] - Remover Marca        #");
                Console.WriteLine($"# ---------------------------- #");
                Console.WriteLine($"#   [7] - Deslogar             #");
                Console.WriteLine($"#        [0] - Sair            #");
                Console.WriteLine($"################################");
                Console.ResetColor();
                Opcao = Console.ReadKey(true);

                switch (Opcao.Key)
                {
                    case ConsoleKey.D1:
                        produto.Cadastrar();
                        break;
                    case ConsoleKey.D2:
                    produto.Listar();
                       
                    break;
                    case ConsoleKey.D3:

                    Console.WriteLine($"Informe o código a ser removido");
                    int codigoProduto = int.Parse(Console.ReadLine());

                    produto.Deletar(codigoProduto);

                    break;
                case ConsoleKey.D4:
                    marca.Cadastrar();
                    break;
                case ConsoleKey.D5:
                    marca.Listar();
                    break;
                case ConsoleKey.D6:
                    Console.WriteLine($"Informe o código a ser removido");
                    int codigoMarca = int.Parse(Console.ReadLine());

                    marca.Deletar();

                    break;
                case ConsoleKey.D7:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Deseja entrar em um novo Login?");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"(S) - Sim");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"(N) - Não");
                    Console.ResetColor();
                    SimOuNão = Console.ReadLine().ToUpper();

                    if (SimOuNão == "S")
                    {
                        Usuario cadastro = new Usuario();

                    }
                    else if (SimOuNão == "N")
                    {
                        Logado = false;
                        Login app = new Login();
                        Console.WriteLine($"Tchau!!!");
                        
                    }


                    break;
                case ConsoleKey.D0:
                    Console.WriteLine($"Tchau!!!!");

                    break;
                default:
                    break;
                }

            } while (Opcao.Key != ConsoleKey.D0);

        }
    }
}