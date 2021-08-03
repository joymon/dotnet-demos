# Purpose

Demonstrate a sample WebAPI is hosted into Kubernetes running using DockerDesktop

# Environment
- ASP.Net WebAPI on .Net 5
- Docker Desktop
- Windows OS
- Visual Studio 2019

# How to run
- Clone.
- Compile the project and make sure its running using Docker.
- Build the image
- Push the newly created image to repository.
  - The sample uses Docker Hub for images
- Apply the file k8s-docker-desktop-deploy.yml using kubectl
- Get the list of services in the deployment and get the NodePort number
- Navigate to http://localhost:<port number>/WeatherForecast
  
The API will return random weather data.
  
  
