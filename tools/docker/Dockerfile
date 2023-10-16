FROM mcr.microsoft.com/powershell:lts-7.2-ubuntu-18.04

# Install dependencies and clean up
RUN apt-get update \
    && apt-get install -y curl \
    && curl -o- https://raw.githubusercontent.com/creationix/nvm/v0.33.11/install.sh | bash \
    && . /root/.bashrc \
    && nvm install 14.15.5 \
    && npm config set unsafe-perm true \
    && npm install -g autorest \
    && npm install -g dotnet-sdk-2.1 \
    && apt-get -o Acquire::Check-Valid-Until=false install -y \
    && apt-get clean \
    && rm -rf /var/lib/apt/lists/* \
    && locale-gen $LANG && update-locale

RUN mkdir -p /src

WORKDIR /src

CMD [ "bash" ]
