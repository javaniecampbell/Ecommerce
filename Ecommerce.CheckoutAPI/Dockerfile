#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Ecommerce.CheckoutAPI/Ecommerce.CheckoutAPI.csproj", "Ecommerce.CheckoutAPI/"]
RUN dotnet restore "Ecommerce.CheckoutAPI/Ecommerce.CheckoutAPI.csproj"
COPY . .
WORKDIR "/src/Ecommerce.CheckoutAPI"
RUN dotnet build "Ecommerce.CheckoutAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ecommerce.CheckoutAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ecommerce.CheckoutAPI.dll"]