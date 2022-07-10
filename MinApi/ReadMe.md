### Defining the stack from compose file
```console
docker stack deploy --compose-file docker-compose.yml stackname
```

### Scaling up service
```console
docker service scale stackname_simple-time-api=5
```
### Testing the loadbalancer!

```console
 for i in `seq 100`; do curl 127.0.0.1:8080; echo ''; done
```

### Sampled output
```console
api:972483304 response=ok ok ok 07/10/2022 17:33:56
api:2119011498 response=ok ok ok 07/10/2022 17:33:56
api:1624708748 response=ok ok ok 07/10/2022 17:33:56
api:1467235243 response=ok ok ok 07/10/2022 17:33:56
api:505570279 response=ok ok ok 07/10/2022 17:33:56
api:972483304 response=ok ok ok 07/10/2022 17:33:56
api:2119011498 response=ok ok ok 07/10/2022 17:33:56
api:1624708748 response=ok ok ok 07/10/2022 17:33:56
api:1467235243 response=ok ok ok 07/10/2022 17:33:56

```

As we can see api 'id' is repeating every 5 calls