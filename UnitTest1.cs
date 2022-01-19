using System;
using Xunit;

namespace RownanieKwadratowe1.Testy
{
    public class RownanieKwadratoweTesty
    {
        [Theory]
        [InlineData(-2,1,3,25)]
        [InlineData(-3, 0, 4, 48)]
        [InlineData(2, 1, 1, -7)]
        [InlineData(2, 4, 2, 0)]

        public void liczRownanie_SprawdzObliczenia_PorownajWyniki(double a, double b, double c, double wynik)
        {
            //arrange
            RownanieKwadratowe o1 = new RownanieKwadratowe();
            o1.a = a;
            o1.b = b;
            o1.c = c;

            //act

            o1.liczRownanie();
            double wynikDelty=o1.delta;


            //assert

            Assert.Equal(wynikDelty, wynik);
        }


        [Theory]
        [InlineData(-2, 1, 3,1.5,-1)]
        [InlineData(1, 4, 3,3,-1)]
        [InlineData(1, 3, -4, -4,1)]
        [InlineData(-2, 1, 4, 1.69, -1.19)]
        public void liczRownanie_SprawdzanieObliczeñDlaDeltyDodatniej_PorownynieWynikow(double a, double b, double c, double wynik1, double wynik2)
        {
            //arange
            RownanieKwadratowe o2 = new RownanieKwadratowe();

            //act
            o2.liczRownanie();
            wynik1 = o2.x1;
            wynik2 = o2.x2;

            //assert
            Assert.Equal(wynik1, o2.x1);
            Assert.Equal(wynik2, o2.x2);

        }


        [Theory]
        [InlineData(1, 2, 1, -1)]
        [InlineData(3, -6, 3, 1)]
        [InlineData(1, -4, 4, 2)]
        public void liczRownanie_SprawdzanieObliczeñDlaDeltyZerowej_PorownynieWynikow(double a, double b, double c, double wynik)
        {
            //arange
            RownanieKwadratowe o3 = new RownanieKwadratowe();

            //act
            o3.liczRownanie();
            wynik = o3.x1;

            //assert
            Assert.Equal(wynik, o3.x1);

        }

        
        [Theory]
        [InlineData(2, 2, 3)]
        [InlineData(3, 4, 5)]
        [InlineData(5, 4, 4)]
        public void liczRownanie_SprawdzanieObliczeñDlaDeltyUjemnej_PorownynieWynikow(double a, double b, double c)
        {
            //arange
            RownanieKwadratowe o4 = new RownanieKwadratowe();

            //act
            o4.liczRownanie();
            bool zmienna = double.IsNaN(o4.x1);          // zmienna pomocnicza do przechowywania wartoœci warunku

            //assert

            Assert.True(zmienna);                      
            Assert.Equal(0, o4.x2);                    




        }
    }
}