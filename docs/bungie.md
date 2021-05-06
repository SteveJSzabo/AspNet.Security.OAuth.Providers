# Integrating the Bungie Provider

## Example

```csharp
services.AddAuthentication(options => /* Auth configuration */)
        .AddBungie(options =>
        {
            options.ClientId = "my-client-id";
            options.ClientSecret = "my-client-secret";
        });
```

## Required Additional Settings

_None._

## Optional Settings

_None._
