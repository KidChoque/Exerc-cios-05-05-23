using Ex_1;

Elevador elevador = new Elevador();

elevador.ActualFL = 0;

elevador.CapacityPeople = 8;

elevador.Passengers = 7;

elevador.NumberOfFL = 5;




Console.WriteLine($"Seja bem vindo ao nosso elevator");
Console.WriteLine($"Welcome to our elevator");

elevador.Inicialize(elevador.CapacityPeople, elevador.NumberOfFL);

Console.WriteLine($"Escolha uma opção do menu");
char resposta = char.Parse(Console.ReadLine());
;
Console.WriteLine($"Menu");
Console.WriteLine($"1-Entrar");
Console.WriteLine($"2-Subir");
Console.WriteLine($"3-Descer");
Console.WriteLine($"4-Descer");
Console.WriteLine($"5-Sair");

while(resposta != 0)
{

Console.WriteLine($"Escolha uma opção do menu");

resposta = char.Parse(Console.ReadLine());
}




switch (resposta)
{
    case '1': elevador.Entrar(elevador.CapacityPeople, elevador.Passengers);
        break;
        case '2':
    default:
        break;
}


if (resposta == '1')
{
    elevador.Entrar(elevador.CapacityPeople, elevador.Passengers);
}
else
{
    Console.WriteLine($"Okay");
    
}








// Console.WriteLine($"O número de passageiros é {elevador.Passengers}");


// Console.WriteLine($"");


// Console.WriteLine($"Deja entrar no elevador ? s-Sim ou n-Não");

// }

// Console.WriteLine($"Deseja sair do elevador? s-Sim ou n-Não ? ");
// resposta = char.Parse(Console.ReadLine());

// if (resposta == 's')
// {
//     elevador.Sair(elevador.Passengers);
// }
// else
// {
//     Console.WriteLine($"Okay, passageiros = {elevador.Passengers}");

// }



