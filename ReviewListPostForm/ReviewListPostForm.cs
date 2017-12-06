public class ReviewListPostFormHypermedia : HydraClass
    {
        public HydraLink ReviewListLink { get; set; }

		public HydraLink ReviewLink { get; set; }

	    public ReviewListPostFormHypermedia()
	    {
			ReviewListLink = new HydraLink();
			ReviewLink = new HydraLink();
		}

        public ReviewListPostFormHypermedia(IContext ctx) : this()
        {
	        Id = ctx.Link<ReviewListPostFormHypermedia>().Id;

	        Title = "Post form to create a new review";

	        ReviewListLink = ctx.Link<ReviewListHypermedia>().WithTitle("Review list");

			AddPost();
        }

	    private void AddPost()
	    {
		    AddPost(new List<SupportingProperty>
			    {
				    new TextSupportingProperty("name"),
				    DataSupportingProperty.FromEnum<ReviewType>("reviewtype", "")
			    });
	    }

		public ReviewListPostFormHypermedia WithErrorMessage(string message)
        {
            AddErrorMessage(message);
            return this;
        }

	    public ReviewListPostFormHypermedia WithReviewLink(HydraLink link)
	    {
		    ReviewLink = link;
		    return this;
	    }

	    public bool HasReviewLink()
	    {
		    return ReviewLink.Id.NotEmpty();
	    }
    }