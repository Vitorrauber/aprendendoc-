static int[] Random4Numberdif()
{
    int[] op = new int[4];
    Random rnd = new Random();

    for (int i = 0; i < 10; i++)
    {
        op[0] = rnd.Next(0, 4);
        op[1] = rnd.Next(0, 4);
        op[2] = rnd.Next(0, 4);
        while (op[0] == op[1])
        {
            op[1] = rnd.Next(0, 4);
        }
        while ((op[1] == op[2]) || (op[0] == op[2]))
        {
            op[2] = rnd.Next(0, 4);
        }
        while ((op[1] == op[2]) || (op[0] == op[2]))
        {
            op[2] = rnd.Next(0, 4);

        }
        while ((op[1] == op[3]) || (op[2] == op[3]) || (op[0] == op[3]))
        {
            op[3] = rnd.Next(0, 4);
        }

        //Console.WriteLine("{0} {1} {2} {3} ", op[0], op[1], op[2], op[3]);

    }
    return op;
}
static int conta(int num1, int num2, int op)
{
    
    int result;
    Random rnd = new Random();
    

    if (op == 0)
    {
        result = num1 + num2;
    }
    else if (op == 1)
    {
        result = num1 - num2;
    }
    else if (op == 2)
    {
        result = num1 / num2;//0/ NUM2
        while (Convert.ToDouble(num1) % Convert.ToDouble(num2) != 0)
        {
            num1 = rnd.Next(0, 10);
            num2 = rnd.Next(1, 10);//IMPEDIR DIVISÃO POR 0

            result = num1 / num2;
        }
        

    }
    else
    {
        result = num1 * num2;
    }
    Console.WriteLine("Num1: {0}  Num2: {1}", num1, num2);

    return result;
}


int a = 8;

int[] num = new int[a];

Random rnd = new Random();
int pontos = 0;

string jogar = "S";
while(jogar == "S")
{
    Console.WriteLine("\n\n\n\n\n\n");
    for (a = 0; a < 8; a++)
    {
        num[a] = rnd.Next(0, 10);
    }


    int[,] opr = new int[5, 4];

    int[] op = new int[4];

    //gera a matrix com as alternativas de respotas
    for (int m = 0; m < 5; m++)
    {
        op = Random4Numberdif();
        for (int n = 0; n < 4; n++)
        {

            opr[m, n] = op[n];
        }
    }

    int[] eqresposta = new int[4];

    eqresposta = Random4Numberdif();

    //mistura a resposta junto da matrix
    int numeroresposta = rnd.Next(0, 5);
    for (int n = 0; n < 4; n++)
    {
        opr[numeroresposta, n] = eqresposta[n];
    }


    //faz as contas do jogo
    for (a = 0; a < 4; a++)
    {
        Console.WriteLine(conta(num[a], num[a + 1], eqresposta[a]));
    }


    //gera a as letras das alternativas de respotas
    string[] letra = ["A", "B", "C", "D", "E"];


    Console.WriteLine("Bem víndo ao jogo matematico");
    Console.WriteLine("O jogo consiste em acertar quais operações foram feitas");

    Console.WriteLine("Qual é a respota certa? ");

    for (int m = 0; m < 5; m++)
    {
        Console.WriteLine("{0}) {1} {2} {3} {4} ", letra[m], opr[m, 0], opr[m, 1], opr[m, 2], opr[m, 3]);

    }


    Console.Write("Digite a letra da respota");
    string letraDaResposta = Console.ReadLine();


    if (letra[numeroresposta] == letraDaResposta)
    {
        Console.WriteLine("Resposta Correta");
        pontos++;
    }
    else
    {
        Console.WriteLine("Resposta Incorreta");
    }


    Console.WriteLine("Gabarito letra {0}", letra[numeroresposta]);
    Console.Write("Seus pontos são: {0}", pontos);
   

    Console.Write("\n Continuar jogando digite S");
    jogar = Console.ReadLine();
}