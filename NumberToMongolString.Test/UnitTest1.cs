using System;
using Xunit;

namespace NumberToMongolString.Test
{
    public class UnitTest1
    {


        [Fact]
        public void test1()
        {
            Assert.Equal("тавь", NumberConverter.convert(50));            
        }

        [Fact]
        public void test2()
        {
            
            Assert.Equal("нэг мянга хоёр зуун гучин дөрөв", NumberConverter.convert(1234));
        }

        [Fact]
        public void test3()
        {
            
            Assert.Equal("есөн зуун наян долоон мянга", NumberConverter.convert(987000));
        }


        [Fact]
        public void test4()
        {
            
            Assert.Equal("гурван зуун дал", NumberConverter.convert(370));
        }

        [Fact]
        public void test5()
        {
            
            Assert.Equal("хоёр мянга гуч", NumberConverter.convert(2030));
        }

        [Fact]
        public void test6()
        {
            
            Assert.Equal("нэг зуун хорин гурван их наяд дөрвөн зуун тавин зургаан тэрбум долоон зуун наян есөн сая нэг зуун хорин гурван мянга дөрвөн зуун тавин зургаа", NumberConverter.convert(123456789123456));
        }

        [Fact]
        public void test7()
        {
            
            Assert.Equal("хорин мянга", NumberConverter.convert(20000));
        }

        [Fact]
        public void test8()
        {
            
            Assert.Equal("хорин хоёр мянга", NumberConverter.convert(22000));
        }

        [Fact]
        public void test9()
        {
            
            Assert.Equal("хорин мянга хоёр зуу", NumberConverter.convert(20200));
        }

        [Fact]
        public void test10()
        {
            
            Assert.Equal("хорин мянга нэг", NumberConverter.convert(20001));
        }

        [Fact]
        public void test11()
        {
            
            Assert.Equal("хоёр зуун мянга", NumberConverter.convert(200000));
        }

        [Fact]
        public void test12()
        {
            
            Assert.Equal("хоёр сая", NumberConverter.convert(2000000));
        }

        [Fact]
        public void test13()
        {
            
            Assert.Equal("хорин сая", NumberConverter.convert(20000000));
        }

        [Fact]
        public void test14()
        {
            
            Assert.Equal("нэг зуун нэг мянга арав", NumberConverter.convert(101010));
        }

        [Fact]
        public void test15()
        {
            
            Assert.Equal("нэг зуун нэг мянга арван нэг", NumberConverter.convert(101011));
        }

        [Fact]
        public void testMulti()
        {
            
            for (int i = 10000; i < 100000; i++)
            {
                NumberConverter.convert(i);
            }
            Assert.Equal("нэг зуун нэг мянга арван нэг", NumberConverter.convert(101011));
        }

        [Fact]
        public void test16()
        {
            
            Assert.Equal("тэг", NumberConverter.convert(0));
        }
    }
}
