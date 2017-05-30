
struct Table
{
	char Coulor[15];
	int width;		//ширина
	int height;		//висота
	int deep;		//глибина
	int count;		//к-ість ніжок
	char material[20];	//матеріали
	int price;			//ціна
};


void InPut(Table &t);
void InPut(Table* t, int cnt);
	void OutPut (const Table &t);
	void OutPut (const Table* t,int cnt);

			void save_in_file(const Table* t,int cnt);
			void load_from_file(Table* t,int cnt);
				
				void Find_Price(Table* t, int cnt, int price);
					void Find_count_of_legs(Table* t, int cnt, int count_of_legs);
						void Find_collor(Table* t, int cnt, char collor[15]);
							void Search(Table* t, int cnt, char find_color[15], int cnt_of_legs, int price);
