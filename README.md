# hydra

I have built pure Hydra api applications, plus used hydra as internal hypermedia representations for applications that use HTML as their primary content type. Since all the view models are Hydra compliant, then the the HTML application all have a full JSON-LD interface for all operations by default when content negotiating application/json. 

The approach of brining the hypermedia constraints further down into the application stack reduces impedance between application semantics and hypermedia semantics, ie when binding to HTML in view engines.

The following information is a result of using Hydra in anger, and is subject to my own ignorance/lazyness regarding the Hydra specification. I have tried to honor  the Hydra spec, however some deviation has occurred due to pragmatism and tight project deliverable time lines.

#### Using Hydra representations as the internal application view models

For lists, most of the time the POST operation is attached to the list. In many cases it is required to model the postform as a separate hypermedia resource. In this instance the list then has a link to the postform. Since the Id of the postform is not the Id to actually perform a post to add an item, we tend to add a Link to the list  on the postform representation.

I guess a better solution would be model the Postform representation as an empty list, which will include the associated POST operation.

I could not find a convenient way of representing a range of data for a POST operation, a common example of this is data which would reside as a list of <option> elements inside a HTML dropdown. I abused the specification by setting the 'Range' property to a vale od 'Data' and then attached a list of Hydra classes, one for each available value.
  
  




