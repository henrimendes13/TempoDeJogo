/*Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, 
 sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração 
mínima de 1 hora e máxima de 24 horas.*/

int inicio, fim, tempodejogo;

inicio = int.Parse(Console.ReadLine());
fim = int.Parse(Console.ReadLine());
tempodejogo = fim-inicio;

if(tempodejogo == 0)
{
    tempodejogo = 24;
}

else if(tempodejogo < 0)
{
    tempodejogo = tempodejogo+24;
}

Console.WriteLine($"O JOGO DUROU {tempodejogo} HORA(S)");