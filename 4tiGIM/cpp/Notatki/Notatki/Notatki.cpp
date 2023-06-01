#include <iostream>
using namespace std;

class Note {
private:
	static int _counter;
	int _id;
protected:
	string _title;
	string _content;
public:
	Note(string title,string content) {
		_counter++;
		_id = _counter;
		_title = title;
		_content = content;
	}
	void Show() {
		cout << "Tytul notatki: " << _title << endl;
		cout << "Tresc notatki: " << _content << endl;
	}
	void Diagnostic() {
		cout << _counter << ";" << _id
			<< ";" << _title << "; " << _content << endl;
	}
};
int Note::_counter = 0;

int main()
{
	Note n1("notatka1 ", "treasc notatki 1");
	Note n2("notatka2 ", "treasc notatki 2");
	n1.Diagnostic();
	n2.Diagnostic();
}

