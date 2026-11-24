# Klient server intro

```
Klient        Server
|               |
|--- Request -->|
|               |
|<-- Response --| 
```


## Examples of text content

CSV (Comma sepated values), f.eks:
userName, age, location, admin, 50, bob, 30, anna, 20,

Ulemper: Antall colums må være defiert på forhånd.

XML (Markup language): in short: easier to modify, but its HUGE.

JSON: skal tilbake til denne straks :)


## Nettverks protokoller

google.com
vg.no
kode24.no

## IP adresser

```
255.123.123.123     IPv4
2001:db8:1::1       IPv6
127.0.0.1           IPv4 utgave av din lokale maskin
```


## Ports 

list of common default ports

```
|Port | Typisk bruk  |
|---- |--------------|
| 21  | FTP          |
| 22  | SSH          |
| 80  | HTTP trafikk |
| 443 | HTTPS trafikk|
| 1433| MsSQL        |
| 3306| MySQL        |
| 5432| PostgreSQL   |
| 8080| Alt-webserver port|
|65536| siste port :)|
|---- |-------------|
```


## TCP protokoll

```
Klient        Server
|               |
|--- SYN-msg -->|
|               |
|<-- SYN-ACK ---| 
|               |
|----- ACK. --->|
|               |
|TCP-forb.opprettet|
```


### Forskjell på HTTP og HTTPS

```
HTTP = Hypertext Transfer Protocol
HTTPS = HTTP med TLS kryptering
TLS = Transport Layer Security
```


```
HTTP - Innholdet: syntaks og regler for hovrdan nettlesere og servere ber om og sender nettsider.
TLS - Sørger for at innholdet er "sikkert"
TCP - Deler opp data i mindre pakker.
IP - Gir enhetene addresser og "finner beste ruten".
```


