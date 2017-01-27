using FluentScheduler;

namespace bandenbot.Jobs
{
    public class Registery : Registry
    {
        public Registery()
        {
            Schedule<Backup>().ToRunNow().AndEvery(60).Minutes();
        }
    }
}
