# Technical task
Write an app to search for music albums by artist. When a user enters a group name, the program should prompt the server to look for a list of its albums. If there is no connection to the server, the list (if it was loaded earlier) should be loaded from the local cache.

You can use any server with any API (iTunes service is recommended as a service that does not require authorization). 
To store the cache, you can use any media (file, any database).
Any third-party libraries are allowed.

You need REDIS installed on your local machine to run this app. You can find installer here: https://redis.io/