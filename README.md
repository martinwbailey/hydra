# hydra


## Using Hydra representations as the internal application view models

I tend to model internal view models to the Hydra hypermedia constraint, we then use this Hydra representation to map onto HTML, when content negotiation HTML.

Most of the time the POST operation is attached to the list. In many cases it is required to model the postform as a separate hypermedia resource. In this instance the list then has a link to the postform. Since the Id of the postform is not the Id to actually performa a post to add an item, we tend to add a Link to the list  on the postform representation.

I guess a better solution would be model the Postform representation as an empty list, which will include the associated POST operation.


