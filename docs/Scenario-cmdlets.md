# Generating skeleton-code for scenario cmdlets:

The generator will generate you these only if the target file doesn't exist.

To generate skeletons for scenario cmdlets, add a section called `command` in 
the configuration that has an array of ScenarioCommand objects:

``` typescript
interface ScenarioCommand extends Dictionary<any> {
  action: string;   // the english word action to get mapped to a powershell verb
  subject: string;  // the subject (ie, 'Resource')
  variant: string;  // a variant name unique for that cmdlet
  description: string; // text description
  output?: string;  // output type. 
  link?: string;    // a url for the doc link
  writeable?: boolean; // will emit should process stuff when true
  "as-job"?: boolean; // will add asjob parameter 

  parameters?: Dictionary<ScenarioParameter>; // your parameters for the comand
}

interface ScenarioParameter extends Dictionary<any> {
  type: string; // parameter type
  description: string; // description text
  required?: boolean; // defaults to true, specify only to make an optional parameter
}
```

Example:

~~~ markdown

## Add Scenario Cmdlets

``` yaml 
command:
  - action: get
    subject: resource
    variant: otherstyle
    description: yet another different get resource command
    output: Microsoft.Azure.Resources.Api20191712.Resource

    parameters: 
      foo: 
        type: string
        description: This is my parameter, there are many like it, but this one is my own
        
      bar: 
        type: Microsoft.Azure.Resources.Api20191231.Whatever 
        required: false
        
  - action: get
    subject: resource
    variant: otherstyle
    description: different get resource command
    output: Microsoft.Azure.Resources.Api20191712.Resource

    parameters: 
      flavor: 
        type: string
        description: This is my parameter, there are many like it, but this one is my own
        
      sample: 
        type: string 
        required: false        
```

~~~        