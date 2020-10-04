using System;
using Xunit;
using BootCamp.Chapter.Models;
using BootCamp.Chapter.Exceptions;
using BootCamp.Chapter.Tests.Public;
using Moq;

namespace BootCamp.Chapter.Tests
{
    public class CityTest
    {
        [Theory]
        [InlineData( 1, -1)]
        [InlineData(1, 51)]
        public void City_Given_BadBuildings_Throws_BuildingException(int citySize, int buildingHeight)
        {
            int[][] buildings = Builders.BuildBuildingsArray(citySize, buildingHeight);
            City city;

            Action action = () => city = new City(buildings);

            Assert.Throws<BuildingException>(action);
        }

        [Fact]
        public void GetMaxCityRise_Given_City_Returns_CorrectMaxCityRise()//int offPlace, int Expected, int citySize, int buildingHeight, int offNumber
        {
            //Arrange
            int[][] buildings = new int[][] 
            {
                new int[] { 3, 0, 8, 4 },
                new int[] {2, 4, 5, 7 },
                new int[] {9, 2, 6, 3 },
                new int[] {0, 3, 1, 0 } 
            };
            City city = new City(buildings);

            //Act
            int maxCityRise = MaxCityRise.GetMaxCityRise(city);

            //Assert
            Assert.Equal(35, maxCityRise);
        }
    }
}
