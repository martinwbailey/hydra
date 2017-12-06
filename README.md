# hydra


### I have built pure Hydra api applications, plus used of hydra as the internal application representations for applications that use HTML as thier primary content type. Since all the view models are Hydra compliant, then the the HTML application all have a full JSON-LD interface for all operations by default when content negotiatating application/json. 

The approach of brining the hypermedia constraints further down into the application stack reduces impedience between application symatics and hypermededia symatics, ie when binding to HTML in view engines.

#### Using Hydra representations as the internal application view models

I tend to model internal view models to the Hydra hypermedia constraint, we then use this Hydra representation to map onto HTML, when content negotiation HTML.

For lists, most of the time the POST operation is attached to the list. In many cases it is required to model the postform as a separate hypermedia resource. In this instance the list then has a link to the postform. Since the Id of the postform is not the Id to actually performa a post to add an item, we tend to add a Link to the list  on the postform representation.

I guess a better solution would be model the Postform representation as an empty list, which will include the associated POST operation.

## Representing a range of data for dropdown lists




