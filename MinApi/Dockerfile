FROM mcr.microsoft.com/dotnet/aspnet:6.0
COPY ./bin/Debug/net6.0/ App/
EXPOSE 80
EXPOSE 443
WORKDIR /App
CMD ["ls"]
ENTRYPOINT ["dotnet", "MinApi.dll"]