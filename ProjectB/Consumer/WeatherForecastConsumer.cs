using System.Threading.Tasks;
using MassTransit;
using Model;


namespace ProjectB.Consumer
{
    public class WeatherForecastConsumer : IConsumer<WeatherForecast>
    {
        public async Task Consume(ConsumeContext<WeatherForecast> context)
        {
            var message = context.Message;
            throw new System.NotImplementedException();
        }
    }
}