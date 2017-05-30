#pragma once
using namespace std;

class Time
{
private:
	int hour_;
	int minute_;
	int second_;
	

public:
	Time()				//явний конструктор
	{
		hour_ = 8;
		minute_ = 0;
		second_ = 0;
		cout << "Constructor1\n";
	}
	Time(int hour, int min=0, int sec=0)				
	{
		hour_ = hour;
		minute_ = min;
		second_ = sec;
		cout << "Constructor2\n";
	}
	Time(char* stime)
	{
		hour_ = 12;
		
		minute_ = 00;
		
		second_ =00;
		cout << "Constructor3 char*\n";
	}
	
	~Time()
	{
		cout << "Destructor\n";
	}

	//----------------------------
	void setHour(int hour);
	int getHour();

	//-----------------------------
	void setMinute(int minute);
	int getMinute();
	//----------------------------
	void setSecond(int second);
	int getSecond();
	//-----------------------------

	void initTime(int hour, int minute, int second);
	void initTime(char* stime);
	//------------------------------
	
	int timeToSeconds();
	char* timeToStringFormat();

	void addHours(int hours);
	void addMinutes(int minutes);
	void addSeconds(int seconds);
	void subHours(int hours);
	void subMinutes(int minutes);
	void subSeconds(int seconds);

	Time spanTime(const Time & time)const;
	void addTime(const Time& time);
	
	void show();

	

};
