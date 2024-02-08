# hacker-news-api

This is an API to access to the top n best stories on `Hacker News API`.

We are usin [FirebaseDatabase.net](https://www.nuget.org/packages/FirebaseDatabase.net/) nugget to access the api in order to let firebase to handle the concurrency and performance.

We use services injection to perform actions from the controlers.

We add a swagger instance to be able to play with the endpoints and generate a documentation.

In Addition, we create a `StoryMapper.cs` to map the raw story items

### To run dotnet core api

```
$ dotnet restore
$ dotnet build && dotnet run
```

> you should be able to see the swagger at `http://localhost:5247/swagger/index.html`

### Development

In this project we add the requirements to support codespaces, so you don't need to generate your own environment. You can use directly the github codespace option, or if you want, you can use this on your local envirnoment.