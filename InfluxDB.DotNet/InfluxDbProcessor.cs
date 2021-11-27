using InfluxDB.Collector;
using System;
using System.Collections.Generic;
using System.Threading;

namespace InfluxDB.DotNet
{
    public class InfluxDbProcessor
    {
        public void Add()
        {
            Metrics.Collector = new CollectorConfiguration()
                .Tag.With("host", Environment.GetEnvironmentVariable("COMPUTERNAME"))
                .Batch.AtInterval(TimeSpan.FromSeconds(2))
                .WriteTo.InfluxDB("http://127.0.0.1:8086", "example")
                .CreateCollector();

            Metrics.Write("cpu_time", new Dictionary<string, object>
            {
                { "value", "value" },
                { "user", "user" }
            });
        }

        public void LoadTesting()
        {
            Metrics.Collector = new CollectorConfiguration()
                .Tag.With("host", Environment.GetEnvironmentVariable("COMPUTERNAME"))
                .Batch.AtInterval(TimeSpan.FromSeconds(2))
                .WriteTo.InfluxDB("http://127.0.0.1:8086", "example")
                .CreateCollector();

            var random = new Random();
            for(var i = 0; i < 50; i++)
            {
                var value = 1500 + (1500 * random.NextDouble()) * 2 * random.NextDouble();
                Metrics.Write("cpu", new Dictionary<string, object>
                {
                    { "value", value },
                    { "user", "user" + i }
                });

                Thread.Sleep((int)(1500 + (1500 * random.NextDouble())));
            }
        }
    }
}
