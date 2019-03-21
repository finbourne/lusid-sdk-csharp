# Running SDK Tests

Build and run the container using `docker-compose`

```
$ docker-compose up && docker-compose rm -f
```

Alernatively run using `docker` commands

Build the container
```
$ docker build -t finbourne/lusid-sdk-csharp-test .
```

Run the tests
```
$ docker run --rm -it --name lusid-sdk-test-csharp -v `pwd`:/usr/src finbourne/lusid-sdk-csharp-test
```

## Test Configuration

Create a file named `secrets.json` in the `tests` folder with the structure below and populated with the appropriate values.

``` json
{
  "api" : {
    "tokenUrl": "",
    "username": "",
    "password": "",
    "clientId": "",
    "clientSecret": "",
    "apiUrl": ""
  }
}
```

| Key | Description |
| --- | --- |
| `tokenUrl` | Okta endpoint to generate the authentication token.  This will be of the form https://lusid.okta.com/oauth2/\<key\>/v1/token |
| `username` | Okta username |
| `password` | Okta password |
| `clientId` | Okta client identifier |
| `clientSecret` | Okta client secret |
| `apiUrl` | API url |