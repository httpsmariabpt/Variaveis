// string para armazenar texto
// Atalho de comentário: ctrl + K + C
string nome = "Maria Fernanda Baptista";

//tipo de variavel para valores inteiros: 1, 2, e etc
int idade = 17;

// tipo de variável para valores decimais: 1.5, 2.5, e etc
float altura = 1.63f; // (float) não utilizado em instituições ficanceiras ou algo mt preciso
double preco = 17.5;
decimal saldo = 1000.50m;

//tipo de variavel para valores lógicos: true ou false
bool estudante = true;

// tipo de variável para valores únicos: 'A', 'B' e etc
char genero = 'M';

// tipo de variavel para valores constantes: PI = 3.14
const double pi = 3.14; 

//Forma 1
Console.WriteLine(nome);

//Forma 2 - Interpolação de strings
Console.WriteLine($"O {nome} tem {idade} anos");

//Forma 3 - Concatenação de strings
Console.WriteLine("A " + nome + " tem " + idade + " anos");

// utilizando \n para pular uma linha 
// Semelhante ao <br> do HTML que já utilizamos
Console.WriteLine($"\n O valor de pi é: {pi}");

