#include <iostream>
using namespace std;

template<class T>
class Oceny {
public:
	T wyklad, cwiczenia, laboratorium, seminarium;

	T srednia() {
		return (wyklad + cwiczenia + laboratorium + seminarium) / 4;
	}
    
};

template<>
class Oceny<double> {
public:
	double wyklad, cwiczenia, laboratorium, seminarium;

	double srednia() {
		return (round(wyklad) + round(cwiczenia) + round(laboratorium) + round(seminarium)) / 4;
	}
};



int main()
{
	Oceny<double> oceny2;
	oceny2.wyklad = 3.0;
	oceny2.cwiczenia = 4.0;
	oceny2.laboratorium = 3.0;
	oceny2.seminarium = 4.0;
	cout << "Srednia ocen semestralnych: " << oceny2.srednia() << endl;
}

