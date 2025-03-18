FROM mcr.microsoft.com/powershell:lts-7.2-ubuntu-22.04

# Install dependencies and clean up
RUN apt-get update \
    && apt-get install -y curl \
    && apt-get install -y dotnet-sdk-8.0 \
    && apt-get install -y git \
    && curl -o- https://raw.githubusercontent.com/nvm-sh/nvm/v0.39.7/install.sh | bash \
    && . /root/.bashrc \
    && nvm install 18.20.4 \
    && npm install -g autorest \
    && npm install -g @azure-tools/typespec-client-generator-cli@0.15.x \
    && apt-get -o Acquire::Check-Valid-Until=false install -y \
    && apt-get clean \
    && rm -rf /var/lib/apt/lists/* \
    && locale-gen $LANG && update-locale \
    && pwsh -Command Install-Module -Name platyPS -Force -AllowClobber -Repository PSGallery

RUN mkdir -p /azure-powershell

WORKDIR /azure-powershell

CMD [ "bash" ]