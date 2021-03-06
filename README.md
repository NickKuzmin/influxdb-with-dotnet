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

```show measurements```

```drop measurement cpu``` ("cpu" - is the name of measurement)

```use example```

```
SELECT * FROM cpu
select * from cpu where time >= now() - 5m
show series
```

```
INSERT cpu,host=serverA,region=us_west value=0.64
```

```
POST http://localhost:8086/write?db=example HTTP/1.1
User-Agent: Fiddler
Host: localhost:8086
Content-Length: 42

cpu,host=serverA,region=us_west value=0.64
```

```
curl -i -XPOST 'http://localhost:8086/write?db=mydb'
--data-binary 'cpu_load_short,host=server01,region=us-west value=0.64 1434055562000000000'
```

```
curl -i -XPOST 'http://localhost:8086/api/v2/write?bucket=db/rp&precision=ns' \
  --header 'Authorization: Token username:password' \
  --data-raw 'cpu_load_short,host=server01,region=us-west value=0.64 1434055562000000000'
```

```
curl -i -XPOST 'http://localhost:8086/write?db=mydb' --data-binary @cpu_data.txt
```
------------------
- InfluxDb storage folder:
```c:\Users\<username>\.influxdb\data\```
------------------
### Grafana:

```http://localhost:3000/login```

> https://grafana.com/docs/grafana/latest/getting-started/getting-started-influxdb/

```
Open your web browser and go to http://localhost:3000/. The default HTTP port that Grafana listens to is 3000 unless you have configured a different port.
On the login page, enter admin for username and password.
Click Log in. If login is successful, then you will see a prompt to change the password.
Click OK on the prompt, then change your password.
```
