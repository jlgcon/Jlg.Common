﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JlgCommon.ExcelManager;

namespace JlgCommonTests.Extensions
{
    [TestClass]
    public class ExcelManagerTests
    {
        public static string ExcelManagerTestsFolder = AppDomain.CurrentDomain.BaseDirectory + @"\ExcelManager\";
        public static string ExcelReaderTestsFilePath = ExcelManagerTests.ExcelManagerTestsFolder + "ExcelReaderTestsFile.xlsx";


        [TestMethod]
        public void ExcelFilePathsAreSyncronizedBetweenReaderAndWriter()
        {
            var excelManager = new ExcelManager(ExcelReaderTestsFilePath);
            Assert.AreEqual(ExcelReaderTestsFilePath, excelManager.Reader.ExcelFilePath, false);
            Assert.AreEqual(ExcelReaderTestsFilePath, excelManager.Writer.ExcelFilePath, false);

            var excelFileAnotherPath = "another file path";
            excelManager.ExcelFilePath = excelFileAnotherPath;
            Assert.AreEqual(excelFileAnotherPath, excelManager.Reader.ExcelFilePath, false);
            Assert.AreEqual(excelFileAnotherPath, excelManager.Writer.ExcelFilePath, false);
            
        }
        
    }
}