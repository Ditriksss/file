using File.Application.Commands;
using IntegrationEvent.Interfaces;
using System.Threading.Tasks;

namespace File.Application.EventHandler
{
    public class CreateFileEventHandler : IIntegrationEventHandler<CreateFileCommand>
    {
        public Task Handle(CreateFileCommand integrationEvent)
        {
            System.Console.WriteLine("Handling create file");

            return Task.CompletedTask;
        }
    }
}
