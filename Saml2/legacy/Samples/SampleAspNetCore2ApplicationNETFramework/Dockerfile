FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /app
RUN git clone https://github.com/zucikaruna/creview.git

WORKDIR /app/Saml2/legacy/Samples/SampleAspNetCore2ApplicationNETFramework/

RUN dotnet restore
RUN dotnet publish -c Release /p:EnvironmentName=Development -o out
	
FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /app
EXPOSE 80
COPY --from=build /app/Saml2/legacy/Samples/SampleAspNetCore2ApplicationNETFramework/out .

ENTRYPOINT ["dotnet", "SampleAspNetCore2ApplicationNETFramework.dll"]