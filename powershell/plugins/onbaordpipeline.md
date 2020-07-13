There are three key steps for on-boarding a new RP with AutoRest PowerShell Generator.
- Onboard request
- Design review
- PR review

## Onboard Request
The first step is to send an onboard request to Azure PowerShell PM Damien(<dcaro@microsoft.com>). And you are expected to provide information as below(maybe more).
- RP status
- Roadmap
- Contact person for customer support

Damien will assist you to work out a speclet for your RP, which is something like combination of use-case spec and function spec.

## Design Review
Based on the speclet, you may start to generate code. Detailed steps are below.

- Generate code with PowerShell generator
- Customize code based on the speclet
- Write examples

When all above steps are completed, you may file a ticket in https://github.com/Azure/azure-powershell-cmdlet-review-pr/issues for design review.
The issue should contain content below.
- Link to the speclet
- Cmdlets syntax and examples (you may copy and paste them from the ./docs folder)
- A link to the code repo which contains the docs folder

The issue will be assigned to an engineer in Azure PowerShell team for review. If the RP is complex, a review meeting will be needed, otherwise, review may be done through comments in the ticket/emails.  

## Code Review
When design review is ongoing, you may write the test cases. After design review passes, you may file a PR against the generation branch of azure-powershell for code review. And code list is as following.
- readme.md
- custom
- examples
- test
- docs

After code review, congratulaitions, you got the chance to take the release train, which is once every three week.


