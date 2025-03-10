using System;
using System.Globalization;

namespace ExerciciosProposto05 {
    class URI {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            double[] altura = new double[n];
            char[] sexo = new char[n];

            for(int i = 0; i < n; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(vet[0],CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(vet[1]);
            }

            // Para pegar o menor valor a variavel de atribuição tem que estar com igualdade ao vetor da posicao do valor
            double menorAltura = altura[0];

            //Menor Altura
            for(int i = 0; i < n; i++) {
                if(altura[i] < menorAltura) {
                    menorAltura = altura[i];
                }
            }
            Console.WriteLine("Menor altura = " + menorAltura.ToString("F2",CultureInfo.InvariantCulture));

            // Para pegar o menor valor a variavel de atribuição tem que estar com igualdade ao vetor da posicao do valor
            double maiorAltura = altura[0];

            //Maior Altura
            for(int i = 0; i < n; i++) {
                if(altura[i] > maiorAltura) {
                    maiorAltura = altura[i];
                }
            }
            Console.WriteLine("Maior altura = " + maiorAltura.ToString("F2",CultureInfo.InvariantCulture));

            double somaAlturaMulheres = 0.0;
            int countMulheres = 0;

            //Media das altura das mulheres
            for(int i = 0; i < n; i++) {
                if(sexo[i] == 'F') {
                    somaAlturaMulheres = somaAlturaMulheres + altura[i];
                    countMulheres++;
                }
            }
            if(countMulheres == 0) {
                Console.WriteLine("Não tem nenhuma mulher na lista");
            } else {
                double media = somaAlturaMulheres / countMulheres;
                Console.WriteLine("Media da altura das mulheres = " + media.ToString("F2",CultureInfo.InvariantCulture));
            }

            //Contagem de quantos Homens tem
            int countHomens = 0;

            for(int i = 0; i < n; i++) {
                if(sexo[i] == 'M') {
                    countHomens++;
                }
            }
            Console.WriteLine("Numero de homens = " + countHomens);




        }
    }
}



