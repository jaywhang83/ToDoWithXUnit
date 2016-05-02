using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using ToDoList.Controllers;
using ToDoList.Models;
using Xunit;
using System;

namespace ToDoList.Tests
{
    public class ItemsControllerTest
    {

        [Fact]
        public void Post_MethodAddsItem_Test()
        {
            //Arrange
            ItemsController controller = new ItemsController();
            Item testItem = new Item();
            testItem.Description = "test item";
            testItem.CategoryId = 1;

            // Act
            controller.Create(testItem);
            ViewResult indexView = new ItemsController().Index() as ViewResult;
            var collection = indexView.ViewData.Model as IEnumerable<Item>;

            //Assert
            Assert.Contains<Item>(testItem, collection);
        }
    }
}