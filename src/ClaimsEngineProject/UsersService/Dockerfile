FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# copy solution
COPY . .

# restore and publish
RUN dotnet restore "src/UserService/UserService.ApiService/UserService.ApiService.csproj"
RUN dotnet publish "src/UserService/UserService.ApiService/UserService.ApiService.csproj" -c Release -o /app/publish /p:UseAppHost=false

# runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080
ENTRYPOINT ["dotnet", "UserService.ApiService.dll"]
