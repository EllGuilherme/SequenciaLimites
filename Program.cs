Console.Clear();
 int numero1, numero2;

     Console.ForegroundColor= ConsoleColor.DarkMagenta;
Console.Write($"INÍCIU: ");
numero1 = Convert.ToInt32(Console.ReadLine()!);
     Console.ResetColor();

    Console.ForegroundColor= ConsoleColor.DarkMagenta;
  Console.Write($"fim: ");
  numero2 = Convert.ToInt32(Console.ReadLine()!);
     Console.ResetColor();

string mensagem = "";

  try 
  {
    if (numero1 < numero2)
      throw new Exception("O segundo número não pode ser menor que o primeiro");
    while (numero1 >= numero2)
 {
        mensagem += $"{numero2++} ";
    }
    exibirMensagemSucesso(mensagem);
}
catch (Exception e)
{
    exibirMensagemErro(e.Message);
}
finally
{
    Console.ResetColor();
    Console.WriteLine();
}

void exibirMensagemErro(string mensagem)

{
   Console.ForegroundColor = ConsoleColor.Red;
   Console.WriteLine(mensagem);
   Console.ResetColor();
}

void exibirMensagemSucesso(string mensagem)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(mensagem);
    Console.ResetColor();
}