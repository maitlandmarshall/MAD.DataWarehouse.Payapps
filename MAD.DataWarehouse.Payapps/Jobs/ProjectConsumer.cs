using Hangfire;
using MAD.DataWarehouse.Payapps.Database;
using MAD.Extensions.EFCore;
using Microsoft.EntityFrameworkCore;
using Payapps.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAD.DataWarehouse.Payapps.Jobs
{
    internal class ProjectConsumer
    {
        private readonly ProjectsControllerApiClient apiClient;
        private readonly IBackgroundJobClient backgroundJobClient;
        private readonly IDbContextFactory<PayappsDbContext> dbContextFactory;

        public ProjectConsumer(ProjectsControllerApiClient apiClient, IBackgroundJobClient backgroundJobClient, IDbContextFactory<PayappsDbContext> dbContextFactory)
        {
            this.apiClient = apiClient;
            this.backgroundJobClient = backgroundJobClient;
            this.dbContextFactory = dbContextFactory;
        }

        public async Task EnqueueProjectsForConsumer()
        {
            var projects = await this.apiClient.GetAllProjectsAsync();

            foreach (var p in projects)
            {
                this.backgroundJobClient.Enqueue<ProjectConsumer>(y => y.ConsumeProject(p.Id));
            }
        }

        public async Task ConsumeProject(double id)
        {
            using var db = await this.dbContextFactory.CreateDbContextAsync();
            var project = await this.apiClient.GetProjectAsync(id);

            db.Upsert(project);

            await db.SaveChangesAsync();
        }
    }
}
