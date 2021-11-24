using InfluxDB.Collector;
using System;

namespace InfluxDB.DotNet
{
    public class InfluxDbProcessor
    {
        public void Add()
        {
            Metrics.Collector = new CollectorConfiguration()
                .Tag.With("host", Environment.GetEnvironmentVariable("COMPUTERNAME"))
                .Batch.AtInterval(TimeSpan.FromSeconds(2))
                .WriteTo.InfluxDB("http://127.0.0.1:8086", "data")
                .CreateCollector();
        }
    }
}
