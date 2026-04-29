# 🚀 My Own Generic Host - My Own IHost

A study driven IHost built from C# focusing on Connecting all essential services from a WebFramework like ASP.Net Core. 

## 📌 About The Project

This project is an experimental implementation of IHost building a single service and using it in my own application. Instead of using ASP.Net Core, my goal is to understand how ASP.Net Core services are built and used internally. 

## 🎯 Goals

- Understand about how IHost works internally;
- Creating an implementation of `ServiceCollection` and Dependency Injection;
- Understanding Builder pattern;
- Building an IHost implementation and creating my own service;
- Learn how multiple services are created and used in ASP.Net Core. 

## ⚙️ Core Concepts

This repository is based in a Few Core concepts:

### ♻️ Application Lifecycle

Understanding the behavoiur of application lifecycle, Threading and application Shutdown. 

### 🔌 Service Connection

Implementing my own service called `ClockService` and understanding how services are connected to Asp.Net Core IHost.

### ❌ Cancellation Token 

Understanding how to use Cancellation Token to safely stop threads.

### 🧱 Builder Pattern

Learn how ASP.Net Core uses Builder Pattern to Build IHost correctly. 

## 🧠 How does it works?

`Program` is responsible for calling and defining dependencies using `HostBuilder`. After using the method `Build()` we are responsible for implementing `ServiceProvider`. `ServiceProvider` must create all services on demand. 

## 🛠️ Technologies:

- C#;
- .NET.

## 🚀 Features:

- Reusable Services Implementation;
- My Own Dependency Injection and Service Instances; 
- A simple engine for Web Services;
- An exemple `ClockService` used to implement my `IHost`.

## ⚠️ Limitations

This is a study project and does not aim to be production-ready.

- No Scoped and Tranzient implementations;
- Minimal Error Handling;
- Minimal Performance for `IHost`.

## 📚 Inspirations

This project is inspired by how ASP.NET Core's `IHost` works internally.

## 🗺️ Future Road-Map

- [ ] Supporting Tranzient and Scoped implementations;
- [ ] Pluging [My Own Kestrel](https://github.com/Gustavo6401/MiniKestrel) on my IHost

## 🫱🏼‍🫲🏼 Contribution

Feel free to open issues or to suggest improvements. 