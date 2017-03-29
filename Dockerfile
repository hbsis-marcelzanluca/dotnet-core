FROM microsoft/dotnet

# Defini o WORKDIR e copia o projeto
COPY . /home
WORKDIR /home

# Defini uma variável de ambiente que expoe a porta
# OBS: Necessário apenas por ser uma aplicação .net
ENV ASPNETCORE_URLS http://*:5000

# Expoe a porta do container
EXPOSE 5000

# Ainda não sei pra que serve este ENTRYPOINT
# ENTRYPOINT /bin/bash -c "dotnet YourAppName.dll"

# Restaura os pacotes
RUN dotnet restore

# Inicia a aplicação
CMD ["dotnet", "run"]