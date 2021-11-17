
# Feature 3

## Authorization Options for API

There are many options available for authorization. Different protocols can be used, for example, Cookies can be transfered or a token based system can be implemented.  

For a Web Api or SPA (single page application) where security is important, an authorization system implementing the OAuth standard (token based) is a good choice.    

1. ### Auth0
    <p> Auth0 is a SAAS product rich with many features including an admin panel.  Auth0 hosts the  user database. This provides security of storage but also creates difficulites if you decide to change services in the future.</p>

2. ### OpenIddict
   <p> OpenIddict is an open source .Net Library.  It is free to use and you have lots of flexibility.  Decisions need to me made like where you choose to store your user database.  Flexibility comes at the cost of factors like increased set-up time and complexity.</p>  
