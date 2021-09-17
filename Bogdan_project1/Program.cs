using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogdan_project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.1 task");
            double input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Round(input, 2));
            
            Console.WriteLine("1.2 task");
            Console.WriteLine(Math.Round(Math.E, 10));
            
            Console.WriteLine("1.3 task");
            string number = Console.ReadLine();
            Console.WriteLine("вы ввели число:" + number);
            
            Console.WriteLine("1.4 task");
            string number0 = Console.ReadLine();
            Console.WriteLine(number0 + "-вот такое число вы ввели");
            
            Console.WriteLine("1.5 task");
            Console.WriteLine("1 13 49");
            
            Console.WriteLine("1.6 task");
            Console.WriteLine("7  15  100");
            
            Console.WriteLine("1.7 task");
            Random r = new Random();
            Console.WriteLine(r.Next()+"  "+ r.Next() + "  "+r.Next());
            
            Console.WriteLine("1.8 task");
            Console.WriteLine(r.Next() + " " + r.Next() + " " + r.Next()+" "+r.Next());
            
            Console.WriteLine("1.9 task");
            Console.WriteLine("50\n100");
            
            Console.WriteLine("1.10 task");
            Console.WriteLine("5\n10\n21");
            
            Console.WriteLine("1.11 task");
            Console.WriteLine(r.Next()+"\n"+r.Next() + "\n" + r.Next()+"\n"+r.Next());
            
            Console.WriteLine("1.12 task");
            Console.WriteLine("5 10\n7 см");
            
            Console.WriteLine("1.13 task");
            Console.WriteLine("2 ru\n13 17");
            
            Console.WriteLine("-----------------------------------ВЫЧИСЛЕНИЕ ПО ИЗВЕСТНЫМ ФОРМУЛАМ----------------------------------------");
            Console.WriteLine("2.1a task");
            Console.Write("Введите x=");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 7 * x * x + 3 * x + 6;
            Console.WriteLine("Y="+y);
            Console.WriteLine("2.1b task");
            double a = Convert.ToDouble(Console.ReadLine());
            x = 12 * a * a + 7 * a + 12;
            Console.WriteLine("X="+x);

            Console.WriteLine("2.2 task");
            double side =Convert.ToDouble( Console.ReadLine());
            Console.WriteLine(side * side);

            Console.WriteLine("2.3 task");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(radius+radius);

            Console.WriteLine("2.4 task ");
            int R = 6350;
            double hight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Sqrt((R+hight)*(R + hight)-(R*R)));

            Console.WriteLine("2.5 task");
            int edge = int.Parse(Console.ReadLine());
            Console.WriteLine("обьем = " + Math.Pow(edge, 3));
            Console.WriteLine("площадь = "+(6* Math.Pow(edge, 2)));

            Console.WriteLine("2.6 task");
            radius = int.Parse(Console.ReadLine());
            double lengthOFcircle = 2 * Math.PI * radius;
            double square = Math.PI * radius * radius;
            Console.WriteLine("длина = "+ (2 * Math.PI * radius));
            Console.WriteLine("площадь = "+(Math.PI * radius * radius));

            Console.WriteLine("2.7 task");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine((double)(number1 + number2) / 2);
            Console.WriteLine(Math.Sqrt(number1 * number2));

            Console.WriteLine("2.8 task");
            Console.Write("введите обьём : ");
            double V = Convert.ToDouble(Console.ReadLine());
            Console.Write("введите массу : ");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("площадь = "+(double)(m/V));

            Console.WriteLine("2.9 task");
            int PeopleQuantity = int.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());
            Console.WriteLine("плотность населения = "+(double)(PeopleQuantity/ area));

            Console.WriteLine("2.10 task");
            Console.Write("Ввведите коэффициент a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Ввведите коэффициент b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("корень уравнения x = "+(-b/a));

            Console.WriteLine("2.11 task");
            Console.Write("первый катет :");
            a = int.Parse(Console.ReadLine());
            Console.Write("второй катет:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("гепотенуза равна : "+(Math.Sqrt(a*a+b*b)));
            Console.WriteLine("2.12 task");

            int r1 = int.Parse(Console.ReadLine());
            int r2 = int.Parse(Console.ReadLine());
            square = Math.PI * (r1*r1-r2*r2);
            Console.WriteLine("площадь кольца равна"+square);

            Console.WriteLine("2.13 task");
            Console.Write("первый катет :");
            a = int.Parse(Console.ReadLine());
            Console.Write("второй катет:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("периметр равен : " +(a+b+(Math.Sqrt(a * a + b * b))));
            
            Console.WriteLine("2.13a task");
            number1 = Math.Abs(int.Parse(Console.ReadLine()));
            number2 = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine((double)(number1 + number2) / 2);
            Console.WriteLine(Math.Sqrt(number1 * number2));

            Console.WriteLine("2.14 task");
            double AB = double.Parse(Console.ReadLine());
            double CD = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("площадь трапеции :"+(AB+CD+Math.Sqrt((Math.Pow(AB-CD, 2)/4)+h*h)));

            Console.WriteLine("2.14A task");
            int side1 = int.Parse(Console.ReadLine());
            int side2 = int.Parse(Console.ReadLine());
            Console.WriteLine("периметр = "+(side1*2+side2*2)+"\n"+"диагональ = "+(Math.Sqrt(side1*side1+side2*side2)));

            Console.WriteLine("2.15 task");
            a = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            Console.WriteLine((a+b)+"\n"+(a-b)+ "\n" +(a*b)+"\n" + (a/b));

            Console.WriteLine("2.16 task");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("обьём = "+ (a*b*c)+"площадь = "+(2*a*b+2*b*c));

            Console.WriteLine("2.17 task");
            Console.WriteLine("введите x1, y1, x2, y2");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("расстояние равно : "+(Math.Sqrt(Math.Pow(x2-x1, 2)+ Math.Pow(y2 - y1, 2))));

            Console.WriteLine("2.18 task - 2.14 repeat");

            Console.WriteLine("2.19 task");
            Console.Write("введите угол и основания : ");
            double alpha = double.Parse(Console.ReadLine());
            AB = int.Parse(Console.ReadLine());
            CD = int.Parse(Console.ReadLine());
            square = Math.Tan(alpha) * ((AB * AB - CD * CD) / 4);
            Console.WriteLine(square);

            Console.WriteLine("2.20 task");
            Console.WriteLine("введите поочереди x1,y1,x2,y2,x3,y3");
            x1 = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());
            x2 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());
            double lenght1 = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))); 
            double lenght2 = Math.Sqrt((Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2)));
            double lenght3 = Math.Sqrt((Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2)));
            double P = lenght1 + lenght2 + lenght3;
            Console.WriteLine("периметр = "+P);
            square = Math.Sqrt(P/2 * (P/2 - lenght1) * (P/2 - lenght2) * (P/2 - lenght3));
            Console.WriteLine("площадь = "+square);

            Console.WriteLine("2.21 task");
            Console.WriteLine("введите поочереди x1,y1,x2,y2,x3,y3,x4,y4");
            x1 = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());
            x2 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
            x3 = int.Parse(Console.ReadLine());
            y3 = int.Parse(Console.ReadLine());
            int x4 = int.Parse(Console.ReadLine());
            int y4 = int.Parse(Console.ReadLine());
            lenght1 = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            lenght2 = Math.Sqrt((Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2)));
            lenght3 = Math.Sqrt((Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2)));
            double lenght4 = Math.Sqrt((Math.Pow(x4 - x1, 2) + Math.Pow(y4 - y1, 2)));
            double diagonal =Math.Sqrt((Math.Pow(x4 - x2, 2) + Math.Pow(y4 - y2, 2)));
            double perimetr1 = lenght1 + lenght4 + diagonal;
            double perimetr2 = lenght2 + lenght3 + diagonal;
            double square1 = Math.Sqrt(perimetr1 / 2 * (perimetr1 / 2 - lenght1) * (perimetr1 / 2 - lenght4) * (perimetr1 / 2 - diagonal));
            double square2 = Math.Sqrt(perimetr2 / 2 * (perimetr2 / 2 - lenght1) * (perimetr2 / 2 - lenght2) * (perimetr2 / 2 - diagonal));
            square = square1 + square2;
            Console.WriteLine(square);

            Console.WriteLine("2.22 task");
            Console.Write("WEIGHT OF APPLES=");
            double weightOfApple = double.Parse(Console.ReadLine());
            Console.Write("PRICE OF APPLES=");
            double priceOfApples = double.Parse(Console.ReadLine());
            Console.Write("WEIGHT OF COOKIES=");
            double weightOfCookies = double.Parse(Console.ReadLine());
            Console.Write("PRICE OF COOKIES=");
            double priceOfCookies = double.Parse(Console.ReadLine());
            Console.Write("WEIGHT OF Candles=");
            double weightOfCandles = double.Parse(Console.ReadLine());
            Console.Write("PRICE OF CANDLES=");
            double priceOfCandles = double.Parse(Console.ReadLine());
            Console.WriteLine("full price = "+ (weightOfApple*priceOfApples+weightOfCookies*priceOfCookies+weightOfCandles*priceOfCandles)+"гривен");

            Console.WriteLine("2.23 task");
            Console.Write("Monitor price : ");
            double priceOfMonitor = double.Parse(Console.ReadLine());
            Console.Write("PC price : ");
            double priceOfPC = double.Parse(Console.ReadLine());
            Console.Write("Keyboard price : ");
            double priceOfkeyboard = double.Parse(Console.ReadLine());
            Console.Write("Mouse price : ");
            double priceOfMouse = double.Parse(Console.ReadLine());
            double priceOf3packs = 3 * (priceOfMonitor + priceOfPC + priceOfkeyboard + priceOfMouse);
            Console.WriteLine("Price of 3 full packs : "+ priceOf3packs);
            Console.Write("input count of packs : ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Price of "+N+" full packs : "+N*(priceOfMonitor + priceOfPC + priceOfkeyboard + priceOfMouse));

            Console.WriteLine("2.24 task");
            Console.WriteLine("Тане:");
            int Tanya = int.Parse(Console.ReadLine());
            Console.WriteLine("Мите");
            int Mitya = int.Parse(Console.ReadLine());
            double avarageAge = Convert.ToDouble((Tanya + Mitya) / 2);
            Console.WriteLine("Средний возраст детей :"+ avarageAge);

            if (Tanya> avarageAge)
            {
                Console.WriteLine("Таня старше среднего возраста на"+(Tanya-avarageAge));
            }
           if(Tanya == avarageAge)
            {
                Console.WriteLine("Дети одного возраста");
            }
            else
            {
                Console.WriteLine("Таня старше среднего возраста на" + (avarageAge - Tanya));
            }
            if (Mitya > avarageAge)
            {
                Console.WriteLine("Митя старше среднего возраста на" + (Mitya - avarageAge));
            }
            if (Mitya == avarageAge)
            {
                Console.WriteLine("Дети одного возраста");
            }
            if(Mitya < avarageAge)
            {
                Console.WriteLine("Митя старше среднего возраста на" + (avarageAge - Mitya));
            }

            Console.WriteLine("2.25 task");
            Console.WriteLine("1speed : ");
            int v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2 speed : ");
            int v2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Distance : ");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine((double)s/(v1+v2));

            Console.WriteLine("2.26 task");
            Console.WriteLine("1speed : ");
            v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2 speed : ");
            v2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Distance : "+(v1-v2)*0.5);

            Console.WriteLine("2.27 task");
            Console.Write("Введите температуру в градусах Цельсия : ");
            double temperature = double.Parse(Console.ReadLine());
            Console.WriteLine("Температура по шкале Фаренгейта равна : "+ (temperature*1.8+32));
            Console.WriteLine("Температура по шкале кельвина равна : "+(temperature-273));

            Console.WriteLine("2.28 task");
            temperature = (450 - 32) / 1.8;
            Console.WriteLine("450 градусов по Фарингейту равны"+temperature);



            Console.WriteLine("****************************************************TASK 3*******************************************************");


            Console.WriteLine("3.1 task");
            a = 5;
            b= 100;
            c = (int)a;
            a = b;
            b = c;

            Console.WriteLine("3.2(a) task");
            a = 5;
            b = 25;
            c = 30;
            int d = (int)a;
            a = b;
            b = c;
            c = d;
            
            Console.WriteLine("3.2(b) task");
            d = b;
            b = (int)a;
            c = d;
            a = c;

            Console.WriteLine("3.3a task");
            Console.Write("Input a : ");
            a = int.Parse(Console.ReadLine());
            double a2 = a * a;
            double a4 = a2 * a2;
            Console.WriteLine("a4 = " + a4) ;

            Console.WriteLine("3.3b");
            double a3 = a * a * a;
            double a6 = a3 * a3;
            Console.WriteLine("a6 = "+a6);
            
            Console.WriteLine("3.3c");
            a3 = a * a * a;
            a6 = a3 * a3;
            double a7 = a * a6;
            Console.WriteLine("a7 = "+a7);
            
            Console.WriteLine("3.3d ");
            a2 = a * a;
            a4 = a2 * a2;
            double a8 = a4 * a4;
            Console.WriteLine("a8 = "+a8);

            Console.WriteLine("3.3e");
            a2 = a * a;
            a4 = a2 * a2;
            a8 = a4 * a4;
            double a9 = a8 * a;
            Console.WriteLine("a9 = " + a9);

            Console.WriteLine("3.3f");
            a2 = a * a;
            a4 = a2 * a2;
            double a5 = a4 * a;
            double a10 = a5 * a5;
            Console.WriteLine("a10 = " + a10);

            Console.WriteLine("task 3.4");
            a = double.Parse(Console.ReadLine());
            
            Console.WriteLine("3.4a");
            a2 = a * a;
            a3 = a2 * a;
            a5 = a2 * a3;
            a10 = a5 * a5;
            Console.WriteLine("a3 = "+a3+"   a10 = "+a10);
            Console.WriteLine("3.4b");
            a2 = a * a;
            a4 = a2 * a2;
            a8 = a4 * a4;
            double a16 = a8 * a8;
            double a20 = a16 * a4;
            Console.WriteLine("a4 = " + a4 + "   a20 = " + a20);

            Console.WriteLine("3.4c");
            a2 = a * a;
            a3 = a2 * a;
            a5 = a3 * a2;
            a10 = a5 * a5;
            double a13 = a10 * a3;
            Console.WriteLine("a5 = "+a5+"  a13 = "+a13);

            Console.WriteLine("3.4d");
            a2 = a * a;
            a4 = a2 * a2;
            a5 = a4 * a;
            double a15 = a5 * a5 * a5;
            double a19 = a15 * a4;
            Console.WriteLine("a5 = "+a5+"  a19"+a19);

            Console.WriteLine("3.4e");
            a2 = a * a;
            a3 = a * a2;
            a5 = a3 * a2;
            a7 = a5 * a2;
            double a17 = a7 * a7 * a3;
            Console.WriteLine("a2 = "+a2+"  a5 ="+a5+"   a17 = "+a17);
            
            Console.WriteLine("3.4f");
            a2 = a * a;
            a4 = a2 * a2;
            a6 = a4 * a2;
            double a12 = a6 * a6;
            double a24 = a12 * a12;
            double a28 = a24 * a4;
            Console.WriteLine("a4 = "+a4+"  a12 = "+a12+"   a28"+a28);

            Console.WriteLine("3.5 task");
            Console.WriteLine("Ща будет разнос");
            int Moyo4islo = 1010;
            Moyo4islo += 1;
            Console.WriteLine(Moyo4islo);

            Console.WriteLine("!!-----------------------наконец-то УРАААААААААААААААААААААА----------------------------!!");
            










        }
    }
}
