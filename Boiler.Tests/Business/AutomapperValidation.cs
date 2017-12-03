using AutoMapper;
using Boiler.Business;
using NUnit.Framework;

namespace Boiler.Tests.Business
{
    [TestFixture]
    public class AutomapperValidation {
        private IMapper _mapper;
        private MapperConfiguration _config;

        [SetUp]
        public void SetUp() {
            _config = new MapperConfiguration(opt => opt.AddProfile<AutomapperProfile>());
            _mapper = _config.CreateMapper();
        }

        [Test]
        public void Assert_Automapper_Profile() {
            _config.AssertConfigurationIsValid();
        }
    }
}
