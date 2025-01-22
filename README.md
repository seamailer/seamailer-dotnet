<br/>
<div align="center">
  <a href="https://github.com/YourUserName/SeaMailer">
    <img src="images/seamailer-logo.png" alt="SeaMailer Logo" width="80" height="80">
  </a>
  <h3 align="center">SeaMailer</h3>
  <p align="center">
    An awesome, lightweight email-sending library for .NET projects!
    <br/>
    <br/>
    <a href="https://github.com/YourUserName/SeaMailer/issues/new?labels=bug&template=bug_report.md"><strong>Report Bug .</strong></a>
    <a href="https://github.com/YourUserName/SeaMailer/issues/new?labels=enhancement&template=feature_request.md">Request Feature</a>
  </p>
</div>

![NuGet](https://img.shields.io/nuget/v/SeaMailer?color=blue)
![Contributors](https://img.shields.io/github/contributors/YourUserName/SeaMailer?color=dark-green)
![Issues](https://img.shields.io/github/issues/YourUserName/SeaMailer)
![License](https://img.shields.io/github/license/YourUserName/SeaMailer)

## Table of Contents

- [About The Project](#about-the-project)
- [Built With](#built-with)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)
  - [1. Configure `appsettings.json`](#1-configure-appsettingsjson)
  - [2. Register SeaMailer](#2-register-seamailer)
  - [3. Create a Controller](#3-create-a-controller)
- [Roadmap](#roadmap)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)
- [Acknowledgments](#acknowledgments)
- [Notice](#notice)

---

## About The Project

SeaMailer is a straightforward, lightweight email-sending library for .NET, designed to help you integrate email functionality quickly into your applications. With minimal configuration and a clean, async-ready API, you can focus on building features instead of fighting with email details.

### Built With

- [.NET 6+](https://dotnet.microsoft.com/download/dotnet)
- [Microsoft.Extensions.DependencyInjection](https://www.nuget.org/packages/Microsoft.Extensions.DependencyInjection/)
- [Microsoft.Extensions.Configuration](https://www.nuget.org/packages/Microsoft.Extensions.Configuration/)

---

## Getting Started

Below is a quick guide on how to set up **SeaMailer**. Follow these steps to get it running in your .NET applications.

### Prerequisites

1. **.NET 6 or Later**  
   SeaMailer targets modern .NET, so ensure you’re running .NET 6 or newer.

2. **API Credentials**  
   You’ll need valid `PublicKey` and `SecretKey`. Store them securely in your configuration (`appsettings.json`, environment variables, or [User Secrets](https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets)).

### Installation

Install SeaMailer via [NuGet.org](https://www.nuget.org/packages/SeaMailer/).

```bash
dotnet add package SeaMailer
