# LetsTalk
Chat Ecosystem

Build a chat ecosystem consisting of the following three components:
- Client - the user entry point to the system. It is responsible for giving the user a
visual interface to view messages and communicate with others
- Server - connects all clients and serves the real-time message transmission
logic
- Chat history API - provides an interface to store chat messages persistently
and extract reports based on the saved data

Client

- Provide a way to write and view messages in real time
- Should be HTML based
- The user should be able to see all other users and their online status
- The user should be able to send messages to other users if they are online
- The user should be able to see the chat history with other users
Server
- ASP.NET Core Web App
- Use SignalR for the real-time socket communication

- The messages sent between the users should be made persistent every N
minutes. The value of N should be configurable.
* To clarify, don't immediately call the history API to save the message in the
persistent storage, rather save the messages in the memory of the server and call the
API every N minutes.
- The identity of the user in the system should be the connection ID in the
context of SignalR or a GUID created on each new connection by the server.

Message History Service
- ASP.NET Core Web App
- Uses Entity Framework Core on top of PostgreSQL
- Each message entity consists of
- content
- content length
- user identity
- timestamp
- Provides a RESTful API for the following two functionalities:
- make a list of messages persistent
- generate a report that returns data for the time period confined by the
parameters timestampBegin and timestampEnd. It should be
generated directly using data from the database and should contain
the following information:
- total messages
- total users
- average content length
- maximum content length
- shortest message
- longest message
- most active user by number of messages
