# TimesWire Search

> see https://aka.ms/autorest

This is the AutoRest configuration file for ServerManagement.

---
## Getting Started
To build the SDK for ServerManagement, simply [Install AutoRest](https://aka.ms/autorest/install) and in this folder, run:

> `autorest`

To see additional help and options, run:

> `autorest --help`
---

## Configuration


### Basic Information
These are the global settings for the ServerManagement API.

``` yaml 
use: "@microsoft.azure/autorest.incubator@preview"
input-file: timeswire.yaml
namespace: Times.Wire.Search

powershell: 
  clear-output-folder: true
  output-folder: generated

```
