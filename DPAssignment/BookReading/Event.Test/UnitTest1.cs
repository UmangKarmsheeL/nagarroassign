using AutoMapper;
using Business.Facade;
using Business.Service;
using Event.Controllers;
using Event.Factory;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;


namespace EventControllerTesting
{
    [TestClass]
    public class EventControllerTests
    {
     

        [TestMethod]
        public void Add()
        {
            // Arrange
            
            var mockeventModelFactory = new Mock<IEventModelFactory>();
            var mockmapper = new Mock<IMapper>();
            var mockEventFacade = new Mock<EventServiceFacadeFactory>();
            var mockLogger = new Mock<ILogger<EventController>>();
            var controller = new EventController(
                mockLogger.Object,
                mockeventModelFactory.Object,
                mockmapper.Object,
                mockEventFacade.Object
                );
     
            string viewName = "Add";

            // Act
            var viewResult = controller.View("Add", "Event") as ViewResult;

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(viewName, viewResult.ViewName);
        }

        [TestMethod]
        public void MyEvent()
        {
            // Arrange
            var mockeventModelFactory = new Mock<IEventModelFactory>();
            var mockmapper = new Mock<IMapper>();
            var mockEventFacade = new Mock<EventServiceFacadeFactory>();
            var mockLogger = new Mock<ILogger<EventController>>();
            var controller = new EventController(
                mockLogger.Object,
                mockeventModelFactory.Object,
                mockmapper.Object,
                mockEventFacade.Object
                );

            string viewName = "MyEvent";

            // Act
            var viewResult = controller.View("MyEvent", "Event") as ViewResult;

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(viewName, viewResult.ViewName);
        }

        [TestMethod]
        public void EventsInvitedTo()
        {
            // Arrange
            var mockeventModelFactory = new Mock<IEventModelFactory>();
            var mockmapper = new Mock<IMapper>();
            var mockEventFacade = new Mock<EventServiceFacadeFactory>();
            var mockLogger = new Mock<ILogger<EventController>>();
            var controller = new EventController(
                mockLogger.Object,
                mockeventModelFactory.Object,
                mockmapper.Object,
                mockEventFacade.Object
                );

            string viewName = "EventsInvitedTo";

            // Act
            var viewResult = controller.View("EventsInvitedTo", "Event") as ViewResult;

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(viewName, viewResult.ViewName);
        }
        
        [TestMethod]
        public void List()
        {
            // Arrange
            var mockeventModelFactory = new Mock<IEventModelFactory>();
            var mockmapper = new Mock<IMapper>();
            var mockEventFacade = new Mock<EventServiceFacadeFactory>();
            var mockLogger = new Mock<ILogger<EventController>>();
            var controller = new EventController(
                mockLogger.Object,
                mockeventModelFactory.Object,
                mockmapper.Object,
                mockEventFacade.Object
                );

            string viewName = "List";

            // Act
            var viewResult = controller.View("List", "Event") as ViewResult;

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(viewName, viewResult.ViewName);
        }

        [TestMethod]
        public void CustomerSupport()
        {
            // Arrange
            var mockeventModelFactory = new Mock<IEventModelFactory>();
            var mockmapper = new Mock<IMapper>();
            var mockEventFacade = new Mock<EventServiceFacadeFactory>();
            var mockLogger = new Mock<ILogger<EventController>>();
            var controller = new EventController(
                mockLogger.Object,
                mockeventModelFactory.Object,
                mockmapper.Object,
                mockEventFacade.Object
                );

            string viewName = "CustomerSupport";

            // Act
            var viewResult = controller.View("CustomerSupport", "Event") as ViewResult;

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(viewName, viewResult.ViewName);
        }

    }
}