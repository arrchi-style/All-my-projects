#include <iostream>
#include "Time.h"
#include <stdio.h>
#include<stdlib.h>


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


void Time::initTime(int hour, int minute, int second)
{
	setHour(hour);
	setMinute(minute);
	setSecond(second);
	
};
void Time::initTime(char* stime)
{
	hour_ = atoi(stime);
	stime[0] = stime[3];
	stime[1] = stime[4];
	minute_ = atoi(stime);
	stime[0] = stime[6];
	stime[1] = stime[7];
	second_ = atoi(stime);
}
//--------------------------------------------------
int	Time::timeToSeconds()
{
	int allSecond = second_, d;
	d = hour_ * 60;
	d += minute_;
	allSecond += d * 60;
	return allSecond;
}

char* Time::timeToStringFormat()
{
	char Times[50] = { "\0" }, buff[15] = { "\0" };
	_itoa_s(hour_, buff, 10);
	strcat_s(Times, buff);
	strcat_s(Times, ":");
	
	_itoa_s(minute_, buff, 10);
	strcat_s(Times, buff);
	strcat_s(Times, ":");
	
	_itoa_s(second_, buff, 10);
	strcat_s(Times, buff);
	cout << Times << endl;
	return 0;
}

//--------------------------------------------------

void Time::addHours(int hours)
{
	if (hour_ + hours > 0)
		hour_ += hours;
	else
		hour_ = hour_;
}
void Time::addMinutes(int minutes)
{
	if (minute_ + minutes > 0)
		minute_ += minutes;
	else
		minute_ = minute_;
};
void Time::addSeconds(int seconds)
{
	if (second_ + seconds > 0)
		second_ += seconds;
	else
		second_ = second_;
};

void Time::subHours(int hours)
{
	if (hour_ + hours > 0)
		hour_ -= hours;
	else
		hour_ = hour_;
};
void Time::subMinutes(int minutes)
{
	if (minute_ + minutes > 0)
		minute_ -= minute_;
	else
		minute_ = minute_;
};
void Time::subSeconds(int seconds)
{
	if (second_ + seconds > 0)
		second_ -= seconds;
	else
		second_ = second_;
	
};

 Time Time::spanTime(const Time & time)const
{
	Time res;
	res.hour_ = hour_ - time.hour_;
	res.minute_ = minute_ - time.minute_;
	res.second_ = second_ - time.second_;
	return res;
		
};

 /*void Time::addTime(const Time& time)
 {
	 time.addHours();
 };*/                              //як час додавати якщо обєкт константний?


void Time::show()
{
	cout << hour_ <<":"<< minute_ << ":" << second_;
}
	

