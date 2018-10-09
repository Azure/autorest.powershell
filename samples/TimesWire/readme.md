# TimesWire Search

> see https://aka.ms/autorest

This is the AutoRest configuration file for TimesWire Search.

---
## Getting Started
To build the SDK for TimesWire Search, simply [Install AutoRest](https://aka.ms/autorest/install) and in this folder, run:

> `autorest`

To see additional help and options, run:

> `autorest --help`
---

## Configuration


### Basic Information
These are the global settings for the  API.




``` yaml 

input-file: timeswire.yaml
namespace: Times.Wire.Search

powershell: 
  clear-output-folder: true
  output-folder: generated

```


``` yaml !$(local)

use: 
- "@microsoft.azure/autorest.incubator@preview"

```

``` yaml $(local)
use: 
  - C:/work/2018/autorest.incubator/extensions/csharp-v2 
  - C:/work/2018/autorest.incubator/extensions/powershell 
  - C:/work/2018/autorest.incubator/extensions/remodeler 
```
