using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestPlatform.Common.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using SuperGoalsAPI.Controllers;

namespace SuperGoalsAPITest
{
    [TestClass]
    public class GoalControllerTest
    {
       // static ILogger<GoalController> logger;
        private GoalController goalController;

        [TestInitialize]
        public void TestInitialize()
        {
            goalController = new GoalController();
        }

        [TestMethod]
        [TestCategory("GetAllGoals")]
        public void GetAllGoals_NoGoals()
        {
            // TODO look at using RestSharp for testing

        }
    }
}
