# Intro

This repo contains code and documentation for the "Secure by Design" workshop. The [SalesApi](SalesApi) directory has a separate README-file containing the workshop guide. The directory also contains sub directories with a solution to the tasks given and an extended solution with more improvements.

## Architecture

The application has a same-site hosting setup. This means that the backend and frontend is hosted as the same site. To account for this in development a SPA-proxy is used.

<img src="Resources/WorkshopArchitecture.png" alt="architecture" width="400"/>

### IdP

We have setup a Idp instance using Auth0 which we will use throughout the workshop. You will get the details from the course instructors. This will be need both in the client/BFF and the API parts of the application.

## Workshop

Link to the workshop:

- [**Secure API**](./SalesApi)

# Workshop done

Congrats, you are now done!

If you have time left and want to learn more about this topic, we invite you to
check out the complete workshop in
[this](https://github.com/Omegapoint-Norge-Academy/secure-by-design) repository.

The workshop you just completed is part of this larger workshop as part 1, step 6.
This longer workshop gives you the freedom to explore 
the parts that interest you, whether that is server-side or client-side
authentication or security-testing.
