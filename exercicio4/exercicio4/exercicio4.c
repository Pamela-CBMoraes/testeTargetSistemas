#include <stdio.h>
int main() {
	double sp = 67836.43, rj = 36678.66, mg = 29229.88, es = 27165.48, outros = 19849.53, total = 0.0, percentSP = 0.0, percentRJ = 0.0, percentMG = 0.0, percentES = 0.0, percentOutros = 0.0;

	total = (sp + rj + mg + es + outros);
	percentSP = (sp / total) * 100;
	percentRJ = (rj / total) * 100;
	percentMG = (mg / total) * 100;
	percentES = (es / total) * 100;
	percentOutros = (outros / total) * 100;
	printf("Percentual de SP: %.2f \n", percentSP);
	printf("Percentual de RJ: %.2f \n", percentRJ);
	printf("Percentual de MG: %.2f \n", percentMG);
	printf("Percentual de ES: %.2f \n", percentES);
	printf("Percentual de Outros: %.2f \n", percentOutros);

	return 0;
}
