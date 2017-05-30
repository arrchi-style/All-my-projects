#include <iostream>
#include "Header.h"
using namespace std;


void InPut(Table &t)
{
	cout << "\t����i�� ��������"<<endl;
	cout << "���i� \t ->";				cin.getline (t.Coulor,15);
	cout << "������ \t ->";				cin>>t.width;
	cout << "������ \t ->";				cin>>t.height;
	cout << "������� \t ->";			cin>>t.deep;
	cout << "�i���i��� ���� \t ->";	cin >> t.count;
	cin.get();
	cout << "����� �����i���\t ->";		cin.getline(t.material, 20);
	cout << "�i�� \t ->";				cin>>t.price;
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
	cout << "���i� \t\t ->";						cout << t.Coulor << "\n";
	cout << "������ \t\t ->";						cout << t.width << "\n";
	cout << "������ \t\t ->";						cout << t.height << "\n";
	cout << "������� \t ->";						cout << t.deep << "\n";
	cout << "�i���i��� �i���  ->";					cout << t.count << "\n";
	cout << "����� �����i���\t ->";					cout << t.material << "\n";
	cout << "�i�� \t\t ->";							cout << t.price << "\n";
	
}
void OutPut (const Table* t,int cnt)
{
	for(int i = 0; i < cnt; i++)
	{
		cout <<"\t��i� � "<< i+1<<"\n";
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
	cout << "����� �� ���\n";
	for(int i = 0; i < cnt; i++)
	{
		if (t[i].price < price)
		{
			cout << "\t��i� � " << i + 1 << "\n";
			OutPut(t[i]);
		}
		cout << endl;
	}
}

void Find_count_of_legs(Table* t, int cnt, int count_of_legs)
{
	cout << "\t����� �� �i������ �i���\n";
	for (int i = 0; i < cnt; i++)
	{
		if (t[i].count == count_of_legs)
		{
			cout << "\t��i� � " << i + 1 << "\n";
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
			cout << "\t��i� � " << i + 1 << "\n";
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
			cout << "\t��i� � " << i + 1 << "\n";
			OutPut(t[i]);
		}
	}
}

