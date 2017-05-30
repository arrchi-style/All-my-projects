#include <iostream>
#include "Point.h"
#include <stdio.h>
#include<stdlib.h>

using namespace std;

double Point::setX(double x)
{
	if (x > 0)
		return x_ = x;
	else
	    return x_ = 1;
};
int Point::getX()
{
	return x_;
};

double Point::setY(double y)
{
	if (y > 0)
		return y_ = y;
	else
		return y_ = 1;
};
int Point::getY()
{
	return y_;
};

void Point::init(double x, double y)
{
	setX(x_);
	setY(y_);
};
int Point::toString(char* stime)
{
	int i;
	 return i = atoi(stime);
};

void Point::show()
{
	cout << x_ <<":"<< y_;
}

double Point::distance(const Point& point)
{
	Point res;
	
	res.x_ = point.x_ - point.y_;
	
	cout <<"distance points "<< res.x_ << endl;;
	return 0;
}

double Point::middlePoint(const Point& point)
{
	Point res;
	res.x_=(point.x_ + point.y_) / 2;
	cout << "middle Point is " << res.x_ << endl;
	return 0;
}