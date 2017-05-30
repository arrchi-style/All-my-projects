#include <iostream>
#include "Header.h"
using namespace std;


void InPut(Table &t)
{
	cout << "\tВведiть значення"<<endl;
	cout << "Колiр \t ->";				cin.getline (t.Coulor,15);
	cout << "Ширина \t ->";				cin>>t.width;
	cout << "Висота \t ->";				cin>>t.height;
	cout << "Глибина \t ->";			cin>>t.deep;
	cout << "Кiлькiсть ніжок \t ->";	cin >> t.count;
	cin.get();
	cout << "Назва матерiалу\t ->";		cin.getline(t.material, 20);
	cout << "Цiна \t ->";				cin>>t.price;
	cin.get();

}
void InPut(Table* t, int cnt)
{
	for (int i = 0; i < cnt; i++)
	{
		InPut(t[i]);
		cout<<"\n";
	}
}

void OutPut (const Table &t)
{
	cout << "Колiр \t\t ->";						cout << t.Coulor << "\n";
	cout << "Ширина \t\t ->";						cout << t.width << "\n";
	cout << "Висота \t\t ->";						cout << t.height << "\n";
	cout << "Глибина \t ->";						cout << t.deep << "\n";
	cout << "Кiлькiсть нiжок  ->";					cout << t.count << "\n";
	cout << "Назва матерiалу\t ->";					cout << t.material << "\n";
	cout << "Цiна \t\t ->";							cout << t.price << "\n";
	
}
void OutPut (const Table* t,int cnt)
{
	for(int i = 0; i < cnt; i++)
	{
		cout <<"\tСтiл № "<< i+1<<"\n";
		OutPut(t[i]);
		cout << endl;
	}

}


void save_in_file(const Table* t,int cnt)
{
	FILE *f;
	fopen_s(&f,"J:/Tables/MyTab.txt","ab");
	fwrite(t, sizeof(Table),cnt,f);
	
		fclose(f);
}
void load_from_file(Table* t,int cnt)
{
	FILE*f;
	fopen_s(&f,"J:/Tables/MyTab.txt","rb");
	fread(t, sizeof(Table),cnt,f);
	
	fclose(f);

}

void Find_Price(Table* t, int cnt, int price)
{
	cout << "Пошук по ціні\n";
	for(int i = 0; i < cnt; i++)
	{
		if (t[i].price < price)
		{
			cout << "\tСтiл № " << i + 1 << "\n";
			OutPut(t[i]);
		}
		cout << endl;
	}
}

void Find_count_of_legs(Table* t, int cnt, int count_of_legs)
{
	cout << "\tПошук по кiлькості нiжок\n";
	for (int i = 0; i < cnt; i++)
	{
		if (t[i].count == count_of_legs)
		{
			cout << "\tСтiл № " << i + 1 << "\n";
			OutPut(t[i]);
		}
			cout << endl;
	}
}

void Find_collor(Table* t, int cnt, char collor[15])
{
	for (int i = 0; i < cnt; i++)
	{
		if (strcmp(t[i].Coulor, collor) == 0)
		{
			cout << "\tСтiл № " << i + 1 << "\n";
			OutPut(t[i]);
		}
		cout << endl;
	}
}

void Search(Table* t, int cnt, char find_collor[15], int cnt_of_legs, int price)
{
	for (int i = 0; i < cnt; i++)
	{
		if ((strcmp(t[i].Coulor, find_collor) == 0) && (t[i].count == cnt_of_legs) && (t[i].price <price));
		{
			cout << "\tСтiл № " << i + 1 << "\n";
			OutPut(t[i]);
		}
	}
}

