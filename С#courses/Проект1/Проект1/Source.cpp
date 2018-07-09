#include<iostream>
using namespace std;
int main()
{
	short int a = 1, b = -3, c = 12, d = 4, x = -3, y = 0, y2 = 0, y3 = 0;

	for (; x < 0; x++)
	{ 
		y = (d*d+x)*b*c;
		cout << "y1= " <<y << endl;
	}
	if (x == 0)
	{
		y2 = (c + b) / d;
		cout << "y2= "<< y2 << endl;;
		x++;
	}
	for (; x < 4; x++)
	{
		y3 = (x*x)/(a+b);
		cout << "y3= " << y3 << endl;
	}
	system("pause");
	return 0;
}