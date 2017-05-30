#include <iostream>
#include "Drib.h"
#include <stdio.h>
#include<stdlib.h>
using namespace std;


void Drib::setChyselnyk(int chyselnyk)
{
	if (chyselnyk > 0)
		chyselnyk_ = chyselnyk;
	else
		chyselnyk_ = 1;
};
int Drib::getChselnyk()
{
	return chyselnyk_;
};
//--------------------------------
void Drib::setZnamenyk(int znamenyk)
{
	if (znamenyk > 0)
		znamenyk_ = znamenyk;
	else
		znamenyk_ = 1;
};
int Drib::getZamenyk()
{
	return znamenyk_;
};
//--------------------------------
void Drib::setFull_num(int full_num)
{
	if (full_num > 0)
		full_num_ = full_num;
	else
		full_num_ = 1;
};
int Drib::getFull_num()
{
	return full_num_;
};
//--------------------------------

void Drib::initTime(int chyselnyk, int znamenyk, int full_num)
{
	setChyselnyk(chyselnyk);
	setZnamenyk(znamenyk);
	setFull_num(full_num);
}
char* Drib::ToStringFormat()
{
	char drib[50] = { "\0" }, buff[15] = { "\0" };
	_itoa_s(chyselnyk_, buff, 10);
	strcat_s(drib, "'");
	strcat_s(drib, buff);
	strcat_s(drib, "/");

	_itoa_s(znamenyk_, buff, 10);
	strcat_s(drib, buff);
	strcat_s(drib, "'");
	cout << drib << endl;
	return 0;
}
void Drib::if_Drib_true(const Drib& drib)const
{
	if (drib.chyselnyk_ < drib.znamenyk_)
		cout << "drib is true\n";
	else
		cout << "Drib is FALSE\n";
};
void Drib::transfer_to_wrong_shot( Drib& dribe)
{
	float res;
	res=((dribe.full_num_*dribe.znamenyk_)+dribe.chyselnyk_);
	cout << res<<"/"<<dribe.znamenyk_;
};