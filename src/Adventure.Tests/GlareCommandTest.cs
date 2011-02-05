﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace Adventure.Tests
{
    [TestClass]
    public class GlareCommandTest
    {
        private IConsoleFacade mock;
        private WaveCommand cmd;
        public class MockConsole : IConsoleFacade
        {
            public string WrittenLine { get; set; }

            public void WriteLine(string format, params object[] arg)
            {
                WrittenLine = string.Format(format, arg);
            }

        }

        [TestInitialize]
        public void Before_Each_Test()
        {
            mock = MockRepository.GenerateMock<IConsoleFacade>();
            cmd = new WaveCommand(mock);
        }

        [TestMethod]
        public void IsValid_Should_Return_False_for_Invalid_String()
        {
            // Arrange
            // Already created via TestInitialize

            // Act
            var result = cmd.IsValid("Stupid stuff");
            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void isValid_Should_Return_True_for_Valid_String()
        {
            // Arrange

            // Act
            var result = cmd.IsValid("glare bob");

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Execute_Should_Write_To_Console_Wave_Plus_All_But_First_Word()
        {
            // Arrange

            // Act
            cmd.Execute("glare blah");

            // Assert
            mock.AssertWasCalled(m => m.WriteLine("You fix {0} with a baleful glare.", "blah"));
        }
    }
}