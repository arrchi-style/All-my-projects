#pragma once
using namespace std;

class Point
{
public: 
	Point()
	{
		x_ = 0;
		y_ ;  //?????
		cout << "Constructor1 Point\n";
	}
	Point(double x, double y)
	{
		x_ = x;
		y_ = y;
		cout << "Constructor2 \n";
	}
	~Point()
	{
		cout << "Destructor\n";
	}
		double setX(double);
		int getX();
		double setY(double);
		int getY();

		void init(double , double );
		int toString(char* );
		void show();

		double distance(const Point& point);
		void offset(const Point& point);
		double middlePoint(const Point& point);

private: 
	double x_;
	double y_;
};
