/*
Determine a saída do seguinte programa:

for (int i = 2; i <= 8; i = i + 2) {       // i = 2, 4, 6, 8
    for (int j = i; j <= 4; j++) {         // j começa em i, vai até 4
        for (int k = 1; k <= j; k = k + i) { // k começa em 1, vai até j, incrementando de i
            System.out.println(i + ", " + j + ", " + k);
        }
    }
}

A saída final seria
2, 2, 1
2, 3, 1
2, 3, 3
2, 4, 1
2, 4, 3
4, 4, 1

O loop externo percorre 2, 4, 6, 8, mas apenas i <= 4 gera saída porque o loop de j vai até 4.
Para cada i e j, k começa em 1 e aumenta de i até passar de j, imprimindo i, j, k.
*/
