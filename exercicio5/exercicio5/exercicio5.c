#include <stdio.h>
#include <string.h>


int main() {

	char fraseInicial[80], fraseInvertida[80];
	int tamanhoFrase;

	printf("Por favor, digite uma frase: ");
	scanf(" %80[^\n]", fraseInicial);
	
	strcpy(fraseInvertida, fraseInicial);
	tamanhoFrase = strlen(fraseInicial);
	for (int i = 0, j = tamanhoFrase - 1; i < tamanhoFrase; i++) {
		fraseInvertida[i] = fraseInicial[j - i];
	}
	printf("%s\n", fraseInvertida);

	return 0;
}