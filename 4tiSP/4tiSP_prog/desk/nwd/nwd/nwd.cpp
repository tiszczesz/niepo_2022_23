#include <iostream>
#include <algorithm>
#include <numeric>
using namespace std;

int obliczNWDo(int l1, int l2) {
	while(l1 != l2) {
		if (l1 > l2) l1 = l1 - l2;
		else if (l2 > l1) l2 = l2 - l1;
	}
	return l1;
}

int obliczNWD(int l1, int l2) {
	int t;
	while (l2 != 0) {
		t = l2;
		l2 = l1 % l2;
		l1 = t;
	}

	return l1;
}

int main()
{
	int liczba1, liczba2;
	int nwd;

	cout << "Dane wejsciowe" << endl;
	cout << "Podaj 1 liczbe: ";
	cin >> liczba1;
	cout << "Podaj 2 liczbe: ";
	cin >> liczba2;
	//nwd = obliczNWD(liczba1, liczba2);
	nwd = gcd(liczba1, liczba2);
	cout << "Wynik: " << endl;
	cout << "NWD = " << nwd <<endl;
}

