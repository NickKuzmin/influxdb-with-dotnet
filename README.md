- https://portal.influxdata.com/downloads

**VERSION 1.8.1:**
```
influx.exe
influx_inspect.exe
influx_stress.exe
influxd.exe
influxdb.conf
```
-------------------------
```CREATE DATABASE "example" WITH DURATION 1h```

```show databases```

```use example```

```
SELECT * FROM cpu
```

```
INSERT cpu,host=serverA,region=us_west value=0.64
```
------------------
- InfluxDb storage folder:
```c:\Users\<username>\.influxdb\data\```

