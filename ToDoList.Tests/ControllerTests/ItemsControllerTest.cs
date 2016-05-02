using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using ToDoList.Controllers;
using ToDoList.Models;
using Xunit;

namespace ToDoList.Tests
{
    public class ItemsControllerTest
    {
        [Fact]
        public void Get_ViewRestult_Index_Test()
        {
            //Arrange
            ViewResult indexView = new ItemsController().Index() as ViewResult;


            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsType<List<Item>>(result); 
        }
    }
}