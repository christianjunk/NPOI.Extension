using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using NPOI.Extension.Tests.Case_1;
using NPOI.Extension.Tests.Case_2;

namespace NPOI.Extension.Tests
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void TestSimpleModel()
        {
            var file = Path.Combine(TestContext.CurrentContext.TestDirectory, @"Case 1\Book - Testcase 1.xlsx");
            Assert.IsTrue(File.Exists(file));

            var models = Excel.Load<Model>(file);
            IEnumerable<Model> enumerable = models as IList<Model> ?? models.ToList();

            Assert.AreEqual(8, enumerable.Count());

            var model = enumerable.First();
            Assert.AreEqual("2", model.A);
            Assert.AreEqual("321", model.F);
        }

        [Test]
        public void TestAdvancedModels()
        {
            var file1 = Path.Combine(TestContext.CurrentContext.TestDirectory, @"Case 2\Bavaria_HazmatStorageLocation_A.xls");
            var file2 = Path.Combine(TestContext.CurrentContext.TestDirectory, @"Case 2\Bavaria_HazWasteStorageLocation_A.xls");
            var file3 = Path.Combine(TestContext.CurrentContext.TestDirectory, @"Case 2\Wiesbaden_HazmatStorageLocation_A.xls");
            var file4 = Path.Combine(TestContext.CurrentContext.TestDirectory, @"Case 2\Wiesbaden_HazWasteStorageLocation_A.xls");

            Assert.IsTrue(File.Exists(file1));
            Assert.IsTrue(File.Exists(file2));
            Assert.IsTrue(File.Exists(file3));
            Assert.IsTrue(File.Exists(file4));

            #region First Test
            var bavariaHazmatStorageLocationA = Excel.Load<HazmatStorageLocationArea>(file1);
            var hazmatStorageLocationAreas = bavariaHazmatStorageLocationA as IList<HazmatStorageLocationArea> ?? bavariaHazmatStorageLocationA.ToList();

            Assert.AreEqual(47, hazmatStorageLocationAreas.Count());

            HazmatStorageLocationArea hazmatStorageLocationArea = hazmatStorageLocationAreas.First();
            Assert.AreEqual("Warehouse", hazmatStorageLocationArea.comment);
            Assert.AreEqual("3", hazmatStorageLocationArea.facilityNumber);
            Assert.AreEqual("F1", hazmatStorageLocationArea.floor);
            Assert.AreEqual("GE36L", hazmatStorageLocationArea.installationID);
            Assert.AreEqual("Warehouse", hazmatStorageLocationArea.locationDescription);
            Assert.AreEqual("2", hazmatStorageLocationArea.locationID);
            Assert.IsNull(hazmatStorageLocationArea.materialDescription);
            Assert.AreEqual("3_AAFES_2", hazmatStorageLocationArea.photoID);
            Assert.AreEqual("{CE40D0C7-4993-43D1-AFD3-008037B40F6B}", hazmatStorageLocationArea.sdsID);
            Assert.AreEqual("AAFES", hazmatStorageLocationArea.unit);
            #endregion

            #region Second Test
            var bavariaHazWasteStorageLocationA = Excel.Load<HazWasteStorageLocationArea>(file2);
            var hazWasteStorageLocationAreas = bavariaHazWasteStorageLocationA as IList<HazWasteStorageLocationArea> ?? bavariaHazWasteStorageLocationA.ToList();

            Assert.AreEqual(15, hazWasteStorageLocationAreas.Count());

            HazWasteStorageLocationArea hazWasteStorageLocationArea = hazWasteStorageLocationAreas.First();
            Assert.IsNull(hazWasteStorageLocationArea.comment);
            Assert.AreEqual("125", hazWasteStorageLocationArea.facilityNumber);
            Assert.AreEqual("F1", hazWasteStorageLocationArea.floor);
            Assert.AreEqual("GE36L", hazWasteStorageLocationArea.installationID);
            Assert.AreEqual("Sort Center", hazWasteStorageLocationArea.locationDescription);
            Assert.AreEqual("1", hazWasteStorageLocationArea.locationID);
            Assert.IsNull(hazWasteStorageLocationArea.materialDescription);
            Assert.AreEqual("125_DPW ENV DIVISION_1", hazWasteStorageLocationArea.photoID);
            Assert.AreEqual("{ED66FCC6-3BE5-4FDD-87D2-CA250D808E14}", hazWasteStorageLocationArea.sdsID);
            Assert.AreEqual("DPW ENV DIVISION", hazWasteStorageLocationArea.unit);

            #endregion

            #region Third Test
            var wiesbadenHazmatStorageLocationA = Excel.Load<HazmatStorageLocationArea>(file3);
            hazmatStorageLocationAreas = wiesbadenHazmatStorageLocationA as IList<HazmatStorageLocationArea> ?? wiesbadenHazmatStorageLocationA.ToList();

            Assert.AreEqual(17, hazmatStorageLocationAreas.Count());

            hazmatStorageLocationArea = hazmatStorageLocationAreas.First();
            Assert.AreEqual("It's a transition point (umschlagplatz). Es wird lediglich für 24hrs zwischengelagert", hazmatStorageLocationArea.comment);
            Assert.AreEqual("205", hazmatStorageLocationArea.facilityNumber);
            Assert.AreEqual("F1", hazmatStorageLocationArea.floor);
            Assert.AreEqual("GE31F", hazmatStorageLocationArea.installationID);
            Assert.AreEqual("24hrs storage", hazmatStorageLocationArea.locationDescription);
            Assert.AreEqual("1", hazmatStorageLocationArea.locationID);
            Assert.AreEqual("Small quantities for direct shipping. Car batteries, wind shield fluid, hand sanitizer, glass cleaners, lighters, deicer, power duster", hazmatStorageLocationArea.materialDescription);
            Assert.AreEqual("205_AAFES_1", hazmatStorageLocationArea.photoID);
            Assert.AreEqual("{7699534B-D82E-44F0-83EA-F6F6BA86ADDA}", hazmatStorageLocationArea.sdsID);
            Assert.AreEqual("AAFES", hazmatStorageLocationArea.unit);
            #endregion

            #region Fourth Test
            var wiesbadenHazWasteStorageLocationA = Excel.Load<HazWasteStorageLocationArea>(file4);
            hazWasteStorageLocationAreas = wiesbadenHazWasteStorageLocationA as IList<HazWasteStorageLocationArea> ?? wiesbadenHazWasteStorageLocationA.ToList();

            Assert.AreEqual(3, hazWasteStorageLocationAreas.Count());

            hazWasteStorageLocationArea = hazWasteStorageLocationAreas.First();
            Assert.AreEqual("HWSA", hazWasteStorageLocationArea.comment);
            Assert.AreEqual("237", hazWasteStorageLocationArea.facilityNumber);
            Assert.AreEqual("F1", hazWasteStorageLocationArea.floor);
            Assert.AreEqual("GE31F", hazWasteStorageLocationArea.installationID);
            Assert.AreEqual("yard", hazWasteStorageLocationArea.locationDescription);
            Assert.AreEqual("3", hazWasteStorageLocationArea.locationID);
            Assert.AreEqual("Misc", hazWasteStorageLocationArea.materialDescription);
            Assert.AreEqual("237_AAFES_3", hazWasteStorageLocationArea.photoID);
            Assert.AreEqual("{0CF765EE-72F9-4A08-ADB1-0AB93B9FEE8C}", hazWasteStorageLocationArea.sdsID);
            Assert.AreEqual("AAFES", hazWasteStorageLocationArea.unit);
            #endregion


        }
    }
}
