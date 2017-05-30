#pragma once

class Time
{
private:
	int hour_;
	int minute_;
	bool second_ = false;
	bool open_ = false;

public:

	void setHour(int hour);
	int getHour();

	//-----------------------------
	void setMinute(int minute);
	int getMinute();
	//----------------------------
	void Time::setSecond(int second);
	int Time:: getSecond();
	//-----------------------------


	void setOpen(bool open);
	int getOpen();
	//------------------------------


	void init(int hour, int minute, int second);
	void open();
	void close();
	void show();

	void up();
	void down();

};
