#pragma once


class Box
{
private:
	int width_;
	int height_;
	bool open_ = false;

public:

	void setWidht(int width);
	int getWidth();
	
//-----------------------------
	void setHeight(int height);
	int getHeitght();
//----------------------------
	void setOpen(bool open);
	int getOpen();
//------------------------------


	void init(int width, int height, int open);
	void open();
	void close();
	void show();
};


