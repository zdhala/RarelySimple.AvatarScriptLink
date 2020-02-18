﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Examples.Soap.v3.Shared;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Examples.Tests.v3
{
    [TestClass]
    public class GetErrorCode4Tests
    {
        [TestMethod]
        public void RunScript_GetErrorCode4_OptionObject_ReturnsErrorCode0()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();

            // Act
            OptionObject returnOptionObject = GetErrorCode4.RunScript(optionObject);

            // Assert
            Assert.AreEqual(4, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_GetErrorCode4_OptionObject2_ReturnsErrorCode0()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();

            // Act
            OptionObject2 returnOptionObject = GetErrorCode4.RunScript(optionObject);

            // Assert
            Assert.AreEqual(4, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_GetErrorCode4_OptionObject2015_ReturnsErrorCode0()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();

            // Act
            OptionObject2015 returnOptionObject = GetErrorCode4.RunScript(optionObject);

            // Assert
            Assert.AreEqual(4, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_GetErrorCode4_OptionObject_FormCountEquals0()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();

            // Act
            OptionObject returnOptionObject = GetErrorCode4.RunScript(optionObject);

            // Assert
            Assert.AreEqual(0, returnOptionObject.Forms.Count);
        }

        [TestMethod]
        public void RunScript_GetErrorCode4_OptionObject2_FormCountEquals0()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();

            // Act
            OptionObject2 returnOptionObject = GetErrorCode4.RunScript(optionObject);

            // Assert
            Assert.AreEqual(0, returnOptionObject.Forms.Count);
        }

        [TestMethod]
        public void RunScript_GetErrorCode4_OptionObject2015_FormCountEquals0()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();

            // Act
            OptionObject2015 returnOptionObject = GetErrorCode4.RunScript(optionObject);

            // Assert
            Assert.AreEqual(0, returnOptionObject.Forms.Count);
        }
    }
}
