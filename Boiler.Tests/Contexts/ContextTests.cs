using System;
using Boiler.Db.Contexts;
using Boiler.Db.Entities;
using Moq;
using NUnit.Framework;

namespace Boiler.Tests.Contexts {
    public class BoilerContextTests {
        private Context _context;

        [OneTimeSetUp]
        public void OneTimeSetUp() {
            _context = new Context("local");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown() {
            _context.Database.Delete();
            _context.Dispose();
        }

        [Test]
        [TestCase(typeof(Entity))]
        public void RecipeContext_Initialize_TableExists(Type entityType) {
            //Act
            _context.Database.Initialize(true);

            //Assert
            Assert.That(() => _context.Set(entityType).Local.Count, Throws.Nothing);
        }
    }
}
