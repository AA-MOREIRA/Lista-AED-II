// O programa a seguir estranhamente sempre escreve “A distancia e: 1.0”. Identifique onde está o defeito.

/*
import java.util.Scanner;

public class Distancia {
  public static void main(String[] args) {
    Scanner teclado = new Scanner(System.in);
    double x1, y1, x2, y2, distancia;

    System.out.println("Entre com as coordenadas x e y dos pontos nesta ordem:");
    x1 = teclado.nextFloat();
    y1 = teclado.nextFloat();
    x2 = teclado.nextFloat();
    y2 = teclado.nextFloat();
    distancia = Math.pow(Math.pow(x2-x1, 2) + Math.pow(y2-y1, 2), 1/2);
    System.out.println("A distância é: " + distancia);
  }
}
*/

// O defeito está em duas partes do código. A declaração das variaveis está como double, porém o código está lendo
// como float. O outro problema seria no cálculo da raiz quadrada em Java, nele 1/2 faz a divisão inteira
// 1/2 = 0, o certo seria usar 0.5 nesta parte do código, ficando distancia = Math.pow(Math.pow(x2-x1, 2) + Math.pow(y2-y1, 2), 0.5);
