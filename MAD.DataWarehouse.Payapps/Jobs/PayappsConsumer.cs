using Hangfire;
using MAD.DataWarehouse.Payapps.Database;
using Microsoft.EntityFrameworkCore;
using Payapps.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAD.DataWarehouse.Payapps.Jobs
{
    internal class PayappsConsumer
    {
        private readonly PayappsControllerApiClient apiClient;
        private readonly IBackgroundJobClient backgroundJobClient;
        private readonly IDbContextFactory<PayappsDbContext> dbContextFactory;

        public PayappsConsumer(PayappsControllerApiClient apiClient, IBackgroundJobClient backgroundJobClient, IDbContextFactory<PayappsDbContext> dbContextFactory)
        {
            this.apiClient = apiClient;
            this.backgroundJobClient = backgroundJobClient;
            this.dbContextFactory = dbContextFactory;
        }

        public async Task EnqueuePayappsForConsumer()
        {
            var payapps = await this.apiClient.GetPayappsAsync(project_id: null, start_date: null, end_date: null, claim_status: PayappStatusGroupEnum.All);

            foreach (var p in payapps)
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
