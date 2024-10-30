public class Validacoes
{

    public bool ValidaCPF(string cpf)
    {
        cpf = cpf.Replace(".", "").Replace("-", "");

        if (cpf.Length != 11)
        {
            Console.WriteLine("CPF INVÁLIDO");
            return false;
        }
        int somaD1 = 0;
        for (int i = 0; i < 9; i++)
        {
            somaD1 += Convert.ToInt32(cpf[i].ToString()) * (10 - i);

        }

        int restoD1 = somaD1 % 11;
        int d1 = 0;
        if (restoD1 < 2)
        {
            d1 = 0;
        }
        d1 = 11 - restoD1;


        int somaD2 = 0;
        for (int i = 0; i < 10; i++)
        {
            somaD2 += Convert.ToInt32(cpf[i].ToString()) * (11 - i);
        }

        int restoD2 = somaD2 % 11;
        int d2 = 0;
        if (restoD2 < 2)
        {
            d2 = 0;
        }
        d2 = 11 - restoD2;

        Console.WriteLine("CPF VÁLIDO");
        return true;
    }
}


