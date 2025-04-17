using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Проект.Литературные_вечера;
using Проект.Литературные_вечера.Data;

namespace Tests
{
    [TestClass]

    public class EventTests

    {
        private AppDbContext _dbContext;
        private EventCreator _eventCreator;

        public void Setup()
        {

            _dbContext = new AppDbContext();
            _eventCreator = new EventCreator(_dbContext);
        }
        private Event event1;


        [TestInitialize]
        public void CreateEvent()
        {
            event1 = new Event();

        }
        [TestMethod]
        public void Event_Name_ThrowsExceptionNotCreator()
        {

            event1.Title = "        ";

            Assert.ThrowsException<ArgumentException>(() => event1.Title);
        }
        [TestMethod]
        public void Event_Description_ThrowsExceptionNotCreator()
        {

            event1.Description = String.Empty;

            Assert.ThrowsException<ArgumentException>(() => event1.Description);
        }
        [TestMethod]
        public void Event_Description_ThrowsExceptionIDescriptionNotStartWihtSpace()
        {

            event1.Description = " Обсуждение";

            Assert.ThrowsException<ArgumentException>(() => event1.Description);
        }
        [TestMethod]
        public void Event_Name_ThrowsExceptionINameNotStartWihtSpace()
        {

            event1.Title = " Чаепитие";

            Assert.ThrowsException<ArgumentException>(() => event1.Title);
        }
        [TestMethod]
        public void Event_Name_ThrowsExceptionIName()
        {

            event1.Title = "Чаепитие";

            Assert.AreEqual("Чаепитие", event1.Title);
        }
        [TestMethod]
        public void Event_Description_ThrowsExceptionIName()
        {

            event1.Description = "Чаепитие";

            Assert.AreEqual("Чаепитие", event1.Description);
        }
        [TestMethod]
        public void Event_Name_ThrowsExceptionINameNotStartWihtSimbols()
        {

            event1.Title = "%Чаепитие";

            Assert.ThrowsException<ArgumentException>(() => event1.Title);
        }
        [TestMethod]
        public void Event_Description_ThrowsExceptionINameNotStartWihtSimbols()
        {

            event1.Description = "%Чаепитие";

            Assert.ThrowsException<ArgumentException>(() => event1.Description);
        }
        [TestMethod]
        public void Employer_DateOfEvent()
        {

            event1.Date = new DateTime(1996, 09, 23);
            bool databool = (event1.Date >= DateTime.Today);

            Assert.AreEqual(databool, true);
        }
        [TestMethod]
        public void Employer_DateOfEvent2()
        {

            event1.Date = new DateTime(2026, 09, 23);
            bool databool = (event1.Date >= DateTime.Today);

            Assert.AreEqual(databool, true);
        }

        [TestMethod]

        public void LoadCategories_ShouldLoadDistinctCategoriesFromDatabase()
        {
            _dbContext.Events.Add(new Event { Category = "Category1" });
            _dbContext.Events.Add(new Event { Category = "Category2" });
            _dbContext.Events.Add(new Event { Category = "Category1" }); 
            _dbContext.SaveChanges();

            _eventCreator.LoadCategories();

            Assert.AreEqual(2, _eventCreator.comboBoxCreator.Items.Count);
            Assert.IsTrue(_eventCreator.comboBoxCreator.Items.Contains("Category1"));
            Assert.IsTrue(_eventCreator.comboBoxCreator.Items.Contains("Category2"));
        }
       
    }
}