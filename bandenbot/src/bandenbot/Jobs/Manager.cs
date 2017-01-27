using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentScheduler;

namespace bandenbot.Jobs
{
    public class Manager
    {
        public Manager()
        {
            JobManager.JobStart += JobManager_JobStart;
            JobManager.JobEnd += JobManager_JobEnd;
            JobManager.JobException += JobManager_JobException;
        }

        private void JobManager_JobException(JobExceptionInfo obj)
        {
            throw new NotImplementedException();
        }

        private void JobManager_JobEnd(JobEndInfo obj)
        {
            throw new NotImplementedException();
        }

        private void JobManager_JobStart(JobStartInfo obj)
        {
            throw new NotImplementedException();
        }

        public static void StartJobs() => JobManager.Initialize(new Registery());
    }
}
