#include <iostream>
#include <time.h>
#include<stdio.h>
#include "Header.h"
using namespace std;



int main()
{
	setlocale(LC_ALL,"ukr");	
	system("color 1f");	
	srand(time(0));	
	
	

	Table*t = new Table[10];
	load_from_file(t, 10);

	/*cout << "Пошук по базi даних столiв\n";
	char find_collor[15]; int cnt_of_legs; int price;
	
	cout << "Колiр стола\t";			cin.getline(find_collor, 15);
	cout << "Кiлькiсть нiжок\t";		cin >> cnt_of_legs;
	cout << "До якої суми шукати?\t";	cin >> price;*/
	//Search(t, 10, find_collor[15], cnt_of_legs, price);
	
	Search(t, 10, "yelow", 2, 500);

	

	

	cout << endl;


	
	
	
	system("pause");
return 0;
}
