#include <iostream>
#include "Box.h"
using namespace std; 


void Box::setWidht(int width)
{
	if (width > 0)
		width_ = width;
	else
		width_ = 1;
}

int Box::getWidth()
{
	return width_;
}

//-----------------------------------------

void Box::setHeight(int height)
{
	if (height > 0)
		height_ = height;
	else height_ = 1;
}
int Box::getHeitght()
{
	return height_;
}

//----------------------------------------

void Box::setOpen(bool open)
{
		open_ = open;
}
int Box::getOpen()
{
	return open_;
}

//----------------------------------------

void Box::init(int width, int height, int open)
{
	setWidht(width);
	setHeight(height);
	open_ = open;
};
void Box::open()
{
	open_ = true;
}
void Box::close()
{
	open_ = false;
}
void Box::show()
{
	cout << width_ << height_ << open_;
}