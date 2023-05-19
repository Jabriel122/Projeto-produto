namespace Projeto_Produtos
{
    public class Usuario
    {
        // Atributos
        private int Codigo {get; set;}

        public string Nome {get; set;}

        public string Email {get; set;}

        public string Senha {get; set;}

        private DateTime DataCadastro {get; set;}

        // Metodos

        public Usuario()
        {
            Cadastrar();
        }

        public void Cadastrar()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"");
            // Console.WriteLine($"############ CADSTRO ################");
            Console.ResetColor();
            this.Nome = "Gabriel";
            this.Email = "email";
            this.Senha = "123" ;
            this.Codigo = 001;
            this.DataCadastro = DateTime.Now;
        }

        public void NovoCadastro()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"");
            Console.WriteLine($"############ CADSTRO ################");
            Console.ResetColor();

            Console.WriteLine($"Digite o Seu nome:");
            this.Nome = Console.ReadLine();
            
            Console.WriteLine($"Seu email:");
            this.Email = Console.ReadLine();
            
            Console.WriteLine($"Sua senha:");
            this.Senha = Console.ReadLine();
            
            Console.WriteLine($"O código da sua conta:");
            this.Codigo = int.Parse(Console.ReadLine());

            this.DataCadastro = DateTime.Now;

            
            
        }

        public void Deletar()
        {
            this.Nome = "";
            this.Email = "";
            this.Senha = "";
            this.DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
            this.Codigo = 000;
        }


    }
}