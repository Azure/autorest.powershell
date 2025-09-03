FROM mcr.microsoft.com/dotnet/sdk:8.0.413-noble

# Install dependencies and clean up
RUN apt-get update \
    && apt-get install -y curl \
    && apt-get install -y dotnet-sdk-8.0 \
    && apt-get install -y git \
    && curl -o- https://raw.githubusercontent.com/nvm-sh/nvm/v0.39.7/install.sh | bash \
    && . /root/.bashrc \
    && nvm install 20.19.0 \
    && npm install -g autorest \
    && npm install -g @azure-tools/typespec-client-generator-cli@0.21.0 \
    && apt-get -o Acquire::Check-Valid-Until=false install -y \
    && apt-get clean \
    && rm -rf /var/lib/apt/lists/* \
    && apt-get update \
    && apt-get install -y locales \
    && locale-gen $LANG && update-locale \
    && pwsh -Command Install-Module -Name platyPS -Force -AllowClobber -Repository PSGallery

RUN mkdir -p /azure-powershell

WORKDIR /azure-powershell

CMD [ "bash" ]
