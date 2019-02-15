# PowerShell

# Design

# Projects


### PowerShell
    The things I want to make sure that the Cmdlet support are:
    7)	Support for non-transparent proxies: -Proxy [<Uri>] -ProxyCredential [<PSCredential>] -ProxyUseDefaultCredentials [<SwitchParameter>]
    2)	-Confirm,-Whatif,-Verbose for anything that changes things (especially useful when you’ve used wildcarding)
    4)	Pipelining of cmdlets
    3)	-AsJob support 
    6)	Progress bars

    1)	Wildcard support for filtering
    5)	Paging for large resultsets
    
    
##### Notes
- Goal is to generate PowerShell cmdlets from OpenAPI (swagger) spec
  - Support multi-path spec
  - Single normalized spec metadata for different lang
- Already have ability in AutoRest via ReadMe.md file to specify language specific changes
  - Author of swagger spec shouldn’t need to think about it while defining swagger
  - Already have external companies (Deloitte) that are regenerating SDK using AutoRest via using pure swagger spec
- Tool can’t help all the cases where cmdlets were created by hand and has a lot of business logic on client side.
- CONSIDER: Use profile notion to pin specific version of various APIs. The default could be the latest version of APIs
  - PowerShell user shouldn’t care about profile versions for cmdlet usage
- Move to OpenAPI 3.0 should be for free (summer ‘2018)
- Breaking change will be for Azure Stack Admin modules
  - Smaller set of Azure Stack users
- Having a C# dll helps doc team to reflect on the PS cmdlet return types.
  - Source code already gets published to GitHub. Will happen here too.
- Scenario tests are written in PS script by RP team to validate the cmdlet usage
- AI: Scott/Aaron: Loop back within a month or so to show what this tool generates
- Jeffrey concerns to address in generation:
  - Whatif
  - AsJob
  - Pipelining
  - Non-transparent proxies
