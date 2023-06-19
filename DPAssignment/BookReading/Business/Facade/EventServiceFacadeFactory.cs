using Business.Service;
using DAL.Data;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Business.Facade
{
    public class EventServiceFacadeFactory
    {
        private readonly IConfiguration configuration;

        public EventServiceFacadeFactory(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public EventServiceFacade CreateEventServiceFacade()
        {
            var options = new DbContextOptionsBuilder<eventDbContext>()
                .UseSqlServer(configuration.GetConnectionString("EventsConnectionString"))
                .Options;

            var dbContext = new eventDbContext(options);
            IEventRepository eventRepository = new EventRepository(dbContext);
            IEventService eventService = new EventService(eventRepository);
            return new EventServiceFacade(eventService);
        }

    }
}
