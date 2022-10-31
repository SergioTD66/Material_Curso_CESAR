namespace BancoDeDados {
    internal class Program {
        static void Main(string[] args) {
            string connectionstring = "Server=DESKTOP-V54ABI1\\SQLEXPRESS;Database=Teste;User Id=sergio;Password=12345;Encrypt=False; TrustServerCertificate=False;";
            Funcionario funcionario = new Funcionario();
            funcionario.ObterLista();
            //funcionario.ExecutarStoreProcedure(connectionstring, 1);
            //funcionario.ExecutarStoreProcedure(connectionstring, 2);
            //funcionario.ExecutarStoreProcedure(connectionstring, 22);
            //funcionario.InserirDados(connectionstring);
        }
    }
}