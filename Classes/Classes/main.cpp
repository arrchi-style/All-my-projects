#include <iostream>
#include "Box.h"
#include "Time.h"
using namespace std;

void main()
{
	Box myBox;
	myBox.init(30, 40, true);
	myBox.show();

	system("pause");
}