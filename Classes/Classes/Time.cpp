#include <iostream>
#include "Time.h"
using namespace std;


void Time::setHour(int hour)
{
	if (hour > 0)
		hour_ = hour;
	else
		hour_ = 1;
}

int Time::getHour()
{
	return hour_;
}

//-----------------------------------------

void Time::setMinute(int minute)
{
	if (minute > 0)
		minute_ = minute;
	else minute_ = 1;
}
int Time::getMinute()
{
	return minute_;
}

//----------------------------------------
void Time::setSecond(int second)
{
	if (second > 0)
		second_ = second;
	else second_ = 1;
}
int Time::getSecond()
{
	return second_;
}

//----------------------------------------

void Time::setOpen(bool open)
{
	open_ = open;
}
int Time::getOpen()
{
	return open_;
}

//----------------------------------------

void Time::init(int hour, int minute, int second)
{
	setHour(hour);
	setMinute(minute);
	open_ = open;
};
void Time::open()
{
	open_ = true;
}
void Time::close()
{
	open_ = false;
}
void Time::show()
{
	cout << hour_ << minute_ << second_<< open_;
}

