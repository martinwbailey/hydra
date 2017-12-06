# Using Hydra, a personal experience

I have built pure Hydra api applications, plus used hydra as internal hypermedia representations for applications that use HTML as their primary content type. Since all the view models are Hydra compliant, then the the HTML applications all have a full JSON-LD interface for all operations by default when content negotiating application/json. Once I had 3 systems using the same API interface then integration between these systems became trivial.

The approach of brining the hypermedia constraints further into the application stack reduces impedance between application semantics and hypermedia semantics. This is hugely advantageous when binding HTML in the view engines. 

Another advantage is that since we are building Hydra representations internally, when generation HTML, we can check which operations are valid. This means that user permissions are resolved at the representation level, and the view engine can check, for example, is the POST operation exists, and it so render a HTML form as appropiate.

This approach prevents business logic code appearing in view engines.

The following information is a result of using Hydra in anger, and is subject to my own ignorance/lazyness regarding the Hydra specification. I have tried to honor the Hydra spec, however some (maybe to much) deviation has occurred due to pragmatism and the delivery of working software within very strict timelines.


#### Using Hydra as the primary content type for an API

An example of using Hydra for a search api, written in F#, is contained in folder 'API example'. Users enter a search term, and choose a database to run the query against, the list available databases has its own resource at /databases.

The SupporedProperty name 'databases' has a Range of 'databases'. I don't expose this to the client as a resolvable  url to /databases, I assume this is an ommission on my part.

Because all of these projects were not publicly available anonymously, we did no use the hosted hydra-console. (We should have installed this locally)

Examples of this are in the 'API example' folder

#### Using Hydra representations as internal application view models

The largest divergence I incurred was with POST operations on lists, and 'Range' data.

For lists, most of the time the POST operation is attached to the list. In many cases it is required to model the postform as a separate hypermedia resource. In this instance the list then has a link to the postform. Since the Id of the postform is not the Id to actually perform a post to add an item, we tend to add a Link to the list  on the postform representation.

I guess a better solution would be model the Postform representation as an empty list, which will include the associated POST operation.

I could not find a convenient way of representing a range of data for a POST operation, a common example of this is data which would reside as a list of <option> elements inside a HTML dropdown. I 'abused' the Hydar specification by setting the 'Range' property to a value of 'Data' and then attached a list of Hydra classes, one for each available value.
  
An example of this is in the 'ReviewListPostForm folder', it gives an example of the c# view model, the Razor view, the Hydra JSON output, and the associated HTML.
 

If I find the time, I would like to make my C# implementated Hydra driven framework openly available. There is a lack of concrete examples for C# developers to use as a starting point for their projects.
  
  
  




