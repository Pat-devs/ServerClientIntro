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

JSON: Se API, URL, JSON, osv... seksjonen


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

## HTTP-forespørsel (HTTP-request)

 
Forenklet eksempel på en http 1.1 request:

```
GET /posts/1 HTTP/1.1
Host: jsonplaceholder.typicode.com
Accept: application/json
```


## HTTP-respons

```
HTTP/1.1 200 OK
Content-Type: application/json

{
    "userId: 1,
    "id": 1,
    "title": "Whatevertitle",
    "body": "Noetekst"
}
```

### HTTP request status codes

```
|Kode | betydning |
|---- |--------------|
| 1xx | Basic info   |
| 2xx | Vellyket request |
| 3xx | Omdirigerting |
| 4xx | Feil knyttet til klienten |
| 5xx | Feil knyttet til serveren | 
```

litt mer eksempler på spesifike status koder:
```
|  Kode  | betydning    |
|  ----  |--------------|
| 200 OK |--------------|
| 201 Created | En ressurs ble opprettet  |
| 204 No Content | Vellyket, men det er ingen innhold her |
| 204 No Content | Vellyket, men det er ingen innhold her |
| 400 Bad Request | Ugyldig forespørsel |
| 401 Unauthorized | Mangler gyldig autentisering |
| 404 Not found | Ressurs ikke funnet |
| 500 Internal server error | Intern serverfeil |
| 503 Service unavailable | Tjenesten utilgjengelig |
osv...
```

### API, URL, JSON, osv...

API - Application Programming Interface
URL - En adresse :)
JSON - Javascript Object Notation


JSON eksempel:
```
{
    "id": 1,
    "name": "Ola",
    "age": 25,
    "money": 50.25,
    "isActive": true,
    "email": null,
    "skills": ["C#", "SQL", "HTML"],
    "address": {
        "city": "Bergen",
        "country": "Norge"
    }
}
```

#### API

Eksempel på requests
```
GET /posts Hent alle innlegg
GET /posts/1 Hent innlegg nr 1 (eller erstatt 1 med et spesifikt innlegg)
POST /posts Opprett et innlegg
PUT /posts/1 Erstatt et innlegg (replace)
PATCH /posts/1 Erstatt deler innlegg (edit parts)
DELETE /posts/1 Fjern et innlegg
```


### URL

f.eks:
```
https://jsonplaceholder.typicode.com:443/posts?userId=1
```

```
DEL - Betydning
`https://` - Secure HTTP
`jsonplaceholder.typicode.com` - Addresse / vertsnavn (hostname) 
`:443` - Port
`/posts` - Path / Sti
`?userId=1` - Query string parameter(e)
```


