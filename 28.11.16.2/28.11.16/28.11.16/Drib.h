#pragma once
using namespace std;

class Drib
{
private:
	int chyselnyk_;
	int znamenyk_;
	int full_num_;

public:
	
	Drib(int full_num=10, int chyselnyk=1, int znamenyk=2)
	{
		full_num_ = full_num;
		chyselnyk_ = chyselnyk;
		znamenyk_ = znamenyk;
	}
	/*Drib(int full_num=10, int chyselnyk=1, int znamenyk)
	{
		full_num_ = full_num;
		chyselnyk_ = chyselnyk;
		znamenyk_ = znamenyk;
	}*/

	~Drib()
	{
		cout << "Destructor\n";
	}

	void setChyselnyk(int chyselnyk);
	int getChselnyk();
	//--------------------------------
	void setZnamenyk(int znamenyk);
	int getZamenyk();
	//--------------------------------
	void setFull_num(int chyselnyk);
	int getFull_num();
	//--------------------------------

	void initTime(int chyselnyk, int znamenyk, int full_num);
	char* ToStringFormat();
	void if_Drib_true(const Drib& drib)const;
	void transfer_to_wrong_shot( Drib& dribe);

};
