//﻿
//#include<iostream>
//#include<cstdlib>
//#include<time.h>
//
//
//using namespace std;
//
//
//class Tablica
//{
//public:
//	int wybrana, w, wiel;
//
//	int* tablica = new int[wiel];
//
//
//	void Wypelnij()
//	{
//		cin >> wiel;
//		srand(time(nullptr));
//		for (int i = 0; i < wiel; i++)
//		{
//			tablica[i] = rand() % 100 + 1;
//			cout << i + 1 << "=" << tablica[i];
//		}
//	}
//};
//
//class Wybieranie : public Tablica
//{
//public:
//	void Wybrana()
//	{
//		cout << "Podaj element, ktory nalezy znalezc: ";
//		cin >> wybrana;
//		tablica[wiel] = wybrana;
//		w = 0;
//		while (tablica[w] != wybrana)
//			w++;
//		if (w == wiel)
//
//			cout << "Nie znaleziono szukanej wartosci\n";
//
//		else
//
//			cout << "Szukana wartosc znajduje sie na pozycji " << w + 1 << endl;
//		delete[]	tablica;
//	}
//};
//
//int main()
//{
//	Tablica z1;
//	z1.Wypelnij();
//	Wybieranie z2;
//	z2.Wybrana();
//	return 0;
//}

#include<iostream>
#include<cstdlib>
#include<ctime>

using namespace std;

class Tablica
{
public:
	int wybrana, w, wiel;

	int* tablica;

	Tablica(int rozmiar)
	{
		wiel = rozmiar;
	}
	void Wypelnij()
	{
		
		tablica = new int[wiel+1];
		srand(time(nullptr));
		for (int i = 0; i < wiel; i++)
		{
			tablica[i] = rand() % 100 + 1;
			
		}
	}
	void wyswietl()
	{
		for (int i = 0; i < wiel; i++)
		{
			
			cout <<  tablica[i] ;
			if(i<(wiel-1)) cout << ',';
		}
		cout << endl;
	}
	void Wyszukaj(int szukana)
	{
		int licznik = 0;
		tablica[wiel] = szukana;
		while(tablica[licznik]!=szukana)
		{			
			licznik++;	
		}
		wyswietl();
		if(licznik<wiel-1) {
			cout << "znaleziono liczbe: " << szukana << " na miejscu: " << licznik << endl;
		}else {
			cout << "nie znaleziono!!" << endl;
		}
		
	}
	~Tablica()

	{
		delete[] tablica;
		tablica = nullptr;
	}
};


int main()
{
	int rozmiar;
	cout << "Podaj rozmiar tablicy: ";
	cin >> rozmiar;
	Tablica t1(rozmiar);
	t1.Wypelnij();
	t1.wyswietl();
	cout << "Podaj szukana liczbe: ";
	int szukana;
	cin >> szukana;
	t1.Wyszukaj(szukana);
}
