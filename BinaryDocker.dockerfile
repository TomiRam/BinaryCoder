# Use official .NET SDK image for building C# program
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

# Copy C# file
COPY BinaryCodedMessage.cs .

# Create a C# project to build the single file
RUN dotnet new console -n BinaryCodedMessageApp -o . --force \
    && mv BinaryCodedMessage.cs Program.cs \
    && dotnet build -c Release

# Use Python base image for running Python script
FROM python:3.10-slim AS runtime
WORKDIR /app

# Copy Python file
COPY Binary.py .

# Copy built C# program
COPY --from=build /app/bin/Release/net7.0/ .

# Default command: open a shell
CMD ["bash"]
