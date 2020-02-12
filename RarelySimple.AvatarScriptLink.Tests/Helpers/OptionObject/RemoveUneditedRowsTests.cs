﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.Helpers
{
    [TestClass]
    public class RemoveUneditedRowsTests
    {
        [TestMethod]
        public void RemoveUneditedRows_OptionObject_IsFalse()
        {
            // Arrange
            FieldObject fieldObject01 = new FieldObject("123", "");
            FieldObject fieldObject02 = new FieldObject("124", "");
            FieldObject fieldObject03 = new FieldObject("125", "");
            RowObject rowObject01 = new RowObject("1||1", new List<FieldObject>() { fieldObject01, fieldObject02, fieldObject03 });
            FormObject formObject = new FormObject("1", rowObject01);
            OptionObject optionObject = new OptionObject()
            {
                Forms = new List<FormObject>()
                {
                    formObject
                }
            };

            // Act
            optionObject = (OptionObject)OptionObjectHelpers.RemoveUneditedRows(optionObject);

            // Assert
            Assert.IsFalse(optionObject.IsRowPresent("1||1"));
        }
        [TestMethod]
        public void RemoveUneditedRows_OptionObject_IsTrue()
        {
            // Arrange
            FieldObject fieldObject01 = new FieldObject("123", "");
            FieldObject fieldObject02 = new FieldObject("124", "");
            FieldObject fieldObject03 = new FieldObject("125", "");
            RowObject rowObject01 = new RowObject("1||1", new List<FieldObject>() { fieldObject01, fieldObject02, fieldObject03 });
            FormObject formObject = new FormObject("1", rowObject01);
            OptionObject optionObject = new OptionObject()
            {
                Forms = new List<FormObject>()
                {
                    formObject
                }
            };

            // Act
            optionObject.SetFieldValue("123", "MODIFIED");
            optionObject = (OptionObject)OptionObjectHelpers.RemoveUneditedRows(optionObject);

            // Assert
            Assert.IsTrue(optionObject.IsRowPresent("1||1"));
        }

        [TestMethod]
        public void RemoveUneditedRows_OptionObject_ModifiedFieldIsPresent()
        {
            // Arrange
            FieldObject fieldObject01 = new FieldObject("123", "");
            FieldObject fieldObject02 = new FieldObject("124", "");
            FieldObject fieldObject03 = new FieldObject("125", "");
            RowObject rowObject01 = new RowObject("1||1", new List<FieldObject>() { fieldObject01, fieldObject02, fieldObject03 });
            FormObject formObject = new FormObject("1", rowObject01);
            OptionObject optionObject = new OptionObject()
            {
                Forms = new List<FormObject>()
                {
                    formObject
                }
            };

            // Act
            optionObject.SetFieldValue("123", "MODIFIED");
            optionObject = (OptionObject)OptionObjectHelpers.RemoveUneditedRows(optionObject);

            // Assert
            Assert.IsTrue(optionObject.IsFieldPresent("123"));
        }

        [TestMethod]
        public void RemoveUneditedRows_OptionObject_UnmodifiedFieldIsAbsent()
        {
            // Arrange
            FieldObject fieldObject01 = new FieldObject("123", "");
            FieldObject fieldObject02 = new FieldObject("124", "");
            FieldObject fieldObject03 = new FieldObject("125", "");
            RowObject rowObject01 = new RowObject("1||1", new List<FieldObject>() { fieldObject01, fieldObject02, fieldObject03 });
            FormObject formObject = new FormObject("1", rowObject01);
            OptionObject optionObject = new OptionObject()
            {
                Forms = new List<FormObject>()
                {
                    formObject
                }
            };

            // Act
            optionObject.SetFieldValue("123", "MODIFIED");
            optionObject = (OptionObject)OptionObjectHelpers.RemoveUneditedRows(optionObject);

            // Assert
            Assert.IsFalse(optionObject.IsFieldPresent("124"));
        }

        [TestMethod]
        public void RemoveUneditedRows_OptionObject2_IsFalse()
        {
            // Arrange
            FieldObject fieldObject01 = new FieldObject("123", "");
            FieldObject fieldObject02 = new FieldObject("124", "");
            FieldObject fieldObject03 = new FieldObject("125", "");
            RowObject rowObject01 = new RowObject("1||1", new List<FieldObject>() { fieldObject01, fieldObject02, fieldObject03 });
            FormObject formObject = new FormObject("1", rowObject01);
            OptionObject2 optionObject = new OptionObject2()
            {
                Forms = new List<FormObject>()
                {
                    formObject
                }
            };

            // Act
            optionObject = (OptionObject2)OptionObjectHelpers.RemoveUneditedRows(optionObject);

            // Assert
            Assert.IsFalse(optionObject.IsRowPresent("1||1"));
        }
        [TestMethod]
        public void RemoveUneditedRows_OptionObject2_IsTrue()
        {
            // Arrange
            FieldObject fieldObject01 = new FieldObject("123", "");
            FieldObject fieldObject02 = new FieldObject("124", "");
            FieldObject fieldObject03 = new FieldObject("125", "");
            RowObject rowObject01 = new RowObject("1||1", new List<FieldObject>() { fieldObject01, fieldObject02, fieldObject03 });
            FormObject formObject = new FormObject("1", rowObject01);
            OptionObject2 optionObject = new OptionObject2()
            {
                Forms = new List<FormObject>()
                {
                    formObject
                }
            };

            // Act
            optionObject.SetFieldValue("123", "MODIFIED");
            optionObject = (OptionObject2)OptionObjectHelpers.RemoveUneditedRows(optionObject);

            // Assert
            Assert.IsTrue(optionObject.IsRowPresent("1||1"));
        }

        [TestMethod]
        public void RemoveUneditedRows_OptionObject2_ModifiedFieldIsPresent()
        {
            // Arrange
            FieldObject fieldObject01 = new FieldObject("123", "");
            FieldObject fieldObject02 = new FieldObject("124", "");
            FieldObject fieldObject03 = new FieldObject("125", "");
            RowObject rowObject01 = new RowObject("1||1", new List<FieldObject>() { fieldObject01, fieldObject02, fieldObject03 });
            FormObject formObject = new FormObject("1", rowObject01);
            OptionObject2 optionObject = new OptionObject2()
            {
                Forms = new List<FormObject>()
                {
                    formObject
                }
            };

            // Act
            optionObject.SetFieldValue("123", "MODIFIED");
            optionObject = (OptionObject2)OptionObjectHelpers.RemoveUneditedRows(optionObject);

            // Assert
            Assert.IsTrue(optionObject.IsFieldPresent("123"));
        }

        [TestMethod]
        public void RemoveUneditedRows_OptionObject2_UnmodifiedFieldIsAbsent()
        {
            // Arrange
            FieldObject fieldObject01 = new FieldObject("123", "");
            FieldObject fieldObject02 = new FieldObject("124", "");
            FieldObject fieldObject03 = new FieldObject("125", "");
            RowObject rowObject01 = new RowObject("1||1", new List<FieldObject>() { fieldObject01, fieldObject02, fieldObject03 });
            FormObject formObject = new FormObject("1", rowObject01);
            OptionObject2 optionObject = new OptionObject2()
            {
                Forms = new List<FormObject>()
                {
                    formObject
                }
            };

            // Act
            optionObject.SetFieldValue("123", "MODIFIED");
            optionObject = (OptionObject2)OptionObjectHelpers.RemoveUneditedRows(optionObject);

            // Assert
            Assert.IsFalse(optionObject.IsFieldPresent("124"));
        }

        [TestMethod]
        public void RemoveUneditedRows_OptionObject2015_IsFalse()
        {
            // Arrange
            FieldObject fieldObject01 = new FieldObject("123", "");
            FieldObject fieldObject02 = new FieldObject("124", "");
            FieldObject fieldObject03 = new FieldObject("125", "");
            RowObject rowObject01 = new RowObject("1||1", new List<FieldObject>() { fieldObject01, fieldObject02, fieldObject03 });
            FormObject formObject = new FormObject("1", rowObject01);
            OptionObject2015 optionObject = new OptionObject2015()
            {
                Forms = new List<FormObject>()
                {
                    formObject
                }
            };

            // Act
            optionObject = (OptionObject2015)OptionObjectHelpers.RemoveUneditedRows(optionObject);

            // Assert
            Assert.IsFalse(optionObject.IsRowPresent("1||1"));
        }
        [TestMethod]
        public void RemoveUneditedRows_OptionObject2015_IsTrue()
        {
            // Arrange
            FieldObject fieldObject01 = new FieldObject("123", "");
            FieldObject fieldObject02 = new FieldObject("124", "");
            FieldObject fieldObject03 = new FieldObject("125", "");
            RowObject rowObject01 = new RowObject("1||1", new List<FieldObject>() { fieldObject01, fieldObject02, fieldObject03 });
            FormObject formObject = new FormObject("1", rowObject01);
            OptionObject2015 optionObject = new OptionObject2015()
            {
                Forms = new List<FormObject>()
                {
                    formObject
                }
            };

            // Act
            optionObject.SetFieldValue("123", "MODIFIED");
            optionObject = (OptionObject2015)OptionObjectHelpers.RemoveUneditedRows(optionObject);

            // Assert
            Assert.IsTrue(optionObject.IsRowPresent("1||1"));
        }

        [TestMethod]
        public void RemoveUneditedRows_OptionObject2015_ModifiedFieldIsPresent()
        {
            // Arrange
            FieldObject fieldObject01 = new FieldObject("123", "");
            FieldObject fieldObject02 = new FieldObject("124", "");
            FieldObject fieldObject03 = new FieldObject("125", "");
            RowObject rowObject01 = new RowObject("1||1", new List<FieldObject>() { fieldObject01, fieldObject02, fieldObject03 });
            FormObject formObject = new FormObject("1", rowObject01);
            OptionObject2015 optionObject = new OptionObject2015()
            {
                Forms = new List<FormObject>()
                {
                    formObject
                }
            };

            // Act
            optionObject.SetFieldValue("123", "MODIFIED");
            optionObject = (OptionObject2015)OptionObjectHelpers.RemoveUneditedRows(optionObject);

            // Assert
            Assert.IsTrue(optionObject.IsFieldPresent("123"));
        }

        [TestMethod]
        public void RemoveUneditedRows_OptionObject2015_UnmodifiedFieldIsAbsent()
        {
            // Arrange
            FieldObject fieldObject01 = new FieldObject("123", "");
            FieldObject fieldObject02 = new FieldObject("124", "");
            FieldObject fieldObject03 = new FieldObject("125", "");
            RowObject rowObject01 = new RowObject("1||1", new List<FieldObject>() { fieldObject01, fieldObject02, fieldObject03 });
            FormObject formObject = new FormObject("1", rowObject01);
            OptionObject2015 optionObject = new OptionObject2015()
            {
                Forms = new List<FormObject>()
                {
                    formObject
                }
            };

            // Act
            optionObject.SetFieldValue("123", "MODIFIED");
            optionObject = (OptionObject2015)OptionObjectHelpers.RemoveUneditedRows(optionObject);

            // Assert
            Assert.IsFalse(optionObject.IsFieldPresent("124"));
        }

        // Add tests for multiple forms and multiple iteration tables (incl. Adding rows to multiple iteration tables)
    }
}
