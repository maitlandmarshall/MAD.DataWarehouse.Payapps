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
            using var db = await this.dbContextFactory.CreateDbContextAsync();

            foreach (var p in payapps)
            {
                db.Upsert(p);
            }

            await db.SaveChangesAsync();

            foreach (var p in payapps)
            {
                this.backgroundJobClient.Enqueue<PayappsConsumer>(y => y.ConsumePayapp(p.Claim_id));
            }
        }

        public async Task ConsumePayapp(double id)
        {
            using var db = await this.dbContextFactory.CreateDbContextAsync();
            var payapp = await this.apiClient.GetPayappAsync(id);

            db.Upsert(payapp);

            await db.SaveChangesAsync();
        }
    }
}
