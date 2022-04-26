## Azure Text Analytics


#### To run this project edit:


#### Run az cli to get keys from your service
```bash
$ az cognitiveservices account keys list --resource-group my-resource-group --name my-service-name
```

#### Example output:

```bash
{
  "key1": "131408798asdsa131408798",
  "key2": "132131408798asdasd131408798"
}
```

#### Edit file with key1 or key2 and your endpoint:

```c#
const string endpoint = "https://my-service-name.cognitiveservices.azure.com/";
const string apiKey = "131408798asdsa131408798";
```


#### Example project running:

![](prints\running.gif)